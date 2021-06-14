namespace Diplom_RedkinK
{
	partial class helper
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helper));
			this.qclose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// qclose
			// 
			this.qclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qclose.Location = new System.Drawing.Point(244, 116);
			this.qclose.MaximumSize = new System.Drawing.Size(412, 35);
			this.qclose.Name = "qclose";
			this.qclose.Size = new System.Drawing.Size(178, 35);
			this.qclose.TabIndex = 46;
			this.qclose.Text = "Закрыть";
			this.qclose.UseVisualStyleBackColor = true;
			this.qclose.Click += new System.EventHandler(this.qclose_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(412, 104);
			this.label1.TabIndex = 50;
			this.label1.Text = "Красный цвет записи - заканчивающий курс\r\nЗеленый цвет записи- неактуальная запис" +
    "ь \r\nЧерный цвет записи - актуальная запись";
			// 
			// helper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 159);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.qclose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "helper";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Справочник";
			this.Load += new System.EventHandler(this.helper_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button qclose;
		private System.Windows.Forms.Label label1;
	}
}