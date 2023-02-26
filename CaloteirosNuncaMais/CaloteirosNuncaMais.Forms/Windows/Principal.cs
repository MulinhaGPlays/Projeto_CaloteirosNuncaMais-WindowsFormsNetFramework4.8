using CaloteirosNuncaMais.Forms.Database;
using CaloteirosNuncaMais.Forms.Enums;
using CaloteirosNuncaMais.Forms.Windows.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaloteirosNuncaMais.Forms.Telas
{
    public partial class Principal : Form
    {
        // TODO: validações
        // TODO: gerar o pdf
        // TODO: Filtro tem que ser acumulativo
        // TODO: searchbox não reseta a tabela quando apaga muito rapido
        private dbEmprestimosEntities _context;
        private IQueryable<Emprestimo> _emprestimos;
        private PrivateFontCollection _customFonts;

        private bool _inTask = false;
        private bool _desagrupado = false;

        private int _skip;
        private int _take;

        public Principal()
        {
            InitializeComponent();

            _context = new dbEmprestimosEntities();
            _emprestimos = _context.Emprestimos;
            _customFonts = new PrivateFontCollection();

            _skip = 0;
            _take = 12;

            byte[] fontData = Properties.Resources.IcoMoon_Free;

            IntPtr fontPtr = Marshal.AllocHGlobal(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            _customFonts.AddMemoryFont(fontPtr, fontData.Length);

            this.SetRounded();
            this.LoadChart();
            this.SetFont();
        }

        private IQueryable<Emprestimo> DistinctByEmail() 
            => _context.Emprestimos
            .GroupBy(x => x.Email)
            .Select(g => g.OrderByDescending(x => x.Id).FirstOrDefault());

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse );
        
        private void SetRounded()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            
            this.panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 15, 15));
            this.panelTable.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTable.Width, panelTable.Height, 15, 15));
            this.panelHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelHeader.Width, panelHeader.Height, 15, 15));
            this.panelGerenciar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelGerenciar.Width, panelGerenciar.Height, 15, 15));
            this.textBoxSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxSearch.Width, textBoxSearch.Height, 35, 35));
            this.comboBoxPeoples.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBoxPeoples.Width, comboBoxPeoples.Height, 10, 50));
            this.comboBoxType.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBoxType.Width, comboBoxType.Height, 10, 50));
            this.labelHeader.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelHeader.Width, labelHeader.Height, 5, 5));
            this.dataGridViewPeoples.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridViewPeoples.Width, dataGridViewPeoples.Height, 15, 15));
        }
        private void SetFont()
        {
            var fontText = new Font(_customFonts.Families[0], 12, FontStyle.Bold);
            var fontText2 = new Font(_customFonts.Families[0], 16, FontStyle.Regular);
            var fontText3 = new Font(_customFonts.Families[0], 12, FontStyle.Regular);
            var fontText4 = new Font(_customFonts.Families[0], 9, FontStyle.Regular);
            var fontText5 = new Font(_customFonts.Families[0], 8, FontStyle.Bold);

            this.roundedButtonMenu.Font = fontText;
            this.roundedButtonGerenciar.Font = fontText;
            this.roundedButtonLayouts.Font = fontText;
            this.roundedButtonConfig.Font = fontText;
            this.roundedButtonSair.Font = fontText;
            this.labelHoraAtual.Font = fontText;
            this.textBoxSearch.Font = fontText2;
            this.comboBoxPeoples.Font = fontText3;
            this.comboBoxType.Font = fontText3;
            this.labelHeader.Font = fontText;
            this.dataGridViewPeoples.Font = fontText4;
            this.labelDetalhes.Font = fontText5;
        }
        private void SetCellsColors(DataGridView table)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                int index = table.Columns["Pago"].Index;
                switch (row.Cells[index].Value)
                {
                    case nameof(EStatus.ATRASADO):
                        row.Cells[index].Style.BackColor = Color.Salmon;
                        break;
                    case nameof(EStatus.ANDAMENTO):
                        row.Cells[index].Style.BackColor = Color.Yellow;
                        break;
                    case nameof(EStatus.PAGO):
                        row.Cells[index].Style.BackColor = Color.PaleGreen;
                        break;
                    case nameof(EStatus.CANCELADO):
                        row.Cells[index].Style.BackColor = Color.LightGray;
                        break;
                    default:
                        break;
                }
            }
        }
        private void SetAutoCompleteText()
        {
            var AutoCompleteList = new AutoCompleteStringCollection();
            AutoCompleteList.AddRange(DistinctByEmail().Select(x => x.Nome).ToArray());
            this.textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteCustomSource = AutoCompleteList;
        }

        private void CheckPage()
        {
            int calc = (int)Math.Floor(1M * (_emprestimos.Count() / _take));

            bool min = !(_skip <= 0);
            bool max = !(_skip >= calc);

            this.roundedButtonPreviousPage.Enabled = min;
            this.roundedButtonFirstPage.Enabled = min;
            this.roundedButtonLastPage.Enabled = max;
            this.roundedButtonNextPage.Enabled = max;

            this.roundedButtonPreviousPage.ButtonColor = min ? Color.MediumSlateBlue : Color.DarkSlateBlue;
            this.roundedButtonFirstPage.ButtonColor = min ? Color.MediumSlateBlue : Color.DarkSlateBlue;
            this.roundedButtonLastPage.ButtonColor = max ? Color.MediumSlateBlue : Color.DarkSlateBlue;
            this.roundedButtonNextPage.ButtonColor = max ? Color.MediumSlateBlue : Color.DarkSlateBlue;
        }
        private async Task CheckData()
        {
            var nowDate = DateTime.Now;
            var list = _context.Emprestimos.Where(x => x.Pago != nameof(EStatus.PAGO));
            foreach (var x in list)
            {
                int diferencaMeses = (nowDate.Month - x.DataPrevisao.Month);
                int diferencaAnos = (nowDate.Year - x.DataPrevisao.Year);
                int mesesDivida = diferencaMeses + 12 * diferencaAnos;
                if (mesesDivida > 0)
                {
                    x.Pago = nameof(EStatus.ATRASADO);
                    x.MesesAtrasados = mesesDivida;
                }
            }
            await _context.SaveChangesAsync();
            this.SetAutoCompleteText();
            this.LoadComboBox();
            this.ReloadData(DistinctByEmail(), this.dataGridViewPeoples);
        }
        
        private async void timer_Tick(object sender, EventArgs e)
        {
            this.labelUpdating.Visible = true;
            await this.CheckData();
            await Task.Delay(1000);
            this.labelUpdating.Visible = false;
        }
        private void timerHora_Tick(object sender, EventArgs e) => this.labelHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
        
        private async void Principal_Load(object sender, EventArgs e)
        {
            this.labelHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");
            this.timer.Start();
            this.timerHora.Start();
            await this.CheckData();
            this.LoadComboBox();
            this.roundedButtonLimpar_Click(sender, e);
        }

        private void ReloadData(IQueryable<Emprestimo> emprestimos, DataGridView table)
        {
            _emprestimos = emprestimos;
            this.dataGridViewPeoples.Rows.Clear();
            foreach (var emp in _emprestimos.AsNoTracking().OrderByDescending(x => x.Id)
                .Skip(_skip * _take).Take(_take).ToList())
            {
                decimal deve = 0;
                if (emp.MesesAtrasados > 0 && emp.Pago != nameof(EStatus.PAGO))
                {
                    for (int i = 0; i < emp.MesesAtrasados; i++)
                        deve += emp.Valor * (decimal)0.01;
                }
                table.Rows.Add(emp.Id, emp.Nome, $"R$ {emp.Valor:N2}", emp.Pago, $"R${deve:N2}", "Detalhes", "Deletar");
            }
            this.SetCellsColors(table);
            this.LoadChartData(_emprestimos, this.chart);
            this.CheckPage();
        }
        private Task<bool> ReloadGridWithTextBox(string text)
        {
            _inTask = true;
            if (!String.IsNullOrWhiteSpace(text)) this.ReloadData(DistinctByEmail().Where(x => x.Nome.Contains(text)), this.dataGridViewPeoples);
            else this.ReloadData(DistinctByEmail(), this.dataGridViewPeoples);
            _inTask = false;
            return new Task<bool>(() => 0 == 0);
        }

        private void PaginationActions(EPaginationActions action)
        {
            int maxPages = (int)Math.Ceiling(1M * (_emprestimos.Count() / _take));
            switch (action)
            {
                case EPaginationActions.ULTIMO: _skip = maxPages; break;
                case EPaginationActions.PROXIMO: _skip++; break;
                case EPaginationActions.ANTERIOR: _skip--; break;
                default: _skip = 0; break;
            }
            this.CheckPage();
            this.ReloadData(_emprestimos, this.dataGridViewPeoples);
        }

        private void LoadChart()
        {
            this.chart.Series.Add("Peoples");
            this.chart.Series[0].ChartType = SeriesChartType.Pie;
        }
        private void LoadComboBox()
        {
            var Status = new List<StatusModel>()
            {
                new StatusModel(){ Status = nameof(EStatus.PAGO) },
                new StatusModel(){ Status = nameof(EStatus.ANDAMENTO) },
                new StatusModel(){ Status = nameof(EStatus.ATRASADO) },
                new StatusModel(){ Status = nameof(EStatus.CANCELADO) },
            };

            this.comboBoxPeoples.DataSource = this.DistinctByEmail().ToList();
            this.comboBoxPeoples.ValueMember = "Email";
            this.comboBoxPeoples.DisplayMember = "Nome";

            this.comboBoxType.DataSource = Status;
            this.comboBoxType.ValueMember = "Status";
            this.comboBoxType.DisplayMember = "Status";

            this.comboBoxType.Text = "Selecione um tipo . . .";
            this.comboBoxPeoples.Text = "Selecione uma pessoa . . .";
        }

        private async void textBoxSearch_TextChanged(object sender, EventArgs e)
        { 
            if (!_inTask) 
                await ReloadGridWithTextBox(this.textBoxSearch.Text);
            _skip = 0;
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
                this.ReloadData(_emprestimos, this.dataGridViewPeoples);
            }

            form.Text = $"Detalhes de {emprestimo.Nome}";
            form.labelNome.Text = emprestimo.Nome;
            form.labelEmail.Text = emprestimo.Email;
            form.labelStatus.Text = emprestimo.Pago;
            form.labelPrevisao.Text = emprestimo.DataPrevisao.ToString("dd/MM/yyyy");
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
                this.ReloadData(DistinctByEmail(), this.dataGridViewPeoples);
            }
        }

        private void roundedButtonSair_Click(object sender, EventArgs e) => Application.Exit();
        private void roundedButtonMenu_Click(object sender, EventArgs e)
        {
            this.panelGerenciar.Visible = false;
        }
        private void roundedButtonGerenciar_Click(object sender, EventArgs e)
        {
            this.panelGerenciar.Visible = !this.panelGerenciar.Visible;
            this.comboBoxType.Text = "Selecione um tipo . . .";
            this.comboBoxPeoples.Text = "Selecione uma pessoa . . .";
        }
        private void roundedButtonLayouts_Click(object sender, EventArgs e)
        {
            this.panelGerenciar.Visible = false;
        }
        private void roundedButtonConfig_Click(object sender, EventArgs e)
        {
            this.panelGerenciar.Visible = false;
        }
        private void roundedButtonNew_Click(object sender, EventArgs e)
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
                    this.ReloadData(DistinctByEmail(), this.dataGridViewPeoples);
                }
            }
        }
        private void roundedButtonLimpar_Click(object sender, EventArgs e)
        {
            this.ReloadData(DistinctByEmail(), this.dataGridViewPeoples);
            this.comboBoxType.Text = "Selecione um tipo . . .";
            this.comboBoxPeoples.Text = "Selecione uma pessoa . . .";
            this.textBoxSearch.Text = String.Empty;
            _desagrupado = false;
        }

        private void roundedButtonNextPage_Click(object sender, EventArgs e) => this.PaginationActions(EPaginationActions.PROXIMO);
        private void roundedButtonLastPage_Click(object sender, EventArgs e) => this.PaginationActions(EPaginationActions.ULTIMO);

        private void roundedButtonPreviousPage_Click(object sender, EventArgs e) => this.PaginationActions(EPaginationActions.ANTERIOR);
        private void roundedButtonFirstPage_Click(object sender, EventArgs e) => this.PaginationActions(EPaginationActions.PRIMEIRO);

        private void comboBoxPeoples_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _desagrupado = true;
            var email = this.comboBoxPeoples.SelectedValue as string;
            this.ReloadData(_context.Emprestimos.Where(x => x.Email == email), this.dataGridViewPeoples);
        }
        private void comboBoxType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var status = this.comboBoxType.SelectedValue as string;
            var email = this.comboBoxPeoples.SelectedValue as string;

            if (_desagrupado) 
                this.ReloadData(_context.Emprestimos.Where(x => x.Email == email && x.Pago == status), this.dataGridViewPeoples);
            else this.ReloadData(DistinctByEmail().Where(x => x.Pago == status), this.dataGridViewPeoples);
        }

        private void LoadChartData(IQueryable<Emprestimo> lista, Chart chart)
        {
            chart.Series[0].Points.Clear();

            chart.Series[0].Points.AddY(lista.Count(x => x.Pago == nameof(EStatus.PAGO)));          
            chart.Series[0].Points.AddY(lista.Count(x => x.Pago == nameof(EStatus.ANDAMENTO)));     
            chart.Series[0].Points.AddY(lista.Count(x => x.Pago == nameof(EStatus.ATRASADO)));
            chart.Series[0].Points.AddY(lista.Count(x => x.Pago == nameof(EStatus.CANCELADO)));
            chart.Series[0].Points[0].Color = Color.PaleGreen;
            chart.Series[0].Points[1].Color = Color.Yellow;
            chart.Series[0].Points[2].Color = Color.Salmon;
            chart.Series[0].Points[3].Color = Color.LightGray;
        }

        private void dataGridViewPeoples_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int? Id = this.dataGridViewPeoples.Rows[e.RowIndex].Cells[0].Value as int?;
            if (Id.HasValue)
                this.EmprestimoDelete(Id.Value);
        }
    }
}
