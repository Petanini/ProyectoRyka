namespace ProyectoRyka
{
    partial class PatientOnboarding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientOnboarding));
            this.BtnSavePatientCrud = new System.Windows.Forms.Button();
            this.BtnClearPtFields = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CboClient = new System.Windows.Forms.ComboBox();
            this.DgvCrudPatients = new System.Windows.Forms.DataGridView();
            this.CboSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtMi = new System.Windows.Forms.TextBox();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DtpDob = new System.Windows.Forms.DateTimePicker();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.TxtLn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFn = new System.Windows.Forms.TextBox();
            this.TxtMrn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CboEth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboRace = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTlf = new System.Windows.Forms.TextBox();
            this.BtnUpdateExPat = new System.Windows.Forms.Button();
            this.BtnCreateNewPat = new System.Windows.Forms.Button();
            this.GrpPtSearch = new System.Windows.Forms.GroupBox();
            this.BtnSearchPatient = new System.Windows.Forms.Button();
            this.DtpPatientSearch = new System.Windows.Forms.DateTimePicker();
            this.TxtPatientSearch = new System.Windows.Forms.TextBox();
            this.RbSearchByDob = new System.Windows.Forms.RadioButton();
            this.RbSearchByMrn = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.GrpPatientFields = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRemovePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCrudPatients)).BeginInit();
            this.GrpPtSearch.SuspendLayout();
            this.GrpPatientFields.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSavePatientCrud
            // 
            this.BtnSavePatientCrud.Location = new System.Drawing.Point(107, 227);
            this.BtnSavePatientCrud.Name = "BtnSavePatientCrud";
            this.BtnSavePatientCrud.Size = new System.Drawing.Size(75, 23);
            this.BtnSavePatientCrud.TabIndex = 17;
            this.BtnSavePatientCrud.Text = "Save";
            this.BtnSavePatientCrud.UseVisualStyleBackColor = true;
            this.BtnSavePatientCrud.Click += new System.EventHandler(this.BtnSavePatientCrud_Click);
            // 
            // BtnClearPtFields
            // 
            this.BtnClearPtFields.Location = new System.Drawing.Point(205, 227);
            this.BtnClearPtFields.Name = "BtnClearPtFields";
            this.BtnClearPtFields.Size = new System.Drawing.Size(75, 23);
            this.BtnClearPtFields.TabIndex = 18;
            this.BtnClearPtFields.Text = "Clear";
            this.BtnClearPtFields.UseVisualStyleBackColor = true;
            this.BtnClearPtFields.Click += new System.EventHandler(this.BtnClearPtFields_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Select Facility:";
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
            this.CboClient.Location = new System.Drawing.Point(226, 123);
            this.CboClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboClient.Name = "CboClient";
            this.CboClient.Size = new System.Drawing.Size(209, 24);
            this.CboClient.TabIndex = 32;
            this.CboClient.Tag = "";
            this.CboClient.SelectedIndexChanged += new System.EventHandler(this.CboClient_SelectedIndexChanged);
            // 
            // DgvCrudPatients
            // 
            this.DgvCrudPatients.AllowUserToAddRows = false;
            this.DgvCrudPatients.AllowUserToDeleteRows = false;
            this.DgvCrudPatients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCrudPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCrudPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCrudPatients.Location = new System.Drawing.Point(35, 346);
            this.DgvCrudPatients.Name = "DgvCrudPatients";
            this.DgvCrudPatients.ReadOnly = true;
            this.DgvCrudPatients.RowHeadersWidth = 51;
            this.DgvCrudPatients.RowTemplate.Height = 24;
            this.DgvCrudPatients.Size = new System.Drawing.Size(1246, 314);
            this.DgvCrudPatients.TabIndex = 34;
            this.DgvCrudPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCrudPatients_CellClick);
            // 
            // CboSex
            // 
            this.CboSex.FormattingEnabled = true;
            this.CboSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.CboSex.Location = new System.Drawing.Point(131, 109);
            this.CboSex.Name = "CboSex";
            this.CboSex.Size = new System.Drawing.Size(149, 24);
            this.CboSex.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Sex:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(439, 175);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(163, 22);
            this.TxtCity.TabIndex = 15;
            // 
            // TxtMi
            // 
            this.TxtMi.Location = new System.Drawing.Point(131, 81);
            this.TxtMi.Name = "TxtMi";
            this.TxtMi.Size = new System.Drawing.Size(149, 22);
            this.TxtMi.TabIndex = 21;
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(439, 146);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(163, 22);
            this.TxtZip.TabIndex = 14;
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(23, 87);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(84, 16);
            this.lblMiddle.TabIndex = 22;
            this.lblMiddle.Text = "Middle Initial:";
            this.lblMiddle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(439, 116);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(163, 22);
            this.TxtAdd.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "State:";
            // 
            // DtpDob
            // 
            this.DtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDob.Location = new System.Drawing.Point(131, 144);
            this.DtpDob.Name = "DtpDob";
            this.DtpDob.Size = new System.Drawing.Size(149, 22);
            this.DtpDob.TabIndex = 12;
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(439, 204);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(163, 22);
            this.TxtState.TabIndex = 24;
            // 
            // TxtLn
            // 
            this.TxtLn.Location = new System.Drawing.Point(131, 53);
            this.TxtLn.Name = "TxtLn";
            this.TxtLn.Size = new System.Drawing.Size(149, 22);
            this.TxtLn.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Patient MRN:";
            // 
            // TxtFn
            // 
            this.TxtFn.Location = new System.Drawing.Point(131, 25);
            this.TxtFn.Name = "TxtFn";
            this.TxtFn.Size = new System.Drawing.Size(149, 22);
            this.TxtFn.TabIndex = 10;
            // 
            // TxtMrn
            // 
            this.TxtMrn.Location = new System.Drawing.Point(131, 178);
            this.TxtMrn.Name = "TxtMrn";
            this.TxtMrn.Size = new System.Drawing.Size(149, 22);
            this.TxtMrn.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Address:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(366, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ethnicity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone:";
            // 
            // CboEth
            // 
            this.CboEth.FormattingEnabled = true;
            this.CboEth.Items.AddRange(new object[] {
            "Hispanic or Latino",
            "Not Hispanic or Latino",
            "Unknown"});
            this.CboEth.Location = new System.Drawing.Point(439, 56);
            this.CboEth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboEth.Name = "CboEth";
            this.CboEth.Size = new System.Drawing.Size(163, 24);
            this.CboEth.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ZIP Code:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(386, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Race:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "City:";
            // 
            // CboRace
            // 
            this.CboRace.FormattingEnabled = true;
            this.CboRace.Items.AddRange(new object[] {
            "American Indian or Alaska Native",
            "Asian",
            "Black or African American",
            "Native Hawaiian or Other Pacific Islander",
            "White",
            "Other Race",
            "Unknown"});
            this.CboRace.Location = new System.Drawing.Point(435, 23);
            this.CboRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboRace.Name = "CboRace";
            this.CboRace.Size = new System.Drawing.Size(163, 24);
            this.CboRace.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // TxtTlf
            // 
            this.TxtTlf.Location = new System.Drawing.Point(439, 89);
            this.TxtTlf.Name = "TxtTlf";
            this.TxtTlf.Size = new System.Drawing.Size(163, 22);
            this.TxtTlf.TabIndex = 16;
            // 
            // BtnUpdateExPat
            // 
            this.BtnUpdateExPat.Location = new System.Drawing.Point(22, 15);
            this.BtnUpdateExPat.Name = "BtnUpdateExPat";
            this.BtnUpdateExPat.Size = new System.Drawing.Size(167, 34);
            this.BtnUpdateExPat.TabIndex = 1;
            this.BtnUpdateExPat.Text = "Update Existing Patient";
            this.BtnUpdateExPat.UseVisualStyleBackColor = true;
            this.BtnUpdateExPat.Click += new System.EventHandler(this.BtnUpdateExPat_Click);
            // 
            // BtnCreateNewPat
            // 
            this.BtnCreateNewPat.Location = new System.Drawing.Point(224, 15);
            this.BtnCreateNewPat.Name = "BtnCreateNewPat";
            this.BtnCreateNewPat.Size = new System.Drawing.Size(228, 34);
            this.BtnCreateNewPat.TabIndex = 38;
            this.BtnCreateNewPat.Text = "Create New Patient Account";
            this.BtnCreateNewPat.UseVisualStyleBackColor = true;
            this.BtnCreateNewPat.Click += new System.EventHandler(this.BtnCreateNewPat_Click);
            // 
            // GrpPtSearch
            // 
            this.GrpPtSearch.Controls.Add(this.BtnSearchPatient);
            this.GrpPtSearch.Controls.Add(this.DtpPatientSearch);
            this.GrpPtSearch.Controls.Add(this.TxtPatientSearch);
            this.GrpPtSearch.Controls.Add(this.RbSearchByDob);
            this.GrpPtSearch.Controls.Add(this.RbSearchByMrn);
            this.GrpPtSearch.Controls.Add(this.label14);
            this.GrpPtSearch.Location = new System.Drawing.Point(40, 171);
            this.GrpPtSearch.Name = "GrpPtSearch";
            this.GrpPtSearch.Size = new System.Drawing.Size(482, 133);
            this.GrpPtSearch.TabIndex = 39;
            this.GrpPtSearch.TabStop = false;
            this.GrpPtSearch.Text = "Patient Search";
            // 
            // BtnSearchPatient
            // 
            this.BtnSearchPatient.Image = global::ProyectoRyka.Properties.Resources.buscar2;
            this.BtnSearchPatient.Location = new System.Drawing.Point(254, 64);
            this.BtnSearchPatient.Name = "BtnSearchPatient";
            this.BtnSearchPatient.Size = new System.Drawing.Size(38, 30);
            this.BtnSearchPatient.TabIndex = 5;
            this.BtnSearchPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearchPatient.UseVisualStyleBackColor = true;
            this.BtnSearchPatient.Click += new System.EventHandler(this.BtnSearchPatient_Click);
            // 
            // DtpPatientSearch
            // 
            this.DtpPatientSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpPatientSearch.Location = new System.Drawing.Point(39, 64);
            this.DtpPatientSearch.Name = "DtpPatientSearch";
            this.DtpPatientSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpPatientSearch.Size = new System.Drawing.Size(204, 22);
            this.DtpPatientSearch.TabIndex = 4;
            this.DtpPatientSearch.Visible = false;
            // 
            // TxtPatientSearch
            // 
            this.TxtPatientSearch.Location = new System.Drawing.Point(39, 72);
            this.TxtPatientSearch.Name = "TxtPatientSearch";
            this.TxtPatientSearch.Size = new System.Drawing.Size(204, 22);
            this.TxtPatientSearch.TabIndex = 3;
            // 
            // RbSearchByDob
            // 
            this.RbSearchByDob.AutoSize = true;
            this.RbSearchByDob.Location = new System.Drawing.Point(186, 35);
            this.RbSearchByDob.Name = "RbSearchByDob";
            this.RbSearchByDob.Size = new System.Drawing.Size(57, 20);
            this.RbSearchByDob.TabIndex = 2;
            this.RbSearchByDob.TabStop = true;
            this.RbSearchByDob.Text = "DOB";
            this.RbSearchByDob.UseVisualStyleBackColor = true;
            // 
            // RbSearchByMrn
            // 
            this.RbSearchByMrn.AutoSize = true;
            this.RbSearchByMrn.Location = new System.Drawing.Point(116, 34);
            this.RbSearchByMrn.Name = "RbSearchByMrn";
            this.RbSearchByMrn.Size = new System.Drawing.Size(59, 20);
            this.RbSearchByMrn.TabIndex = 1;
            this.RbSearchByMrn.TabStop = true;
            this.RbSearchByMrn.Text = "MRN";
            this.RbSearchByMrn.UseVisualStyleBackColor = true;
            this.RbSearchByMrn.CheckedChanged += new System.EventHandler(this.RbSearchByMrn_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Search By:";
            // 
            // GrpPatientFields
            // 
            this.GrpPatientFields.Controls.Add(this.TxtZip);
            this.GrpPatientFields.Controls.Add(this.TxtState);
            this.GrpPatientFields.Controls.Add(this.DtpDob);
            this.GrpPatientFields.Controls.Add(this.TxtLn);
            this.GrpPatientFields.Controls.Add(this.TxtTlf);
            this.GrpPatientFields.Controls.Add(this.label10);
            this.GrpPatientFields.Controls.Add(this.label1);
            this.GrpPatientFields.Controls.Add(this.BtnClearPtFields);
            this.GrpPatientFields.Controls.Add(this.label11);
            this.GrpPatientFields.Controls.Add(this.BtnSavePatientCrud);
            this.GrpPatientFields.Controls.Add(this.lblMiddle);
            this.GrpPatientFields.Controls.Add(this.label2);
            this.GrpPatientFields.Controls.Add(this.TxtFn);
            this.GrpPatientFields.Controls.Add(this.TxtMrn);
            this.GrpPatientFields.Controls.Add(this.label4);
            this.GrpPatientFields.Controls.Add(this.TxtMi);
            this.GrpPatientFields.Controls.Add(this.label3);
            this.GrpPatientFields.Controls.Add(this.CboRace);
            this.GrpPatientFields.Controls.Add(this.TxtCity);
            this.GrpPatientFields.Controls.Add(this.label17);
            this.GrpPatientFields.Controls.Add(this.label5);
            this.GrpPatientFields.Controls.Add(this.label7);
            this.GrpPatientFields.Controls.Add(this.label8);
            this.GrpPatientFields.Controls.Add(this.label16);
            this.GrpPatientFields.Controls.Add(this.CboSex);
            this.GrpPatientFields.Controls.Add(this.label6);
            this.GrpPatientFields.Controls.Add(this.CboEth);
            this.GrpPatientFields.Controls.Add(this.TxtAdd);
            this.GrpPatientFields.Location = new System.Drawing.Point(596, 39);
            this.GrpPatientFields.Name = "GrpPatientFields";
            this.GrpPatientFields.Size = new System.Drawing.Size(685, 265);
            this.GrpPatientFields.TabIndex = 40;
            this.GrpPatientFields.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.BtnCreateNewPat);
            this.panel1.Controls.Add(this.BtnUpdateExPat);
            this.panel1.Location = new System.Drawing.Point(57, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 70);
            this.panel1.TabIndex = 41;
            // 
            // BtnRemovePatient
            // 
            this.BtnRemovePatient.Location = new System.Drawing.Point(40, 310);
            this.BtnRemovePatient.Name = "BtnRemovePatient";
            this.BtnRemovePatient.Size = new System.Drawing.Size(175, 30);
            this.BtnRemovePatient.TabIndex = 42;
            this.BtnRemovePatient.Text = "Remove Selected Patient";
            this.BtnRemovePatient.UseVisualStyleBackColor = true;
            this.BtnRemovePatient.Click += new System.EventHandler(this.BtnRemovePatient_Click);
            // 
            // PatientOnboarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1336, 693);
            this.Controls.Add(this.BtnRemovePatient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrpPatientFields);
            this.Controls.Add(this.GrpPtSearch);
            this.Controls.Add(this.DgvCrudPatients);
            this.Controls.Add(this.CboClient);
            this.Controls.Add(this.label12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PatientOnboarding";
            this.Text = "Patients menu";
            this.Load += new System.EventHandler(this.PatientOnboarding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCrudPatients)).EndInit();
            this.GrpPtSearch.ResumeLayout(false);
            this.GrpPtSearch.PerformLayout();
            this.GrpPatientFields.ResumeLayout(false);
            this.GrpPatientFields.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSavePatientCrud;
        private System.Windows.Forms.Button BtnClearPtFields;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboClient;
        private System.Windows.Forms.DataGridView DgvCrudPatients;
        private System.Windows.Forms.ComboBox CboSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtMi;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DtpDob;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox TxtLn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFn;
        private System.Windows.Forms.TextBox TxtMrn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboEth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTlf;
        private System.Windows.Forms.Button BtnUpdateExPat;
        private System.Windows.Forms.Button BtnCreateNewPat;
        private System.Windows.Forms.GroupBox GrpPtSearch;
        private System.Windows.Forms.DateTimePicker DtpPatientSearch;
        private System.Windows.Forms.TextBox TxtPatientSearch;
        private System.Windows.Forms.RadioButton RbSearchByDob;
        private System.Windows.Forms.RadioButton RbSearchByMrn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnSearchPatient;
        private System.Windows.Forms.GroupBox GrpPatientFields;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRemovePatient;
    }
}