namespace Stu_manager
{
	partial class insert
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Sno = new System.Windows.Forms.TextBox();
			this.Cno = new System.Windows.Forms.TextBox();
			this.Sage = new System.Windows.Forms.TextBox();
			this.Ssex = new System.Windows.Forms.TextBox();
			this.Sname = new System.Windows.Forms.TextBox();
			this.Grade = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tablename = new System.Windows.Forms.Label();
			this.Tname = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Sdept = new System.Windows.Forms.TextBox();
			this.putout = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "请输入需要插入数据的相关信息";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.Location = new System.Drawing.Point(10, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "学号";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F);
			this.label3.Location = new System.Drawing.Point(10, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "姓名";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F);
			this.label4.Location = new System.Drawing.Point(10, 246);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "性别";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 12F);
			this.label5.Location = new System.Drawing.Point(10, 303);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "年龄";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 12F);
			this.label6.Location = new System.Drawing.Point(293, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "课程号";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 12F);
			this.label7.Location = new System.Drawing.Point(313, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "成绩";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// Sno
			// 
			this.Sno.Location = new System.Drawing.Point(89, 141);
			this.Sno.Name = "Sno";
			this.Sno.Size = new System.Drawing.Size(137, 25);
			this.Sno.TabIndex = 7;
			this.Sno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Cno
			// 
			this.Cno.Location = new System.Drawing.Point(392, 141);
			this.Cno.Name = "Cno";
			this.Cno.Size = new System.Drawing.Size(137, 25);
			this.Cno.TabIndex = 8;
			// 
			// Sage
			// 
			this.Sage.Location = new System.Drawing.Point(89, 304);
			this.Sage.Name = "Sage";
			this.Sage.Size = new System.Drawing.Size(137, 25);
			this.Sage.TabIndex = 9;
			// 
			// Ssex
			// 
			this.Ssex.Location = new System.Drawing.Point(89, 247);
			this.Ssex.Name = "Ssex";
			this.Ssex.Size = new System.Drawing.Size(137, 25);
			this.Ssex.TabIndex = 10;
			this.Ssex.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// Sname
			// 
			this.Sname.Location = new System.Drawing.Point(89, 188);
			this.Sname.Name = "Sname";
			this.Sname.Size = new System.Drawing.Size(137, 25);
			this.Sname.TabIndex = 11;
			this.Sname.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// Grade
			// 
			this.Grade.Location = new System.Drawing.Point(392, 188);
			this.Grade.Multiline = true;
			this.Grade.Name = "Grade";
			this.Grade.Size = new System.Drawing.Size(137, 25);
			this.Grade.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(595, 127);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 59);
			this.button1.TabIndex = 13;
			this.button1.Text = "插入";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button2.Location = new System.Drawing.Point(595, 273);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 59);
			this.button2.TabIndex = 14;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tablename
			// 
			this.tablename.AutoSize = true;
			this.tablename.Font = new System.Drawing.Font("宋体", 12F);
			this.tablename.Location = new System.Drawing.Point(125, 85);
			this.tablename.Name = "tablename";
			this.tablename.Size = new System.Drawing.Size(49, 20);
			this.tablename.TabIndex = 15;
			this.tablename.Text = "表名";
			// 
			// Tname
			// 
			this.Tname.FormattingEnabled = true;
			this.Tname.Items.AddRange(new object[] {
            "个人信息",
            "成绩"});
			this.Tname.Location = new System.Drawing.Point(204, 87);
			this.Tname.Name = "Tname";
			this.Tname.Size = new System.Drawing.Size(137, 23);
			this.Tname.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 12F);
			this.label8.Location = new System.Drawing.Point(10, 356);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 20);
			this.label8.TabIndex = 17;
			this.label8.Text = "学院";
			// 
			// Sdept
			// 
			this.Sdept.Location = new System.Drawing.Point(89, 357);
			this.Sdept.Name = "Sdept";
			this.Sdept.Size = new System.Drawing.Size(137, 25);
			this.Sdept.TabIndex = 18;
			// 
			// putout
			// 
			this.putout.Location = new System.Drawing.Point(325, 272);
			this.putout.Multiline = true;
			this.putout.Name = "putout";
			this.putout.Size = new System.Drawing.Size(203, 109);
			this.putout.TabIndex = 19;
			// 
			// insert
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.putout);
			this.Controls.Add(this.Sdept);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Tname);
			this.Controls.Add(this.tablename);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Grade);
			this.Controls.Add(this.Sname);
			this.Controls.Add(this.Ssex);
			this.Controls.Add(this.Sage);
			this.Controls.Add(this.Cno);
			this.Controls.Add(this.Sno);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "insert";
			this.Text = "INSERT";
			this.Load += new System.EventHandler(this.insert_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Sno;
		private System.Windows.Forms.TextBox Cno;
		private System.Windows.Forms.TextBox Sage;
		private System.Windows.Forms.TextBox Ssex;
		private System.Windows.Forms.TextBox Sname;
		private System.Windows.Forms.TextBox Grade;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label tablename;
		private System.Windows.Forms.ComboBox Tname;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Sdept;
		private System.Windows.Forms.TextBox putout;
	}
}