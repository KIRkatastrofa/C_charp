using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom_RedkinK
{
	public partial class settings : Form
	{
		public static int Nset = 0;
		public static int Ncat = 0;
		public static int Ndol = 0;
		string idset = "";
		string idcat = "";
		string iddol = "";
		string connStr = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + "";
		public settings()
		{
			InitializeComponent();
		}

		private void qExit_Click(object sender, EventArgs e)
		{
			history main = new history();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void settings_Load(object sender, EventArgs e)
		{
			update();
		}
		public void update()//обновление данных
		{
            qln.Clear();
            qfn.Clear();
            qdol.Clear();
            qAddcat.Enabled = false;
			qAddset.Enabled = false;
			qDelcat.Enabled = false;
			qDelset.Enabled = false;
			qAdddol.Enabled = false;
			qDeldol.Enabled = false;
			qeditset.Enabled = false;
			qeditcat.Enabled = false;
			qeditdol.Enabled = false;
			OleDbConnection conn1 = new OleDbConnection(connStr);
			conn1.Open();
			try
			{
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM settingsuser;");
				sql2.Connection = conn1;
				sql2.ExecuteNonQuery();
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				DataTable dt2 = new DataTable();
				da2.Fill(dt2);
				dt2.Columns["settingsuser"].ColumnName = "Образование";
				allset.DataSource = dt2;
				allset.Columns[0].Visible = false;

				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM categoryuser;");
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				DataTable dt1 = new DataTable();
				da1.Fill(dt1);
				dt1.Columns["kat_users"].ColumnName = "Категория";
				allcat.DataSource = dt1;
				allcat.Columns[0].Visible = false;

				OleDbCommand sql6 = new OleDbCommand("SELECT * FROM dols;");
				sql6.Connection = conn1;
				sql6.ExecuteNonQuery();
				OleDbDataAdapter da6 = new OleDbDataAdapter(sql6);
				DataTable dt6 = new DataTable();
				da6.Fill(dt6);
				dt6.Columns["user_dol"].ColumnName = "Должность";
				alldol.DataSource = dt6;
				alldol.Columns[0].Visible = false;
				VISITS_COUNT1();

				OleDbCommand sql3 = new OleDbCommand("SELECT * FROM settingO;");
				sql3.Connection = conn1;
				sql3.ExecuteNonQuery();
				OleDbDataAdapter da3 = new OleDbDataAdapter(sql3);
				DataTable dt3 = new DataTable();
				da3.Fill(dt3);
				qh.Text= dt3.Rows[0].ItemArray.GetValue(4).ToString();
			}
			catch (System.Data.OleDb.OleDbException)
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			conn1.Close();
		}

		private void qfn_TextChanged(object sender, EventArgs e)
		{
			if (qfn.Text != "")
			{
				qAddcat.Enabled = true;
			}
			else
			{
				qAddcat.Enabled = false;
			}
		}

		private void qln_TextChanged(object sender, EventArgs e)
		{
			if(qln.Text!="")
			{
				qAddset.Enabled = true;
			}
			else
			{
				qAddset.Enabled = false;
			}
		}
		public void VISITS_COUNT1()
		{
			try
			{
				OleDbConnection oleDbConn1 = new OleDbConnection(connStr); // создаем подключение
				DataTable dt1 = new DataTable();
				DataTable dt2 = new DataTable();
				DataTable dt3 = new DataTable();
				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql1 = new OleDbCommand("SELECT COUNT(*) FROM [settingsuser];"); // создаем запрос
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				//qamg.Text = "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				Nset = Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(0).ToString());


				OleDbCommand sql2 = new OleDbCommand("SELECT COUNT(*) FROM [categoryuser];"); // создаем запрос
				sql2.Connection = oleDbConn1; // привязываем запрос к конекту
				sql2.ExecuteNonQuery(); //выполнение
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				da2.Fill(dt2);
				//qamg.Text = "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				Ncat = Convert.ToInt32(dt2.Rows[0].ItemArray.GetValue(0).ToString());


				OleDbCommand sql3 = new OleDbCommand("SELECT COUNT(*) FROM [dols];"); // создаем запрос
				sql3.Connection = oleDbConn1; // привязываем запрос к конекту
				sql3.ExecuteNonQuery(); //выполнение

				OleDbDataAdapter da3 = new OleDbDataAdapter(sql3);
				da3.Fill(dt3);
				//qamg.Text = "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				Ndol = Convert.ToInt32(dt3.Rows[0].ItemArray.GetValue(0).ToString());
				oleDbConn1.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void qAddset_Click(object sender, EventArgs e)//добавление настроек
		{
			try
			{
				int ER = 0;
				int id = 0;
				Random rnd = new Random();
				id = rnd.Next(8, 50000000);
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM settingsuser");
				sql1.Connection = conn1;
				DataTable dt1 = new DataTable();
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				for (int i = 0; i < Nset; i++)
				{
					if (qln.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString())
					{
						ER = 1;
						goto mER;
					}
				}
				OleDbCommand sql = new OleDbCommand("INSERT INTO settingsuser (id_set,settingsuser) VALUES (" + id + ",'" + qln.Text +"');");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qln.Clear();
				update();
			mER:
				if (ER == 1)
				{
					MessageBox.Show("Ошибка!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
		}
			catch
			{

			}
		}

		private void qAddcat_Click(object sender, EventArgs e)//добавление категорий
		{
			try
			{
				int ER = 0;
				int id = 0;
				Random rnd = new Random();
				id = rnd.Next(8, 50000000);
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM categoryuser");
				sql1.Connection = conn1;
				DataTable dt1 = new DataTable();
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				for (int i = 0; i < Ncat; i++)
				{
					if (qfn.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString())
					{
						ER = 1;
						goto mER;
					}
				}
				OleDbCommand sql = new OleDbCommand("INSERT INTO categoryuser (id_kat,kat_users) VALUES (" + id + ",'" + qfn.Text + "');");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qfn.Clear();
				update();
			mER:
				if (ER == 1)
				{
					MessageBox.Show("Ошибка!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{

			}
		}

		private void allset_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//выборка данных из Datagridview
		{
			try
			{
				idset = allset.SelectedCells[0].Value.ToString();
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM settingsuser Where id_set = " + Convert.ToInt32(idset) + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				qln.Text=dt1.Rows[0].ItemArray.GetValue(1).ToString();
				qDelset.Enabled = true;
				qeditset.Enabled = true;
				conn1.Close();
			}
			catch
			{
				qDelset.Enabled = false;
			}
		}

		private void allcat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//выборка данных из Datagridview
		{
			try
			{
				idcat = allcat.SelectedCells[0].Value.ToString();
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM categoryuser Where id_kat = " + Convert.ToInt32(idcat) + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				qfn.Text = dt1.Rows[0].ItemArray.GetValue(1).ToString();
				qDelcat.Enabled = true;
				qeditcat.Enabled = true;
				conn1.Close();
			}
			catch
			{
				qDelcat.Enabled = false;
			}
		}

		private void qDelset_Click(object sender, EventArgs e)//удаление данных 
		{
			try
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql = new OleDbCommand("DELETE FROM settingsuser Where id_set=" + Convert.ToInt32(idset) + ";");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qDelset.Enabled = false;
				qln.Clear();
				update();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void qDelcat_Click(object sender, EventArgs e)//удаление данных 
		{
			try
			{
			OleDbConnection conn1 = new OleDbConnection(connStr);
			conn1.Open();
			OleDbCommand sql = new OleDbCommand("DELETE FROM categoryuser Where id_kat=" + Convert.ToInt32(idcat) + ";");
			sql.Connection = conn1;
			sql.ExecuteNonQuery();
			conn1.Close();
			qDelcat.Enabled=false;
			qfn.Clear();
			update();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void qup_Click(object sender, EventArgs e)
		{
			try
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql3 = new OleDbCommand("Update settingO set sethours=" + Convert.ToInt32(qh.Text) + ";");
				sql3.Connection = conn1;
				sql3.ExecuteNonQuery();
				conn1.Close();
				update();
				MessageBox.Show("Данные обновлены!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{

			}
		}

		private void qdol_TextChanged(object sender, EventArgs e)//проверка на ввод
		{
			if (qdol.Text != "")
			{
				qAdddol.Enabled = true;
			}
			else
			{
				qAdddol.Enabled = false;
			}
		}

		private void qAdddol_Click(object sender, EventArgs e)//добавление данных
		{
			try
			{
				int ER = 0;
				int id = 0;
				Random rnd = new Random();
				id = rnd.Next(8, 50000000);
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM dols");
				sql1.Connection = conn1;
				DataTable dt1 = new DataTable();
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				for (int i = 0; i < Ndol; i++)
				{
					if (qdol.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString())
					{
						ER = 1;
						goto mER;
					}
				}
				OleDbCommand sql = new OleDbCommand("INSERT INTO dols (id_dol,user_dol) VALUES (" + id + ",'" + qdol.Text + "');");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qdol.Clear();
				update();
			mER:
				if (ER == 1)
				{
					MessageBox.Show("Ошибка!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{

			}
		}

		private void qDeldol_Click(object sender, EventArgs e)//удаление данных
		{
			try
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql = new OleDbCommand("DELETE FROM dols Where id_dol=" + Convert.ToInt32(iddol) + ";");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qDeldol.Enabled = false;
				qdol.Clear();
				update();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void alldol_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//выборка данных из Datagridview
		{
			try
			{
				iddol = alldol.SelectedCells[0].Value.ToString();
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM dols Where id_dol = " + Convert.ToInt32(iddol) + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				qdol.Text = dt1.Rows[0].ItemArray.GetValue(1).ToString();
				qeditdol.Enabled = true;
				qDeldol.Enabled = true;
				conn1.Close();
			}
			catch
			{
				qDeldol.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			editusers main = new editusers();
			this.Visible = false;
			main.ShowDialog();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Today;
			string day = Convert.ToString(dt.Day);
			string month = Convert.ToString(dt.Month);
			string year = Convert.ToString(dt.Year);
			if(day.Length!=2)
			{
				day = "0" + day;
			}
			if (month.Length != 2)
			{
				month = "0" + month;
			}
			try
			{
				File.Copy("" + login.namebd + ".mdb", @"Резерв\" + day + "_" + month + "_" + year + ".kat", true);
				MessageBox.Show("База экспортирована!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				Directory.CreateDirectory("Резерв");
				File.Copy("" + login.namebd + ".mdb", @"Резерв\" + day + "_" + month + "_" + year + ".kat", true);
				MessageBox.Show("База экспортирована!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog opd = new OpenFileDialog();
			{
				//Directory.GetFiles("Резерв");
				//opd.InitialDirectory = @"Резерв\";
				opd.Filter = "(*.kat)|*.kat";
				opd.InitialDirectory = Environment.CurrentDirectory+@"\Резерв";
				if (opd.ShowDialog() == DialogResult.OK)
				{
					//Directory.GetFiles("Резерв");
					File.Copy(opd.FileName, "" + login.namebd + ".mdb", true);
					MessageBox.Show("База импортирована, приложение будет перезагружено!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
					login main = new login();//false
					this.Visible = false;
					main.ShowDialog();
				}
			}
		}

		private void qeditcat_Click(object sender, EventArgs e)
		{
			try
			{
				int ER = 0;
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM categoryuser");
				sql1.Connection = conn1;
				DataTable dt1 = new DataTable();
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				for (int i = 0; i < Ncat; i++)
				{
					if (qfn.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString())
					{
						ER = 1;
						goto mER;
					}
				}
				OleDbCommand sql = new OleDbCommand("Update categoryuser set kat_users='" + qfn.Text + "' where id_kat=" + Convert.ToInt32(idcat) + ";");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qfn.Clear();
				update();
			mER:
				if (ER == 1)
				{
					MessageBox.Show("Ошибка!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{

			}
		}

		private void qeditset_Click(object sender, EventArgs e)
		{
			try
			{
				int ER = 0;
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM settingsuser");
				sql1.Connection = conn1;
				DataTable dt1 = new DataTable();
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				for (int i = 0; i < Nset; i++)
				{
					if (qln.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString())
					{
						ER = 1;
						goto mER;
					}
				}
				OleDbCommand sql = new OleDbCommand("Update settingsuser set settingsuser='" + qln.Text + "' where id_set=" + Convert.ToInt32(idset) + ";");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qln.Clear();
				update();
			mER:
				if (ER == 1)
				{
					MessageBox.Show("Ошибка!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{

			}
		}

		private void qeditdol_Click(object sender, EventArgs e)
		{
			try
			{
				int ER = 0;
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM dols");
				sql1.Connection = conn1;
				DataTable dt1 = new DataTable();
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				for (int i = 0; i < Ndol; i++)
				{
					if (qdol.Text == dt1.Rows[i].ItemArray.GetValue(0).ToString())
					{
						ER = 1;
						goto mER;
					}
				}
				OleDbCommand sql = new OleDbCommand("Update dols set user_dol='" + qdol.Text + "' where id_dol=" + Convert.ToInt32(iddol) + ";");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qdol.Clear();
				update();
			mER:
				if (ER == 1)
				{
					MessageBox.Show("Ошибка!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch
			{

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void qh_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

        private void qdol_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar < 'а' && e.KeyChar != 8 && e.KeyChar != 32  || e.KeyChar > 'я' && e.KeyChar != 8 && e.KeyChar != 32)
			{
				e.Handled = true;
			}
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
        }
	}
}
