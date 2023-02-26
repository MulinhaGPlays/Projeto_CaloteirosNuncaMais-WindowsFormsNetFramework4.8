using System;

namespace CaloteirosNuncaMais.Forms.Telas
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel = new System.Windows.Forms.Panel();
            this.labelHoraAtual = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGerenciar = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.labelDetalhes = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataGridViewPeoples = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxPeoples = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.roundedButtonLimpar = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonFirstPage = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonNew = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonPreviousPage = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonLastPage = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonNextPage = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonSair = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonConfig = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonLayouts = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonGerenciar = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonMenu = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.labelUpdating = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGerenciar.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeoples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelUpdating);
            this.panel.Controls.Add(this.labelHoraAtual);
            this.panel.Controls.Add(this.roundedButtonSair);
            this.panel.Controls.Add(this.roundedButtonConfig);
            this.panel.Controls.Add(this.roundedButtonLayouts);
            this.panel.Controls.Add(this.roundedButtonGerenciar);
            this.panel.Controls.Add(this.roundedButtonMenu);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(764, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(184, 516);
            this.panel.TabIndex = 9;
            // 
            // labelHoraAtual
            // 
            this.labelHoraAtual.AutoSize = true;
            this.labelHoraAtual.BackColor = System.Drawing.Color.Transparent;
            this.labelHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraAtual.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelHoraAtual.Location = new System.Drawing.Point(56, 467);
            this.labelHoraAtual.Name = "labelHoraAtual";
            this.labelHoraAtual.Size = new System.Drawing.Size(79, 20);
            this.labelHoraAtual.TabIndex = 11;
            this.labelHoraAtual.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaloteirosNuncaMais.Forms.Properties.Resources.Nubank_logo_2021;
            this.pictureBox1.Location = new System.Drawing.Point(43, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelGerenciar
            // 
            this.panelGerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.panelGerenciar.Controls.Add(this.roundedButtonLimpar);
            this.panelGerenciar.Controls.Add(this.panelTable);
            this.panelGerenciar.Controls.Add(this.chart);
            this.panelGerenciar.Controls.Add(this.label3);
            this.panelGerenciar.Controls.Add(this.label2);
            this.panelGerenciar.Controls.Add(this.label1);
            this.panelGerenciar.Controls.Add(this.comboBoxType);
            this.panelGerenciar.Controls.Add(this.textBoxSearch);
            this.panelGerenciar.Controls.Add(this.comboBoxPeoples);
            this.panelGerenciar.Location = new System.Drawing.Point(12, 12);
            this.panelGerenciar.Name = "panelGerenciar";
            this.panelGerenciar.Size = new System.Drawing.Size(746, 516);
            this.panelGerenciar.TabIndex = 10;
            this.panelGerenciar.Visible = false;
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.Color.White;
            this.panelTable.Controls.Add(this.labelDetalhes);
            this.panelTable.Controls.Add(this.panelHeader);
            this.panelTable.Controls.Add(this.dataGridViewPeoples);
            this.panelTable.Controls.Add(this.roundedButtonFirstPage);
            this.panelTable.Controls.Add(this.roundedButtonNew);
            this.panelTable.Controls.Add(this.roundedButtonPreviousPage);
            this.panelTable.Controls.Add(this.roundedButtonLastPage);
            this.panelTable.Controls.Add(this.roundedButtonNextPage);
            this.panelTable.Location = new System.Drawing.Point(15, 18);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(406, 480);
            this.panelTable.TabIndex = 17;
            // 
            // labelDetalhes
            // 
            this.labelDetalhes.AutoSize = true;
            this.labelDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.labelDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalhes.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelDetalhes.Location = new System.Drawing.Point(24, 463);
            this.labelDetalhes.Name = "labelDetalhes";
            this.labelDetalhes.Size = new System.Drawing.Size(363, 13);
            this.labelDetalhes.TabIndex = 18;
            this.labelDetalhes.Text = "Clique duas vezes no empréstimo para visualizar seus detalhes";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkViolet;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(20, 14);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(368, 33);
            this.panelHeader.TabIndex = 17;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(18, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(384, 20);
            this.labelHeader.TabIndex = 20;
            this.labelHeader.Text = "Nome            Valor               Status           Juros";
            // 
            // dataGridViewPeoples
            // 
            this.dataGridViewPeoples.AllowUserToAddRows = false;
            this.dataGridViewPeoples.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.dataGridViewPeoples.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPeoples.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPeoples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPeoples.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPeoples.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeoples.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPeoples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeoples.ColumnHeadersVisible = false;
            this.dataGridViewPeoples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Valor,
            this.Pago,
            this.Juros});
            this.dataGridViewPeoples.GridColor = System.Drawing.Color.White;
            this.dataGridViewPeoples.Location = new System.Drawing.Point(20, 53);
            this.dataGridViewPeoples.Name = "dataGridViewPeoples";
            this.dataGridViewPeoples.ReadOnly = true;
            this.dataGridViewPeoples.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewPeoples.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPeoples.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPeoples.RowHeadersVisible = false;
            this.dataGridViewPeoples.RowTemplate.DividerHeight = 1;
            this.dataGridViewPeoples.RowTemplate.Height = 30;
            this.dataGridViewPeoples.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPeoples.Size = new System.Drawing.Size(368, 360);
            this.dataGridViewPeoples.TabIndex = 0;
            this.dataGridViewPeoples.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeoples_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 88;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Status";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // Juros
            // 
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            this.Juros.ReadOnly = true;
            this.Juros.Width = 80;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(455, 231);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(256, 256);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(437, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filtrar por status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(437, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desagrupar pessoa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DisplayMember = "Pago";
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(439, 172);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(211, 28);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.Text = "Selecione um tipo . . .";
            this.comboBoxType.SelectionChangeCommitted += new System.EventHandler(this.comboBoxType_SelectionChangeCommitted);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(440, 47);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(288, 29);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // comboBoxPeoples
            // 
            this.comboBoxPeoples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPeoples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPeoples.FormattingEnabled = true;
            this.comboBoxPeoples.Location = new System.Drawing.Point(439, 120);
            this.comboBoxPeoples.Name = "comboBoxPeoples";
            this.comboBoxPeoples.Size = new System.Drawing.Size(289, 28);
            this.comboBoxPeoples.TabIndex = 2;
            this.comboBoxPeoples.Text = "Selecione uma pessoa . . .";
            this.comboBoxPeoples.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPeoples_SelectionChangeCommitted);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // roundedButtonLimpar
            // 
            this.roundedButtonLimpar.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonLimpar.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLimpar.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonLimpar.ButtonText = "Limpar";
            this.roundedButtonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLimpar.Location = new System.Drawing.Point(661, 171);
            this.roundedButtonLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButtonLimpar.Name = "roundedButtonLimpar";
            this.roundedButtonLimpar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLimpar.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonLimpar.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonLimpar.Size = new System.Drawing.Size(67, 29);
            this.roundedButtonLimpar.TabIndex = 18;
            this.roundedButtonLimpar.TextColor = System.Drawing.Color.White;
            this.roundedButtonLimpar.Click += new System.EventHandler(this.roundedButtonLimpar_Click);
            // 
            // roundedButtonFirstPage
            // 
            this.roundedButtonFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonFirstPage.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonFirstPage.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonFirstPage.ButtonText = "<<";
            this.roundedButtonFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonFirstPage.Location = new System.Drawing.Point(20, 431);
            this.roundedButtonFirstPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButtonFirstPage.Name = "roundedButtonFirstPage";
            this.roundedButtonFirstPage.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonFirstPage.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonFirstPage.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonFirstPage.Size = new System.Drawing.Size(67, 29);
            this.roundedButtonFirstPage.TabIndex = 16;
            this.roundedButtonFirstPage.TextColor = System.Drawing.Color.White;
            this.roundedButtonFirstPage.Click += new System.EventHandler(this.roundedButtonFirstPage_Click);
            // 
            // roundedButtonNew
            // 
            this.roundedButtonNew.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonNew.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonNew.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonNew.ButtonText = "Novo";
            this.roundedButtonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonNew.Location = new System.Drawing.Point(154, 426);
            this.roundedButtonNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.roundedButtonNew.Name = "roundedButtonNew";
            this.roundedButtonNew.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonNew.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonNew.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonNew.Size = new System.Drawing.Size(100, 39);
            this.roundedButtonNew.TabIndex = 12;
            this.roundedButtonNew.TextColor = System.Drawing.Color.White;
            this.roundedButtonNew.Click += new System.EventHandler(this.roundedButtonNew_Click);
            // 
            // roundedButtonPreviousPage
            // 
            this.roundedButtonPreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonPreviousPage.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonPreviousPage.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonPreviousPage.ButtonText = "<";
            this.roundedButtonPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonPreviousPage.Location = new System.Drawing.Point(86, 431);
            this.roundedButtonPreviousPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButtonPreviousPage.Name = "roundedButtonPreviousPage";
            this.roundedButtonPreviousPage.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonPreviousPage.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonPreviousPage.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonPreviousPage.Size = new System.Drawing.Size(67, 29);
            this.roundedButtonPreviousPage.TabIndex = 15;
            this.roundedButtonPreviousPage.TextColor = System.Drawing.Color.White;
            this.roundedButtonPreviousPage.Click += new System.EventHandler(this.roundedButtonPreviousPage_Click);
            // 
            // roundedButtonLastPage
            // 
            this.roundedButtonLastPage.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonLastPage.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLastPage.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonLastPage.ButtonText = ">>";
            this.roundedButtonLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLastPage.Location = new System.Drawing.Point(321, 431);
            this.roundedButtonLastPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButtonLastPage.Name = "roundedButtonLastPage";
            this.roundedButtonLastPage.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLastPage.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonLastPage.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonLastPage.Size = new System.Drawing.Size(67, 29);
            this.roundedButtonLastPage.TabIndex = 13;
            this.roundedButtonLastPage.TextColor = System.Drawing.Color.White;
            this.roundedButtonLastPage.Click += new System.EventHandler(this.roundedButtonLastPage_Click);
            // 
            // roundedButtonNextPage
            // 
            this.roundedButtonNextPage.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonNextPage.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonNextPage.ButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButtonNextPage.ButtonText = ">";
            this.roundedButtonNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonNextPage.Location = new System.Drawing.Point(255, 431);
            this.roundedButtonNextPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.roundedButtonNextPage.Name = "roundedButtonNextPage";
            this.roundedButtonNextPage.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonNextPage.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonNextPage.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonNextPage.Size = new System.Drawing.Size(67, 29);
            this.roundedButtonNextPage.TabIndex = 14;
            this.roundedButtonNextPage.TextColor = System.Drawing.Color.White;
            this.roundedButtonNextPage.Click += new System.EventHandler(this.roundedButtonNextPage_Click);
            // 
            // roundedButtonSair
            // 
            this.roundedButtonSair.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonSair.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonSair.ButtonText = "Sair";
            this.roundedButtonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSair.Location = new System.Drawing.Point(20, 398);
            this.roundedButtonSair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonSair.Name = "roundedButtonSair";
            this.roundedButtonSair.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonSair.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonSair.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonSair.Size = new System.Drawing.Size(145, 45);
            this.roundedButtonSair.TabIndex = 10;
            this.roundedButtonSair.TextColor = System.Drawing.Color.White;
            this.roundedButtonSair.Click += new System.EventHandler(this.roundedButtonSair_Click);
            // 
            // roundedButtonConfig
            // 
            this.roundedButtonConfig.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonConfig.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonConfig.ButtonText = "Configurações";
            this.roundedButtonConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonConfig.Location = new System.Drawing.Point(20, 338);
            this.roundedButtonConfig.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonConfig.Name = "roundedButtonConfig";
            this.roundedButtonConfig.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonConfig.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonConfig.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonConfig.Size = new System.Drawing.Size(145, 45);
            this.roundedButtonConfig.TabIndex = 9;
            this.roundedButtonConfig.TextColor = System.Drawing.Color.White;
            this.roundedButtonConfig.Click += new System.EventHandler(this.roundedButtonConfig_Click);
            // 
            // roundedButtonLayouts
            // 
            this.roundedButtonLayouts.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLayouts.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonLayouts.ButtonText = "Layouts";
            this.roundedButtonLayouts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonLayouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonLayouts.Location = new System.Drawing.Point(20, 278);
            this.roundedButtonLayouts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonLayouts.Name = "roundedButtonLayouts";
            this.roundedButtonLayouts.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLayouts.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonLayouts.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonLayouts.Size = new System.Drawing.Size(145, 45);
            this.roundedButtonLayouts.TabIndex = 8;
            this.roundedButtonLayouts.TextColor = System.Drawing.Color.White;
            this.roundedButtonLayouts.Click += new System.EventHandler(this.roundedButtonLayouts_Click);
            // 
            // roundedButtonGerenciar
            // 
            this.roundedButtonGerenciar.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonGerenciar.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonGerenciar.ButtonText = "Gerenciar";
            this.roundedButtonGerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonGerenciar.Location = new System.Drawing.Point(20, 218);
            this.roundedButtonGerenciar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonGerenciar.Name = "roundedButtonGerenciar";
            this.roundedButtonGerenciar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonGerenciar.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonGerenciar.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonGerenciar.Size = new System.Drawing.Size(145, 45);
            this.roundedButtonGerenciar.TabIndex = 7;
            this.roundedButtonGerenciar.TextColor = System.Drawing.Color.White;
            this.roundedButtonGerenciar.Click += new System.EventHandler(this.roundedButtonGerenciar_Click);
            // 
            // roundedButtonMenu
            // 
            this.roundedButtonMenu.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonMenu.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonMenu.ButtonText = "Menu";
            this.roundedButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonMenu.Location = new System.Drawing.Point(20, 158);
            this.roundedButtonMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonMenu.Name = "roundedButtonMenu";
            this.roundedButtonMenu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonMenu.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonMenu.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonMenu.Size = new System.Drawing.Size(145, 45);
            this.roundedButtonMenu.TabIndex = 6;
            this.roundedButtonMenu.TextColor = System.Drawing.Color.White;
            this.roundedButtonMenu.Click += new System.EventHandler(this.roundedButtonMenu_Click);
            // 
            // labelUpdating
            // 
            this.labelUpdating.AutoSize = true;
            this.labelUpdating.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdating.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelUpdating.Location = new System.Drawing.Point(34, 124);
            this.labelUpdating.Name = "labelUpdating";
            this.labelUpdating.Size = new System.Drawing.Size(119, 20);
            this.labelUpdating.TabIndex = 12;
            this.labelUpdating.Text = "Atualizando...";
            this.labelUpdating.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImage = global::CaloteirosNuncaMais.Forms.Properties.Resources._8110265_fundo_roxo_ondulado_moderno_gratis_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.panelGerenciar);
            this.Controls.Add(this.panel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nubank Empréstimos";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGerenciar.ResumeLayout(false);
            this.panelGerenciar.PerformLayout();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeoples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.RoundedButton roundedButtonSair;
        private Controls.RoundedButton roundedButtonConfig;
        private Controls.RoundedButton roundedButtonLayouts;
        private Controls.RoundedButton roundedButtonGerenciar;
        private Controls.RoundedButton roundedButtonMenu;
        private System.Windows.Forms.Label labelHoraAtual;
        private System.Windows.Forms.Panel panelGerenciar;
        private System.Windows.Forms.DataGridView dataGridViewPeoples;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxPeoples;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.RoundedButton roundedButtonNew;
        private System.Windows.Forms.Panel panelTable;
        private Controls.RoundedButton roundedButtonFirstPage;
        private Controls.RoundedButton roundedButtonPreviousPage;
        private Controls.RoundedButton roundedButtonLastPage;
        private Controls.RoundedButton roundedButtonNextPage;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private Controls.RoundedButton roundedButtonLimpar;
        private System.Windows.Forms.Label labelDetalhes;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label labelUpdating;
    }
}