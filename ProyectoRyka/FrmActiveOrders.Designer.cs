namespace ProyectoRyka
{
    partial class FrmOrderHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.RbOrderID = new System.Windows.Forms.RadioButton();
            this.GrpSearchByOrderId = new System.Windows.Forms.GroupBox();
            this.BtnSearchOrderId = new System.Windows.Forms.Button();
            this.txtSearchbyOrderID = new System.Windows.Forms.TextBox();
            this.GrpSearchByPatientMrn = new System.Windows.Forms.GroupBox();
            this.BtnSearchMrn = new System.Windows.Forms.Button();
            this.txtSearchbyMRN = new System.Windows.Forms.TextBox();
            this.RbMRN = new System.Windows.Forms.RadioButton();
            this.GrpSearchByFacility = new System.Windows.Forms.GroupBox();
            this.CboClient = new System.Windows.Forms.ComboBox();
            this.DgvActiveOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEditOrder = new System.Windows.Forms.Button();
            this.BtnMarkAsCompleted = new System.Windows.Forms.Button();
            this.BtnCancelOrder = new System.Windows.Forms.Button();
            this.LblConteodeOrdenes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.GrpSearchByOrderId.SuspendLayout();
            this.GrpSearchByPatientMrn.SuspendLayout();
            this.GrpSearchByFacility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActiveOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // RbOrderID
            // 
            this.RbOrderID.AutoSize = true;
            this.RbOrderID.Location = new System.Drawing.Point(13, 40);
            this.RbOrderID.Name = "RbOrderID";
            this.RbOrderID.Size = new System.Drawing.Size(82, 20);
            this.RbOrderID.TabIndex = 2;
            this.RbOrderID.TabStop = true;
            this.RbOrderID.Text = "OrderID#";
            this.RbOrderID.UseVisualStyleBackColor = true;
            this.RbOrderID.Click += new System.EventHandler(this.RbOrderID_Click);
            // 
            // GrpSearchByOrderId
            // 
            this.GrpSearchByOrderId.Controls.Add(this.BtnSearchOrderId);
            this.GrpSearchByOrderId.Controls.Add(this.txtSearchbyOrderID);
            this.GrpSearchByOrderId.Controls.Add(this.RbOrderID);
            this.GrpSearchByOrderId.Location = new System.Drawing.Point(836, 13);
            this.GrpSearchByOrderId.Name = "GrpSearchByOrderId";
            this.GrpSearchByOrderId.Size = new System.Drawing.Size(247, 100);
            this.GrpSearchByOrderId.TabIndex = 2;
            this.GrpSearchByOrderId.TabStop = false;
            this.GrpSearchByOrderId.Text = "Order ID";
            // 
            // BtnSearchOrderId
            // 
            this.BtnSearchOrderId.Image = global::ProyectoRyka.Properties.Resources.buscar2;
            this.BtnSearchOrderId.Location = new System.Drawing.Point(189, 39);
            this.BtnSearchOrderId.Name = "BtnSearchOrderId";
            this.BtnSearchOrderId.Size = new System.Drawing.Size(45, 24);
            this.BtnSearchOrderId.TabIndex = 8;
            this.BtnSearchOrderId.UseVisualStyleBackColor = true;
            this.BtnSearchOrderId.Click += new System.EventHandler(this.BtnSearchOrderId_Click);
            // 
            // txtSearchbyOrderID
            // 
            this.txtSearchbyOrderID.Location = new System.Drawing.Point(35, 40);
            this.txtSearchbyOrderID.Name = "txtSearchbyOrderID";
            this.txtSearchbyOrderID.Size = new System.Drawing.Size(148, 22);
            this.txtSearchbyOrderID.TabIndex = 7;
            // 
            // GrpSearchByPatientMrn
            // 
            this.GrpSearchByPatientMrn.Controls.Add(this.BtnSearchMrn);
            this.GrpSearchByPatientMrn.Controls.Add(this.txtSearchbyMRN);
            this.GrpSearchByPatientMrn.Controls.Add(this.RbMRN);
            this.GrpSearchByPatientMrn.Location = new System.Drawing.Point(836, 119);
            this.GrpSearchByPatientMrn.Name = "GrpSearchByPatientMrn";
            this.GrpSearchByPatientMrn.Size = new System.Drawing.Size(247, 100);
            this.GrpSearchByPatientMrn.TabIndex = 3;
            this.GrpSearchByPatientMrn.TabStop = false;
            this.GrpSearchByPatientMrn.Text = "Patient MRN";
            // 
            // BtnSearchMrn
            // 
            this.BtnSearchMrn.Image = global::ProyectoRyka.Properties.Resources.buscar2;
            this.BtnSearchMrn.Location = new System.Drawing.Point(189, 35);
            this.BtnSearchMrn.Name = "BtnSearchMrn";
            this.BtnSearchMrn.Size = new System.Drawing.Size(45, 27);
            this.BtnSearchMrn.TabIndex = 10;
            this.BtnSearchMrn.UseVisualStyleBackColor = true;
            this.BtnSearchMrn.Click += new System.EventHandler(this.BtnSearchMrn_Click_1);
            // 
            // txtSearchbyMRN
            // 
            this.txtSearchbyMRN.Location = new System.Drawing.Point(33, 42);
            this.txtSearchbyMRN.Name = "txtSearchbyMRN";
            this.txtSearchbyMRN.Size = new System.Drawing.Size(150, 22);
            this.txtSearchbyMRN.TabIndex = 9;
            // 
            // RbMRN
            // 
            this.RbMRN.AutoSize = true;
            this.RbMRN.Location = new System.Drawing.Point(11, 42);
            this.RbMRN.Name = "RbMRN";
            this.RbMRN.Size = new System.Drawing.Size(66, 20);
            this.RbMRN.TabIndex = 3;
            this.RbMRN.TabStop = true;
            this.RbMRN.Text = "MRN#";
            this.RbMRN.UseVisualStyleBackColor = true;
            this.RbMRN.Click += new System.EventHandler(this.RbMRN_Click);
            // 
            // GrpSearchByFacility
            // 
            this.GrpSearchByFacility.Controls.Add(this.CboClient);
            this.GrpSearchByFacility.Location = new System.Drawing.Point(42, 41);
            this.GrpSearchByFacility.Name = "GrpSearchByFacility";
            this.GrpSearchByFacility.Size = new System.Drawing.Size(248, 100);
            this.GrpSearchByFacility.TabIndex = 1;
            this.GrpSearchByFacility.TabStop = false;
            this.GrpSearchByFacility.Text = "Facility";
            // 
            // CboClient
            // 
            this.CboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboClient.FormattingEnabled = true;
            this.CboClient.Location = new System.Drawing.Point(21, 36);
            this.CboClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboClient.Name = "CboClient";
            this.CboClient.Size = new System.Drawing.Size(209, 24);
            this.CboClient.TabIndex = 4;
            this.CboClient.Tag = "";
            this.CboClient.DropDown += new System.EventHandler(this.CboClient_DropDown);
            this.CboClient.SelectedIndexChanged += new System.EventHandler(this.CboClient_SelectedIndexChanged);
            // 
            // DgvActiveOrders
            // 
            this.DgvActiveOrders.AllowUserToAddRows = false;
            this.DgvActiveOrders.AllowUserToDeleteRows = false;
            this.DgvActiveOrders.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvActiveOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvActiveOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActiveOrders.Location = new System.Drawing.Point(26, 183);
            this.DgvActiveOrders.Name = "DgvActiveOrders";
            this.DgvActiveOrders.ReadOnly = true;
            this.DgvActiveOrders.RowHeadersWidth = 51;
            this.DgvActiveOrders.RowTemplate.Height = 24;
            this.DgvActiveOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvActiveOrders.Size = new System.Drawing.Size(768, 402);
            this.DgvActiveOrders.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Active Orders Dashboard";
            // 
            // BtnEditOrder
            // 
            this.BtnEditOrder.Location = new System.Drawing.Point(836, 297);
            this.BtnEditOrder.Name = "BtnEditOrder";
            this.BtnEditOrder.Size = new System.Drawing.Size(183, 36);
            this.BtnEditOrder.TabIndex = 9;
            this.BtnEditOrder.Text = "Edit Selected Order";
            this.BtnEditOrder.UseVisualStyleBackColor = true;
            this.BtnEditOrder.Click += new System.EventHandler(this.BtnEditOrder_Click);
            // 
            // BtnMarkAsCompleted
            // 
            this.BtnMarkAsCompleted.Location = new System.Drawing.Point(836, 255);
            this.BtnMarkAsCompleted.Name = "BtnMarkAsCompleted";
            this.BtnMarkAsCompleted.Size = new System.Drawing.Size(183, 36);
            this.BtnMarkAsCompleted.TabIndex = 10;
            this.BtnMarkAsCompleted.Text = "Complete Selected Order";
            this.BtnMarkAsCompleted.UseVisualStyleBackColor = true;
            this.BtnMarkAsCompleted.Click += new System.EventHandler(this.BtnMarkAsCompleted_Click);
            // 
            // BtnCancelOrder
            // 
            this.BtnCancelOrder.Location = new System.Drawing.Point(837, 339);
            this.BtnCancelOrder.Name = "BtnCancelOrder";
            this.BtnCancelOrder.Size = new System.Drawing.Size(182, 33);
            this.BtnCancelOrder.TabIndex = 11;
            this.BtnCancelOrder.Text = "Cancel Selected Order";
            this.BtnCancelOrder.UseVisualStyleBackColor = true;
            this.BtnCancelOrder.Click += new System.EventHandler(this.BtnCancelOrder_Click);
            // 
            // LblConteodeOrdenes
            // 
            this.LblConteodeOrdenes.AutoSize = true;
            this.LblConteodeOrdenes.Location = new System.Drawing.Point(23, 144);
            this.LblConteodeOrdenes.Name = "LblConteodeOrdenes";
            this.LblConteodeOrdenes.Size = new System.Drawing.Size(16, 16);
            this.LblConteodeOrdenes.TabIndex = 12;
            this.LblConteodeOrdenes.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboStatus);
            this.groupBox1.Location = new System.Drawing.Point(313, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // CboStatus
            // 
            this.CboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed",
            "Cancelled"});
            this.CboStatus.Location = new System.Drawing.Point(26, 36);
            this.CboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(209, 24);
            this.CboStatus.TabIndex = 4;
            this.CboStatus.Tag = "";
            // 
            // BtnFilter
            // 
            this.BtnFilter.Image = global::ProyectoRyka.Properties.Resources.buscar2;
            this.BtnFilter.Location = new System.Drawing.Point(580, 114);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(45, 27);
            this.BtnFilter.TabIndex = 17;
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // FrmOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 639);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblConteodeOrdenes);
            this.Controls.Add(this.BtnCancelOrder);
            this.Controls.Add(this.BtnMarkAsCompleted);
            this.Controls.Add(this.BtnEditOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvActiveOrders);
            this.Controls.Add(this.GrpSearchByFacility);
            this.Controls.Add(this.GrpSearchByPatientMrn);
            this.Controls.Add(this.GrpSearchByOrderId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderHistory";
            this.Text = "Orders History";
            this.Load += new System.EventHandler(this.FrmActiveOrders_Load);
            this.GrpSearchByOrderId.ResumeLayout(false);
            this.GrpSearchByOrderId.PerformLayout();
            this.GrpSearchByPatientMrn.ResumeLayout(false);
            this.GrpSearchByPatientMrn.PerformLayout();
            this.GrpSearchByFacility.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActiveOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbOrderID;
        private System.Windows.Forms.GroupBox GrpSearchByOrderId;
        private System.Windows.Forms.GroupBox GrpSearchByPatientMrn;
        private System.Windows.Forms.GroupBox GrpSearchByFacility;
        private System.Windows.Forms.TextBox txtSearchbyOrderID;
        //private db_RykaTableAdapters.ORDENTableAdapter oRDENTableAdapter;
        //private db_RykaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtSearchbyMRN;
        private System.Windows.Forms.RadioButton RbMRN;
        private System.Windows.Forms.ComboBox CboClient;
        private System.Windows.Forms.Button BtnSearchOrderId;
        private System.Windows.Forms.Button BtnSearchMrn;
        private System.Windows.Forms.DataGridView DgvActiveOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEditOrder;
        private System.Windows.Forms.Button BtnMarkAsCompleted;
        private System.Windows.Forms.Button BtnCancelOrder;
        private System.Windows.Forms.Label LblConteodeOrdenes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.Button BtnFilter;
    }
}