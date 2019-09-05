namespace Stu_manager
{
	partial class update
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
			this.SearchDataGridView = new System.Windows.Forms.DataGridView();
			this.Sno = new System.Windows.Forms.TextBox();
			this.select = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Sdept = new System.Windows.Forms.TextBox();
			this.grade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Cname = new System.Windows.Forms.TextBox();
			this.cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchDataGridView
			// 
			this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchDataGridView.Location = new System.Drawing.Point(5, 174);
			this.SearchDataGridView.Name = "SearchDataGridView";
			this.SearchDataGridView.RowTemplate.Height = 27;
			this.SearchDataGridView.Size = new System.Drawing.Size(796, 278);
			this.SearchDataGridView.TabIndex = 0;
			this.SearchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchDataGridView_CellContentClick);
			// 
			// Sno
			// 
			this.Sno.Location = new System.Drawing.Point(47, 39);
			this.Sno.Name = "Sno";
			this.Sno.Size = new System.Drawing.Size(100, 25);
			this.Sno.TabIndex = 1;
			this.Sno.TextChanged += new System.EventHandler(this.Sno_TextChanged);
			// 
			// select
			// 
			this.select.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.select.Location = new System.Drawing.Point(47, 119);
			this.select.Name = "select";
			this.select.Size = new System.Drawing.Size(100, 40);
			this.select.TabIndex = 2;
			this.select.Text = "查询";
			this.select.UseVisualStyleBackColor = true;
			this.select.Click += new System.EventHandler(this.select_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(70, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "学号";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(390, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "修改";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(322, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "学院";
			// 
			// Sdept
			// 
			this.Sdept.Location = new System.Drawing.Point(296, 39);
			this.Sdept.Name = "Sdept";
			this.Sdept.Size = new System.Drawing.Size(100, 25);
			this.Sdept.TabIndex = 6;
			// 
			// grade
			// 
			this.grade.Location = new System.Drawing.Point(660, 39);
			this.grade.Name = "grade";
			this.grade.Size = new System.Drawing.Size(100, 25);
			this.grade.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label3.Location = new System.Drawing.Point(683, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "成绩";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.Location = new System.Drawing.Point(499, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "课程名";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Cname
			// 
			this.Cname.Location = new System.Drawing.Point(482, 39);
			this.Cname.Name = "Cname";
			this.Cname.Size = new System.Drawing.Size(100, 25);
			this.Cname.TabIndex = 10;
			// 
			// cancel
			// 
			this.cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cancel.Location = new System.Drawing.Point(576, 109);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(100, 40);
			this.cancel.TabIndex = 11;
			this.cancel.Text = "取消";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.Cname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grade);
			this.Controls.Add(this.Sdept);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.select);
			this.Controls.Add(this.Sno);
			this.Controls.Add(this.SearchDataGridView);
			this.Name = "update";
			this.Text = "UPDATE";
			((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView SearchDataGridView;
		private System.Windows.Forms.TextBox Sno;
		private System.Windows.Forms.Button select;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Sdept;
		private System.Windows.Forms.TextBox grade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Cname;
		private System.Windows.Forms.Button cancel;
	}
}