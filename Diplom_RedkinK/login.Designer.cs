namespace Diplom_RedkinK
{
	partial class login
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.qExit = new System.Windows.Forms.Button();
			this.qPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.qEnter = new System.Windows.Forms.Button();
			this.qlogin = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(268, 43);
			this.label3.TabIndex = 27;
			this.label3.Text = "Авторизация";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 111);
			this.label2.MinimumSize = new System.Drawing.Size(76, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 24);
			this.label2.TabIndex = 26;
			this.label2.Text = "Пароль";
			// 
			// qExit
			// 
			this.qExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qExit.Location = new System.Drawing.Point(7, 187);
			this.qExit.Name = "qExit";
			this.qExit.Size = new System.Drawing.Size(253, 38);
			this.qExit.TabIndex = 27;
			this.qExit.Text = "Выход";
			this.qExit.UseVisualStyleBackColor = true;
			this.qExit.Click += new System.EventHandler(this.qExit_Click);
			// 
			// qPassword
			// 
			this.qPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qPassword.Location = new System.Drawing.Point(82, 108);
			this.qPassword.MaxLength = 30;
			this.qPassword.MinimumSize = new System.Drawing.Size(177, 29);
			this.qPassword.Name = "qPassword";
			this.qPassword.Size = new System.Drawing.Size(177, 29);
			this.qPassword.TabIndex = 25;
			this.qPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 63);
			this.label1.MinimumSize = new System.Drawing.Size(64, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "Логин";
			// 
			// qEnter
			// 
			this.qEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qEnter.Location = new System.Drawing.Point(7, 143);
			this.qEnter.Name = "qEnter";
			this.qEnter.Size = new System.Drawing.Size(253, 38);
			this.qEnter.TabIndex = 26;
			this.qEnter.Text = "Авторизоваться ";
			this.qEnter.UseVisualStyleBackColor = true;
			this.qEnter.Click += new System.EventHandler(this.qEnter_Click);
			// 
			// qlogin
			// 
			this.qlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.qlogin.Location = new System.Drawing.Point(82, 60);
			this.qlogin.MaxLength = 30;
			this.qlogin.MinimumSize = new System.Drawing.Size(177, 29);
			this.qlogin.Name = "qlogin";
			this.qlogin.Size = new System.Drawing.Size(177, 29);
			this.qlogin.TabIndex = 24;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 231);
			this.ControlBox = false;
			this.Controls.Add(this.qlogin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.qExit);
			this.Controls.Add(this.qPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.qEnter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.Load += new System.EventHandler(this.login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button qExit;
		private System.Windows.Forms.TextBox qPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button qEnter;
		private System.Windows.Forms.TextBox qlogin;
	}
}

