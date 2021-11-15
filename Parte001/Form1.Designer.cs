
namespace Parte001
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTítulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoEllipsis = true;
            this.lblTítulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTítulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTítulo.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTítulo.Location = new System.Drawing.Point(66, 9);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Padding = new System.Windows.Forms.Padding(20);
            this.lblTítulo.Size = new System.Drawing.Size(700, 170);
            this.lblTítulo.TabIndex = 1;
            this.lblTítulo.Text = "Willian";
            this.lblTítulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTítulo.Click += new System.EventHandler(this.lblTítulo_Click);
            this.lblTítulo.MouseEnter += new System.EventHandler(this.lblTítulo_MouseEnter);
            this.lblTítulo.MouseLeave += new System.EventHandler(this.lblTítulo_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTítulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTítulo;
    }
}

