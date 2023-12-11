namespace Client
{
    partial class MainForm
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
            this.employees = new System.Windows.Forms.Button();
            this.departments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employees
            // 
            this.employees.Location = new System.Drawing.Point(89, 167);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(207, 23);
            this.employees.TabIndex = 0;
            this.employees.Text = "Employees";
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // departments
            // 
            this.departments.Location = new System.Drawing.Point(384, 167);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(207, 23);
            this.departments.TabIndex = 1;
            this.departments.Text = "Departments";
            this.departments.UseVisualStyleBackColor = true;
            this.departments.Click += new System.EventHandler(this.departments_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.departments);
            this.Controls.Add(this.employees);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Button departments;
    }
}