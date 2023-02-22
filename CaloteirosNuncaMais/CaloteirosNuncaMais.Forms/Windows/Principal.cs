using CaloteirosNuncaMais.Forms.Database;
using CaloteirosNuncaMais.Forms.Enums;
using CaloteirosNuncaMais.Forms.Services;
using CaloteirosNuncaMais.Forms.Windows.Dialogs;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloteirosNuncaMais.Forms.Telas
{
    public partial class Principal : Form
    {
        // TODO: validações
        // TODO: desativar textbox de url quando o agradecimento estiver ativado
        // TODO: desativar botões de paginação baseado na página
        // TODO: estilizar
        // TODO: searchbox
        // TODO: gerar o pdf
        // TODO: detalhes
        // TODO: deletar
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

        private async Task CheckData()
        {
            foreach (var emprestimo in _context.Emprestimos)
            {
                if (emprestimo.Pago != nameof(EStatus.PAGO))
                {
                    var calc = DateTime.Now.Subtract(emprestimo.DataPrevisao);
                    int diferenca = (int)Math.Round(calc.TotalDays);
                    if (diferenca > 0)
                    {
                        emprestimo.Pago = nameof(EStatus.ATRASADO);
                        emprestimo.MesesAtrasados++;
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
                this.dataGridView.Rows.Add(emp.Nome, $"R$ {emp.Valor:N2}", emp.Pago, $"R${deve:N2}", "Detalhes", "Deletar");
            }
            this.comboBoxPeoples.DataSource = _emprestimos.ToList();
            this.comboBoxPeoples2.DataSource = _emprestimos.ToList();
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
            this.ReloadData(_emprestimos);
        }

        private async void Principal_Load(object sender, EventArgs e)
        {
            await this.CheckData();
            this.ReloadData(_context.Emprestimos);
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
    }
}
