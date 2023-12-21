namespace ProyectoRyka
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClient = new System.Windows.Forms.TextBox();
            this.LblFacState = new System.Windows.Forms.Label();
            this.LblFacName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboClient = new System.Windows.Forms.ComboBox();
            this.CboPatient = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DgvOrdersEntered = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboRace = new System.Windows.Forms.ComboBox();
            this.CboEth = new System.Windows.Forms.ComboBox();
            this.BtnOrderChoices = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSavePat = new System.Windows.Forms.Button();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTlf = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtZip = new System.Windows.Forms.TextBox();
            this.TxtAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtMrn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.TxtMi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboSex = new System.Windows.Forms.ComboBox();
            this.DtpDob = new System.Windows.Forms.DateTimePicker();
            this.TxtLn = new System.Windows.Forms.TextBox();
            this.TxtFn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDoctor = new System.Windows.Forms.TextBox();
            this.BtnRemoveSel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LblFacTlf = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LblFacFax = new System.Windows.Forms.Label();
            this.BtnAddPT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdersEntered)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lab Accessioning for TridentCopia West";
            // 
            // TxtClient
            // 
            this.TxtClient.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClient.Location = new System.Drawing.Point(118, 81);
            this.TxtClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtClient.Name = "TxtClient";
            this.TxtClient.Size = new System.Drawing.Size(209, 22);
            this.TxtClient.TabIndex = 1;
            this.TxtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtClient_KeyDown);
            // 
            // LblFacState
            // 
            this.LblFacState.AutoSize = true;
            this.LblFacState.Location = new System.Drawing.Point(115, 138);
            this.LblFacState.Name = "LblFacState";
            this.LblFacState.Size = new System.Drawing.Size(16, 16);
            this.LblFacState.TabIndex = 6;
            this.LblFacState.Text = "...";
            // 
            // LblFacName
            // 
            this.LblFacName.AutoSize = true;
            this.LblFacName.Location = new System.Drawing.Point(115, 118);
            this.LblFacName.Name = "LblFacName";
            this.LblFacName.Size = new System.Drawing.Size(16, 16);
            this.LblFacName.TabIndex = 4;
            this.LblFacName.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "State:";
            // 
            // CboClient
            // 
            this.CboClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboClient.FormattingEnabled = true;
            this.CboClient.Location = new System.Drawing.Point(443, 79);
            this.CboClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboClient.Name = "CboClient";
            this.CboClient.Size = new System.Drawing.Size(209, 24);
            this.CboClient.TabIndex = 2;
            this.CboClient.Tag = "";
            this.CboClient.SelectedIndexChanged += new System.EventHandler(this.CboClient_SelectedIndexChanged);
            // 
            // CboPatient
            // 
            this.CboPatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboPatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboPatient.FormattingEnabled = true;
            this.CboPatient.Location = new System.Drawing.Point(118, 223);
            this.CboPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboPatient.Name = "CboPatient";
            this.CboPatient.Size = new System.Drawing.Size(209, 24);
            this.CboPatient.TabIndex = 3;
            this.CboPatient.SelectedIndexChanged += new System.EventHandler(this.CboPatient_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Client ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Client Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Patient:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(336, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Race:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Ethnicity:";
            // 
            // DgvOrdersEntered
            // 
            this.DgvOrdersEntered.AllowUserToAddRows = false;
            this.DgvOrdersEntered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrdersEntered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdersEntered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvOrdersEntered.Location = new System.Drawing.Point(24, 419);
            this.DgvOrdersEntered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvOrdersEntered.Name = "DgvOrdersEntered";
            this.DgvOrdersEntered.ReadOnly = true;
            this.DgvOrdersEntered.RowHeadersWidth = 51;
            this.DgvOrdersEntered.RowTemplate.Height = 24;
            this.DgvOrdersEntered.Size = new System.Drawing.Size(749, 212);
            this.DgvOrdersEntered.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DL-CODE";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sample Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.CboRace.Location = new System.Drawing.Point(387, 22);
            this.CboRace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboRace.Name = "CboRace";
            this.CboRace.Size = new System.Drawing.Size(163, 24);
            this.CboRace.TabIndex = 5;
            this.CboRace.SelectedIndexChanged += new System.EventHandler(this.CboRace_SelectedIndexChanged);
            // 
            // CboEth
            // 
            this.CboEth.FormattingEnabled = true;
            this.CboEth.Items.AddRange(new object[] {
            "Hispanic or Latino",
            "Not Hispanic or Latino",
            "Unknown"});
            this.CboEth.Location = new System.Drawing.Point(387, 58);
            this.CboEth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboEth.Name = "CboEth";
            this.CboEth.Size = new System.Drawing.Size(163, 24);
            this.CboEth.TabIndex = 6;
            this.CboEth.SelectedIndexChanged += new System.EventHandler(this.CboEth_SelectedIndexChanged);
            // 
            // BtnOrderChoices
            // 
            this.BtnOrderChoices.AutoSize = true;
            this.BtnOrderChoices.Location = new System.Drawing.Point(24, 387);
            this.BtnOrderChoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOrderChoices.Name = "BtnOrderChoices";
            this.BtnOrderChoices.Size = new System.Drawing.Size(139, 28);
            this.BtnOrderChoices.TabIndex = 31;
            this.BtnOrderChoices.Text = "Add Order Choices";
            this.BtnOrderChoices.UseVisualStyleBackColor = true;
            this.BtnOrderChoices.Click += new System.EventHandler(this.BtnOrderChoices_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.Location = new System.Drawing.Point(779, 571);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 28);
            this.BtnSave.TabIndex = 32;
            this.BtnSave.Text = "Save Order";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.Location = new System.Drawing.Point(779, 603);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(117, 28);
            this.BtnClose.TabIndex = 34;
            this.BtnClose.Text = "Close Order";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSavePat);
            this.groupBox2.Controls.Add(this.TxtState);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtTlf);
            this.groupBox2.Controls.Add(this.TxtCity);
            this.groupBox2.Controls.Add(this.TxtZip);
            this.groupBox2.Controls.Add(this.TxtAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.TxtMrn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblMiddle);
            this.groupBox2.Controls.Add(this.TxtMi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CboSex);
            this.groupBox2.Controls.Add(this.DtpDob);
            this.groupBox2.Controls.Add(this.TxtLn);
            this.groupBox2.Controls.Add(this.TxtFn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CboRace);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.CboEth);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(366, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(604, 284);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // BtnSavePat
            // 
            this.BtnSavePat.AutoSize = true;
            this.BtnSavePat.Location = new System.Drawing.Point(464, 244);
            this.BtnSavePat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSavePat.Name = "BtnSavePat";
            this.BtnSavePat.Size = new System.Drawing.Size(93, 26);
            this.BtnSavePat.TabIndex = 49;
            this.BtnSavePat.Text = "Save Patient";
            this.BtnSavePat.UseVisualStyleBackColor = true;
            this.BtnSavePat.Click += new System.EventHandler(this.BtnSavePat_Click);
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(387, 205);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(163, 22);
            this.TxtState.TabIndex = 48;
            this.TxtState.TextChanged += new System.EventHandler(this.TxtState_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "State:";
            // 
            // TxtTlf
            // 
            this.TxtTlf.Location = new System.Drawing.Point(387, 87);
            this.TxtTlf.Name = "TxtTlf";
            this.TxtTlf.Size = new System.Drawing.Size(163, 22);
            this.TxtTlf.TabIndex = 46;
            this.TxtTlf.TextChanged += new System.EventHandler(this.TxtTlf_TextChanged);
            this.TxtTlf.Enter += new System.EventHandler(this.TxtTlf_Enter);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(387, 173);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(163, 22);
            this.TxtCity.TabIndex = 45;
            this.TxtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            // 
            // TxtZip
            // 
            this.TxtZip.Location = new System.Drawing.Point(387, 147);
            this.TxtZip.Name = "TxtZip";
            this.TxtZip.Size = new System.Drawing.Size(163, 22);
            this.TxtZip.TabIndex = 44;
            this.TxtZip.TextChanged += new System.EventHandler(this.TxtZip_TextChanged);
            // 
            // TxtAdd
            // 
            this.TxtAdd.Location = new System.Drawing.Point(387, 115);
            this.TxtAdd.Name = "TxtAdd";
            this.TxtAdd.Size = new System.Drawing.Size(163, 22);
            this.TxtAdd.TabIndex = 43;
            this.TxtAdd.TextChanged += new System.EventHandler(this.TxtAdd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Phone:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 16);
            this.label18.TabIndex = 40;
            this.label18.Text = "ZIP Code:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(322, 176);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 16);
            this.label19.TabIndex = 39;
            this.label19.Text = "City:";
            // 
            // TxtMrn
            // 
            this.TxtMrn.Location = new System.Drawing.Point(129, 178);
            this.TxtMrn.Name = "TxtMrn";
            this.TxtMrn.Size = new System.Drawing.Size(149, 22);
            this.TxtMrn.TabIndex = 38;
            this.TxtMrn.TextChanged += new System.EventHandler(this.TxtMrn_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Patient MRN:";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.Location = new System.Drawing.Point(21, 93);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(84, 16);
            this.lblMiddle.TabIndex = 36;
            this.lblMiddle.Text = "Middle Initial:";
            this.lblMiddle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtMi
            // 
            this.TxtMi.Location = new System.Drawing.Point(129, 87);
            this.TxtMi.Name = "TxtMi";
            this.TxtMi.Size = new System.Drawing.Size(149, 22);
            this.TxtMi.TabIndex = 35;
            this.TxtMi.TextChanged += new System.EventHandler(this.TxtMi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sex:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CboSex
            // 
            this.CboSex.FormattingEnabled = true;
            this.CboSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.CboSex.Location = new System.Drawing.Point(129, 115);
            this.CboSex.Name = "CboSex";
            this.CboSex.Size = new System.Drawing.Size(149, 24);
            this.CboSex.TabIndex = 33;
            this.CboSex.SelectedIndexChanged += new System.EventHandler(this.CboSex_SelectedIndexChanged);
            // 
            // DtpDob
            // 
            this.DtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDob.Location = new System.Drawing.Point(129, 150);
            this.DtpDob.Name = "DtpDob";
            this.DtpDob.Size = new System.Drawing.Size(149, 22);
            this.DtpDob.TabIndex = 32;
            this.DtpDob.ValueChanged += new System.EventHandler(this.DtpDob_ValueChanged);
            // 
            // TxtLn
            // 
            this.TxtLn.Location = new System.Drawing.Point(129, 59);
            this.TxtLn.Name = "TxtLn";
            this.TxtLn.Size = new System.Drawing.Size(149, 22);
            this.TxtLn.TabIndex = 31;
            this.TxtLn.TextChanged += new System.EventHandler(this.TxtLn_TextChanged);
            // 
            // TxtFn
            // 
            this.TxtFn.Location = new System.Drawing.Point(129, 31);
            this.TxtFn.Name = "TxtFn";
            this.TxtFn.Size = new System.Drawing.Size(149, 22);
            this.TxtFn.TabIndex = 30;
            this.TxtFn.TextChanged += new System.EventHandler(this.TxtFn_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Physician:";
            // 
            // TxtDoctor
            // 
            this.TxtDoctor.Location = new System.Drawing.Point(118, 262);
            this.TxtDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(209, 22);
            this.TxtDoctor.TabIndex = 7;
            // 
            // BtnRemoveSel
            // 
            this.BtnRemoveSel.AutoSize = true;
            this.BtnRemoveSel.Location = new System.Drawing.Point(178, 387);
            this.BtnRemoveSel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemoveSel.Name = "BtnRemoveSel";
            this.BtnRemoveSel.Size = new System.Drawing.Size(139, 28);
            this.BtnRemoveSel.TabIndex = 37;
            this.BtnRemoveSel.Text = "Remove Selection";
            this.BtnRemoveSel.UseVisualStyleBackColor = true;
            this.BtnRemoveSel.Click += new System.EventHandler(this.BtnRemoveSel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search Client:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(78, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "Tlf:";
            // 
            // LblFacTlf
            // 
            this.LblFacTlf.AutoSize = true;
            this.LblFacTlf.Location = new System.Drawing.Point(115, 155);
            this.LblFacTlf.Name = "LblFacTlf";
            this.LblFacTlf.Size = new System.Drawing.Size(16, 16);
            this.LblFacTlf.TabIndex = 40;
            this.LblFacTlf.Text = "...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(39, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "Main Fax:";
            // 
            // LblFacFax
            // 
            this.LblFacFax.AutoSize = true;
            this.LblFacFax.Location = new System.Drawing.Point(115, 171);
            this.LblFacFax.Name = "LblFacFax";
            this.LblFacFax.Size = new System.Drawing.Size(16, 16);
            this.LblFacFax.TabIndex = 42;
            this.LblFacFax.Text = "...";
            // 
            // BtnAddPT
            // 
            this.BtnAddPT.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnAddPT.Location = new System.Drawing.Point(330, 218);
            this.BtnAddPT.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddPT.Name = "BtnAddPT";
            this.BtnAddPT.Size = new System.Drawing.Size(20, 34);
            this.BtnAddPT.TabIndex = 43;
            this.BtnAddPT.Text = "+";
            this.BtnAddPT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddPT.UseVisualStyleBackColor = true;
            this.BtnAddPT.Click += new System.EventHandler(this.BtnAddPT_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(985, 688);
            this.Controls.Add(this.BtnAddPT);
            this.Controls.Add(this.LblFacFax);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.LblFacTlf);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemoveSel);
            this.Controls.Add(this.LblFacState);
            this.Controls.Add(this.TxtDoctor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblFacName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnOrderChoices);
            this.Controls.Add(this.DgvOrdersEntered);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CboPatient);
            this.Controls.Add(this.CboClient);
            this.Controls.Add(this.TxtClient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Accessioning Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdersEntered)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtClient;
        private System.Windows.Forms.Label LblFacState;
        private System.Windows.Forms.Label LblFacName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboClient;
        public  System.Windows.Forms.ComboBox CboPatient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView DgvOrdersEntered;
        private System.Windows.Forms.ComboBox CboRace;
        private System.Windows.Forms.ComboBox CboEth;
        private System.Windows.Forms.Button BtnOrderChoices;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDoctor;
        private System.Windows.Forms.Button BtnRemoveSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMrn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.TextBox TxtMi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboSex;
        private System.Windows.Forms.DateTimePicker DtpDob;
        private System.Windows.Forms.TextBox TxtLn;
        private System.Windows.Forms.TextBox TxtFn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtTlf;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtZip;
        private System.Windows.Forms.TextBox TxtAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LblFacTlf;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LblFacFax;
        private System.Windows.Forms.Button BtnAddPT;
        private System.Windows.Forms.Button BtnSavePat;
    }
}

