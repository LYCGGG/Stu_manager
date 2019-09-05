namespace Stu_manager
{
	partial class Form2
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
			this.select = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
			this.delect = new System.Windows.Forms.Button();
			this.insert = new System.Windows.Forms.Button();
			this.register = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// select
			// 
			this.select.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.select.Location = new System.Drawing.Point(10, 350);
			this.select.Name = "select";
			this.select.Size = new System.Drawing.Size(113, 74);
			this.select.TabIndex = 1;
			this.select.Text = "查询";
			this.select.UseVisualStyleBackColor = true;
			this.select.Click += new System.EventHandler(this.select_Click);
			// 
			// update
			// 
			this.update.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.update.Location = new System.Drawing.Point(10, 250);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(113, 74);
			this.update.TabIndex = 2;
			this.update.Text = "修改";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.update_Click);
			// 
			// delect
			// 
			this.delect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.delect.Location = new System.Drawing.Point(10, 150);
			this.delect.Name = "delect";
			this.delect.Size = new System.Drawing.Size(113, 74);
			this.delect.TabIndex = 3;
			this.delect.Text = "删除";
			this.delect.UseVisualStyleBackColor = true;
			this.delect.Click += new System.EventHandler(this.delect_Click);
			// 
			// insert
			// 
			this.insert.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.insert.Location = new System.Drawing.Point(10, 50);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(113, 74);
			this.insert.TabIndex = 4;
			this.insert.Text = "插入";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// register
			// 
			this.register.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.register.Location = new System.Drawing.Point(657, 50);
			this.register.Name = "register";
			this.register.Size = new System.Drawing.Size(113, 74);
			this.register.TabIndex = 5;
			this.register.Text = "用户\r\n注册";
			this.register.UseVisualStyleBackColor = true;
			this.register.Click += new System.EventHandler(this.register_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.button1.Location = new System.Drawing.Point(657, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 74);
			this.button1.TabIndex = 6;
			this.button1.Text = "用户修改";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 453);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.register);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.delect);
			this.Controls.Add(this.update);
			this.Controls.Add(this.select);
			this.Name = "Form2";
			this.Text = "相关操作";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button select;
		private System.Windows.Forms.Button update;
		private System.Windows.Forms.Button delect;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Button register;
		private System.Windows.Forms.Button button1;
	}
}