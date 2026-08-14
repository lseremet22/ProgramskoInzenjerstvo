namespace RentacarioProject
{
    partial class Prijava
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
            this.useranameBox = new System.Windows.Forms.TextBox();
            this.gumbPrijava = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // useranameBox
            // 
            this.useranameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.useranameBox.Location = new System.Drawing.Point(147, 159);
            this.useranameBox.Name = "useranameBox";
            this.useranameBox.Size = new System.Drawing.Size(441, 20);
            this.useranameBox.TabIndex = 0;
            this.useranameBox.Text = "Korisničko ime";
            // 
            // gumbPrijava
            // 
            this.gumbPrijava.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gumbPrijava.Location = new System.Drawing.Point(325, 250);
            this.gumbPrijava.MaximumSize = new System.Drawing.Size(80, 30);
            this.gumbPrijava.MinimumSize = new System.Drawing.Size(80, 30);
            this.gumbPrijava.Name = "gumbPrijava";
            this.gumbPrijava.Size = new System.Drawing.Size(80, 30);
            this.gumbPrijava.TabIndex = 1;
            this.gumbPrijava.Text = "Prijavi se";
            this.gumbPrijava.UseVisualStyleBackColor = true;
            this.gumbPrijava.Click += new System.EventHandler(this.gumbPrijava_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(147, 224);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(441, 20);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.Text = "Lozinka";
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 451);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.gumbPrijava);
            this.Controls.Add(this.useranameBox);
            this.MaximumSize = new System.Drawing.Size(781, 491);
            this.MinimumSize = new System.Drawing.Size(780, 490);
            this.Name = "Prijava";
            this.Text = "Prijava u korisnički račun";
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox useranameBox;
        private System.Windows.Forms.Button gumbPrijava;
        private System.Windows.Forms.TextBox passwordBox;
    }
}

