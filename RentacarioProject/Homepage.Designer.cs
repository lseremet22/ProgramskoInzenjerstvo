namespace RentacarioProject
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.userButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.allCarsButton = new System.Windows.Forms.Button();
            this.freeCarsButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelVehicles = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.Location = new System.Drawing.Point(591, 3);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(193, 45);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "user";
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.userButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.allCarsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.freeCarsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.reservationsButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 51);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // allCarsButton
            // 
            this.allCarsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCarsButton.Location = new System.Drawing.Point(3, 3);
            this.allCarsButton.Name = "allCarsButton";
            this.allCarsButton.Size = new System.Drawing.Size(190, 45);
            this.allCarsButton.TabIndex = 1;
            this.allCarsButton.Text = "Sva vozila";
            this.allCarsButton.UseVisualStyleBackColor = true;
            this.allCarsButton.Click += new System.EventHandler(this.allCarsButton_Click);
            // 
            // freeCarsButton
            // 
            this.freeCarsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeCarsButton.Location = new System.Drawing.Point(199, 3);
            this.freeCarsButton.Name = "freeCarsButton";
            this.freeCarsButton.Size = new System.Drawing.Size(190, 45);
            this.freeCarsButton.TabIndex = 2;
            this.freeCarsButton.Text = "Dostupna vozila";
            this.freeCarsButton.UseVisualStyleBackColor = true;
            // 
            // reservationsButton
            // 
            this.reservationsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationsButton.Location = new System.Drawing.Point(395, 3);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Size = new System.Drawing.Size(190, 45);
            this.reservationsButton.TabIndex = 3;
            this.reservationsButton.Text = "Rezervacije";
            this.reservationsButton.UseVisualStyleBackColor = true;
            this.reservationsButton.Click += new System.EventHandler(this.reservationsButton_Click);
            // 
            // flowLayoutPanelVehicles
            // 
            this.flowLayoutPanelVehicles.AutoScroll = true;
            this.flowLayoutPanelVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelVehicles.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanelVehicles.Name = "flowLayoutPanelVehicles";
            this.flowLayoutPanelVehicles.Size = new System.Drawing.Size(787, 500);
            this.flowLayoutPanelVehicles.TabIndex = 2;
            this.flowLayoutPanelVehicles.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 551);
            this.Controls.Add(this.flowLayoutPanelVehicles);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Homepage";
            this.Text = "Rentacario";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button allCarsButton;
        private System.Windows.Forms.Button freeCarsButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVehicles;
    }
}