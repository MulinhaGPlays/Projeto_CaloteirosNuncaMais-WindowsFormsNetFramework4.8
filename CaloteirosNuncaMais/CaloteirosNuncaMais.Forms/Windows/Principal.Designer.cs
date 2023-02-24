﻿namespace CaloteirosNuncaMais.Forms.Telas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.SendEmail = new System.Windows.Forms.Button();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.checkBoxTypeContent = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPeoples = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.comboBoxPeoples2 = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.roundedButtonSair = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonConfig = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonLayouts = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonGerenciar = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.roundedButtonMenu = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGerenciar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGerenciar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendEmail
            // 
            this.SendEmail.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.SendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEmail.ForeColor = System.Drawing.Color.Black;
            this.SendEmail.Location = new System.Drawing.Point(6, 54);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(89, 26);
            this.SendEmail.TabIndex = 0;
            this.SendEmail.Text = "Enviar";
            this.SendEmail.UseVisualStyleBackColor = false;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.Location = new System.Drawing.Point(88, 21);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(311, 26);
            this.textBoxUrl.TabIndex = 2;
            // 
            // checkBoxTypeContent
            // 
            this.checkBoxTypeContent.AutoSize = true;
            this.checkBoxTypeContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTypeContent.Location = new System.Drawing.Point(102, 58);
            this.checkBoxTypeContent.Name = "checkBoxTypeContent";
            this.checkBoxTypeContent.Size = new System.Drawing.Size(118, 20);
            this.checkBoxTypeContent.TabIndex = 3;
            this.checkBoxTypeContent.Text = "Agradecimento";
            this.checkBoxTypeContent.UseVisualStyleBackColor = true;
            this.checkBoxTypeContent.CheckStateChanged += new System.EventHandler(this.checkBoxTypeContent_CheckStateChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Deve,
            this.Pago,
            this.Juros,
            this.Details,
            this.Delete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridView.Location = new System.Drawing.Point(6, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView.Size = new System.Drawing.Size(661, 136);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
            this.Nome.Width = 180;
            // 
            // Deve
            // 
            this.Deve.HeaderText = "Deve";
            this.Deve.Name = "Deve";
            this.Deve.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // Juros
            // 
            this.Juros.HeaderText = "Juros";
            this.Juros.Name = "Juros";
            this.Juros.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 75;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 62;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(6, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(84, 29);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "Novo";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPeoples);
            this.groupBox1.Controls.Add(this.SendEmail);
            this.groupBox1.Controls.Add(this.checkBoxTypeContent);
            this.groupBox1.Controls.Add(this.textBoxUrl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(406, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Url do PDF:";
            // 
            // comboBoxPeoples
            // 
            this.comboBoxPeoples.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxPeoples.DisplayMember = "Nome";
            this.comboBoxPeoples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPeoples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPeoples.FormattingEnabled = true;
            this.comboBoxPeoples.Location = new System.Drawing.Point(226, 56);
            this.comboBoxPeoples.Name = "comboBoxPeoples";
            this.comboBoxPeoples.Size = new System.Drawing.Size(174, 24);
            this.comboBoxPeoples.TabIndex = 4;
            this.comboBoxPeoples.ValueMember = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.buttonPreviousPage);
            this.groupBox2.Controls.Add(this.buttonFirstPage);
            this.groupBox2.Controls.Add(this.buttonNextPage);
            this.groupBox2.Controls.Add(this.buttonLastPage);
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 199);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerenciar Empréstimos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(198, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(244, 22);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousPage.Location = new System.Drawing.Point(524, 24);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(38, 23);
            this.buttonPreviousPage.TabIndex = 9;
            this.buttonPreviousPage.Text = "<";
            this.buttonPreviousPage.UseVisualStyleBackColor = false;
            this.buttonPreviousPage.Click += new System.EventHandler(this.buttonPreviousPage_Click);
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirstPage.Location = new System.Drawing.Point(480, 24);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(38, 23);
            this.buttonFirstPage.TabIndex = 8;
            this.buttonFirstPage.Text = "<<";
            this.buttonFirstPage.UseVisualStyleBackColor = false;
            this.buttonFirstPage.Click += new System.EventHandler(this.buttonFirstPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextPage.Location = new System.Drawing.Point(585, 24);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(38, 23);
            this.buttonNextPage.TabIndex = 7;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLastPage.Location = new System.Drawing.Point(629, 24);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(38, 23);
            this.buttonLastPage.TabIndex = 6;
            this.buttonLastPage.Text = ">>";
            this.buttonLastPage.UseVisualStyleBackColor = false;
            this.buttonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGenerate);
            this.groupBox3.Controls.Add(this.comboBoxPeoples2);
            this.groupBox3.Location = new System.Drawing.Point(441, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 90);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerar PDF";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(30, 54);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(89, 26);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Gerar";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // comboBoxPeoples2
            // 
            this.comboBoxPeoples2.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxPeoples2.DisplayMember = "Nome";
            this.comboBoxPeoples2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPeoples2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPeoples2.FormattingEnabled = true;
            this.comboBoxPeoples2.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPeoples2.Name = "comboBoxPeoples2";
            this.comboBoxPeoples2.Size = new System.Drawing.Size(138, 24);
            this.comboBoxPeoples2.TabIndex = 6;
            this.comboBoxPeoples2.ValueMember = "Id";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.labelCreditos);
            this.panel.Controls.Add(this.roundedButtonSair);
            this.panel.Controls.Add(this.roundedButtonConfig);
            this.panel.Controls.Add(this.roundedButtonLayouts);
            this.panel.Controls.Add(this.roundedButtonGerenciar);
            this.panel.Controls.Add(this.roundedButtonMenu);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(748, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 516);
            this.panel.TabIndex = 9;
            // 
            // labelCreditos
            // 
            this.labelCreditos.AutoSize = true;
            this.labelCreditos.BackColor = System.Drawing.Color.Transparent;
            this.labelCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditos.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelCreditos.Location = new System.Drawing.Point(28, 469);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(149, 20);
            this.labelCreditos.TabIndex = 11;
            this.labelCreditos.Text = "Maked by Filaupe";
            // 
            // roundedButtonSair
            // 
            this.roundedButtonSair.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonSair.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonSair.ButtonText = "Sair";
            this.roundedButtonSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSair.Location = new System.Drawing.Point(21, 398);
            this.roundedButtonSair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonSair.Name = "roundedButtonSair";
            this.roundedButtonSair.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonSair.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonSair.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonSair.Size = new System.Drawing.Size(159, 45);
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
            this.roundedButtonConfig.Location = new System.Drawing.Point(21, 338);
            this.roundedButtonConfig.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonConfig.Name = "roundedButtonConfig";
            this.roundedButtonConfig.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonConfig.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonConfig.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonConfig.Size = new System.Drawing.Size(159, 45);
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
            this.roundedButtonLayouts.Location = new System.Drawing.Point(21, 278);
            this.roundedButtonLayouts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonLayouts.Name = "roundedButtonLayouts";
            this.roundedButtonLayouts.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonLayouts.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonLayouts.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonLayouts.Size = new System.Drawing.Size(159, 45);
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
            this.roundedButtonGerenciar.Location = new System.Drawing.Point(21, 218);
            this.roundedButtonGerenciar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonGerenciar.Name = "roundedButtonGerenciar";
            this.roundedButtonGerenciar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonGerenciar.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonGerenciar.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonGerenciar.Size = new System.Drawing.Size(159, 45);
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
            this.roundedButtonMenu.Location = new System.Drawing.Point(21, 158);
            this.roundedButtonMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundedButtonMenu.Name = "roundedButtonMenu";
            this.roundedButtonMenu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonMenu.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonMenu.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonMenu.Size = new System.Drawing.Size(159, 45);
            this.roundedButtonMenu.TabIndex = 6;
            this.roundedButtonMenu.TextColor = System.Drawing.Color.White;
            this.roundedButtonMenu.Click += new System.EventHandler(this.roundedButtonMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaloteirosNuncaMais.Forms.Properties.Resources.Nubank_logo_2021;
            this.pictureBox1.Location = new System.Drawing.Point(50, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelGerenciar
            // 
            this.panelGerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panelGerenciar.Controls.Add(this.groupBox1);
            this.panelGerenciar.Controls.Add(this.groupBox3);
            this.panelGerenciar.Controls.Add(this.groupBox2);
            this.panelGerenciar.Location = new System.Drawing.Point(12, 12);
            this.panelGerenciar.Name = "panelGerenciar";
            this.panelGerenciar.Size = new System.Drawing.Size(730, 516);
            this.panelGerenciar.TabIndex = 10;
            this.panelGerenciar.Visible = false;
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
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGerenciar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendEmail;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.CheckBox checkBoxTypeContent;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPeoples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ComboBox comboBoxPeoples2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juros;
        private System.Windows.Forms.DataGridViewButtonColumn Details;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.RoundedButton roundedButtonSair;
        private Controls.RoundedButton roundedButtonConfig;
        private Controls.RoundedButton roundedButtonLayouts;
        private Controls.RoundedButton roundedButtonGerenciar;
        private Controls.RoundedButton roundedButtonMenu;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.Panel panelGerenciar;
    }
}