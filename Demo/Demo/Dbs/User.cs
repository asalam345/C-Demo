using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo.Dbs
{
	class User
	{
		Connections _conString = new Connections();
		public bool Entry(string code, string name, string city, string salary, string address, string dob, string gender)
		{
			bool result = false;
			SqlConnection sqlCon = new SqlConnection(_conString.ConnectionString);
			try
			{
				sqlCon.Open();
				string sql = "INSERT INTO tblUser(Name, Gender, City, Salary, Address, Code, DOB) VALUES('" +
					name + "', '" + gender + "', '" + city + "', '" + salary + "', '" + address + "', '" + code
					+ "', '" + dob + "')";
				SqlCommand cmd = new SqlCommand(sql, sqlCon);
				int r = cmd.ExecuteNonQuery();
				if(r > 0)
				{
					result = true;
				}
				return result;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				sqlCon.Close();
			}
		}
		public DataSet GetAllData()
		{
			SqlConnection sqlCon = new SqlConnection(_conString.ConnectionString);

			try
			{
				sqlCon.Open();
				string sql = "SELECT Id, Name, Gender, City, Salary, Address, Code, DOB FROM tbUsers";
				SqlCommand cmd = new SqlCommand(sql, sqlCon);
				SqlDataAdapter oda = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				oda.Fill(ds, "Table");
				return ds;
			}
			catch (Exception ex)
			{
				return null;
			}
			finally
			{
				sqlCon.Close();
			}
		}
		public MUser GetAUser(long id)
		{
			SqlConnection sqlCon = new SqlConnection(_conString.ConnectionString);

			try
			{
				sqlCon.Open();
				string sql = "SELECT Id, Name, Gender, City, Salary, Address, Code, DOB FROM tbUsers WHERE Id = " + id;
				SqlCommand cmd = new SqlCommand(sql, sqlCon);
				SqlDataAdapter oda = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				oda.Fill(ds, "Table");
				MUser mUser = new MUser();
				DataTable dataTable = ds.Tables[0];
				mUser.Id = Convert.ToInt64(dataTable.Rows[0]);
				mUser.Name = dataTable.Rows[1].ToString();
				mUser.Address = dataTable.Rows[2].ToString();
				mUser.City = dataTable.Rows[3].ToString();
				return mUser;
			}
			catch (Exception ex)
			{
				return null;
			}
			finally
			{
				sqlCon.Close();
			}
		}
		public bool Update(string code, string name, string city, string salary, string address, string dob, string gender)
		{
			bool result = false;
			SqlConnection sqlCon = new SqlConnection(_conString.ConnectionString);
			try
			{
				sqlCon.Open();
				string sql = "INSERT INTO tblUser(Name, Gender, City, Salary, Address, Code, DOB) VALUES('" +
					name + "', '" + gender + "', '" + city + "', '" + salary + "', '" + address + "', '" + code
					+ "', '" + dob + "')";
				SqlCommand cmd = new SqlCommand(sql, sqlCon);
				int r = cmd.ExecuteNonQuery();
				if (r > 0)
				{
					result = true;
				}
				return result;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				sqlCon.Close();
			}
		}
		public bool Delete(long id)
		{
			bool result = false;
			SqlConnection sqlCon = new SqlConnection(_conString.ConnectionString);
			try
			{
				sqlCon.Open();
				string sql = "DELETE FROM tblUser WHERE Id = " + id;
				SqlCommand cmd = new SqlCommand(sql, sqlCon);
				int r = cmd.ExecuteNonQuery();
				if (r > 0)
				{
					result = true;
				}
				return result;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				sqlCon.Close();
			}
		}
		public bool Login(string userName, string password)
		{
			bool result = false;
			SqlConnection sqlCon = new SqlConnection(_conString.ConnectionString);

			try
			{
				sqlCon.Open();
				string sql = "SELECT * FROM tbUsers WHERE UserName = '" + userName + 
					"' AND PASSWORD = '" + password + "'";
				SqlCommand cmd = new SqlCommand(sql, sqlCon);
				SqlDataAdapter oda = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				oda.Fill(ds, "Table");
				if (ds.Tables[0].Rows.Count > 0)
				{
					return result = true;
				}
				return result;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				sqlCon.Close();
			}
		}
	}
}
