namespace Diplom_RedkinK
{
	partial class editusers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editusers));
			this.qlogin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.qPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.qExit = new System.Windows.Forms.Button();
			this.qedit = new System.Windows.Forms.Button();
			this.qdel = new System.Windows.Forms.Button();
			this.allusers = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.qAdd = new System.Windows.Forms.Button();
			this.qStatus = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.qFIO = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.allusers)).BeginInit();
			this.SuspendLayout();
			// 
			// qlogin
			// 
			this.qlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qlogin.Location = new System.Drawing.Point(102, 80);
			this.qlogin.MaxLength = 30;
			this.qlogin.MinimumSize = new System.Drawing.Size(177, 29);
			this.qlogin.Name = "qlogin";
			this.qlogin.Size = new System.Drawing.Size(177, 29);
			this.qlogin.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(15, 122);
			this.label2.MinimumSize = new System.Drawing.Size(76, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 24);
			this.label2.TabIndex = 45;
			this.label2.Text = "Пароль";
			// 
			// qPassword
			// 
			this.qPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qPassword.Location = new System.Drawing.Point(102, 119);
			this.qPassword.MaxLength = 30;
			this.qPassword.MinimumSize = new System.Drawing.Size(177, 29);
			this.qPassword.Name = "qPassword";
			this.qPassword.Size = new System.Drawing.Size(177, 29);
			this.qPassword.TabIndex = 11;
			this.qPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(15, 83);
			this.label1.MinimumSize = new System.Drawing.Size(64, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 43;
			this.label1.Text = "Логин";
			// 
			// qExit
			// 
			this.qExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qExit.Location = new System.Drawing.Point(846, 6);
			this.qExit.Name = "qExit";
			this.qExit.Size = new System.Drawing.Size(158, 35);
			this.qExit.TabIndex = 18;
			this.qExit.Text = "В меню";
			this.qExit.UseVisualStyleBackColor = true;
			this.qExit.Click += new System.EventHandler(this.qExit_Click);
			// 
			// qedit
			// 
			this.qedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.qedit.Enabled = false;
			this.qedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qedit.Location = new System.Drawing.Point(184, 315);
			this.qedit.Name = "qedit";
			this.qedit.Size = new System.Drawing.Size(166, 34);
			this.qedit.TabIndex = 15;
			this.qedit.Text = "Редактировать";
			this.qedit.UseVisualStyleBackColor = true;
			this.qedit.Click += new System.EventHandler(this.qedit_Click);
			// 
			// qdel
			// 
			this.qdel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.qdel.Enabled = false;
			this.qdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qdel.Location = new System.Drawing.Point(356, 315);
			this.qdel.Name = "qdel";
			this.qdel.Size = new System.Drawing.Size(166, 34);
			this.qdel.TabIndex = 16;
			this.qdel.Text = "Удалить";
			this.qdel.UseVisualStyleBackColor = true;
			this.qdel.Click += new System.EventHandler(this.qdel_Click);
			// 
			// allusers
			// 
			this.allusers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.allusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.allusers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allusers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.allusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.allusers.DefaultCellStyle = dataGridViewCellStyle2;
			this.allusers.Location = new System.Drawing.Point(12, 154);
			this.allusers.Name = "allusers";
			this.allusers.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.allusers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.allusers.Size = new System.Drawing.Size(992, 155);
			this.allusers.TabIndex = 52;
			this.allusers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allusers_RowHeaderMouseClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(838, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(166, 34);
			this.button1.TabIndex = 17;
			this.button1.Text = "Очистить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// qAdd
			// 
			this.qAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.qAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qAdd.Location = new System.Drawing.Point(12, 315);
			this.qAdd.Name = "qAdd";
			this.qAdd.Size = new System.Drawing.Size(166, 34);
			this.qAdd.TabIndex = 14;
			this.qAdd.Text = "Добавить";
			this.qAdd.UseVisualStyleBackColor = true;
			this.qAdd.Click += new System.EventHandler(this.qAdd_Click);
			// 
			// qStatus
			// 
			this.qStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.qStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qStatus.FormattingEnabled = true;
			this.qStatus.Items.AddRange(new object[] {
            "Администратор",
            "Методист"});
			this.qStatus.Location = new System.Drawing.Point(685, 119);
			this.qStatus.Name = "qStatus";
			this.qStatus.Size = new System.Drawing.Size(319, 32);
			this.qStatus.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(603, 122);
			this.label4.MinimumSize = new System.Drawing.Size(76, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 24);
			this.label4.TabIndex = 60;
			this.label4.Text = "Статус";
			// 
			// qFIO
			// 
			this.qFIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.qFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qFIO.Location = new System.Drawing.Point(685, 80);
			this.qFIO.MaxLength = 30;
			this.qFIO.MinimumSize = new System.Drawing.Size(177, 29);
			this.qFIO.Name = "qFIO";
			this.qFIO.Size = new System.Drawing.Size(319, 29);
			this.qFIO.TabIndex = 12;
			this.qFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qFIO_KeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(603, 83);
			this.label3.MinimumSize = new System.Drawing.Size(64, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 61;
			this.label3.Text = "ФИО";
			// 
			// editusers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 359);
			this.ControlBox = false;
			this.Controls.Add(this.qFIO);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.qStatus);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.allusers);
			this.Controls.Add(this.qAdd);
			this.Controls.Add(this.qdel);
			this.Controls.Add(this.qedit);
			this.Controls.Add(this.qExit);
			this.Controls.Add(this.qlogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.qPassword);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "editusers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пользователи";
			this.Load += new System.EventHandler(this.editusers_Load);
			((System.ComponentModel.ISupportInitialize)(this.allusers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox qlogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox qPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button qExit;
		private System.Windows.Forms.Button qedit;
		private System.Windows.Forms.Button qdel;
		private System.Windows.Forms.DataGridView allusers;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button qAdd;
		private System.Windows.Forms.ComboBox qStatus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox qFIO;
		private System.Windows.Forms.Label label3;
	}
}