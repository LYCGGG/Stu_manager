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
	public partial class update : Form
	{
		public update()
		{
			InitializeComponent();
		}

		private void Sno_TextChanged(object sender, EventArgs e)
		{

		}

		private void select_Click(object sender, EventArgs e)
		{
			string connectString = "server=localhost;user=root;password=123456;Database=lyc_sql;";
			string sql = string.Format("select student.Sno,Sname,Ssex,Sage,Sdept,Cname,Grade from student,sc,course where student.Sno = '" + Sno.Text.Trim() 
									+ "' and student.Sno = sc.Sno and sc.Cno = course.Cno;");
			MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			this.SearchDataGridView.DataSource = dt;
			Sno.ReadOnly = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string connectString = "server=localhost;user=root;password=123456;Database=lyc_sql;";
			MySqlConnection conn = new MySqlConnection(connectString);
			conn.Open();
			if (Sdept.Text != "")
			{
				string sql = string.Format("update student set Sdept = '" + Sdept.Text.Trim() 
										+ "' where Sno = '" + Sno.Text.Trim() + "';");
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
			}
			if(Cname.Text != "")
			{
				string sql = string.Format("update sc set grade = '" + grade.Text.Trim()
								+ "' where Sno = '" + Sno.Text.Trim()
								+ "' and Cno in ( select Cno from course where Cname = '" + Cname.Text.Trim() + "');");
				MySqlCommand cmd = new MySqlCommand(sql, conn);
				cmd.ExecuteNonQuery();
				
			}
			string sql2 = string.Format("select student.Sno,Sname,Ssex,Sage,Sdept,Cname,Grade from student,sc,course where student.Sno = '" + Sno.Text.Trim()
									+ "' and student.Sno = sc.Sno and sc.Cno = course.Cno;");
			MySqlDataAdapter adapter = new MySqlDataAdapter(sql2, connectString);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			this.SearchDataGridView.DataSource = dt;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void cancel_Click(object sender, EventArgs e)
		{
			Sno.ReadOnly = false;
		}

		private void SearchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
