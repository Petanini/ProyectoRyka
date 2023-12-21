namespace ProyectoRyka
{
    partial class FrmOrderChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderChoices));
            this.DgvExSelected = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExSelected
            // 
            this.DgvExSelected.AllowUserToAddRows = false;
            this.DgvExSelected.AllowUserToDeleteRows = false;
            this.DgvExSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvExSelected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvExSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected});
            this.DgvExSelected.Location = new System.Drawing.Point(26, 32);
            this.DgvExSelected.Name = "DgvExSelected";
            this.DgvExSelected.RowHeadersWidth = 51;
            this.DgvExSelected.RowTemplate.Height = 24;
            this.DgvExSelected.Size = new System.Drawing.Size(545, 183);
            this.DgvExSelected.TabIndex = 0;
            this.DgvExSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExSelected_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "SELECT";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Width = 65;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(599, 32);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(113, 23);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Add Selected";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmOrderChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 244);
            this.Controls.Add(this.DgvExSelected);
            this.Controls.Add(this.BtnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderChoices";
            this.Text = "Test Menu";
            this.Load += new System.EventHandler(this.OrderChoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEx;
        private System.Windows.Forms.DataGridView DgvExSelected;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.Button BtnAgregar;
    }
}