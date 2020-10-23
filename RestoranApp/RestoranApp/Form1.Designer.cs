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
            this.btnUlaz = new System.Windows.Forms.Button();
            this.btnJelovnik = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUlaz
            // 
            this.btnUlaz.Location = new System.Drawing.Point(344, 13);
            this.btnUlaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUlaz.Name = "btnUlaz";
            this.btnUlaz.Size = new System.Drawing.Size(183, 129);
            this.btnUlaz.TabIndex = 0;
            this.btnUlaz.Text = "Ulazak";
            this.btnUlaz.UseVisualStyleBackColor = true;
            // 
            // btnJelovnik
            // 
            this.btnJelovnik.Location = new System.Drawing.Point(344, 184);
            this.btnJelovnik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJelovnik.Name = "btnJelovnik";
            this.btnJelovnik.Size = new System.Drawing.Size(183, 129);
            this.btnJelovnik.TabIndex = 1;
            this.btnJelovnik.Text = "Jelovnik";
            this.btnJelovnik.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 361);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 129);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnJelovnik);
            this.Controls.Add(this.btnUlaz);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUlaz;
        private System.Windows.Forms.Button btnJelovnik;
        private System.Windows.Forms.Button btnExit;
    }
}

