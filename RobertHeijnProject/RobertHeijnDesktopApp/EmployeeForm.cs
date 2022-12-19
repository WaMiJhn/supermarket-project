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
		public EmployeeForm()
		{
			InitializeComponent();
		}

		private void btnAddEmployee_Click(object sender, EventArgs e)
		{
			new EmployeeContentForm().ShowDialog();
		}
	}
}
