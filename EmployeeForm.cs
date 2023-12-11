using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class EmployeeForm : Form
    {
        private readonly ApiService _apiService;
        private readonly EmailService _emailService;

        public EmployeeForm(ApiService apiService, EmailService emailService)
        {
            InitializeComponent();
            _apiService = apiService;
            _emailService = emailService;
        }

        private async void showEmployees_Click(object sender, EventArgs e)
        {
            var employees = await _apiService.GetEmployeesAsync();
            dgvEmployees.DataSource = employees;
            cmbEmployees.DataSource = employees;
            cmbEmployees.DisplayMember = "Email";
            cmbEmployees.ValueMember = "Id";
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            var subject = txtEmailSubject.Text;
            var body = txtEmailBody.Text;
            var selectedEmployee = cmbEmployees.SelectedItem as Employee;

            if (selectedEmployee != null)
            {
                _emailService.SendEmail(selectedEmployee.Email, subject, body);

            } else
            {
                MessageBox.Show("Please select an employee to send the email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
