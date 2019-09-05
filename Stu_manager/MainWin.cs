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
	public partial class MainWin : Form
	{
		public static string users_ID;
		public MainWin()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void passwd_TextChanged(object sender, EventArgs e)
		{

		}

		private void usrname_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void MainWin_Load(object sender, EventArgs e)
		{

		}

		private void cancel_Click(object sender, EventArgs e)
		{
			usrname.Text = "";
			passwd.Text = "";
			usrname.Focus();
		}

		private void Sure_Click(object sender, EventArgs e)
		{
			string username = usrname.Text;
			string usrpasswd = passwd.Text;
			string dir;
			String connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			if (radioButton1.Checked) dir = "admins";
			else if (radioButton2.Checked) dir = "users";
			else
			{
				MessageBox.Show("请选择登录的身份");
				return;
			}
			string land = "select Uno from " + dir + " where Uno = '" + username + "' and Upasswd = '" + usrpasswd + "';";//选择管理员表和用户表进行查询
			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(land, conn);
				string checkname;
				try
				{
					checkname = cmd.ExecuteScalar().ToString();
					MessageBox.Show("登陆成功！", "提示", MessageBoxButtons.OK);
					if (dir == "users")
					{
						string getSno = "select Sno from users where Uno = '" + username + "' and Upasswd = '" + usrpasswd + "';";
						cmd = new MySqlCommand(getSno, conn);
						users_ID = cmd.ExecuteScalar().ToString();
						users main = new users();
						this.Hide();
						main.ShowDialog();
					}
					else if(dir == "admins")
					{
						Form2 main = new Form2();
						this.Hide();
						main.ShowDialog();
					}
				}
				catch
				{
					MessageBox.Show("账户或密码错误！");
				}
				finally
				{
					conn.Close();
					this.Close();
				}
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
