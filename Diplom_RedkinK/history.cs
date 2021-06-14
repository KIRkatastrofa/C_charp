using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Diplom_RedkinK
{
	public partial class history : Form
	{
		int N = 0;
		string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + ""; // строка подключения
		public history()
		{
			InitializeComponent();
		}
		//кнопки перехода
		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void boptions_Click(object sender, EventArgs e)
		{
			editusers main = new editusers();
			this.Visible = false;
			main.ShowDialog();
		}
		//проверка на пользователя
		private void history_Load(object sender, EventArgs e)
		{
			if (login.loginu == "3")
			{
				groupBox2.Visible = true;
				groupBox1.Visible = false;
			}
		}

		private void busers_Click(object sender, EventArgs e)
		{
			active main = new active();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void barchive_Click(object sender, EventArgs e)
		{
			archive main = new archive();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			settings main = new settings();//false
			this.Visible = false;
			main.ShowDialog();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			ins();
		}
		public void ins()
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			archive main = new archive();
			this.Visible = false;
			main.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			specialists main = new specialists();
			this.Visible = false;
			main.ShowDialog();
		}
	}
}
