using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            this.panel = new System.Windows.Forms.Panel();
            this.roundedButtonApagar = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.labelAssinatura = new System.Windows.Forms.Label();
            this.roundedButtonCancel = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.panelButton = new System.Windows.Forms.Panel();
            this.roundedButtonSetPay = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.roundedButtonAddimage = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.panelPersonalDetails = new System.Windows.Forms.Panel();
            this.roundedButtonExt = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.roundedButtonMinimize = new CaloteirosNuncaMais.Forms.Controls.RoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDataEmprestimo = new System.Windows.Forms.Label();
            this.labelDataPagamento = new System.Windows.Forms.Label();
            this.labelValorComJuros = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelPersonalDetails.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(185)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.panel.Controls.Add(this.roundedButtonApagar);
            this.panel.Controls.Add(this.labelAssinatura);
            this.panel.Controls.Add(this.roundedButtonCancel);
            this.panel.Controls.Add(this.panelButton);
            this.panel.Controls.Add(this.roundedButtonAddimage);
            this.panel.Controls.Add(this.pictureBoxImage);
            this.panel.Controls.Add(this.panelPersonalDetails);
            this.panel.Location = new System.Drawing.Point(12, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(652, 328);
            this.panel.TabIndex = 0;
            // 
            // roundedButtonApagar
            // 
            this.roundedButtonApagar.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedButtonApagar.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonApagar.ButtonColor = System.Drawing.Color.OrangeRed;
            this.roundedButtonApagar.ButtonText = "Apagar";
            this.roundedButtonApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonApagar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonApagar.Location = new System.Drawing.Point(545, 152);
            this.roundedButtonApagar.Margin = new System.Windows.Forms.Padding(6);
            this.roundedButtonApagar.Name = "roundedButtonApagar";
            this.roundedButtonApagar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonApagar.OnHoverButtonColor = System.Drawing.Color.Tomato;
            this.roundedButtonApagar.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonApagar.Size = new System.Drawing.Size(89, 48);
            this.roundedButtonApagar.TabIndex = 9;
            this.roundedButtonApagar.TextColor = System.Drawing.Color.White;
            // 
            // labelAssinatura
            // 
            this.labelAssinatura.AutoSize = true;
            this.labelAssinatura.BackColor = System.Drawing.Color.Transparent;
            this.labelAssinatura.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssinatura.ForeColor = System.Drawing.Color.White;
            this.labelAssinatura.Location = new System.Drawing.Point(425, 134);
            this.labelAssinatura.Name = "labelAssinatura";
            this.labelAssinatura.Size = new System.Drawing.Size(115, 13);
            this.labelAssinatura.TabIndex = 8;
            this.labelAssinatura.Text = "Assinatura de usuário";
            // 
            // roundedButtonCancel
            // 
            this.roundedButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonCancel.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonCancel.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonCancel.ButtonText = "Cancelar Empréstimo";
            this.roundedButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonCancel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonCancel.Location = new System.Drawing.Point(425, 259);
            this.roundedButtonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.roundedButtonCancel.Name = "roundedButtonCancel";
            this.roundedButtonCancel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonCancel.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonCancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonCancel.Size = new System.Drawing.Size(209, 48);
            this.roundedButtonCancel.TabIndex = 7;
            this.roundedButtonCancel.TextColor = System.Drawing.Color.White;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.White;
            this.panelButton.Controls.Add(this.roundedButtonSetPay);
            this.panelButton.Controls.Add(this.pictureBoxChecked);
            this.panelButton.Location = new System.Drawing.Point(425, 209);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(209, 41);
            this.panelButton.TabIndex = 6;
            // 
            // roundedButtonSetPay
            // 
            this.roundedButtonSetPay.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonSetPay.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonSetPay.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonSetPay.ButtonText = "Marcar Pago";
            this.roundedButtonSetPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonSetPay.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSetPay.Location = new System.Drawing.Point(-4, -4);
            this.roundedButtonSetPay.Margin = new System.Windows.Forms.Padding(6);
            this.roundedButtonSetPay.Name = "roundedButtonSetPay";
            this.roundedButtonSetPay.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonSetPay.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonSetPay.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonSetPay.Size = new System.Drawing.Size(163, 48);
            this.roundedButtonSetPay.TabIndex = 5;
            this.roundedButtonSetPay.TextColor = System.Drawing.Color.White;
            this.roundedButtonSetPay.Click += new System.EventHandler(this.roundedButtonSetPay_Click);
            // 
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChecked.Image = global::CaloteirosNuncaMais.Forms.Properties.Resources.multiply;
            this.pictureBoxChecked.Location = new System.Drawing.Point(167, 0);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChecked.TabIndex = 5;
            this.pictureBoxChecked.TabStop = false;
            // 
            // roundedButtonAddimage
            // 
            this.roundedButtonAddimage.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonAddimage.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonAddimage.ButtonColor = System.Drawing.Color.DarkViolet;
            this.roundedButtonAddimage.ButtonText = "Adicionar";
            this.roundedButtonAddimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonAddimage.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonAddimage.Location = new System.Drawing.Point(425, 152);
            this.roundedButtonAddimage.Margin = new System.Windows.Forms.Padding(6);
            this.roundedButtonAddimage.Name = "roundedButtonAddimage";
            this.roundedButtonAddimage.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.roundedButtonAddimage.OnHoverButtonColor = System.Drawing.Color.MediumOrchid;
            this.roundedButtonAddimage.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButtonAddimage.Size = new System.Drawing.Size(115, 48);
            this.roundedButtonAddimage.TabIndex = 2;
            this.roundedButtonAddimage.TextColor = System.Drawing.Color.White;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBoxImage.Image = global::CaloteirosNuncaMais.Forms.Properties.Resources.nofigure;
            this.pictureBoxImage.Location = new System.Drawing.Point(425, 19);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(209, 116);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 1;
            this.pictureBoxImage.TabStop = false;
            // 
            // panelPersonalDetails
            // 
            this.panelPersonalDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelPersonalDetails.Controls.Add(this.labelNome);
            this.panelPersonalDetails.Controls.Add(this.labelEmail);
            this.panelPersonalDetails.Controls.Add(this.labelValorComJuros);
            this.panelPersonalDetails.Controls.Add(this.labelDataPagamento);
            this.panelPersonalDetails.Controls.Add(this.labelDataEmprestimo);
            this.panelPersonalDetails.Controls.Add(this.label5);
            this.panelPersonalDetails.Controls.Add(this.label4);
            this.panelPersonalDetails.Controls.Add(this.label2);
            this.panelPersonalDetails.Controls.Add(this.label1);
            this.panelPersonalDetails.Controls.Add(this.label3);
            this.panelPersonalDetails.Location = new System.Drawing.Point(20, 19);
            this.panelPersonalDetails.Name = "panelPersonalDetails";
            this.panelPersonalDetails.Size = new System.Drawing.Size(388, 288);
            this.panelPersonalDetails.TabIndex = 0;
            // 
            // roundedButtonExt
            // 
            this.roundedButtonExt.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonExt.BorderColor = System.Drawing.Color.LightGray;
            this.roundedButtonExt.ButtonColor = System.Drawing.Color.DarkRed;
            this.roundedButtonExt.ButtonText = "X";
            this.roundedButtonExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonExt.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonExt.Location = new System.Drawing.Point(612, 9);
            this.roundedButtonExt.Margin = new System.Windows.Forms.Padding(6);
            this.roundedButtonExt.Name = "roundedButtonExt";
            this.roundedButtonExt.OnHoverBorderColor = System.Drawing.Color.White;
            this.roundedButtonExt.OnHoverButtonColor = System.Drawing.Color.Red;
            this.roundedButtonExt.OnHoverTextColor = System.Drawing.Color.White;
            this.roundedButtonExt.Size = new System.Drawing.Size(52, 39);
            this.roundedButtonExt.TabIndex = 1;
            this.roundedButtonExt.TextColor = System.Drawing.Color.White;
            this.roundedButtonExt.Click += new System.EventHandler(this.roundedButtonExt_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(7, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(94, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Detalhes";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Location = new System.Drawing.Point(12, 9);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(518, 39);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            this.panelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseMove);
            this.panelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseUp);
            // 
            // roundedButtonMinimize
            // 
            this.roundedButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.roundedButtonMinimize.BorderColor = System.Drawing.Color.LightGray;
            this.roundedButtonMinimize.ButtonColor = System.Drawing.Color.Teal;
            this.roundedButtonMinimize.ButtonText = " ____";
            this.roundedButtonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButtonMinimize.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonMinimize.Location = new System.Drawing.Point(546, 9);
            this.roundedButtonMinimize.Margin = new System.Windows.Forms.Padding(6);
            this.roundedButtonMinimize.Name = "roundedButtonMinimize";
            this.roundedButtonMinimize.OnHoverBorderColor = System.Drawing.Color.White;
            this.roundedButtonMinimize.OnHoverButtonColor = System.Drawing.Color.Cyan;
            this.roundedButtonMinimize.OnHoverTextColor = System.Drawing.Color.White;
            this.roundedButtonMinimize.Size = new System.Drawing.Size(52, 39);
            this.roundedButtonMinimize.TabIndex = 3;
            this.roundedButtonMinimize.TextColor = System.Drawing.Color.White;
            this.roundedButtonMinimize.Click += new System.EventHandler(this.roundedButtonMinimize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor com Juros :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Empréstimo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(211, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Pagamento :";
            // 
            // labelDataEmprestimo
            // 
            this.labelDataEmprestimo.AutoSize = true;
            this.labelDataEmprestimo.BackColor = System.Drawing.Color.Transparent;
            this.labelDataEmprestimo.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.labelDataEmprestimo.Location = new System.Drawing.Point(19, 240);
            this.labelDataEmprestimo.Name = "labelDataEmprestimo";
            this.labelDataEmprestimo.Size = new System.Drawing.Size(166, 25);
            this.labelDataEmprestimo.TabIndex = 8;
            this.labelDataEmprestimo.Text = "Data Empréstimo";
            // 
            // labelDataPagamento
            // 
            this.labelDataPagamento.AutoSize = true;
            this.labelDataPagamento.BackColor = System.Drawing.Color.Transparent;
            this.labelDataPagamento.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataPagamento.ForeColor = System.Drawing.Color.Black;
            this.labelDataPagamento.Location = new System.Drawing.Point(210, 240);
            this.labelDataPagamento.Name = "labelDataPagamento";
            this.labelDataPagamento.Size = new System.Drawing.Size(156, 25);
            this.labelDataPagamento.TabIndex = 9;
            this.labelDataPagamento.Text = "DataPagamento";
            // 
            // labelValorComJuros
            // 
            this.labelValorComJuros.AutoSize = true;
            this.labelValorComJuros.BackColor = System.Drawing.Color.Transparent;
            this.labelValorComJuros.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorComJuros.ForeColor = System.Drawing.Color.Black;
            this.labelValorComJuros.Location = new System.Drawing.Point(19, 154);
            this.labelValorComJuros.Name = "labelValorComJuros";
            this.labelValorComJuros.Size = new System.Drawing.Size(57, 25);
            this.labelValorComJuros.TabIndex = 10;
            this.labelValorComJuros.Text = "Valor";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(18, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 25);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(18, 39);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(64, 25);
            this.labelNome.TabIndex = 12;
            this.labelNome.Text = "Nome";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::CaloteirosNuncaMais.Forms.Properties.Resources._8110265_fundo_roxo_ondulado_moderno_gratis_vetor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(676, 394);
            this.Controls.Add(this.roundedButtonMinimize);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.roundedButtonExt);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Details";
            this.Text = "Detalhes";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelPersonalDetails.ResumeLayout(false);
            this.panelPersonalDetails.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.RoundedButton roundedButtonExt;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Panel panelTitle;
        private Controls.RoundedButton roundedButtonMinimize;
        private Controls.RoundedButton roundedButtonSetPay;
        public System.Windows.Forms.Panel panelPersonalDetails;
        public System.Windows.Forms.Panel panelButton;
        public Controls.RoundedButton roundedButtonCancel;
        public Controls.RoundedButton roundedButtonAddimage;
        public System.Windows.Forms.PictureBox pictureBoxImage;
        public Controls.RoundedButton roundedButtonApagar;
        public System.Windows.Forms.Label labelAssinatura;
        public System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.Label labelValorComJuros;
        public System.Windows.Forms.Label labelDataPagamento;
        public System.Windows.Forms.Label labelDataEmprestimo;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pictureBoxChecked;
    }
}