namespace ProyectoRyka
{
    partial class FrmFacility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacility));
            this.BtnCreateNew = new System.Windows.Forms.Button();
            this.BtnUpdateExisting = new System.Windows.Forms.Button();
            this.DgvFacility = new System.Windows.Forms.DataGridView();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.TxtTlf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.TxtMainFax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDoctor = new System.Windows.Forms.TextBox();
            this.TxtFacName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboClient = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtIdFac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.GrpCampos = new System.Windows.Forms.Panel();
            this.BtnActivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacility)).BeginInit();
            this.GrpCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCreateNew
            // 
            this.BtnCreateNew.Location = new System.Drawing.Point(35, 43);
            this.BtnCreateNew.Name = "BtnCreateNew";
            this.BtnCreateNew.Size = new System.Drawing.Size(184, 32);
            this.BtnCreateNew.TabIndex = 0;
            this.BtnCreateNew.Text = "Create new facility Account";
            this.BtnCreateNew.UseVisualStyleBackColor = true;
            this.BtnCreateNew.Click += new System.EventHandler(this.BtnCreateNew_Click);
            // 
            // BtnUpdateExisting
            // 
            this.BtnUpdateExisting.Location = new System.Drawing.Point(35, 103);
            this.BtnUpdateExisting.Name = "BtnUpdateExisting";
            this.BtnUpdateExisting.Size = new System.Drawing.Size(184, 32);
            this.BtnUpdateExisting.TabIndex = 1;
            this.BtnUpdateExisting.Text = "Update Existing Account";
            this.BtnUpdateExisting.UseVisualStyleBackColor = true;
            this.BtnUpdateExisting.Click += new System.EventHandler(this.BtnUpdateExisting_Click);
            // 
            // DgvFacility
            // 
            this.DgvFacility.AllowUserToAddRows = false;
            this.DgvFacility.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFacility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacility.Location = new System.Drawing.Point(44, 257);
            this.DgvFacility.MultiSelect = false;
            this.DgvFacility.Name = "DgvFacility";
            this.DgvFacility.ReadOnly = true;
            this.DgvFacility.RowHeadersWidth = 51;
            this.DgvFacility.RowTemplate.Height = 24;
            this.DgvFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFacility.Size = new System.Drawing.Size(1070, 305);
            this.DgvFacility.TabIndex = 2;
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(368, 52);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(163, 22);
            this.TxtZip.TabIndex = 34;
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(368, 110);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(163, 22);
            this.TxtState.TabIndex = 38;
            // 
            // TxtTlf
            // 
            this.TxtTlf.Location = new System.Drawing.Point(106, 55);
            this.TxtTlf.Name = "TxtTlf";
            this.TxtTlf.Size = new System.Drawing.Size(163, 22);
            this.TxtTlf.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Address:";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(368, 81);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(163, 22);
            this.TxtCity.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "ZIP Code:";
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(368, 19);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(163, 22);
            this.TxtAdd.TabIndex = 33;
            // 
            // TxtMainFax
            // 
            this.TxtMainFax.Location = new System.Drawing.Point(106, 87);
            this.TxtMainFax.Name = "TxtMainFax";
            this.TxtMainFax.Size = new System.Drawing.Size(163, 22);
            this.TxtMainFax.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Main Fax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Doctor:";
            // 
            // TxtDoctor
            // 
            this.TxtDoctor.Location = new System.Drawing.Point(106, 115);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(163, 22);
            this.TxtDoctor.TabIndex = 41;
            // 
            // TxtFacName
            // 
            this.TxtFacName.Location = new System.Drawing.Point(106, 19);
            this.TxtFacName.Name = "TxtFacName";
            this.TxtFacName.Size = new System.Drawing.Size(163, 22);
            this.TxtFacName.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Facility Name:";
            // 
            // CboClient
            // 
            this.CboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboClient.BackColor = System.Drawing.Color.AntiqueWhite;
            this.CboClient.ForeColor = System.Drawing.Color.Black;
            this.CboClient.FormattingEnabled = true;
            this.CboClient.Items.AddRange(new object[] {
            "Seleccione"});
            this.CboClient.Location = new System.Drawing.Point(419, 29);
            this.CboClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboClient.Name = "CboClient";
            this.CboClient.Size = new System.Drawing.Size(209, 24);
            this.CboClient.TabIndex = 46;
            this.CboClient.Tag = "";
            this.CboClient.DropDown += new System.EventHandler(this.CboClient_DropDown);
            this.CboClient.SelectedIndexChanged += new System.EventHandler(this.CboClient_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Select Facility:";
            // 
            // TxtIdFac
            // 
            this.TxtIdFac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdFac.Location = new System.Drawing.Point(727, 34);
            this.TxtIdFac.Name = "TxtIdFac";
            this.TxtIdFac.Size = new System.Drawing.Size(163, 22);
            this.TxtIdFac.TabIndex = 47;
            this.TxtIdFac.TextChanged += new System.EventHandler(this.TxtIdFac_TextChanged);
            this.TxtIdFac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdFac_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(644, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID Code:";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(1045, 181);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 50;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(964, 181);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 49;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(44, 211);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(137, 30);
            this.BtnRemove.TabIndex = 51;
            this.BtnRemove.Text = "Deactivate Selected";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // GrpCampos
            // 
            this.GrpCampos.Controls.Add(this.TxtCity);
            this.GrpCampos.Controls.Add(this.TxtAdd);
            this.GrpCampos.Controls.Add(this.label6);
            this.GrpCampos.Controls.Add(this.label8);
            this.GrpCampos.Controls.Add(this.label5);
            this.GrpCampos.Controls.Add(this.label3);
            this.GrpCampos.Controls.Add(this.label10);
            this.GrpCampos.Controls.Add(this.TxtTlf);
            this.GrpCampos.Controls.Add(this.TxtFacName);
            this.GrpCampos.Controls.Add(this.TxtState);
            this.GrpCampos.Controls.Add(this.label4);
            this.GrpCampos.Controls.Add(this.TxtZip);
            this.GrpCampos.Controls.Add(this.label2);
            this.GrpCampos.Controls.Add(this.TxtMainFax);
            this.GrpCampos.Controls.Add(this.TxtDoctor);
            this.GrpCampos.Controls.Add(this.label1);
            this.GrpCampos.Location = new System.Drawing.Point(363, 62);
            this.GrpCampos.Name = "GrpCampos";
            this.GrpCampos.Size = new System.Drawing.Size(539, 163);
            this.GrpCampos.TabIndex = 52;
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(187, 211);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(137, 30);
            this.BtnActivate.TabIndex = 53;
            this.BtnActivate.Text = "Activate Selected";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // FrmFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 589);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.GrpCampos);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtIdFac);
            this.Controls.Add(this.CboClient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DgvFacility);
            this.Controls.Add(this.BtnUpdateExisting);
            this.Controls.Add(this.BtnCreateNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFacility";
            this.Text = "Facility menu";
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacility)).EndInit();
            this.GrpCampos.ResumeLayout(false);
            this.GrpCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateNew;
        private System.Windows.Forms.Button BtnUpdateExisting;
        private System.Windows.Forms.DataGridView DgvFacility;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox TxtTlf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.TextBox TxtMainFax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDoctor;
        private System.Windows.Forms.TextBox TxtFacName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtIdFac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Panel GrpCampos;
        private System.Windows.Forms.Button BtnActivate;
    }
}