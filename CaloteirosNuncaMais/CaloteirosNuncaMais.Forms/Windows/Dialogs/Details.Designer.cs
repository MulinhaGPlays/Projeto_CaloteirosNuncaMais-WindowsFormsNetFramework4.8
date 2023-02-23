namespace CaloteirosNuncaMais.Forms.Windows.Dialogs
{
    partial class Details
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartHistorico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDevolvido = new System.Windows.Forms.Label();
            this.labelEmprestado = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListEmprestimos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMarcarwithPago = new System.Windows.Forms.Button();
            this.pictureBoxAssinatura = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssinatura)).BeginInit();
            this.SuspendLayout();
            // 
            // chartHistorico
            // 
            chartArea4.Name = "ChartArea1";
            this.chartHistorico.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartHistorico.Legends.Add(legend4);
            this.chartHistorico.Location = new System.Drawing.Point(282, 21);
            this.chartHistorico.Name = "chartHistorico";
            this.chartHistorico.Size = new System.Drawing.Size(239, 241);
            this.chartHistorico.TabIndex = 1;
            this.chartHistorico.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDevolvido);
            this.groupBox1.Controls.Add(this.labelEmprestado);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // labelDevolvido
            // 
            this.labelDevolvido.AutoSize = true;
            this.labelDevolvido.Location = new System.Drawing.Point(127, 224);
            this.labelDevolvido.Name = "labelDevolvido";
            this.labelDevolvido.Size = new System.Drawing.Size(90, 13);
            this.labelDevolvido.TabIndex = 8;
            this.labelDevolvido.Text = "DevolvidoPessoa";
            // 
            // labelEmprestado
            // 
            this.labelEmprestado.AutoSize = true;
            this.labelEmprestado.Location = new System.Drawing.Point(127, 190);
            this.labelEmprestado.Name = "labelEmprestado";
            this.labelEmprestado.Size = new System.Drawing.Size(122, 13);
            this.labelEmprestado.TabIndex = 7;
            this.labelEmprestado.Text = "TotalEmprestadoPessoa";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(127, 105);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(67, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "EmailPessoa";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(127, 70);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(72, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "StatusPessoa";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(124, 38);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "NomePessoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total devolvido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total emprestado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status atual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // comboBoxListEmprestimos
            // 
            this.comboBoxListEmprestimos.DisplayMember = "DataEmp";
            this.comboBoxListEmprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListEmprestimos.FormattingEnabled = true;
            this.comboBoxListEmprestimos.Location = new System.Drawing.Point(6, 19);
            this.comboBoxListEmprestimos.Name = "comboBoxListEmprestimos";
            this.comboBoxListEmprestimos.Size = new System.Drawing.Size(155, 28);
            this.comboBoxListEmprestimos.TabIndex = 3;
            this.comboBoxListEmprestimos.ValueMember = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMarcarwithPago);
            this.groupBox2.Controls.Add(this.comboBoxListEmprestimos);
            this.groupBox2.Location = new System.Drawing.Point(354, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empréstimos";
            // 
            // buttonMarcarwithPago
            // 
            this.buttonMarcarwithPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMarcarwithPago.Location = new System.Drawing.Point(6, 69);
            this.buttonMarcarwithPago.Name = "buttonMarcarwithPago";
            this.buttonMarcarwithPago.Size = new System.Drawing.Size(155, 39);
            this.buttonMarcarwithPago.TabIndex = 4;
            this.buttonMarcarwithPago.Text = "Marcar como pago";
            this.buttonMarcarwithPago.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAssinatura
            // 
            this.pictureBoxAssinatura.Location = new System.Drawing.Point(139, 287);
            this.pictureBoxAssinatura.Name = "pictureBoxAssinatura";
            this.pictureBoxAssinatura.Size = new System.Drawing.Size(209, 89);
            this.pictureBoxAssinatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAssinatura.TabIndex = 6;
            this.pictureBoxAssinatura.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adicioanr Assinatura";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxAssinatura);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartHistorico);
            this.Name = "Details";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAssinatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartHistorico;
        public System.Windows.Forms.Label labelDevolvido;
        public System.Windows.Forms.Label labelEmprestado;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.ComboBox comboBoxListEmprestimos;
        public System.Windows.Forms.Button buttonMarcarwithPago;
        public System.Windows.Forms.PictureBox pictureBoxAssinatura;
        private System.Windows.Forms.Button button1;
    }
}