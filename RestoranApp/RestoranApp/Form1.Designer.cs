namespace RestoranApp
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
            this.btnKonobari = new System.Windows.Forms.Button();
            this.btnJelovnik = new System.Windows.Forms.Button();
            this.btnMesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKonobari
            // 
            this.btnKonobari.Location = new System.Drawing.Point(749, 460);
            this.btnKonobari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKonobari.Name = "btnKonobari";
            this.btnKonobari.Size = new System.Drawing.Size(139, 75);
            this.btnKonobari.TabIndex = 0;
            this.btnKonobari.Text = "Konobari";
            this.btnKonobari.UseVisualStyleBackColor = true;
            this.btnKonobari.Click += new System.EventHandler(this.btnKonobari_Click);
            // 
            // btnJelovnik
            // 
            this.btnJelovnik.Location = new System.Drawing.Point(368, 460);
            this.btnJelovnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJelovnik.Name = "btnJelovnik";
            this.btnJelovnik.Size = new System.Drawing.Size(139, 75);
            this.btnJelovnik.TabIndex = 1;
            this.btnJelovnik.Text = "Jelovnik";
            this.btnJelovnik.UseVisualStyleBackColor = true;
            this.btnJelovnik.Click += new System.EventHandler(this.btnJelovnik_Click);
            // 
            // btnMesta
            // 
            this.btnMesta.Location = new System.Drawing.Point(12, 460);
            this.btnMesta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMesta.Name = "btnMesta";
            this.btnMesta.Size = new System.Drawing.Size(139, 75);
            this.btnMesta.TabIndex = 2;
            this.btnMesta.Text = "Mesta";
            this.btnMesta.UseVisualStyleBackColor = true;
            this.btnMesta.Click += new System.EventHandler(this.btnMesta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnMesta);
            this.Controls.Add(this.btnJelovnik);
            this.Controls.Add(this.btnKonobari);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKonobari;
        private System.Windows.Forms.Button btnJelovnik;
        private System.Windows.Forms.Button btnMesta;
    }
}

