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
	public partial class insert : Form
	{
		//如何将初始焦点对准Tname?
		public insert()
		{
			InitializeComponent();
		}

		private void insert_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//string Table_name = Tname.Text;
			string Stu_no = Sno.Text;
			string Stu_name = Sname.Text;
			string Stu_sex = Ssex.Text;
			string Stu_age = Sage.Text;
			string Stu_dept = Sdept.Text;
			string Cou_no = Cno.Text;
			string Stu_grade = Grade.Text;
			//连接数据库
			String connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			using (MySqlConnection conn = new MySqlConnection(connectString))
			{
				conn.Open();
				try
				{
					if(Tname.Text == "个人信息")
					{
						if(Sname.Text == "" || Sno.Text == "")
						{
							putout.Text = "姓名学号不能为空";
							return;
						}
						string sql = "insert into student(Sno,Sname,Ssex,Sage,Sdept) " +
									"values('" + Stu_no + "','" 
									+ Stu_name + "' , '"
									+ Stu_sex + "' , '"
									+ Stu_age + "' , '"
									+ Stu_dept + "');";
						MySqlCommand cmd = new MySqlCommand(sql, conn);
						cmd.ExecuteNonQuery();
						putout.Text = "个人信息插入成功";
						//return;
					}
					else if(Tname.Text == "成绩")
					{
						if (Sno.Text == "")
						{
							putout.Text = "学号不能为空";
							return;
						}
						string sql = "insert into sc(Sno,Cno,Grade) "
							+ "values('" + Stu_no + "' , '"
							+ Cou_no + "' , '"
							+ Stu_grade + "');";
						MySqlCommand cmd = new MySqlCommand(sql, conn);
						cmd.ExecuteNonQuery();
						putout.Text = "成绩插入成功";
						//return;
					}
					else
					{
						putout.Text = "未知错误";
						return;
					}
				}
				catch
				{
					putout.Text = "错误,可能是数据库已经存在该学生信息";
					return;
				}
				finally
				{
					//this.Close();
				}
			}
				
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void Tname_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
