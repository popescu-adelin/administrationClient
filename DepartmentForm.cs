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
    public partial class DepartmentForm : Form
    {
        private readonly ApiService _apiService;
        private readonly EmailService _emailService;

        public DepartmentForm(ApiService apiService, EmailService emailService)
        {
            InitializeComponent();
            _apiService = apiService;
            _emailService = emailService;
        }

        private async void DepartmentForm_Load(object sender, EventArgs e)
        {
            var departments = await _apiService.GetDepartmentsAsync();
            // Populate the list or grid view with department data
        }

        private async void showDepartments_Click(object sender, EventArgs e)
        {
            var departments = await _apiService.GetDepartmentsAsync();
            dgvDepartments.DataSource = departments;
            cmbDepartments.DataSource = departments;
            cmbDepartments.DisplayMember = "Name";
            cmbDepartments.ValueMember = "Id";
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
