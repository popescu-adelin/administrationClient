namespace Client
{
    partial class DepartmentForm
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
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.showDepartments = new System.Windows.Forms.Button();
            this.sendEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(27, 203);
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(121, 22);
            this.txtEmailBody.TabIndex = 10;
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(27, 166);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(121, 22);
            this.txtEmailSubject.TabIndex = 9;
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(27, 127);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartments.TabIndex = 8;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(176, 86);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.Size = new System.Drawing.Size(463, 173);
            this.dgvDepartments.TabIndex = 7;
            this.dgvDepartments.UseWaitCursor = true;
            // 
            // showDepartments
            // 
            this.showDepartments.Location = new System.Drawing.Point(23, 86);
            this.showDepartments.Name = "showDepartments";
            this.showDepartments.Size = new System.Drawing.Size(125, 23);
            this.showDepartments.TabIndex = 6;
            this.showDepartments.Text = "Show";
            this.showDepartments.UseVisualStyleBackColor = true;
            this.showDepartments.Click += new System.EventHandler(this.showDepartments_Click);
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(27, 236);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(125, 23);
            this.sendEmail.TabIndex = 11;
            this.sendEmail.Text = "SendEmail";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.txtEmailBody);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.dgvDepartments);
            this.Controls.Add(this.showDepartments);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailBody;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button showDepartments;
        private System.Windows.Forms.Button sendEmail;
    }
}