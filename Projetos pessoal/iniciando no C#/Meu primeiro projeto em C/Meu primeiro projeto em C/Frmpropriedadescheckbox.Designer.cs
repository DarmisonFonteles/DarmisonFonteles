namespace Meu_primeiro_projeto_em_C
{
    partial class Frmpropriedadescheckbox
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.painelpessoafisica = new System.Windows.Forms.Panel();
            this.texcpfpessoafisica = new System.Windows.Forms.TextBox();
            this.texnomepessoafisica = new System.Windows.Forms.TextBox();
            this.lblcpfpessoafisica = new System.Windows.Forms.Label();
            this.lblnomepessoafisica = new System.Windows.Forms.Label();
            this.panelpessoajuridica = new System.Windows.Forms.Panel();
            this.textcnpjpessoajuridica = new System.Windows.Forms.TextBox();
            this.texnomepessoajuridica = new System.Windows.Forms.TextBox();
            this.lblcnpjpessoajuridica = new System.Windows.Forms.Label();
            this.lblnomepessoajuridica = new System.Windows.Forms.Label();
            this.painelpessoafisica.SuspendLayout();
            this.panelpessoajuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(141, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 26);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Pessoa fisica";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(141, 285);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(153, 26);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Pessoa jurifica";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // painelpessoafisica
            // 
            this.painelpessoafisica.Controls.Add(this.texcpfpessoafisica);
            this.painelpessoafisica.Controls.Add(this.texnomepessoafisica);
            this.painelpessoafisica.Controls.Add(this.lblcpfpessoafisica);
            this.painelpessoafisica.Controls.Add(this.lblnomepessoafisica);
            this.painelpessoafisica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.painelpessoafisica.Location = new System.Drawing.Point(415, 69);
            this.painelpessoafisica.Name = "painelpessoafisica";
            this.painelpessoafisica.Size = new System.Drawing.Size(249, 132);
            this.painelpessoafisica.TabIndex = 2;
            this.painelpessoafisica.Visible = false;
            // 
            // texcpfpessoafisica
            // 
            this.texcpfpessoafisica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texcpfpessoafisica.Location = new System.Drawing.Point(96, 68);
            this.texcpfpessoafisica.Name = "texcpfpessoafisica";
            this.texcpfpessoafisica.Size = new System.Drawing.Size(100, 29);
            this.texcpfpessoafisica.TabIndex = 3;
            // 
            // texnomepessoafisica
            // 
            this.texnomepessoafisica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texnomepessoafisica.Location = new System.Drawing.Point(96, 29);
            this.texnomepessoafisica.Name = "texnomepessoafisica";
            this.texnomepessoafisica.Size = new System.Drawing.Size(100, 29);
            this.texnomepessoafisica.TabIndex = 2;
            // 
            // lblcpfpessoafisica
            // 
            this.lblcpfpessoafisica.AutoSize = true;
            this.lblcpfpessoafisica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcpfpessoafisica.Location = new System.Drawing.Point(17, 74);
            this.lblcpfpessoafisica.Name = "lblcpfpessoafisica";
            this.lblcpfpessoafisica.Size = new System.Drawing.Size(49, 22);
            this.lblcpfpessoafisica.TabIndex = 1;
            this.lblcpfpessoafisica.Text = "CPF";
            this.lblcpfpessoafisica.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblnomepessoafisica
            // 
            this.lblnomepessoafisica.AutoSize = true;
            this.lblnomepessoafisica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnomepessoafisica.Location = new System.Drawing.Point(17, 32);
            this.lblnomepessoafisica.Name = "lblnomepessoafisica";
            this.lblnomepessoafisica.Size = new System.Drawing.Size(61, 22);
            this.lblnomepessoafisica.TabIndex = 0;
            this.lblnomepessoafisica.Text = "Nome";
            this.lblnomepessoafisica.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelpessoajuridica
            // 
            this.panelpessoajuridica.Controls.Add(this.textcnpjpessoajuridica);
            this.panelpessoajuridica.Controls.Add(this.texnomepessoajuridica);
            this.panelpessoajuridica.Controls.Add(this.lblcnpjpessoajuridica);
            this.panelpessoajuridica.Controls.Add(this.lblnomepessoajuridica);
            this.panelpessoajuridica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelpessoajuridica.Location = new System.Drawing.Point(415, 217);
            this.panelpessoajuridica.Name = "panelpessoajuridica";
            this.panelpessoajuridica.Size = new System.Drawing.Size(249, 132);
            this.panelpessoajuridica.TabIndex = 4;
            this.panelpessoajuridica.Visible = false;
            // 
            // textcnpjpessoajuridica
            // 
            this.textcnpjpessoajuridica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textcnpjpessoajuridica.Location = new System.Drawing.Point(96, 68);
            this.textcnpjpessoajuridica.Name = "textcnpjpessoajuridica";
            this.textcnpjpessoajuridica.Size = new System.Drawing.Size(100, 29);
            this.textcnpjpessoajuridica.TabIndex = 3;
            // 
            // texnomepessoajuridica
            // 
            this.texnomepessoajuridica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.texnomepessoajuridica.Location = new System.Drawing.Point(96, 29);
            this.texnomepessoajuridica.Name = "texnomepessoajuridica";
            this.texnomepessoajuridica.Size = new System.Drawing.Size(100, 29);
            this.texnomepessoajuridica.TabIndex = 2;
            // 
            // lblcnpjpessoajuridica
            // 
            this.lblcnpjpessoajuridica.AutoSize = true;
            this.lblcnpjpessoajuridica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcnpjpessoajuridica.Location = new System.Drawing.Point(17, 74);
            this.lblcnpjpessoajuridica.Name = "lblcnpjpessoajuridica";
            this.lblcnpjpessoajuridica.Size = new System.Drawing.Size(60, 22);
            this.lblcnpjpessoajuridica.TabIndex = 1;
            this.lblcnpjpessoajuridica.Text = "CNPJ";
            // 
            // lblnomepessoajuridica
            // 
            this.lblnomepessoajuridica.AutoSize = true;
            this.lblnomepessoajuridica.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnomepessoajuridica.Location = new System.Drawing.Point(17, 32);
            this.lblnomepessoajuridica.Name = "lblnomepessoajuridica";
            this.lblnomepessoajuridica.Size = new System.Drawing.Size(61, 22);
            this.lblnomepessoajuridica.TabIndex = 0;
            this.lblnomepessoajuridica.Text = "Nome";
            // 
            // Frmpropriedadescheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelpessoajuridica);
            this.Controls.Add(this.painelpessoafisica);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frmpropriedadescheckbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmpropriedadescheckbox";
            this.painelpessoafisica.ResumeLayout(false);
            this.painelpessoafisica.PerformLayout();
            this.panelpessoajuridica.ResumeLayout(false);
            this.panelpessoajuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel painelpessoafisica;
        private Label lblcpfpessoafisica;
        private Label lblnomepessoafisica;
        private TextBox texcpfpessoafisica;
        private TextBox texnomepessoafisica;
        private Panel panelpessoajuridica;
        private TextBox textcnpjpessoajuridica;
        private TextBox texnomepessoajuridica;
        private Label lblcnpjpessoajuridica;
        private Label lblnomepessoajuridica;
    }
}