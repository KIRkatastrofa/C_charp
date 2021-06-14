using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom_RedkinK
{
	public partial class users : Form
	{
		int ER = 0;
		public static int key = 0;
		int N = 0;
		string connStr = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + "";
		public users()
		{
			InitializeComponent();
		}

		private void qAdd_Click(object sender, EventArgs e)//доабвление работника
		{
			try
			{
				if (qtabN.Text == "" || qF.Text == "" || qI.Text == "" || qKv.Text == "" || qOs.Text == "" || qPs.Text == "" || qO.Text == "" || qkat.Text == "" || qDol.Text == "" || qobr.Text == "" || qdiplom.Text == "" || qdpo.Text == "" || qphone.Text == "" || dayof.Text == "" || daykat.Text == "")
				{
					MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{				
					qSrok.Text = "5";
					if (Convert.ToInt32(qOs.Text) >= Convert.ToInt32(qPs.Text))
					{
						ER = 0;
						DateTime dt = DateTime.Today;
						int years = Convert.ToInt32(qSrok.Text) + dt.Year;
						OleDbConnection conn1 = new OleDbConnection(connStr);
						conn1.Open();
						OleDbCommand sql1 = new OleDbCommand("SELECT * FROM users");
						sql1.Connection = conn1;
						DataTable dt1 = new DataTable();
						sql1.ExecuteNonQuery();
						OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
						da1.Fill(dt1);
						string phones = qphone.Text;
						if(phones.Length!=16)
						{
							ER = 2;
							goto mER;
						}
						for (int i = 0; i <= N; i++)
						{
							string str = dt1.Rows[i].ItemArray.GetValue(0).ToString();
							if (qtabN.Text == dt1.Rows[i].ItemArray.GetValue(0).ToString() || qphone.Text== dt1.Rows[i].ItemArray.GetValue(16).ToString() || qmail.Text == dt1.Rows[i].ItemArray.GetValue(4).ToString() && qmail.Text!="")
							{
								ER = 1;
								goto mER;
							}
						}
						//преобразование первой буквы в заглавную
						qF.Text=qF.Text.ToLower();
						qI.Text=qI.Text.ToLower();
						qO.Text=qO.Text.ToLower();
						qF.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qF.Text);
						qI.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qI.Text);
						qO.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qO.Text);
						OleDbCommand sql = new OleDbCommand("INSERT INTO users (id_user,user_name,user_mail,user_education,status,user_position,user_ex,user_kat,user_exP,date_kat,hours_kat,user_qualification,user_dpo,user_dop,user_phone,user_dayof,user_kat_day) VALUES (" + Convert.ToInt32(qtabN.Text) + ",'" + qF.Text + " " + qI.Text + " " + qO.Text + "','"+qmail.Text+"','" + qobr.Text + "'," + 0 + ",'" + qDol.Text + "','" + qOs.Text + "','" + qkat.Text + "','" + qPs.Text + "'," + years + "," + 0 + ",'" + qKv.Text + "','" + qdpo.Text + "','" + qdiplom.Text + "','" + qphone.Text + "','" + dayof.Text + "','" + daykat.Text + "');");
						sql.Connection = conn1;
						sql.ExecuteNonQuery();
						conn1.Close();
						MessageBox.Show("Пользователь в базу добавлен", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
						qAdd.Enabled = false;
						qEd.Enabled = true;
						qDel.Enabled = true;
						qkurs.Enabled = true;
						qsee.Enabled = true;
						qtabN.Enabled = false;
						specialists.iduser = qtabN.Text;
						specialists.Fn = qF.Text;
						specialists.In = qI.Text;
                        specialists.qdaykat = daykat.Text;
						specialists.On = qO.Text;
						specialists.obr = qobr.Text;
						specialists.dol = qDol.Text;
						specialists.Os = qOs.Text;
						specialists.kat = qkat.Text;
						specialists.Ps = qPs.Text;
						specialists.srok = qSrok.Text;
						specialists.Kv = qKv.Text;
						specialists.po = qdpo.Text;
						specialists.op = qdiplom.Text;
						specialists.phones = qphone.Text;
						specialists.qdayof = dayof.Text;
						specialists.qmail = qmail.Text;
						update();
					mER:
						if (ER == 1)
						{
							MessageBox.Show("Ошибка! такой пользователь уже существует!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						if (ER == 2)
						{
							MessageBox.Show("Ошибка! Проверьте номер телефона!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
					else
					{
						MessageBox.Show("Общий стаж не может быть меньше педагогического!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
			catch
			{
				MessageBox.Show("Ошибка! Проверьте данные!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void qDel_Click(object sender, EventArgs e)//удаление работника
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Удалить данные?", "Сообщение пользователю", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (dialogResult == DialogResult.Yes)
				{
					OleDbConnection conn1 = new OleDbConnection(connStr);
					conn1.Open();
					OleDbCommand sql = new OleDbCommand("DELETE FROM users Where id_user=" + Convert.ToInt32(qtabN.Text) + ";");
					sql.Connection = conn1;
					sql.ExecuteNonQuery();
					conn1.Close();
					MessageBox.Show("Данные удалены", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					specialists main = new specialists();
					this.Visible = false;
					main.ShowDialog();
				}
			}
			catch
			{
				delcourse();
			}
		}
		public void delcourse()
		{
			try
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql = new OleDbCommand("DELETE FROM archives Where id_user=" + Convert.ToInt32(qtabN.Text) + ";");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();

				OleDbCommand sql1 = new OleDbCommand("DELETE FROM users Where id_user=" + Convert.ToInt32(qtabN.Text) + ";");
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				conn1.Close();
				MessageBox.Show("Данные удалены", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				specialists main = new specialists();
				this.Visible = false;
				main.ShowDialog();
			}
			catch
			{

			}
		}
		private void qEd_Click(object sender, EventArgs e)//редактирование данных
		{
			try
			{
				string f = qphone.Text;
				if (qtabN.Text == "" || qF.Text == "" || qI.Text == "" || qKv.Text == "" || qOs.Text == "" || qPs.Text == "" || qO.Text == "" || qkat.Text == "" || qDol.Text == "" || qobr.Text == "" || qSrok.Text == "" || qdiplom.Text == "" || qdpo.Text == "" || qphone.Text == "" || dayof.Text == "" || daykat.Text == "")
				{
					MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение пользователю", MessageBoxButtons.OK);
				}
				else
				{
					if (specialists.qdaykat != daykat.Text)
					{
						qSrok.Text = "5";
					}
					DialogResult dialogResult = MessageBox.Show("Редактировать данные?", "Сообщение пользователю", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (dialogResult == DialogResult.Yes)
					{
						if (Convert.ToInt32(qOs.Text) >= Convert.ToInt32(qPs.Text))
						{
							ER = 0;
							qF.Text = qF.Text.ToLower();
							qI.Text=qI.Text.ToLower();
							qO.Text=qO.Text.ToLower();
							qF.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qF.Text);
							qI.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qI.Text);
							qO.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qO.Text);
							DateTime dt = DateTime.Today;
							int years = Convert.ToInt32(qSrok.Text) + dt.Year;
							OleDbConnection conn1 = new OleDbConnection(connStr);
							conn1.Open();
							OleDbCommand sql1 = new OleDbCommand("SELECT * FROM users");
							sql1.Connection = conn1;
							DataTable dt1 = new DataTable();
							sql1.ExecuteNonQuery();
							OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
							da1.Fill(dt1);
							string phones = qphone.Text;
							if (phones.Length != 16)
							{
								ER = 2;
								goto mER;
							}
							for (int i = 0; i <= N; i++)
							{
								if (qtabN.Text != dt1.Rows[i].ItemArray.GetValue(0).ToString() && qphone.Text == dt1.Rows[i].ItemArray.GetValue(16).ToString() || qtabN.Text != dt1.Rows[i].ItemArray.GetValue(0).ToString() && qmail.Text == dt1.Rows[i].ItemArray.GetValue(4).ToString() && dt1.Rows[i].ItemArray.GetValue(4).ToString()!="")
								{
									ER = 1;
									goto mER;
								}
							}
							OleDbCommand sql = new OleDbCommand("update users SET user_name='" + qF.Text + " " + qI.Text + " " + qO.Text + "',user_education='" + qobr.Text + "',status=0,user_position='" + qDol.Text + "',user_ex='" + qOs.Text + "',user_kat='" + qkat.Text + "',user_exP='" + qPs.Text + "',date_kat=" + years + ",hours_kat=0,user_qualification='" + qKv.Text + "',user_dpo='" + qdpo.Text + "',user_dop='" + qdiplom.Text + "',user_phone='" + qphone.Text + "',user_dayof='" + dayof.Text + "',user_kat_day='" + daykat.Text + "',user_mail='"+qmail.Text+"' WHERE id_user=" + Convert.ToInt32(qtabN.Text) + ";");
							sql.Connection = conn1;
							sql.ExecuteNonQuery();
							conn1.Close();
							//присвоение значений
							specialists.obr = qobr.Text;
							specialists.dol = qDol.Text;
							specialists.Os = qOs.Text;
							specialists.kat = qkat.Text;
							specialists.Ps = qPs.Text;
							specialists.srok = qSrok.Text;
							specialists.Kv = qKv.Text;
							specialists.po = qdpo.Text;
							specialists.op = qdiplom.Text;
							specialists.Fn = qF.Text;
							specialists.In = qI.Text;
							specialists.On = qO.Text;
							specialists.phones = qphone.Text;
							specialists.qdayof = dayof.Text;
							specialists.qdaykat = daykat.Text;
							specialists.qmail = qmail.Text;
							MessageBox.Show("Данные обновлены!", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
							update();
						mER:
							if (ER == 1)
							{
								MessageBox.Show("Ошибка! такой пользователь уже существует!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
							if (ER == 2)
							{
								MessageBox.Show("Ошибка! Проверьте номер телефона!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							}
						}
						else
						{
							MessageBox.Show("Общий стаж не может быть меньше педагогического!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
				}
			}
			catch
			{

			}
		}

		private void qExit_Click(object sender, EventArgs e)
		{
			specialists main = new specialists();
			this.Visible = false;
			main.ShowDialog();
		}

		private void users_Load(object sender, EventArgs e)
		{
			try
			{
				DateTime dt = DateTime.Today;
				dayof.MaxDate = dt.Date;
				daykat.MaxDate = dt.Date;
				//загрузка всех настроек
				OleDbConnection conn = new OleDbConnection(connStr);
				conn.Open();
				OleDbCommand sql5 = new OleDbCommand("SELECT * FROM categoryuser;", conn);
				OleDbDataReader DR2 = sql5.ExecuteReader();
				while (DR2.Read())
				{
					qkat.Items.Add(DR2.GetValue(1).ToString());
				}
				//###################################################
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM settingsuser;", conn);
				OleDbDataReader DR1 = sql1.ExecuteReader();
				while (DR1.Read())
				{
					qobr.Items.Add(DR1.GetValue(1).ToString());
				}
				//###################################################
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM dols;", conn);
				OleDbDataReader DR3 = sql2.ExecuteReader();
				while (DR3.Read())
				{
					qDol.Items.Add(DR3.GetValue(1).ToString());
				}
				if (specialists.key == 1)
				{
					specialists.key = 0;
					qtabN.Enabled = false;
					qAdd.Enabled = false;
					qtabN.Text = specialists.iduser;
					qF.Text = specialists.Fn;
					qI.Text = specialists.In;
					qO.Text = specialists.On;
					qKv.Text = specialists.Kv;
					qDol.Text = specialists.dol;
					qOs.Text = specialists.Os;
					qPs.Text = specialists.Ps;
					qobr.Text = specialists.obr;
					qdpo.Text = specialists.po;
					qdiplom.Text = specialists.op;
					qkat.Text = specialists.kat;
					qSrok.Text = specialists.srok;
					daykat.Text = specialists.qdaykat;
					qphone.Text = specialists.phones;
					dayof.Text = specialists.qdayof;
					qmail.Text = specialists.qmail;
					qEd.Enabled = true;
					qDel.Enabled = true;
					qkurs.Enabled = true;
					qsee.Enabled = true;
				}
				else
				{
					if (login.loginu != "3")
					{
						if (login.dosad == "запрещено")
						{
							qAdd.Enabled = false;
						}
					}
				}
				update();
				//###################################################
			}
			catch
			{

			}
		}
		public void update()
		{
			VISITS_COUNT1();
		}
		public void VISITS_COUNT1()
		{
			try
			{
				OleDbConnection oleDbConn1 = new OleDbConnection(connStr); // создаем подключение
				DataTable dt1 = new DataTable(); // создаем таблицу 

				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql1 = new OleDbCommand("SELECT COUNT(id_user) FROM [users] WHERE status<>3;"); // создаем запрос
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение

				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				//qamg.Text = "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				N = Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(0).ToString());
				oleDbConn1.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void qRez_TextChanged(object sender, EventArgs e)
		{
		}

		private void qkurs_Click(object sender, EventArgs e)
		{
			active main = new active();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void qsee_Click(object sender, EventArgs e)
		{
			predpros.key = 1;
			predpros main = new predpros();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void qSrok_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

		private void qSrok_TextChanged(object sender, EventArgs e)//проверка на ввод данных
		{
			//int k = Convert.ToInt32(qSrok.Text);
			if (qSrok.Text == "0")// && k >= 5)
			{
				qSrok.Text = "1";
			}
		}

		private void qPs_TextChanged(object sender, EventArgs e)//проверка на ввод данных
		{
			if (qOs.Text == "0")
			{
				qOs.Text = "1";
			}
			if (qPs.Text == "0")
			{
				qPs.Text = "1";
			}
			if(qtabN.Text=="0")
			{
				qtabN.Text = "1";
			}
		}

		private void qphone_TextChanged(object sender, EventArgs e)//проверка на ввод данных
		{
			try
			{
				int k = Convert.ToInt32(qphone.Text[0]) - 48;
				if (k != 8)
				{
					qphone.Text = "8";
				}
			}
			catch
			{

			}
		}
		private void qF_KeyPress(object sender, KeyPressEventArgs e)//проверка на ввод данных
		{
			if (e.KeyChar < 'А' && e.KeyChar != 8 || e.KeyChar > 'я' && e.KeyChar != 8)
			{
				e.Handled = true;
			}
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
		}
		private void qF_TextChanged(object sender, EventArgs e)
		{
		}
		private void qKv_KeyPress(object sender, KeyPressEventArgs e)//проверка на ввод данных
		{
			if (e.KeyChar < 'а' && e.KeyChar != 8 && e.KeyChar != 32  || e.KeyChar > 'я' && e.KeyChar != 8 && e.KeyChar != 32)
			{
				e.Handled = true;
			}
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
		}

		private void qExit_MouseHover(object sender, EventArgs e)
		{
			ToolTip t = new ToolTip();
			t.SetToolTip(qExit, "Сотрудники");
		}
	}
}
