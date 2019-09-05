namespace Stu_manager
{
	partial class users
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
			this.usersdateGridView = new System.Windows.Forms.DataGridView();
			this.select_yourself = new System.Windows.Forms.Button();
			this.select_grade = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.usersdateGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// usersdateGridView
			// 
			this.usersdateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersdateGridView.Location = new System.Drawing.Point(-2, 81);
			this.usersdateGridView.Name = "usersdateGridView";
			this.usersdateGridView.RowTemplate.Height = 27;
			this.usersdateGridView.Size = new System.Drawing.Size(805, 191);
			this.usersdateGridView.TabIndex = 0;
			this.usersdateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersdateGridView_CellContentClick);
			// 
			// select_yourself
			// 
			this.select_yourself.Font = new System.Drawing.Font("宋体", 12F);
			this.select_yourself.Location = new System.Drawing.Point(12, 29);
			this.select_yourself.Name = "select_yourself";
			this.select_yourself.Size = new System.Drawing.Size(157, 46);
			this.select_yourself.TabIndex = 1;
			this.select_yourself.Text = "查询个人信息";
			this.select_yourself.UseVisualStyleBackColor = true;
			this.select_yourself.Click += new System.EventHandler(this.select_yourself_Click);
			// 
			// select_grade
			// 
			this.select_grade.Font = new System.Drawing.Font("宋体", 12F);
			this.select_grade.Location = new System.Drawing.Point(224, 29);
			this.select_grade.Name = "select_grade";
			this.select_grade.Size = new System.Drawing.Size(157, 46);
			this.select_grade.TabIndex = 2;
			this.select_grade.Text = "查询个人成绩";
			this.select_grade.UseVisualStyleBackColor = true;
			this.select_grade.Click += new System.EventHandler(this.select_grade_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 12F);
			this.button1.Location = new System.Drawing.Point(445, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 46);
			this.button1.TabIndex = 3;
			this.button1.Text = "取消";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 268);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.select_grade);
			this.Controls.Add(this.select_yourself);
			this.Controls.Add(this.usersdateGridView);
			this.Name = "users";
			this.Text = "你的个人信息";
			((System.ComponentModel.ISupportInitialize)(this.usersdateGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView usersdateGridView;
		private System.Windows.Forms.Button select_yourself;
		private System.Windows.Forms.Button select_grade;
		private System.Windows.Forms.Button button1;
	}
}