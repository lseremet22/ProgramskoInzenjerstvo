namespace RentacarioProject
{
    partial class VehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetails));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.homepageButton = new System.Windows.Forms.Button();
            this.availeableCarsButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.homepageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.availeableCarsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reservationsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // homepageButton
            // 
            this.homepageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepageButton.Image = ((System.Drawing.Image)(resources.GetObject("homepageButton.Image")));
            this.homepageButton.Location = new System.Drawing.Point(3, 3);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(190, 39);
            this.homepageButton.TabIndex = 0;
            this.homepageButton.Text = "Naslovna stranica";
            this.homepageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // availeableCarsButton
            // 
            this.availeableCarsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availeableCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("availeableCarsButton.Image")));
            this.availeableCarsButton.Location = new System.Drawing.Point(199, 3);
            this.availeableCarsButton.Name = "availeableCarsButton";
            this.availeableCarsButton.Size = new System.Drawing.Size(190, 39);
            this.availeableCarsButton.TabIndex = 1;
            this.availeableCarsButton.Text = "Dostupna vozila";
            this.availeableCarsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.availeableCarsButton.UseVisualStyleBackColor = true;
            // 
            // reservationsButton
            // 
            this.reservationsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationsButton.Image = ((System.Drawing.Image)(resources.GetObject("reservationsButton.Image")));
            this.reservationsButton.Location = new System.Drawing.Point(395, 3);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(190, 39);
            this.reservationsButton.TabIndex = 2;
            this.reservationsButton.Text = "Rezervacije";
            this.reservationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservationsButton.UseMnemonic = false;
            this.reservationsButton.UseVisualStyleBackColor = true;
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.Location = new System.Drawing.Point(591, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(192, 39);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "user";
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(786, 405);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // VehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VehicleDetails";
            this.Text = "Podaci o vozilu";
            this.Load += new System.EventHandler(this.VehicleDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button availeableCarsButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}