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
	public partial class delect : Form
	{
		public delect()
		{
			InitializeComponent();
		}

		private void Tname_TextChanged(object sender, EventArgs e)
		{

		}

		private void sure_Click(object sender, EventArgs e)
		{
			//string Table_name = Tname.Text;
			//string Stu_no = Sno.Text;
			//string Cou_no = Cno.Text;
			//连接数据库
			String connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			MySqlConnection conn = new MySqlConnection(connectString);
			conn.Open();

			string sql;
			//选择要删除的数据
			if(Tname.Text == "学生所有信息")
			{
				sql = string.Format("delete from student where Sno = '" + Sno.Text.Trim() + "';");
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
				explain.Text = "学生信息删除";
			}
			else if(Tname.Text == "课程记录")
			{
				sql = string.Format("delete from sc where Sno = '" + Sno.Text.Trim() + "' and Cno = '" + Cno.Text.Trim() + "';");
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
				explain.Text = "学生该课程信息删除";
			}
			else if(Tname.Text == "所有课程记录")
			{
				sql = string.Format("delete from sc where Sno = '" + Sno.Text.Trim() + "';");
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
				explain.Text = "该学生选课记录删除";
			}
			else
			{
				explain.Text = "请输入正确的信息";
			}
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
