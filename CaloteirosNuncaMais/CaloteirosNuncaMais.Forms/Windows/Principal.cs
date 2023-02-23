using CaloteirosNuncaMais.Forms.Database;
using CaloteirosNuncaMais.Forms.Enums;
using CaloteirosNuncaMais.Forms.Services;
using CaloteirosNuncaMais.Forms.Windows.Dialogs;
using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CaloteirosNuncaMais.Forms.Telas
{
    public partial class Principal : Form
    {
        // TODO: validações
        // TODO: estilizar
        // TODO: gerar o pdf
        // TODO: marcar como pago
        private dbEmprestimosEntities _context;
        private IQueryable<Emprestimo> _emprestimos;

        private int _skip;
        private int _take;

        public Principal()
        {
            InitializeComponent();

            _context = new dbEmprestimosEntities();
            _emprestimos = _context.Emprestimos;

            _skip = 0;
            _take = 5;
        }

        private void CheckPage()
        {
            bool min = !(_skip <= 0);
            bool max = !(_skip >= (int)Math.Ceiling(1M * (_emprestimos.Count() / _take)));

            this.buttonFirstPage.Enabled = min;
            this.buttonPreviousPage.Enabled = min;

            this.buttonNextPage.Enabled = max;
            this.buttonLastPage.Enabled = max;
        }

        private async Task CheckData()
        {
            foreach (var emprestimo in _context.Emprestimos)
            {
                if (emprestimo.Pago != nameof(EStatus.PAGO))
                {
                    var nowDate = DateTime.Now;
                    var empPDate = emprestimo.DataPrevisao;
                    var diferenca = (nowDate.Month - empPDate.Month) + 12 * (nowDate.Year - empPDate.Year);
                    if (diferenca > 0)
                    {
                        emprestimo.Pago = nameof(EStatus.ATRASADO);
                        emprestimo.MesesAtrasados = diferenca;
                    }
                }
            }
            await _context.SaveChangesAsync();
        }

        private void ReloadData(IQueryable<Emprestimo> emprestimos)
        {
            _emprestimos = emprestimos;
            this.dataGridView.Rows.Clear();

            foreach (var emp in _emprestimos
                .AsNoTracking()
                .OrderBy(x => x.Nome)
                .Skip(_skip*_take)
                .Take(_take)
                .ToList())
            {
                decimal deve = 0;
                if (emp.MesesAtrasados > 0 && emp.Pago != nameof(EStatus.PAGO))
                {
                    for (int i = 0; i < emp.MesesAtrasados; i++)
                        deve += emp.Valor * (decimal)0.01;
                }
                this.dataGridView.Rows.Add(emp.Id, emp.Nome, $"R$ {emp.Valor:N2}", emp.Pago, $"R${deve:N2}", "Detalhes", "Deletar");
            }
            this.comboBoxPeoples.DataSource = _emprestimos.ToList();
            this.comboBoxPeoples2.DataSource = _emprestimos.ToList();
            this.CheckPage();
        }

        private void PaginationActions(EPaginationActions action)
        {
            switch (action)
            {
                case EPaginationActions.ULTIMO:
                    _skip = (int)Math.Ceiling(1M * (_emprestimos.Count()/_take));
                    break;
                case EPaginationActions.PROXIMO:
                    _skip++;
                    break;
                case EPaginationActions.ANTERIOR:
                    _skip--;
                    break;
                default:
                    _skip = 0;
                    break;
            }
            this.CheckPage();
            this.ReloadData(_emprestimos);
        }

        private async void Principal_Load(object sender, EventArgs e)
        {
            await this.CheckData();
            
            this.ReloadData(_context.Emprestimos);
            this.CheckPage();
        }

        private async void SendEmail_Click(object sender, EventArgs e)
        {
            var email = new MailAddress(this.comboBoxPeoples.SelectedValue.ToString());
            var content = this.textBoxUrl.Text;
            var emailType = this.checkBoxTypeContent.Checked
                ? ETypeEmail.AGRADECIMENTO
                : ETypeEmail.PROCESSAMENTO;

            if (await EmailService.CreateMail(email, content, emailType).Sending()) 
                MessageBox.Show("Email enviado com sucesso!");
            else 
                MessageBox.Show("Erro ao enviar o Email.");
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            using (var form = new CreateOrEdit())
            {
                form.Text = "Novo Empréstimo";
                form.buttonAdd.Text = "Adicionar";

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string priceNotMasked = form.maskedTextBoxPrice.Text
                        .Replace("R$", String.Empty)
                        .Replace("_", String.Empty);

                    decimal price = decimal.Parse(priceNotMasked);

                    var model = new Emprestimo()
                    {
                        Nome = form.textBoxName.Text,
                        Email = form.textBoxEmail.Text,
                        Valor = price,
                        DataEmp = form.dateTimePickerEmprestimo.Value,
                        DataPrevisao = form.dateTimePickerPrevision.Value,
                        Pago = nameof(EStatus.ANDAMENTO),
                        Assinatura = null,
                        MesesAtrasados = 0,
                    };

                    try
                    {
                        _context.Emprestimos.Add(model);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao salvar no \"{model.Nome}\" banco de dados, tente novamente mais tarde. Erro: {ex.Message}");
                    }
                    this.ReloadData(_context.Emprestimos);
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {

        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
            => this.PaginationActions(EPaginationActions.PRIMEIRO);
        private void buttonPreviousPage_Click(object sender, EventArgs e)
            => this.PaginationActions(EPaginationActions.ANTERIOR);
        private void buttonNextPage_Click(object sender, EventArgs e)
            => this.PaginationActions(EPaginationActions.PROXIMO);
        private void buttonLastPage_Click(object sender, EventArgs e)
            => this.PaginationActions(EPaginationActions.ULTIMO);

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string text = this.textBoxSearch.Text;
            if (String.IsNullOrWhiteSpace(text)) this.ReloadData(_context.Emprestimos);
            else this.ReloadData(_emprestimos.Where(x => x.Nome.Contains(text)));
        }
        private void checkBoxTypeContent_CheckStateChanged(object sender, EventArgs e)
        {
            this.textBoxUrl.Enabled = !this.checkBoxTypeContent.Checked;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                var emprestimo = (int)this.dataGridView.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == 5) //Detalhes
                    this.EmprestimoDetails(emprestimo);
                if (e.ColumnIndex == 6)
                {
                    this.EmprestimoDelete(emprestimo);
                    this.ReloadData(_emprestimos);
                }
            }
        }

        private void EmprestimoEdit()
        {

        }

        private void EmprestimoDetails(int id)
        {
            var emprestimo = _context.Emprestimos.Find(id);
            var userData = _context.Emprestimos.Where(x => x.Email == emprestimo.Email);
            var form = new Details();
            void SetPago (object sender, EventArgs e)
            {
                int selecteId = (int)form.comboBoxListEmprestimos.SelectedValue;
                var emp = _context.Emprestimos.Find(selecteId);
                emp.Pago = nameof(EStatus.PAGO);
                _context.SaveChanges();
                this.ReloadData(_emprestimos);
            }

            form.Text = $"Detalhes de {emprestimo.Nome}";
            form.labelNome.Text = emprestimo.Nome;
            form.labelEmail.Text = emprestimo.Email;
            form.labelStatus.Text = emprestimo.Pago;
            form.labelEmprestado.Text = $"R${userData.Sum(x => x.Valor):N2}";
            form.pictureBoxAssinatura.Image = Properties.Resources.nofigure;
            if (emprestimo.Assinatura != null)
            {
                using (MemoryStream memory = new MemoryStream(emprestimo.Assinatura))
                {
                    form.pictureBoxAssinatura.Image = Image.FromStream(memory);
                }
            }
            var lista = userData.Where(x => x.Pago == nameof(EStatus.PAGO));
            decimal soma = 0;
            try { soma = lista.Sum(x => x.Valor); }
            catch { }

            form.labelDevolvido.Text = $"R$ {soma:N2}";
            form.comboBoxListEmprestimos.DataSource = userData.Where(x => x.Pago != nameof(EStatus.PAGO)).ToList();
            form.buttonMarcarwithPago.Click += SetPago;
            form.chartHistorico.Series.Add(emprestimo.Nome);
            form.chartHistorico.Series[0].ChartType = SeriesChartType.Pie;

            form.chartHistorico.Series[0].Points.Add(userData.Count(x => x.Pago == nameof(EStatus.PAGO)));
            form.chartHistorico.Series[0].Points.Add(userData.Count(x => x.Pago == nameof(EStatus.ANDAMENTO)));
            form.chartHistorico.Series[0].Points.Add(userData.Count(x => x.Pago == nameof(EStatus.ATRASADO)));
                
            form.chartHistorico.Series[0].Points[0].LegendText = nameof(EStatus.PAGO);
            form.chartHistorico.Series[0].Points[1].LegendText = nameof(EStatus.ANDAMENTO);
            form.chartHistorico.Series[0].Points[2].LegendText = nameof(EStatus.ATRASADO);

            form.Show();
        }

        private void EmprestimoDelete(int id)
        {
            if (MessageBox.Show("Você realmente deseja apagar este empréstimo?", "Empréstimo deletado!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var model = _context.Emprestimos.Find(id);
                _context.Emprestimos.Remove(model);
                _context.SaveChanges();
                MessageBox.Show("Empréstimo deletado!");
            }
        }
    }
}
