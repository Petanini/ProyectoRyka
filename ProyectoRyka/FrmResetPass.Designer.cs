namespace ProyectoRyka
{
    partial class FrmResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResetPass));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassuno = new System.Windows.Forms.TextBox();
            this.TxtPassdos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a new Password:";
            // 
            // TxtPassuno
            // 
            this.TxtPassuno.Location = new System.Drawing.Point(229, 70);
            this.TxtPassuno.Name = "TxtPassuno";
            this.TxtPassuno.PasswordChar = '*';
            this.TxtPassuno.Size = new System.Drawing.Size(175, 22);
            this.TxtPassuno.TabIndex = 1;
            // 
            // TxtPassdos
            // 
            this.TxtPassdos.Location = new System.Drawing.Point(233, 104);
            this.TxtPassdos.Name = "TxtPassdos";
            this.TxtPassdos.PasswordChar = '*';
            this.TxtPassdos.Size = new System.Drawing.Size(171, 22);
            this.TxtPassdos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm your password:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(329, 150);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "You have to reset your password!!";
            // 
            // FrmResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtPassdos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassuno);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResetPass";
            this.Text = "Reset your password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassuno;
        private System.Windows.Forms.TextBox TxtPassdos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label3;
    }
}