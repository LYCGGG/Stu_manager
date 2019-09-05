using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stu_manager
{
	public partial class users_register : Form
	{
		public users_register()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string users_Uno = Uno.Text;
			string users_Upasswd = Upasswd.Text;
			string users_Sno = Sno.Text;
			String connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				try
				{
					if (users_Uno == "" || users_Upasswd == "" || users_Sno == "")
					{
						explain.Text = "三个属性均不能为空";
						return;
					}
					string sql = "select Sno from student where Sno = '" + users_Sno + "';";
					MySqlCommand cmd = new MySqlCommand(sql, conn);
					//cmd.ExecuteNonQuery();
					string reslut = cmd.ExecuteScalar().ToString();
					if(reslut == "")
					{
						explain.Text = "无该学生的信息";
						return;
					}
					sql = "insert into users values ('" + users_Uno + "','" + users_Upasswd + "','" + users_Sno + "');";
					cmd = new MySqlCommand(sql, conn);
					cmd.ExecuteNonQuery();
					explain.Text = "用户注册成功";
				}
				catch
				{
					explain.Text = "注册错误";
				}
				finally
				{

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
