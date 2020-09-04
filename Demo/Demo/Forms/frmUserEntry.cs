using Demo.Dbs;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Forms
{
	public partial class frmUserEntry : Form
	{
		long id;
		public frmUserEntry()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			User user = new User();
			string code = txtCode.Text;
			string name = cbName.Text;
			string address = txtAddress.Text;
			string salary = txtSalary.Text;
			string city = cbCity.SelectedItem.ToString();
			string dob = dpDOB.Value.Date.ToString();
			string gender = rbGender.Checked.ToString();
			user.Entry(code, name, city, salary, address, dob, gender);
		}
		private void Clear()
		{

		}

		private void frmUserEntry_Load(object sender, EventArgs e)
		{
			GetAllUser();
		}
		private void GetAllUser()
		{
			User user = new User();
			dgUsers.DataSource = user.GetAllData().Tables[0];
			dgUsers.AutoGenerateColumns = false;
			dgUsers.Refresh();
		}
		private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//User user = new User();
			////edit column 
			//if (e.ColumnIndex == 5)
			//{
			//	long id = Convert.ToInt64(dgUsers.Rows[e.RowIndex].Cells["id"].Value);
			//	MUser aUser = new MUser();
			//	aUser = user.GetAUser(id);
			//	UserLoadForEdit(aUser);
			//}
			////delete column
			//if (e.ColumnIndex == 6)
			//{
			//	long id = Convert.ToInt64(dgUsers.Rows[e.RowIndex].Cells["id"].Value);
			//	user.Delete(id);
			//	GetAllUser();
			//}
		}
		void UserLoadForEdit(MUser aUser)
		{
			cbName.SelectedItem = aUser.Id;
			txtAddress.Text = aUser.Address;
			txtCode.Text = aUser.City;
		}

		private void dgUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			id = Convert.ToInt64(dgUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
			cbName.Text = dgUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
			cbCity.Text = dgUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
		}
	
	}
}
