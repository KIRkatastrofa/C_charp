namespace Diplom_RedkinK
{
	partial class settings
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
			this.qExit = new System.Windows.Forms.Button();
			this.qfn = new System.Windows.Forms.TextBox();
			this.qln = new System.Windows.Forms.TextBox();
			this.allset = new System.Windows.Forms.DataGridView();
			this.allcat = new System.Windows.Forms.DataGridView();
			this.qAddcat = new System.Windows.Forms.Button();
			this.qAddset = new System.Windows.Forms.Button();
			this.qDelset = new System.Windows.Forms.Button();
			this.qDelcat = new System.Windows.Forms.Button();
			this.qup = new System.Windows.Forms.Button();
			this.qh = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.qDeldol = new System.Windows.Forms.Button();
			this.qAdddol = new System.Windows.Forms.Button();
			this.alldol = new System.Windows.Forms.DataGridView();
			this.qdol = new System.Windows.Forms.TextBox();
			this.qeditset = new System.Windows.Forms.Button();
			this.qeditcat = new System.Windows.Forms.Button();
			this.qeditdol = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.allset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allcat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alldol)).BeginInit();
			this.SuspendLayout();
			// 
			// qExit
			// 
			this.qExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qExit.Location = new System.Drawing.Point(847, 12);
			this.qExit.Name = "qExit";
			this.qExit.Size = new System.Drawing.Size(150, 33);
			this.qExit.TabIndex = 26;
			this.qExit.Text = "В меню";
			this.qExit.UseVisualStyleBackColor = true;
			this.qExit.Click += new System.EventHandler(this.qExit_Click);
			// 
			// qfn
			// 
			this.qfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qfn.Location = new System.Drawing.Point(346, 203);
			this.qfn.MaxLength = 30;
			this.qfn.Name = "qfn";
			this.qfn.Size = new System.Drawing.Size(317, 29);
			this.qfn.TabIndex = 14;
			this.qfn.TextChanged += new System.EventHandler(this.qfn_TextChanged);
			this.qfn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qdol_KeyPress);
			// 
			// qln
			// 
			this.qln.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qln.Location = new System.Drawing.Point(12, 203);
			this.qln.MaxLength = 30;
			this.qln.Name = "qln";
			this.qln.Size = new System.Drawing.Size(317, 29);
			this.qln.TabIndex = 10;
			this.qln.TextChanged += new System.EventHandler(this.qln_TextChanged);
			this.qln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qdol_KeyPress);
			// 
			// allset
			// 
			this.allset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.allset.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.allset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allset.DefaultCellStyle = dataGridViewCellStyle2;
			this.allset.Location = new System.Drawing.Point(12, 62);
			this.allset.Name = "allset";
			this.allset.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allset.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.allset.Size = new System.Drawing.Size(317, 135);
			this.allset.TabIndex = 41;
			this.allset.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allset_RowHeaderMouseClick);
			// 
			// allcat
			// 
			this.allcat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.allcat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allcat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.allcat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allcat.DefaultCellStyle = dataGridViewCellStyle5;
			this.allcat.Location = new System.Drawing.Point(346, 62);
			this.allcat.Name = "allcat";
			this.allcat.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allcat.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.allcat.Size = new System.Drawing.Size(317, 135);
			this.allcat.TabIndex = 46;
			this.allcat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allcat_RowHeaderMouseClick);
			// 
			// qAddcat
			// 
			this.qAddcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qAddcat.Location = new System.Drawing.Point(346, 238);
			this.qAddcat.Name = "qAddcat";
			this.qAddcat.Size = new System.Drawing.Size(317, 33);
			this.qAddcat.TabIndex = 15;
			this.qAddcat.Text = "Добавить";
			this.qAddcat.UseVisualStyleBackColor = true;
			this.qAddcat.Click += new System.EventHandler(this.qAddcat_Click);
			// 
			// qAddset
			// 
			this.qAddset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qAddset.Location = new System.Drawing.Point(12, 238);
			this.qAddset.Name = "qAddset";
			this.qAddset.Size = new System.Drawing.Size(317, 33);
			this.qAddset.TabIndex = 11;
			this.qAddset.Text = "Добавить";
			this.qAddset.UseVisualStyleBackColor = true;
			this.qAddset.Click += new System.EventHandler(this.qAddset_Click);
			// 
			// qDelset
			// 
			this.qDelset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qDelset.Location = new System.Drawing.Point(12, 326);
			this.qDelset.Name = "qDelset";
			this.qDelset.Size = new System.Drawing.Size(317, 33);
			this.qDelset.TabIndex = 13;
			this.qDelset.Text = "Удалить";
			this.qDelset.UseVisualStyleBackColor = true;
			this.qDelset.Click += new System.EventHandler(this.qDelset_Click);
			// 
			// qDelcat
			// 
			this.qDelcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qDelcat.Location = new System.Drawing.Point(346, 326);
			this.qDelcat.Name = "qDelcat";
			this.qDelcat.Size = new System.Drawing.Size(317, 33);
			this.qDelcat.TabIndex = 17;
			this.qDelcat.Text = "Удалить";
			this.qDelcat.UseVisualStyleBackColor = true;
			this.qDelcat.Click += new System.EventHandler(this.qDelcat_Click);
			// 
			// qup
			// 
			this.qup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qup.Location = new System.Drawing.Point(372, 376);
			this.qup.Name = "qup";
			this.qup.Size = new System.Drawing.Size(151, 33);
			this.qup.TabIndex = 23;
			this.qup.Text = "Обновить";
			this.qup.UseVisualStyleBackColor = true;
			this.qup.Click += new System.EventHandler(this.qup_Click);
			// 
			// qh
			// 
			this.qh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qh.Location = new System.Drawing.Point(308, 377);
			this.qh.MaxLength = 3;
			this.qh.Name = "qh";
			this.qh.Size = new System.Drawing.Size(58, 29);
			this.qh.TabIndex = 22;
			this.qh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qh_KeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 377);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(290, 31);
			this.label3.TabIndex = 60;
			this.label3.Text = "Часы для прохождения курсов\r\n";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// qDeldol
			// 
			this.qDeldol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qDeldol.Location = new System.Drawing.Point(680, 326);
			this.qDeldol.Name = "qDeldol";
			this.qDeldol.Size = new System.Drawing.Size(317, 33);
			this.qDeldol.TabIndex = 21;
			this.qDeldol.Text = "Удалить";
			this.qDeldol.UseVisualStyleBackColor = true;
			this.qDeldol.Click += new System.EventHandler(this.qDeldol_Click);
			// 
			// qAdddol
			// 
			this.qAdddol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qAdddol.Location = new System.Drawing.Point(680, 238);
			this.qAdddol.Name = "qAdddol";
			this.qAdddol.Size = new System.Drawing.Size(317, 33);
			this.qAdddol.TabIndex = 19;
			this.qAdddol.Text = "Добавить";
			this.qAdddol.UseVisualStyleBackColor = true;
			this.qAdddol.Click += new System.EventHandler(this.qAdddol_Click);
			// 
			// alldol
			// 
			this.alldol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.alldol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.alldol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.alldol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.alldol.DefaultCellStyle = dataGridViewCellStyle8;
			this.alldol.Location = new System.Drawing.Point(680, 62);
			this.alldol.Name = "alldol";
			this.alldol.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.alldol.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.alldol.Size = new System.Drawing.Size(317, 135);
			this.alldol.TabIndex = 62;
			this.alldol.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.alldol_RowHeaderMouseClick);
			// 
			// qdol
			// 
			this.qdol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qdol.Location = new System.Drawing.Point(680, 203);
			this.qdol.MaxLength = 30;
			this.qdol.Name = "qdol";
			this.qdol.Size = new System.Drawing.Size(317, 29);
			this.qdol.TabIndex = 18;
			this.qdol.TextChanged += new System.EventHandler(this.qdol_TextChanged);
			this.qdol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qdol_KeyPress);
			// 
			// qeditset
			// 
			this.qeditset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qeditset.Location = new System.Drawing.Point(12, 282);
			this.qeditset.Name = "qeditset";
			this.qeditset.Size = new System.Drawing.Size(317, 33);
			this.qeditset.TabIndex = 12;
			this.qeditset.Text = "Редактировать";
			this.qeditset.UseVisualStyleBackColor = true;
			this.qeditset.Click += new System.EventHandler(this.qeditset_Click);
			// 
			// qeditcat
			// 
			this.qeditcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qeditcat.Location = new System.Drawing.Point(346, 282);
			this.qeditcat.Name = "qeditcat";
			this.qeditcat.Size = new System.Drawing.Size(317, 33);
			this.qeditcat.TabIndex = 16;
			this.qeditcat.Text = "Редактировать";
			this.qeditcat.UseVisualStyleBackColor = true;
			this.qeditcat.Click += new System.EventHandler(this.qeditcat_Click);
			// 
			// qeditdol
			// 
			this.qeditdol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qeditdol.Location = new System.Drawing.Point(680, 282);
			this.qeditdol.Name = "qeditdol";
			this.qeditdol.Size = new System.Drawing.Size(317, 33);
			this.qeditdol.TabIndex = 20;
			this.qeditdol.Text = "Редактировать";
			this.qeditdol.UseVisualStyleBackColor = true;
			this.qeditdol.Click += new System.EventHandler(this.qeditdol_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(510, 447);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(487, 33);
			this.button2.TabIndex = 25;
			this.button2.Text = "Восстановление базы данных";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(12, 447);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(481, 33);
			this.button1.TabIndex = 24;
			this.button1.Text = "Сохранение базы данных";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 492);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.qeditdol);
			this.Controls.Add(this.qDeldol);
			this.Controls.Add(this.qAdddol);
			this.Controls.Add(this.alldol);
			this.Controls.Add(this.qdol);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.qup);
			this.Controls.Add(this.qeditcat);
			this.Controls.Add(this.qh);
			this.Controls.Add(this.qeditset);
			this.Controls.Add(this.qDelcat);
			this.Controls.Add(this.qDelset);
			this.Controls.Add(this.qAddset);
			this.Controls.Add(this.qAddcat);
			this.Controls.Add(this.allcat);
			this.Controls.Add(this.qfn);
			this.Controls.Add(this.qln);
			this.Controls.Add(this.allset);
			this.Controls.Add(this.qExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Настройки";
			this.Load += new System.EventHandler(this.settings_Load);
			((System.ComponentModel.ISupportInitialize)(this.allset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allcat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alldol)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button qExit;
		private System.Windows.Forms.TextBox qfn;
		private System.Windows.Forms.TextBox qln;
		private System.Windows.Forms.DataGridView allset;
		private System.Windows.Forms.DataGridView allcat;
		private System.Windows.Forms.Button qAddcat;
		private System.Windows.Forms.Button qAddset;
		private System.Windows.Forms.Button qDelset;
		private System.Windows.Forms.Button qDelcat;
		private System.Windows.Forms.Button qup;
		private System.Windows.Forms.TextBox qh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button qDeldol;
		private System.Windows.Forms.Button qAdddol;
		private System.Windows.Forms.DataGridView alldol;
		private System.Windows.Forms.TextBox qdol;
		private System.Windows.Forms.Button qeditset;
		private System.Windows.Forms.Button qeditcat;
		private System.Windows.Forms.Button qeditdol;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}