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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.reserveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.financeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.flowLayoutPanel.Size = new System.Drawing.Size(786, 428);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.reserveButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.editButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.financeButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 433);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 40);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // reserveButton
            // 
            this.reserveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reserveButton.Location = new System.Drawing.Point(3, 3);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(190, 34);
            this.reserveButton.TabIndex = 0;
            this.reserveButton.Text = "Rezerviraj";
            this.reserveButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(199, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(190, 34);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Uredi";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(395, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 34);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Obriši";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // financeButton
            // 
            this.financeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financeButton.Location = new System.Drawing.Point(591, 3);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(192, 34);
            this.financeButton.TabIndex = 3;
            this.financeButton.Text = "Pregled financijskih podataka";
            this.financeButton.UseVisualStyleBackColor = true;
            // 
            // VehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 473);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VehicleDetails";
            this.Text = "Podaci o vozilu";
            this.Load += new System.EventHandler(this.VehicleDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Button availeableCarsButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button financeButton;
    }
}