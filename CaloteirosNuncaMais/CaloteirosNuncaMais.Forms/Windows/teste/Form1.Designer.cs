namespace CaloteirosNuncaMais.Forms.Windows.teste
{
    partial class Form1
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
            this.roundedButton1 = new CaloteirosNuncaMais.Forms.Windows.teste.RoundedButton();
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderColor = System.Drawing.Color.Silver;
            this.roundedButton1.ButtonColor = System.Drawing.Color.Red;
            this.roundedButton1.Location = new System.Drawing.Point(82, 63);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundedButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundedButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton1.Size = new System.Drawing.Size(418, 154);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton roundedButton1;
    }
}