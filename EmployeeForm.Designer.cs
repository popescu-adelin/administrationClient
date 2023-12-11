namespace Client
{
    partial class EmployeeForm
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
            this.showEmployees = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.sendEmail = new System.Windows.Forms.Button();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.txtEmailBody = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // showEmployees
            // 
            this.showEmployees.Location = new System.Drawing.Point(12, 52);
            this.showEmployees.Name = "showEmployees";
            this.showEmployees.Size = new System.Drawing.Size(125, 23);
            this.showEmployees.TabIndex = 0;
            this.showEmployees.Text = "Show";
            this.showEmployees.UseVisualStyleBackColor = true;
            this.showEmployees.Click += new System.EventHandler(this.showEmployees_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(165, 52);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(463, 173);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.UseWaitCursor = true;
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(12, 289);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(125, 23);
            this.sendEmail.TabIndex = 2;
            this.sendEmail.Text = "SendEmail";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(16, 93);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployees.TabIndex = 3;
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(16, 132);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(121, 22);
            this.txtEmailSubject.TabIndex = 4;
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Location = new System.Drawing.Point(16, 169);
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(121, 22);
            this.txtEmailBody.TabIndex = 5;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.txtEmailBody);
            this.Controls.Add(this.txtEmailSubject);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.showEmployees);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showEmployees;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.TextBox txtEmailBody;
    }
}