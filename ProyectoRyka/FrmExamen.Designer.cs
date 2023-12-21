namespace ProyectoRyka
{
    partial class FrmExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExamen));
            this.DgvExamenes = new System.Windows.Forms.DataGridView();
            this.txtDlCode = new System.Windows.Forms.TextBox();
            this.TxtShort = new System.Windows.Forms.TextBox();
            this.TxtFull = new System.Windows.Forms.TextBox();
            this.TxtSample = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblShort = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnClearFields = new System.Windows.Forms.Button();
            this.BtnSaveCrud = new System.Windows.Forms.Button();
            this.BtnDesactivar = new System.Windows.Forms.Button();
            this.GrpCampos = new System.Windows.Forms.Panel();
            this.BtnActivar = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExamenes)).BeginInit();
            this.GrpCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvExamenes
            // 
            this.DgvExamenes.AllowUserToAddRows = false;
            this.DgvExamenes.AllowUserToDeleteRows = false;
            this.DgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExamenes.Location = new System.Drawing.Point(21, 22);
            this.DgvExamenes.Name = "DgvExamenes";
            this.DgvExamenes.ReadOnly = true;
            this.DgvExamenes.RowHeadersWidth = 51;
            this.DgvExamenes.RowTemplate.Height = 24;
            this.DgvExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExamenes.Size = new System.Drawing.Size(752, 336);
            this.DgvExamenes.TabIndex = 0;
            this.DgvExamenes.SelectionChanged += new System.EventHandler(this.DgvExamenes_SelectionChanged);
            // 
            // txtDlCode
            // 
            this.txtDlCode.Location = new System.Drawing.Point(135, 17);
            this.txtDlCode.Name = "txtDlCode";
            this.txtDlCode.Size = new System.Drawing.Size(173, 22);
            this.txtDlCode.TabIndex = 1;
            // 
            // TxtShort
            // 
            this.TxtShort.Location = new System.Drawing.Point(135, 45);
            this.TxtShort.Name = "TxtShort";
            this.TxtShort.Size = new System.Drawing.Size(173, 22);
            this.TxtShort.TabIndex = 2;
            // 
            // TxtFull
            // 
            this.TxtFull.Location = new System.Drawing.Point(135, 73);
            this.TxtFull.Name = "TxtFull";
            this.TxtFull.Size = new System.Drawing.Size(173, 22);
            this.TxtFull.TabIndex = 3;
            // 
            // TxtSample
            // 
            this.TxtSample.Location = new System.Drawing.Point(135, 101);
            this.TxtSample.Name = "TxtSample";
            this.TxtSample.Size = new System.Drawing.Size(173, 22);
            this.TxtSample.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "DL-Code:";
            // 
            // LblShort
            // 
            this.LblShort.AutoSize = true;
            this.LblShort.Location = new System.Drawing.Point(34, 48);
            this.LblShort.Name = "LblShort";
            this.LblShort.Size = new System.Drawing.Size(81, 16);
            this.LblShort.TabIndex = 6;
            this.LblShort.Text = "Short Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sample Type:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(832, 22);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(126, 29);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add New Test";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(795, 329);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(126, 29);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.Text = "Edit Selected";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnClearFields
            // 
            this.BtnClearFields.Location = new System.Drawing.Point(118, 151);
            this.BtnClearFields.Name = "BtnClearFields";
            this.BtnClearFields.Size = new System.Drawing.Size(75, 23);
            this.BtnClearFields.TabIndex = 20;
            this.BtnClearFields.Text = "Clear";
            this.BtnClearFields.UseVisualStyleBackColor = true;
            this.BtnClearFields.Click += new System.EventHandler(this.BtnClearFields_Click);
            // 
            // BtnSaveCrud
            // 
            this.BtnSaveCrud.Location = new System.Drawing.Point(37, 151);
            this.BtnSaveCrud.Name = "BtnSaveCrud";
            this.BtnSaveCrud.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveCrud.TabIndex = 19;
            this.BtnSaveCrud.Text = "Save";
            this.BtnSaveCrud.UseVisualStyleBackColor = true;
            this.BtnSaveCrud.Click += new System.EventHandler(this.BtnSaveCrud_Click);
            // 
            // BtnDesactivar
            // 
            this.BtnDesactivar.Location = new System.Drawing.Point(930, 328);
            this.BtnDesactivar.Name = "BtnDesactivar";
            this.BtnDesactivar.Size = new System.Drawing.Size(91, 30);
            this.BtnDesactivar.TabIndex = 43;
            this.BtnDesactivar.Text = "Deactivate";
            this.BtnDesactivar.UseVisualStyleBackColor = true;
            this.BtnDesactivar.Click += new System.EventHandler(this.BtnDesactivar_Click);
            // 
            // GrpCampos
            // 
            this.GrpCampos.Controls.Add(this.TxtFull);
            this.GrpCampos.Controls.Add(this.txtDlCode);
            this.GrpCampos.Controls.Add(this.BtnClearFields);
            this.GrpCampos.Controls.Add(this.TxtShort);
            this.GrpCampos.Controls.Add(this.BtnSaveCrud);
            this.GrpCampos.Controls.Add(this.TxtSample);
            this.GrpCampos.Controls.Add(this.label1);
            this.GrpCampos.Controls.Add(this.LblShort);
            this.GrpCampos.Controls.Add(this.label4);
            this.GrpCampos.Controls.Add(this.label3);
            this.GrpCampos.Location = new System.Drawing.Point(795, 87);
            this.GrpCampos.Name = "GrpCampos";
            this.GrpCampos.Size = new System.Drawing.Size(328, 188);
            this.GrpCampos.TabIndex = 44;
            // 
            // BtnActivar
            // 
            this.BtnActivar.Location = new System.Drawing.Point(1027, 328);
            this.BtnActivar.Name = "BtnActivar";
            this.BtnActivar.Size = new System.Drawing.Size(91, 30);
            this.BtnActivar.TabIndex = 45;
            this.BtnActivar.Text = "Activate";
            this.BtnActivar.UseVisualStyleBackColor = true;
            this.BtnActivar.Click += new System.EventHandler(this.BtnActivar_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::ProyectoRyka.Properties.Resources.icons8_actualizar_24;
            this.BtnRefresh.Location = new System.Drawing.Point(780, 13);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(46, 38);
            this.BtnRefresh.TabIndex = 46;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 409);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnActivar);
            this.Controls.Add(this.GrpCampos);
            this.Controls.Add(this.BtnDesactivar);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvExamenes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExamen";
            this.Text = "Test menu";
            ((System.ComponentModel.ISupportInitialize)(this.DgvExamenes)).EndInit();
            this.GrpCampos.ResumeLayout(false);
            this.GrpCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExamenes;
        private System.Windows.Forms.TextBox txtDlCode;
        private System.Windows.Forms.TextBox TxtShort;
        private System.Windows.Forms.TextBox TxtFull;
        private System.Windows.Forms.TextBox TxtSample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblShort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnClearFields;
        private System.Windows.Forms.Button BtnSaveCrud;
        private System.Windows.Forms.Button BtnDesactivar;
        private System.Windows.Forms.Panel GrpCampos;
        private System.Windows.Forms.Button BtnActivar;
        private System.Windows.Forms.Button BtnRefresh;
    }
}