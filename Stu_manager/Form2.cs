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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void insert_Click(object sender, EventArgs e)
		{
			insert button = new insert();
			//this.Hide();
			button.ShowDialog();
		}

		private void delect_Click(object sender, EventArgs e)
		{
			delect button = new delect();
			//this.Hide();
			button.ShowDialog();
		}

		private void update_Click(object sender, EventArgs e)
		{
			update button = new update();
			button.ShowDialog();
		}

		private void select_Click(object sender, EventArgs e)
		{
			select button = new select();
			button.ShowDialog();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void register_Click(object sender, EventArgs e)
		{
			users_register button = new users_register();
			button.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
