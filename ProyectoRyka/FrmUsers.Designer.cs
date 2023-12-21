namespace ProyectoRyka
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnResetPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtLast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboType = new System.Windows.Forms.ComboBox();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditUser = new System.Windows.Forms.Button();
            this.GrpCampos = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.GrpCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 22);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersWidth = 51;
            this.DgvUsuarios.RowTemplate.Height = 24;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(734, 382);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // BtnResetPass
            // 
            this.BtnResetPass.Location = new System.Drawing.Point(758, 325);
            this.BtnResetPass.Name = "BtnResetPass";
            this.BtnResetPass.Size = new System.Drawing.Size(114, 23);
            this.BtnResetPass.TabIndex = 1;
            this.BtnResetPass.Text = "Reset Password";
            this.BtnResetPass.UseVisualStyleBackColor = true;
            this.BtnResetPass.Click += new System.EventHandler(this.BtnResetPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(87, 39);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(155, 22);
            this.TxtName.TabIndex = 5;
            // 
            // TxtLast
            // 
            this.TxtLast.Location = new System.Drawing.Point(87, 70);
            this.TxtLast.Name = "TxtLast";
            this.TxtLast.Size = new System.Drawing.Size(155, 22);
            this.TxtLast.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type:";
            // 
            // CboType
            // 
            this.CboType.FormattingEnabled = true;
            this.CboType.Items.AddRange(new object[] {
            "Supervisor",
            "Agent"});
            this.CboType.Location = new System.Drawing.Point(87, 132);
            this.CboType.Name = "CboType";
            this.CboType.Size = new System.Drawing.Size(155, 24);
            this.CboType.TabIndex = 9;
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.Location = new System.Drawing.Point(758, 267);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(114, 23);
            this.BtnNewUser.TabIndex = 10;
            this.BtnNewUser.Text = "New User";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(87, 11);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(155, 22);
            this.TxtId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(87, 98);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(155, 22);
            this.TxtUser.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username:";
            // 
            // BtnEditUser
            // 
            this.BtnEditUser.Location = new System.Drawing.Point(758, 296);
            this.BtnEditUser.Name = "BtnEditUser";
            this.BtnEditUser.Size = new System.Drawing.Size(114, 23);
            this.BtnEditUser.TabIndex = 15;
            this.BtnEditUser.Text = "Edit User";
            this.BtnEditUser.UseVisualStyleBackColor = true;
            this.BtnEditUser.Click += new System.EventHandler(this.BtnEditUser_Click);
            // 
            // GrpCampos
            // 
            this.GrpCampos.Controls.Add(this.BtnClear);
            this.GrpCampos.Controls.Add(this.BtnSave);
            this.GrpCampos.Controls.Add(this.TxtLast);
            this.GrpCampos.Controls.Add(this.label1);
            this.GrpCampos.Controls.Add(this.label5);
            this.GrpCampos.Controls.Add(this.TxtName);
            this.GrpCampos.Controls.Add(this.TxtUser);
            this.GrpCampos.Controls.Add(this.label2);
            this.GrpCampos.Controls.Add(this.label4);
            this.GrpCampos.Controls.Add(this.label3);
            this.GrpCampos.Controls.Add(this.TxtId);
            this.GrpCampos.Controls.Add(this.CboType);
            this.GrpCampos.Location = new System.Drawing.Point(758, 22);
            this.GrpCampos.Name = "GrpCampos";
            this.GrpCampos.Size = new System.Drawing.Size(281, 224);
            this.GrpCampos.TabIndex = 16;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(106, 186);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(25, 186);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 453);
            this.Controls.Add(this.GrpCampos);
            this.Controls.Add(this.BtnEditUser);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.BtnResetPass);
            this.Controls.Add(this.DgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsers";
            this.Text = "Users admin";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.GrpCampos.ResumeLayout(false);
            this.GrpCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnResetPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtLast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboType;
        private System.Windows.Forms.Button BtnNewUser;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEditUser;
        private System.Windows.Forms.Panel GrpCampos;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
    }
}