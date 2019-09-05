namespace Stu_manager
{
	partial class users_register
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
			this.Uno = new System.Windows.Forms.TextBox();
			this.Upasswd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Sno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.explain = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F);
			this.label1.Location = new System.Drawing.Point(12, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名";
			// 
			// Uno
			// 
			this.Uno.Location = new System.Drawing.Point(120, 100);
			this.Uno.Name = "Uno";
			this.Uno.Size = new System.Drawing.Size(100, 25);
			this.Uno.TabIndex = 1;
			// 
			// Upasswd
			// 
			this.Upasswd.Location = new System.Drawing.Point(120, 200);
			this.Upasswd.Name = "Upasswd";
			this.Upasswd.Size = new System.Drawing.Size(100, 25);
			this.Upasswd.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F);
			this.label2.Location = new System.Drawing.Point(12, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "密码";
			// 
			// Sno
			// 
			this.Sno.Location = new System.Drawing.Point(120, 300);
			this.Sno.Name = "Sno";
			this.Sno.Size = new System.Drawing.Size(100, 25);
			this.Sno.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F);
			this.label3.Location = new System.Drawing.Point(12, 300);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "学号";
			// 
			// explain
			// 
			this.explain.Location = new System.Drawing.Point(16, 362);
			this.explain.Name = "explain";
			this.explain.Size = new System.Drawing.Size(204, 25);
			this.explain.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 12F);
			this.button1.Location = new System.Drawing.Point(300, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 29);
			this.button1.TabIndex = 7;
			this.button1.Text = "注册";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("宋体", 12F);
			this.button2.Location = new System.Drawing.Point(300, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 29);
			this.button2.TabIndex = 8;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// users_register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 433);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.explain);
			this.Controls.Add(this.Sno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Upasswd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Uno);
			this.Controls.Add(this.label1);
			this.Name = "users_register";
			this.Text = "用户注册";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Uno;
		private System.Windows.Forms.TextBox Upasswd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Sno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox explain;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}