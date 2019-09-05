namespace Stu_manager
{
	partial class select
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
			this.lebel1 = new System.Windows.Forms.Label();
			this.Sno = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.selectResultView = new System.Windows.Forms.DataGridView();
			this.selectTable = new System.Windows.Forms.ComboBox();
			this.Lebel2 = new System.Windows.Forms.Label();
			this.Sname = new System.Windows.Forms.TextBox();
			this.explain = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.selectResultView)).BeginInit();
			this.SuspendLayout();
			// 
			// lebel1
			// 
			this.lebel1.AutoSize = true;
			this.lebel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lebel1.Location = new System.Drawing.Point(44, 140);
			this.lebel1.Name = "lebel1";
			this.lebel1.Size = new System.Drawing.Size(49, 20);
			this.lebel1.TabIndex = 0;
			this.lebel1.Text = "学号";
			this.lebel1.Click += new System.EventHandler(this.lebel1_Click);
			// 
			// Sno
			// 
			this.Sno.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Sno.Location = new System.Drawing.Point(12, 109);
			this.Sno.Multiline = true;
			this.Sno.Name = "Sno";
			this.Sno.Size = new System.Drawing.Size(121, 28);
			this.Sno.TabIndex = 1;
			this.Sno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(223, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "查询";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// selectResultView
			// 
			this.selectResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.selectResultView.Location = new System.Drawing.Point(0, 303);
			this.selectResultView.Name = "selectResultView";
			this.selectResultView.RowTemplate.Height = 27;
			this.selectResultView.Size = new System.Drawing.Size(791, 244);
			this.selectResultView.TabIndex = 3;
			// 
			// selectTable
			// 
			this.selectTable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.selectTable.FormattingEnabled = true;
			this.selectTable.Items.AddRange(new object[] {
            "个人信息",
            "成绩",
            "所有信息"});
			this.selectTable.Location = new System.Drawing.Point(12, 49);
			this.selectTable.Name = "selectTable";
			this.selectTable.Size = new System.Drawing.Size(121, 28);
			this.selectTable.TabIndex = 4;
			this.selectTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Lebel2
			// 
			this.Lebel2.AutoSize = true;
			this.Lebel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Lebel2.Location = new System.Drawing.Point(44, 218);
			this.Lebel2.Name = "Lebel2";
			this.Lebel2.Size = new System.Drawing.Size(49, 20);
			this.Lebel2.TabIndex = 5;
			this.Lebel2.Text = "姓名";
			// 
			// Sname
			// 
			this.Sname.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Sname.Location = new System.Drawing.Point(12, 187);
			this.Sname.Multiline = true;
			this.Sname.Name = "Sname";
			this.Sname.Size = new System.Drawing.Size(121, 28);
			this.Sname.TabIndex = 6;
			this.Sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// explain
			// 
			this.explain.BackColor = System.Drawing.SystemColors.Menu;
			this.explain.Location = new System.Drawing.Point(12, 260);
			this.explain.Multiline = true;
			this.explain.Name = "explain";
			this.explain.Size = new System.Drawing.Size(121, 37);
			this.explain.TabIndex = 7;
			// 
			// select
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 548);
			this.Controls.Add(this.explain);
			this.Controls.Add(this.Sname);
			this.Controls.Add(this.Lebel2);
			this.Controls.Add(this.selectTable);
			this.Controls.Add(this.selectResultView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Sno);
			this.Controls.Add(this.lebel1);
			this.Name = "select";
			this.Text = "SELECT";
			((System.ComponentModel.ISupportInitialize)(this.selectResultView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lebel1;
		private System.Windows.Forms.TextBox Sno;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView selectResultView;
		private System.Windows.Forms.ComboBox selectTable;
		private System.Windows.Forms.Label Lebel2;
		private System.Windows.Forms.TextBox Sname;
		private System.Windows.Forms.TextBox explain;
	}
}