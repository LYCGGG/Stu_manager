namespace Stu_manager
{
	partial class MainWin
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.usrname = new System.Windows.Forms.TextBox();
			this.passwd = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Sure = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(32, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(32, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "密码";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// usrname
			// 
			this.usrname.BackColor = System.Drawing.SystemColors.Window;
			this.usrname.Location = new System.Drawing.Point(131, 123);
			this.usrname.Name = "usrname";
			this.usrname.Size = new System.Drawing.Size(166, 25);
			this.usrname.TabIndex = 2;
			this.usrname.TextChanged += new System.EventHandler(this.usrname_TextChanged);
			// 
			// passwd
			// 
			this.passwd.Location = new System.Drawing.Point(131, 187);
			this.passwd.Name = "passwd";
			this.passwd.Size = new System.Drawing.Size(166, 25);
			this.passwd.TabIndex = 3;
			this.passwd.TextChanged += new System.EventHandler(this.passwd_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(15, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "简易学生信息管理系统";
			// 
			// Sure
			// 
			this.Sure.Location = new System.Drawing.Point(384, 128);
			this.Sure.Name = "Sure";
			this.Sure.Size = new System.Drawing.Size(88, 37);
			this.Sure.TabIndex = 6;
			this.Sure.Text = "登录";
			this.Sure.UseVisualStyleBackColor = true;
			this.Sure.Click += new System.EventHandler(this.Sure_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(384, 192);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(88, 37);
			this.cancel.TabIndex = 7;
			this.cancel.Text = "取消";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(69, 248);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 19);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "管理员";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(193, 248);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(58, 19);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "用户";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 433);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.Sure);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwd);
			this.Controls.Add(this.usrname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainWin";
			this.Text = "登录";
			this.Load += new System.EventHandler(this.MainWin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox usrname;
		private System.Windows.Forms.TextBox passwd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Sure;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
	}
}

