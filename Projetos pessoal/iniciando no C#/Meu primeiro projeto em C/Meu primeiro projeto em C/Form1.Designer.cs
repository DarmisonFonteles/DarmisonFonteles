namespace Meu_primeiro_projeto_em_C
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmensagem = new System.Windows.Forms.Label();
            this.btnmensagem = new System.Windows.Forms.Button();
            this.btnpropriedadescheckbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.BackColor = System.Drawing.SystemColors.Control;
            this.lblmensagem.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmensagem.Location = new System.Drawing.Point(26, 67);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(0, 56);
            this.lblmensagem.TabIndex = 0;
            // 
            // btnmensagem
            // 
            this.btnmensagem.Location = new System.Drawing.Point(148, 172);
            this.btnmensagem.Name = "btnmensagem";
            this.btnmensagem.Size = new System.Drawing.Size(190, 35);
            this.btnmensagem.TabIndex = 1;
            this.btnmensagem.Text = "botãozão";
            this.btnmensagem.UseVisualStyleBackColor = true;
            this.btnmensagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpropriedadescheckbox
            // 
            this.btnpropriedadescheckbox.Location = new System.Drawing.Point(12, 12);
            this.btnpropriedadescheckbox.Name = "btnpropriedadescheckbox";
            this.btnpropriedadescheckbox.Size = new System.Drawing.Size(75, 23);
            this.btnpropriedadescheckbox.TabIndex = 2;
            this.btnpropriedadescheckbox.Text = "Checkbox";
            this.btnpropriedadescheckbox.UseVisualStyleBackColor = true;
            this.btnpropriedadescheckbox.Click += new System.EventHandler(this.btnpropriedadescheckbox_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 280);
            this.Controls.Add(this.btnpropriedadescheckbox);
            this.Controls.Add(this.btnmensagem);
            this.Controls.Add(this.lblmensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Aplicação em C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmensagem;
        private Button btnmensagem;
        private Button btnpropriedadescheckbox;
    }
}