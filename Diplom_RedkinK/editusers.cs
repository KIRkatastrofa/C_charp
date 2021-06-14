using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Diplom_RedkinK
{
	public partial class editusers : Form
	{
		string passwords = "";
		string iduser = "";
		string connStr = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + "";
		int provpass = 0;
		string dostup = "";
		int status = 0;
		public editusers()
		{
			InitializeComponent();
		}

		private void editusers_Load(object sender, EventArgs e)
		{
			uppdate();
		}
		public void uppdate()//обновление данных
		{
			//qAd.Enabled = false;
			//qEd.Enabled = false;
			//qDe.Enabled = false;
			qAdd.Enabled = true;
			qdel.Enabled = false;
			qedit.Enabled = false;
			button1.Enabled = false;
			qlogin.Clear();
			qPassword.Clear();
			qFIO.Clear();
			qStatus.SelectedIndex = -1;
			OleDbConnection conn1 = new OleDbConnection(connStr);
			conn1.Open();
			OleDbCommand sql2 = new OleDbCommand("SELECT * FROM user_u;");
			sql2.Connection = conn1;
			sql2.ExecuteNonQuery();
			try
			{
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				System.Data.DataTable dt1 = new System.Data.DataTable();
				da2.Fill(dt1);
				//вывод заголовков datagridview
				dt1.Columns["loginu"].ColumnName = "Логин";
				dt1.Columns["fiou"].ColumnName = "ФИО";
				dt1.Columns["statusu"].ColumnName = "Статус";
				//dt1.Columns["user_position"].ColumnName = "Должность";
				//dt1.Columns["user_exP"].ColumnName = "Стаж";
				//dt1.Columns["user_kat"].ColumnName = "Категория";
				//dt1.Columns["user_qualification"].ColumnName = "Квалификация";
				allusers.DataSource = dt1;
				//DateTime dt = DateTime.Today;
				allusers.Columns[0].Visible = false;
				allusers.Columns[2].Visible = false;
				allusers.Columns[5].Visible = false;
				//allusers.Columns[4].Visible = false;
				//allusers.Columns[3].Visible = false;
				//allusers.Columns[5].Visible = false;
				//allusers.Columns[8].Visible = false;
				//allusers.Columns[9].Visible = false;
				//allusers.Columns[10].Visible = false;
				//allusers.Columns[11].Visible = false;
				//allusers.Columns[12].Visible = false;
				//allusers.Columns[13].Visible = false;
				//allusers.Columns[15].Visible = false;
				//allusers.Columns[14].Visible = false;
				//allusers.Columns[16].Visible = false;
				//allusers.Columns[17].Visible = false;
				//allusers.Columns[18].Visible = false;
				//###########################################
				OleDbCommand sql3 = new OleDbCommand("SELECT * FROM settingO;");
				sql3.Connection = conn1;
				sql3.ExecuteNonQuery();
			}
			catch (System.Data.OleDb.OleDbException)
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
			conn1.Close();
		}

		private void qExit_Click(object sender, EventArgs e)
		{
			history main = new history();
			this.Visible = false;
			main.ShowDialog();
		}

		private void allusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//управление элементами datagridview
		{
			try
			{
				//qAd.Enabled = false;
				//qEd.Enabled = false;
				//qDe.Enabled = false;
				qAdd.Enabled = false;
				button1.Enabled = true;
				qdel.Enabled = true;
				qedit.Enabled = true;
				iduser = allusers.SelectedCells[0].Value.ToString();
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM user_u Where id_u = " + Convert.ToInt32(iduser) + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				qlogin.Text = dt1.Rows[0].ItemArray.GetValue(1).ToString();
				//q.Text = dt1.Rows[2].ItemArray.GetValue(2).ToString();
				qFIO.Text = dt1.Rows[0].ItemArray.GetValue(3).ToString();
				qStatus.Text = dt1.Rows[0].ItemArray.GetValue(4).ToString();
				//status = Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(6).ToString());
				//string dostupD= dt1.Rows[0].ItemArray.GetValue(19).ToString();
				//if(dostupD.Length>10)
				//{
				//	string[] dostupm = dostupD.Split(':');
				//	//qAd.Text = dostupm[0];
				//	//qEd.Text = dostupm[1];
				//	//qDe.Text = dostupm[2];
				//}
				qPassword.Clear();
				//if(status!=3)
				//{
				//	//qAd.Enabled=true;
				//	//qEd.Enabled=true;
				//	//qDe.Enabled=true;
				//	qdel.Enabled = true;
				//}
				//qedit.Enabled = true;
				conn1.Close();
			}
			catch
			{
				uppdate();
				qAdd.Enabled = true;
			}
		}
		string GetHashPass(string password)//преобразование пароля
		{
			int aa = 0;
			int ch = 0;
			int AA = 0;
			provpass = 0;
			string passprov = password;
			//проверка
			for (int i = 0; i < passprov.Length; i++)
			{
				if (passprov[i] >= 'a' && passprov[i] <= 'z')
				{
					aa = 1;
				}
				else if (passprov[i] >= '!' && passprov[i] <= '@')
				{
					ch = 1;
				}
				else if (passprov[i] >= 'A' && passprov[i] <= 'Z')
				{
					AA = 1;
				}

			}
			if (AA == 1 && aa == 1 && ch == 1 && passprov.Length >= 8)
			{
				provpass = 1;
			}
			//==========

			//получаем байтовое представление строки
			byte[] bytesPass = Encoding.Unicode.GetBytes(password);

			//экземпляр класса для работы с алгоритмом SHA256
			SHA256Managed hashpass = new SHA256Managed();

			//получаем хеш из строки в виде массива байтов
			byte[] hash = hashpass.ComputeHash(bytesPass);

			//очищаем строку
			string hashPasswd = string.Empty;

			//собираем полученный хеш воедино
			foreach (byte x in hash)
			{
				hashPasswd += String.Format("{0:x2}", x);
			}

			//освобождаем все ресурсы связанные с экземпляром объекта SHA256Managed
			hashpass.Dispose();
			return hashPasswd;
		}
		private void qdel_Click(object sender, EventArgs e)//удаление данных
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Удалить данные?", "Сообщение пользователю", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (dialogResult == DialogResult.Yes)
				{
					int ER = 0;
					DateTime dt = DateTime.Today;
					OleDbConnection conn1 = new OleDbConnection(connStr);
					conn1.Open();
					OleDbCommand sql1 = new OleDbCommand("SELECT * FROM user_u");
					sql1.Connection = conn1;
					DataTable dt1 = new DataTable();
					sql1.ExecuteNonQuery();
					OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
					da1.Fill(dt1);
					//string phones = qphone.Text;
					for (int i = 0; i <= dt1.Rows.Count - 1; i++)
					{
						string ggg = dt1.Rows[i].ItemArray.GetValue(0).ToString();
						string gggd = dt1.Rows[i].ItemArray.GetValue(5).ToString();
						if (Convert.ToInt32(iduser)==login.iduser)
						{
							ER = 2;
							goto mER;
						}
					}
					OleDbCommand sql = new OleDbCommand("DELETE FROM user_u Where id_u=" + Convert.ToInt32(iduser) + ";");
					sql.Connection = conn1;
					sql.ExecuteNonQuery();
					conn1.Close();
					MessageBox.Show("Данные удалены", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					uppdate();
				mER:
					if (ER == 2)
					{
						MessageBox.Show("Ошибка! доступ запрещен!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
			catch
			{
				//MessageBox.Show("Предупреждение. Вы не можете удалить сотрудника, который имеет курсы!", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void qedit_Click(object sender, EventArgs e)//редактирование данных
		{
			try
			{
				int ER = 0;
				if (qlogin.Text == "" || qFIO.Text == "" || qPassword.Text == "" || qStatus.Text == "")
				{
					MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					string password = GetHashPass(qPassword.Text.ToString());
					DateTime dt = DateTime.Today;
					OleDbConnection conn1 = new OleDbConnection(connStr);
					conn1.Open();
					OleDbCommand sql1 = new OleDbCommand("SELECT * FROM user_u");
					sql1.Connection = conn1;
					DataTable dt1 = new DataTable();
					sql1.ExecuteNonQuery();
					OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
					da1.Fill(dt1);
					//string phones = qphone.Text;
					for (int i = 0; i <= dt1.Rows.Count-1; i++)
					{
						if (qlogin.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString() && iduser!= dt1.Rows[i].ItemArray.GetValue(0).ToString())
						{
							ER = 1;
							goto mER;
						}
						if (Convert.ToInt32(iduser) == login.iduser && qStatus.Text != "Администратор")
						{
							ER = 2;
							goto mER;
						}
					}
					if (qStatus.Text == "Администратор")
					{
						status = 3;
					}
					else
					{
						status = 1;
					}
				OleDbCommand sql = new OleDbCommand("update user_u SET loginu='" + qlogin.Text+"',passwdu='"+password+"',fiou='"+qFIO.Text+"',statusu='"+qStatus.Text+"',status="+status+ " where id_u=" + Convert.ToInt32(iduser)+";");
					sql.Connection = conn1;
					sql.ExecuteNonQuery();
					conn1.Close();
					MessageBox.Show("Пользователь обновлен!", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					uppdate();
				mER:
					if (ER == 1)
					{
						MessageBox.Show("Ошибка! такой пользователь уже существует!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				if (ER == 2)
				{
					MessageBox.Show("Ошибка! доступ запрещен!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			}
			catch
			{
				MessageBox.Show("Ошибка! Проверьте данные!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void button1_Click(object sender, EventArgs e)//кнопка очистки
		{
			qlogin.Clear();
			qPassword.Clear();
			qFIO.Clear();
			qStatus.SelectedIndex = -1;
			uppdate();
		}

		private void qAdd_Click(object sender, EventArgs e)
		{
			try
			{
				int ER = 0;
				if (qlogin.Text == "" || qFIO.Text == "" || qPassword.Text == "" || qStatus.Text == "")
				{
					MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					int id = 0;
					Random rnd = new Random();
					int status = 0;
					id = rnd.Next(2,99999);
					string password= GetHashPass(qPassword.Text.ToString());
					if(qStatus.Text=="Администратор")
					{
						status = 3;
					}
					else
					{
						status = 1;
					}
					DateTime dt = DateTime.Today;
					OleDbConnection conn1 = new OleDbConnection(connStr);
					conn1.Open();
					OleDbCommand sql1 = new OleDbCommand("SELECT * FROM user_u");
					sql1.Connection = conn1;
					DataTable dt1 = new DataTable();
					sql1.ExecuteNonQuery();
					OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
					da1.Fill(dt1);			
					//string phones = qphone.Text;
					for (int i = 0; i < allusers.Rows.Count-1; i++)
					{
						if (qlogin.Text == dt1.Rows[i].ItemArray.GetValue(1).ToString())
						{
							ER = 1;
							goto mER;
						}
					}
					OleDbCommand sql = new OleDbCommand("INSERT INTO user_u (id_u,loginu,passwdu,fiou,statusu,status) VALUES (" + id + ",'" + qlogin.Text + "','" + password + "','" + qFIO.Text + "','" + qStatus.Text + "'," + status + ");");
					sql.Connection = conn1;
					sql.ExecuteNonQuery();
					conn1.Close();
					MessageBox.Show("Пользователь в базу добавлен", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					uppdate();
				mER:
					if (ER == 1)
					{
						MessageBox.Show("Ошибка! такой пользователь уже существует!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
		}
			catch
			{
				MessageBox.Show("Ошибка! Проверьте данные!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
}

		private void qFIO_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar !=46 && e.KeyChar < 'А' && e.KeyChar != 8 && e.KeyChar != 32 || e.KeyChar != 46 && e.KeyChar > 'я' && e.KeyChar != 8 && e.KeyChar != 32)
			{
				e.Handled = true;
			}
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
		}
	}
}
