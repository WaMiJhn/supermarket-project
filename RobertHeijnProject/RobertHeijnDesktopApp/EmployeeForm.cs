using RhClassLibrary.Interfaces;
using RhClassLibrary.Managers;
using RhDalLibrary.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobertHeijnDesktopApp
{
	public partial class EmployeeForm : Form
	{
		private readonly IEmployeeManager employeeManager;
		public EmployeeForm(IEmployeeManager employeeManager)
		{
			InitializeComponent();

			this.employeeManager = employeeManager;
			this.LoadData();
		}
		public void LoadData()
		{
			dgvEmployees.DataSource = employeeManager.GetEmployeeDataTable(tbSearch.Text);
		}

		private void btnAddEmployee_Click(object sender, EventArgs e)
		{
			new EmployeeContentForm(new PersonManager(new PersonDAL()), new AccountManager(new AccountDAL())).ShowDialog();
		}

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
			this.LoadData();
        }
    }
}
