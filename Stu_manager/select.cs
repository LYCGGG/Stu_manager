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
	public partial class select : Form
	{
		public select()
		{
			InitializeComponent();
		}

		private void lebel1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			if (selectTable.Text == "个人信息")
			{
				if(Sno.Text == "")
				{
					string sql = string.Format("select Sno,Sname,Ssex,Sage,Sdept from student where  Sname like '%" + Sname.Text.Trim() + "%'");
					MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					this.selectResultView.DataSource = dt;
					explain.Text = "查询结果如下";
				}
				else
				{
					string sql = string.Format("select Sno,Sname,Ssex,Sage,Sdept from student where Sno = '" + Sno.Text.Trim()
										+ "' and Sname like '%" + Sname.Text.Trim() + "%'");
					MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					this.selectResultView.DataSource = dt;
					explain.Text = "学生个人信息结果如下";
				}
				
			}
			else if(selectTable.Text == "成绩")
			{
				if (Sno.Text == "")
				{
					string sql = string.Format("select student.Sno,Sname,sc.Cno,Cname,Grade from student,sc,course " +
						"where  Sname like '%" + Sname.Text.Trim() + "%'" +
						" and student.Sno = sc.Sno and sc.Cno = course.Cno;");
					explain.Text = "查询成绩结果如下";
					MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					this.selectResultView.DataSource = dt;
				}
				else
				{
					string sql = string.Format("select student.Sno,Sname,sc.Cno,Cname,Grade from student,sc,course where student.Sno = '" + Sno.Text.Trim()
											+ "' and student.Sno = sc.Sno and sc.Cno = course.Cno;");
					MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					this.selectResultView.DataSource = dt;
					explain.Text = "学生成绩如下";
				}
			}
			else if(selectTable.Text == "所有信息")
			{
				string sql = string.Format("select student.Sno,Sname,Ssex,Sage,Sdept,sc.Cno,Cname,Grade from student,sc,course where student.Sno = '" + Sno.Text.Trim()
						+ "' and student.Sno = sc.Sno and sc.Cno = course.Cno;");
				MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				this.selectResultView.DataSource = dt;
				explain.Text = "学生信息结果如下";
			}
			else
			{
				explain.Text = "输入了错误的信息";
				return;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
