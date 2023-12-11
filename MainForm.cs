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
    public partial class MainForm : Form
    {
        private readonly ApiService _apiService;
        private readonly EmailService _emailService;

        public MainForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
            _emailService = new EmailService();
        }


        private void employees_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm(_apiService, _emailService);
            employeeForm.Show();
        }

        private void departments_Click(object sender, EventArgs e)
        {
            var departmentForm = new DepartmentForm(_apiService, _emailService);
            departmentForm.Show();
        }
    }
}
