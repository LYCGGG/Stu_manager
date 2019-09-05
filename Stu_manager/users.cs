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
	public partial class users : Form
	{
		public users()
		{
			InitializeComponent();
		}

		private void select_yourself_Click(object sender, EventArgs e)
		{
			string connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			string sql = string.Format("select Sno,Sname,Ssex,Sage,Sdept from student where Sno = '" + MainWin.users_ID + "';");
			MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			this.usersdateGridView.DataSource = dt;
		}

		private void usersdateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void select_grade_Click(object sender, EventArgs e)
		{
			string connectString = "server=localhost;User=root;password=123456;Database=lyc_sql;";
			string sql = string.Format("select student.Sno,Sname,sc.Cno,Cname,Grade from student,sc,course where student.Sno = '" + MainWin.users_ID
						+ "' and student.Sno = sc.Sno and sc.Cno = course.Cno;");
			MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connectString);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			this.usersdateGridView.DataSource = dt;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
