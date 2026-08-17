namespace RentacarioProject
{
    partial class ActiveReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveReservations));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.homePageButton = new System.Windows.Forms.Button();
            this.allCarsButton = new System.Windows.Forms.Button();
            this.availeableCarsButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.homePageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.allCarsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.availeableCarsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // homePageButton
            // 
            this.homePageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePageButton.Image = ((System.Drawing.Image)(resources.GetObject("homePageButton.Image")));
            this.homePageButton.Location = new System.Drawing.Point(3, 3);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(158, 34);
            this.homePageButton.TabIndex = 0;
            this.homePageButton.Text = "Naslovna stranica";
            this.homePageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homePageButton.UseVisualStyleBackColor = true;
            this.homePageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // allCarsButton
            // 
            this.allCarsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("allCarsButton.Image")));
            this.allCarsButton.Location = new System.Drawing.Point(167, 3);
            this.allCarsButton.Name = "allCarsButton";
            this.allCarsButton.Size = new System.Drawing.Size(158, 34);
            this.allCarsButton.TabIndex = 1;
            this.allCarsButton.Text = "Sva vozila";
            this.allCarsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allCarsButton.UseVisualStyleBackColor = true;
            this.allCarsButton.Click += new System.EventHandler(this.allCarsButton_Click);
            // 
            // availeableCarsButton
            // 
            this.availeableCarsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availeableCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("availeableCarsButton.Image")));
            this.availeableCarsButton.Location = new System.Drawing.Point(331, 3);
            this.availeableCarsButton.Name = "availeableCarsButton";
            this.availeableCarsButton.Size = new System.Drawing.Size(158, 34);
            this.availeableCarsButton.TabIndex = 2;
            this.availeableCarsButton.Text = "Dostupna vozila";
            this.availeableCarsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.availeableCarsButton.UseVisualStyleBackColor = true;
            this.availeableCarsButton.Click += new System.EventHandler(this.availeableCarsButton_Click);
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.Location = new System.Drawing.Point(495, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(161, 34);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "user";
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(659, 410);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // ActiveReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ActiveReservations";
            this.Text = "Trenutno iznajmljena vozila";
            this.Load += new System.EventHandler(this.AktivneRezervacije_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homePageButton;
        private System.Windows.Forms.Button allCarsButton;
        private System.Windows.Forms.Button availeableCarsButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}