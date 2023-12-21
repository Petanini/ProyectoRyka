namespace ProyectoRyka
{
    partial class FrmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.accessioningScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmFac = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmPat = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmOrders,
            this.TsmFac,
            this.TsmPat,
            this.TsmTest,
            this.TsmAdmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmOrders
            // 
            this.TsmOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accessioningScreenToolStripMenuItem,
            this.orderHistoryToolStripMenuItem});
            this.TsmOrders.Name = "TsmOrders";
            this.TsmOrders.Size = new System.Drawing.Size(95, 24);
            this.TsmOrders.Text = "Lab Orders";
            // 
            // accessioningScreenToolStripMenuItem
            // 
            this.accessioningScreenToolStripMenuItem.Name = "accessioningScreenToolStripMenuItem";
            this.accessioningScreenToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.accessioningScreenToolStripMenuItem.Text = "Accessioning Screen";
            this.accessioningScreenToolStripMenuItem.Click += new System.EventHandler(this.accessioningScreenToolStripMenuItem_Click);
            // 
            // orderHistoryToolStripMenuItem
            // 
            this.orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            this.orderHistoryToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.orderHistoryToolStripMenuItem.Text = "Order History";
            this.orderHistoryToolStripMenuItem.Click += new System.EventHandler(this.orderHistoryToolStripMenuItem_Click);
            // 
            // TsmFac
            // 
            this.TsmFac.Name = "TsmFac";
            this.TsmFac.Size = new System.Drawing.Size(79, 24);
            this.TsmFac.Text = "Facilities";
            this.TsmFac.Click += new System.EventHandler(this.TsmFac_Click);
            // 
            // TsmPat
            // 
            this.TsmPat.Name = "TsmPat";
            this.TsmPat.Size = new System.Drawing.Size(74, 24);
            this.TsmPat.Text = "Patients";
            this.TsmPat.Click += new System.EventHandler(this.TsmPat_Click);
            // 
            // TsmTest
            // 
            this.TsmTest.Name = "TsmTest";
            this.TsmTest.Size = new System.Drawing.Size(55, 24);
            this.TsmTest.Text = "Tests";
            this.TsmTest.Click += new System.EventHandler(this.TsmTest_Click);
            // 
            // TsmAdmin
            // 
            this.TsmAdmin.Name = "TsmAdmin";
            this.TsmAdmin.Size = new System.Drawing.Size(106, 24);
            this.TsmAdmin.Text = "Admin Users";
            this.TsmAdmin.Click += new System.EventHandler(this.TsmAdmin_Click);
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(657, 532);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.MdiChildActivate += new System.EventHandler(this.FrmMenuAdmin_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmOrders;
        private System.Windows.Forms.ToolStripMenuItem TsmFac;
        private System.Windows.Forms.ToolStripMenuItem accessioningScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmPat;
        private System.Windows.Forms.ToolStripMenuItem TsmTest;
        private System.Windows.Forms.ToolStripMenuItem TsmAdmin;
    }
}