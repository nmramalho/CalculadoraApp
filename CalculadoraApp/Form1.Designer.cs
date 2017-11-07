namespace CalculadoraApp
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
            this.labelVisor = new System.Windows.Forms.Label();
            this.userControlTeclado1 = new ClassLibraryTeclado.UserControlTeclado();
            this.SuspendLayout();
            // 
            // labelVisor
            // 
            this.labelVisor.BackColor = System.Drawing.Color.Gray;
            this.labelVisor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVisor.Location = new System.Drawing.Point(0, 0);
            this.labelVisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisor.Name = "labelVisor";
            this.labelVisor.Size = new System.Drawing.Size(191, 46);
            this.labelVisor.TabIndex = 1;
            this.labelVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userControlTeclado1
            // 
            this.userControlTeclado1.AutoScroll = true;
            this.userControlTeclado1.AutoSize = true;
            this.userControlTeclado1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlTeclado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlTeclado1.Location = new System.Drawing.Point(4, 61);
            this.userControlTeclado1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlTeclado1.Name = "userControlTeclado1";
            this.userControlTeclado1.Size = new System.Drawing.Size(175, 225);
            this.userControlTeclado1.TabIndex = 2;
            this.userControlTeclado1.UltimaTeclaPremida = '\0';
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(191, 297);
            this.Controls.Add(this.userControlTeclado1);
            this.Controls.Add(this.labelVisor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Exemplo Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVisor;
        private ClassLibraryTeclado.UserControlTeclado userControlTeclado1;
    }
}

