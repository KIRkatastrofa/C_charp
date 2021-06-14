namespace Diplom_RedkinK
{
	partial class archive
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archive));
			this.button6 = new System.Windows.Forms.Button();
			this.qsearch = new System.Windows.Forms.Button();
			this.qstring = new System.Windows.Forms.TextBox();
			this.allcourse = new System.Windows.Forms.DataGridView();
			this.qclose = new System.Windows.Forms.Button();
			this.qexport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.qamg = new System.Windows.Forms.Label();
			this.qyear = new System.Windows.Forms.ComboBox();
			this.qmonth = new System.Windows.Forms.ComboBox();
			this.qact = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.allcourse1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.qneact = new System.Windows.Forms.CheckBox();
			this.qzak = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.qneactc = new System.Windows.Forms.CheckBox();
			this.qzackc = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.allcourse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allcourse1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Location = new System.Drawing.Point(934, 12);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(178, 35);
			this.button6.TabIndex = 24;
			this.button6.Text = "В меню";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// qsearch
			// 
			this.qsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qsearch.Location = new System.Drawing.Point(483, 142);
			this.qsearch.MaximumSize = new System.Drawing.Size(412, 35);
			this.qsearch.Name = "qsearch";
			this.qsearch.Size = new System.Drawing.Size(178, 35);
			this.qsearch.TabIndex = 19;
			this.qsearch.Text = "Поиск";
			this.qsearch.UseVisualStyleBackColor = true;
			this.qsearch.Click += new System.EventHandler(this.qsearch_Click);
			// 
			// qstring
			// 
			this.qstring.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.qstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qstring.Location = new System.Drawing.Point(80, 50);
			this.qstring.MaxLength = 30;
			this.qstring.MinimumSize = new System.Drawing.Size(226, 29);
			this.qstring.Name = "qstring";
			this.qstring.Size = new System.Drawing.Size(226, 29);
			this.qstring.TabIndex = 10;
			this.qstring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qstring_KeyPress);
			// 
			// allcourse
			// 
			this.allcourse.AllowUserToResizeColumns = false;
			this.allcourse.AllowUserToResizeRows = false;
			this.allcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.allcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.allcourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allcourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.allcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allcourse.DefaultCellStyle = dataGridViewCellStyle2;
			this.allcourse.Location = new System.Drawing.Point(12, 224);
			this.allcourse.Name = "allcourse";
			this.allcourse.ReadOnly = true;
			this.allcourse.Size = new System.Drawing.Size(1100, 359);
			this.allcourse.TabIndex = 41;
			this.allcourse.Sorted += new System.EventHandler(this.allcourse_Sorted);
			// 
			// qclose
			// 
			this.qclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qclose.Location = new System.Drawing.Point(483, 183);
			this.qclose.MaximumSize = new System.Drawing.Size(412, 35);
			this.qclose.Name = "qclose";
			this.qclose.Size = new System.Drawing.Size(178, 35);
			this.qclose.TabIndex = 20;
			this.qclose.Text = "Очистить";
			this.qclose.UseVisualStyleBackColor = true;
			this.qclose.Click += new System.EventHandler(this.qclose_Click);
			// 
			// qexport
			// 
			this.qexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.qexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qexport.Location = new System.Drawing.Point(934, 588);
			this.qexport.MaximumSize = new System.Drawing.Size(412, 35);
			this.qexport.Name = "qexport";
			this.qexport.Size = new System.Drawing.Size(178, 35);
			this.qexport.TabIndex = 22;
			this.qexport.Text = "Отчет";
			this.qexport.UseVisualStyleBackColor = true;
			this.qexport.Click += new System.EventHandler(this.qexport_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 24);
			this.label1.TabIndex = 49;
			this.label1.Text = "ФИО";
			// 
			// qamg
			// 
			this.qamg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.qamg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qamg.Location = new System.Drawing.Point(12, 596);
			this.qamg.Name = "qamg";
			this.qamg.Size = new System.Drawing.Size(295, 30);
			this.qamg.TabIndex = 54;
			this.qamg.Text = "Количество записей: ";
			// 
			// qyear
			// 
			this.qyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.qyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qyear.FormattingEnabled = true;
			this.qyear.Location = new System.Drawing.Point(227, 107);
			this.qyear.Name = "qyear";
			this.qyear.Size = new System.Drawing.Size(129, 32);
			this.qyear.TabIndex = 12;
			// 
			// qmonth
			// 
			this.qmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.qmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qmonth.FormattingEnabled = true;
			this.qmonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.qmonth.Location = new System.Drawing.Point(80, 107);
			this.qmonth.Name = "qmonth";
			this.qmonth.Size = new System.Drawing.Size(72, 32);
			this.qmonth.TabIndex = 11;
			// 
			// qact
			// 
			this.qact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qact.AutoSize = true;
			this.qact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qact.Location = new System.Drawing.Point(29, 38);
			this.qact.Name = "qact";
			this.qact.Size = new System.Drawing.Size(136, 28);
			this.qact.TabIndex = 13;
			this.qact.Text = "Актуальные";
			this.qact.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(747, 12);
			this.button1.MaximumSize = new System.Drawing.Size(412, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(178, 35);
			this.button1.TabIndex = 23;
			this.button1.Text = "Справка";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// allcourse1
			// 
			this.allcourse1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.allcourse1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.allcourse1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allcourse1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.allcourse1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allcourse1.DefaultCellStyle = dataGridViewCellStyle4;
			this.allcourse1.Location = new System.Drawing.Point(696, 12);
			this.allcourse1.Name = "allcourse1";
			this.allcourse1.ReadOnly = true;
			this.allcourse1.Size = new System.Drawing.Size(39, 33);
			this.allcourse1.TabIndex = 69;
			this.allcourse1.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(6, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 24);
			this.label3.TabIndex = 70;
			this.label3.Text = "Месяц";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(167, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 24);
			this.label5.TabIndex = 70;
			this.label5.Text = "Год";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.qstring);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.qyear);
			this.groupBox1.Controls.Add(this.qmonth);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(12, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(465, 169);
			this.groupBox1.TabIndex = 71;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Поиск";
			// 
			// qneact
			// 
			this.qneact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qneact.AutoSize = true;
			this.qneact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qneact.Location = new System.Drawing.Point(235, 76);
			this.qneact.Name = "qneact";
			this.qneact.Size = new System.Drawing.Size(197, 28);
			this.qneact.TabIndex = 16;
			this.qneact.Text = "Часы от 250 до 500";
			this.qneact.UseVisualStyleBackColor = true;
			// 
			// qzak
			// 
			this.qzak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qzak.AutoSize = true;
			this.qzak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qzak.Location = new System.Drawing.Point(29, 76);
			this.qzak.Name = "qzak";
			this.qzak.Size = new System.Drawing.Size(177, 28);
			this.qzak.TabIndex = 14;
			this.qzak.Text = "Часы от 16 до 72";
			this.qzak.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.qneactc);
			this.groupBox2.Controls.Add(this.qneact);
			this.groupBox2.Controls.Add(this.qact);
			this.groupBox2.Controls.Add(this.qzackc);
			this.groupBox2.Controls.Add(this.qzak);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(667, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(445, 169);
			this.groupBox2.TabIndex = 72;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Фильтр";
			// 
			// qneactc
			// 
			this.qneactc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qneactc.AutoSize = true;
			this.qneactc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qneactc.Location = new System.Drawing.Point(235, 119);
			this.qneactc.Name = "qneactc";
			this.qneactc.Size = new System.Drawing.Size(204, 28);
			this.qneactc.TabIndex = 17;
			this.qneactc.Text = "Часы от 500 и выше";
			this.qneactc.UseVisualStyleBackColor = true;
			this.qneactc.CheckedChanged += new System.EventHandler(this.qneactc_CheckedChanged);
			// 
			// qzackc
			// 
			this.qzackc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qzackc.AutoSize = true;
			this.qzackc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qzackc.Location = new System.Drawing.Point(29, 119);
			this.qzackc.Name = "qzackc";
			this.qzackc.Size = new System.Drawing.Size(194, 28);
			this.qzackc.TabIndex = 15;
			this.qzackc.Text = "Часы от 72 и выше";
			this.qzackc.UseVisualStyleBackColor = true;
			// 
			// archive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 629);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.allcourse1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.qamg);
			this.Controls.Add(this.qclose);
			this.Controls.Add(this.qsearch);
			this.Controls.Add(this.qexport);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.allcourse);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "archive";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Журнал курсов";
			this.Load += new System.EventHandler(this.archive_Load);
			((System.ComponentModel.ISupportInitialize)(this.allcourse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allcourse1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button qsearch;
		private System.Windows.Forms.TextBox qstring;
		private System.Windows.Forms.DataGridView allcourse;
		private System.Windows.Forms.Button qclose;
		private System.Windows.Forms.Button qexport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label qamg;
		private System.Windows.Forms.ComboBox qyear;
		private System.Windows.Forms.ComboBox qmonth;
		private System.Windows.Forms.CheckBox qact;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView allcourse1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox qzak;
		private System.Windows.Forms.CheckBox qneact;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox qneactc;
		private System.Windows.Forms.CheckBox qzackc;
	}
}