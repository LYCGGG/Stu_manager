namespace Stu_manager
{
	partial class delect
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Sno = new System.Windows.Forms.TextBox();
			this.Cno = new System.Windows.Forms.TextBox();
			this.sure = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.Tname = new System.Windows.Forms.ComboBox();
			this.explain = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(95, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "学号";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(74, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "课程号";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(53, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "删除选择";
			// 
			// Sno
			// 
			this.Sno.Location = new System.Drawing.Point(214, 175);
			this.Sno.Name = "Sno";
			this.Sno.Size = new System.Drawing.Size(156, 25);
			this.Sno.TabIndex = 5;
			// 
			// Cno
			// 
			this.Cno.Location = new System.Drawing.Point(214, 277);
			this.Cno.Name = "Cno";
			this.Cno.Size = new System.Drawing.Size(156, 25);
			this.Cno.TabIndex = 7;
			// 
			// sure
			// 
			this.sure.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.sure.Location = new System.Drawing.Point(534, 86);
			this.sure.Name = "sure";
			this.sure.Size = new System.Drawing.Size(118, 55);
			this.sure.TabIndex = 8;
			this.sure.Text = "删除";
			this.sure.UseVisualStyleBackColor = true;
			this.sure.Click += new System.EventHandler(this.sure_Click);
			// 
			// cancel
			// 
			this.cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
			this.cancel.Location = new System.Drawing.Point(534, 247);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(118, 55);
			this.cancel.TabIndex = 9;
			this.cancel.Text = "取消";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// Tname
			// 
			this.Tname.FormattingEnabled = true;
			this.Tname.Items.AddRange(new object[] {
            "学生所有信息",
            "课程记录",
            "所有课程记录"});
			this.Tname.Location = new System.Drawing.Point(214, 83);
			this.Tname.Name = "Tname";
			this.Tname.Size = new System.Drawing.Size(156, 23);
			this.Tname.TabIndex = 10;
			// 
			// explain
			// 
			this.explain.Location = new System.Drawing.Point(214, 341);
			this.explain.Name = "explain";
			this.explain.ReadOnly = true;
			this.explain.Size = new System.Drawing.Size(156, 25);
			this.explain.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(74, 346);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "显示信息";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// delect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.explain);
			this.Controls.Add(this.Tname);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.sure);
			this.Controls.Add(this.Cno);
			this.Controls.Add(this.Sno);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "delect";
			this.Text = "DELECT";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Sno;
		private System.Windows.Forms.TextBox Cno;
		private System.Windows.Forms.Button sure;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.ComboBox Tname;
		private System.Windows.Forms.TextBox explain;
		private System.Windows.Forms.Label label2;
	}
}