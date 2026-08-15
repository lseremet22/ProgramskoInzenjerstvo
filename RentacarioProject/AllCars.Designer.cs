namespace RentacarioProject
{
    partial class AllCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCars));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.homepageButton = new System.Windows.Forms.Button();
            this.availeableVehiclesButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelVehicles = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.76498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.23502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.homepageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.availeableVehiclesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reservationsButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // homepageButton
            // 
            this.homepageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepageButton.Image = ((System.Drawing.Image)(resources.GetObject("homepageButton.Image")));
            this.homepageButton.Location = new System.Drawing.Point(3, 3);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(248, 51);
            this.homepageButton.TabIndex = 0;
            this.homepageButton.Text = "Naslovna stranica";
            this.homepageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // availeableVehiclesButton
            // 
            this.availeableVehiclesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availeableVehiclesButton.Image = ((System.Drawing.Image)(resources.GetObject("availeableVehiclesButton.Image")));
            this.availeableVehiclesButton.Location = new System.Drawing.Point(257, 3);
            this.availeableVehiclesButton.Name = "availeableVehiclesButton";
            this.availeableVehiclesButton.Size = new System.Drawing.Size(221, 51);
            this.availeableVehiclesButton.TabIndex = 1;
            this.availeableVehiclesButton.Text = "Dostupna vozila";
            this.availeableVehiclesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.availeableVehiclesButton.UseVisualStyleBackColor = true;
            this.availeableVehiclesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationsButton.Image = ((System.Drawing.Image)(resources.GetObject("reservationsButton.Image")));
            this.reservationsButton.Location = new System.Drawing.Point(484, 3);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(213, 51);
            this.reservationsButton.TabIndex = 2;
            this.reservationsButton.Text = "Rezervacije";
            this.reservationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservationsButton.UseVisualStyleBackColor = true;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.Location = new System.Drawing.Point(703, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(127, 51);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "user";
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // flowLayoutPanelVehicles
            // 
            this.flowLayoutPanelVehicles.AutoScroll = true;
            this.flowLayoutPanelVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelVehicles.Location = new System.Drawing.Point(0, 57);
            this.flowLayoutPanelVehicles.Name = "flowLayoutPanelVehicles";
            this.flowLayoutPanelVehicles.Size = new System.Drawing.Size(833, 343);
            this.flowLayoutPanelVehicles.TabIndex = 1;
            this.flowLayoutPanelVehicles.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelVehicles_Paint);
            // 
            // AllCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 400);
            this.Controls.Add(this.flowLayoutPanelVehicles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AllCars";
            this.Text = "Sva vozila";
            this.Load += new System.EventHandler(this.AllCars_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button availeableVehiclesButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVehicles;
    }
}