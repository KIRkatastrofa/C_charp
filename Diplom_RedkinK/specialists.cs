using Microsoft.Office.Interop.Word;
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
	public partial class specialists : Form
	{
		int housnorm = 0;
		public static string iduser = "";
		public static string Fn = "";
		public static string qmail = "";
		public static string In = "";
		public static string On = "";
		public static string Kv = "";
		public static string Os = "";
		public static string Ps = "";
		public static string op = "";
		public static string po = "";
		public static string obr = "";
		public static string kat = "";
		public static string dol = "";
		public static string srok = "";
		public static int key = 0;
		public static string add = "";
		public static string edit = "";
		public static string del = "";

		public static string phones = "";
		public static string qdayof = "";
		public static string qdaykat = "";

		string connStr = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + "";
		public specialists()
		{
			InitializeComponent();
		}

		private void qAddspec_Click(object sender, EventArgs e)
		{
			key = 0;
			users main = new users();
			this.Visible = false;
			main.ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			history main = new history();
			this.Visible = false;
			main.ShowDialog();
		}

		private void specialists_Load(object sender, EventArgs e)
		{
			VISITS_COUNT1();
			updatetable();
			updatetable();
		}
		public void updatetable()//обновление данных
		{
			try
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM archives;");
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				System.Data.DataTable dt2 = new System.Data.DataTable();
				da1.Fill(dt2);
				int monthy = 0;
				int yeary = 0;
				int idd = 0;
				int koll = 0;
				//##############
				OleDbCommand sql4 = new OleDbCommand("SELECT sethours FROM settingO;");
				sql4.Connection = conn1;
				sql4.ExecuteNonQuery();
				OleDbDataAdapter da4 = new OleDbDataAdapter(sql4);
				System.Data.DataTable dt4 = new System.Data.DataTable();
				da4.Fill(dt4);
				housnorm = Convert.ToInt32(dt4.Rows[0].ItemArray.GetValue(0).ToString());
				//##############
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM users WHERE status<>3 order by user_name asc;");
				sql2.Connection = conn1;
				sql2.ExecuteNonQuery();
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				System.Data.DataTable dt1 = new System.Data.DataTable();
				da2.Fill(dt1);
				//добавление заголовков
				dt1.Columns["user_name"].ColumnName = "ФИО";
				dt1.Columns["user_mail"].ColumnName = "Почта";
				dt1.Columns["user_education"].ColumnName = "Образование";
				dt1.Columns["user_position"].ColumnName = "Должность";
				dt1.Columns["user_exP"].ColumnName = "Пед стаж";
				dt1.Columns["user_kat"].ColumnName = "Категория";
				dt1.Columns["user_qualification"].ColumnName = "Квалификация";
				allusers.DataSource = dt1;
				DateTime dt = DateTime.Today;
				for (int i = 0; i < allusers.Rows.Count - 1; i++)
				{
				koll = 0;
					string dates = dt1.Rows[i].ItemArray.GetValue(18).ToString();
					string[] datemass = dates.Split('.');
					int dayyn = Convert.ToInt32(datemass[0]);
					int monthyn = Convert.ToInt32(datemass[1]);
					int yearyn = Convert.ToInt32(datemass[2]);
					int idn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(0).ToString());
					for (int ii = 0; ii <= dt2.Rows.Count - 1; ii++)
					{
						int dayyy = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(5).ToString());
						int monthyy = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(8).ToString());
						int yearyy = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(6).ToString());
						idd = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(1).ToString());
						if (idn == idd)
						{
							int dat = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(7).ToString());
							if (dayyy >= dayyn && monthyy >= monthyn && yearyy >= yearyn || dayyy < dayyn && monthyy > monthyn && yearyy >= yearyn || dayyy >= dayyn && monthyy < monthyn && yearyy > yearyn || dayyy < dayyn && monthyy < monthyn && yearyy > yearyn)
							{
								koll += dat;
							}
						}

					}
					OleDbCommand sql = new OleDbCommand("update users set hours_kat="+koll+" WHERE id_user=" + idn + ";");
					sql.Connection = conn1;
					sql.ExecuteNonQuery();
					int f = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(11).ToString());
					int g = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(12).ToString());
					if (Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(11).ToString()) - dt.Year <= 4 && Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(12).ToString())< housnorm)
					{
						spat.Visible = true;
						//allusers.DataSource = dt1;
						allusers.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

					}
				}
				
				allusers.Columns[1].DisplayIndex = 1;
				allusers.Columns[5].DisplayIndex = 7;
				allusers.Columns[9].DisplayIndex = 10;
				allusers.Columns[10].DisplayIndex = 13;
				allusers.Columns[13].DisplayIndex = 9;
				allusers.Columns[7].DisplayIndex = 5;
				allusers.Columns[1].Width = 349;
				allusers.Columns[5].Width = 140;
				allusers.Columns[9].Width = 134;
				allusers.Columns[10].Width = 120;
				allusers.Columns[13].Width = 160;
				allusers.Columns[7].Width = 140;
				allusers.Columns[0].Visible = false;
				allusers.Columns[3].Visible = false;
				allusers.Columns[4].Visible = false;
				allusers.Columns[2].Visible = false;
				allusers.Columns[6].Visible = false;
				allusers.Columns[8].Visible = false;
				allusers.Columns[11].Visible = false;
				allusers.Columns[12].Visible = false;
				allusers.Columns[15].Visible = false;
				allusers.Columns[14].Visible = false;
				allusers.Columns[16].Visible = false;
				allusers.Columns[17].Visible = false;
				allusers.Columns[18].Visible = false;
				allusers.Columns[19].Visible = false;
				//###########################################
				OleDbCommand sql3 = new OleDbCommand("SELECT * FROM settingO;");
				sql3.Connection = conn1;
				sql3.ExecuteNonQuery();
				OleDbDataAdapter da3 = new OleDbDataAdapter(sql3);
				System.Data.DataTable dt3 = new System.Data.DataTable();
				da3.Fill(dt3);
				add = dt3.Rows[0].ItemArray.GetValue(1).ToString();
				edit = dt3.Rows[0].ItemArray.GetValue(2).ToString();
				del = dt3.Rows[0].ItemArray.GetValue(3).ToString();
				conn1.Close();
			}
			catch (System.Data.OleDb.OleDbException)
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void allusers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			updateall();
			users main = new users();
			this.Visible = false;
			main.ShowDialog();
		}
		public void updateall()//выборка данных из Datagridview
		{
			try
			{
				iduser = allusers.SelectedCells[0].Value.ToString();
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				System.Data.DataTable dt1 = new System.Data.DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM users Where id_user = " + Convert.ToInt32(iduser) + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				DateTime dt = DateTime.Today;
				qmail = dt1.Rows[0].ItemArray.GetValue(4).ToString();
				obr = dt1.Rows[0].ItemArray.GetValue(5).ToString();
				dol = dt1.Rows[0].ItemArray.GetValue(7).ToString();
				Os = dt1.Rows[0].ItemArray.GetValue(8).ToString();
				kat = dt1.Rows[0].ItemArray.GetValue(9).ToString();
				Ps = dt1.Rows[0].ItemArray.GetValue(10).ToString();
				srok = Convert.ToString(Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(11).ToString()) - dt.Year);
				Kv = dt1.Rows[0].ItemArray.GetValue(13).ToString();
				po = dt1.Rows[0].ItemArray.GetValue(14).ToString();
				op = dt1.Rows[0].ItemArray.GetValue(15).ToString();
				phones = dt1.Rows[0].ItemArray.GetValue(16).ToString();
				qdayof = dt1.Rows[0].ItemArray.GetValue(17).ToString();
				qdaykat = dt1.Rows[0].ItemArray.GetValue(18).ToString();
				string FIO = dt1.Rows[0].ItemArray.GetValue(1).ToString();
				string[] FIOs = FIO.Split(' ');
				Fn = FIOs[0];
				In = FIOs[1];
				On = FIOs[2];
				conn1.Close();
				key = 1;
			}
			catch
			{
				//qaddmet.Visible = false;
				qedit.Visible = false;
				qkurs.Visible = false;
				key = 0;
			}
		}
		public void VISITS_COUNT1()
		{
			try
			{
				OleDbConnection oleDbConn1 = new OleDbConnection(connStr); // создаем подключение
				System.Data.DataTable dt1 = new System.Data.DataTable(); // создаем таблицу 

				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql1 = new OleDbCommand("SELECT COUNT(id_user) FROM [users] WHERE status<>3;"); // создаем запрос
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение

				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				//qamg.Text = "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				qamg.Text += " "+Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(0).ToString());
				oleDbConn1.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void allusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//if(login.loginu=="3")
			//{
			//	//qaddmet.Visible = true;
			//}
			qedit.Visible = true;
			qkurs.Visible = true;
			updateall();

		}

		private void qedit_Click(object sender, EventArgs e)
		{
			users main = new users();
			this.Visible = false;
			main.ShowDialog();
		}

		private void qaddmet_Click(object sender, EventArgs e)
		{
		}

		private void qkurs_Click(object sender, EventArgs e)
		{
			active main = new active();
			this.Visible = false;
			main.ShowDialog();
		}

		private void allusers_Sorted(object sender, EventArgs e)
		{
			updatetable();
		}

		private void button1_Click_1(object sender, EventArgs e)//Экспорт данных в MS Word
		{
			//#############################################################
			DateTime dt = DateTime.Today;
			int dat = dt.Year + 4;
			OleDbConnection oleDbConn1 = new OleDbConnection(connStr);
			oleDbConn1.Open(); // открываем подключение к базе
			OleDbCommand sql1 = new OleDbCommand("SELECT archives.id_user,(SELECT  users.user_name FROM users WHERE id_user=[archives].id_user) AS ФИО, (SELECT  users.user_mail FROM users WHERE id_user=[archives].id_user) AS Почта,(SELECT  users.user_phone FROM users WHERE id_user=[archives].id_user) AS Телефон,(SELECT  users.user_position FROM users WHERE id_user=[archives].id_user) AS Должность,(SELECT  users.user_kat FROM users WHERE id_user=[archives].id_user) AS Категория,(SELECT  users.user_ex FROM users WHERE id_user=[archives].id_user), (SELECT  users.user_exP FROM users WHERE id_user=[archives].id_user),(SELECT  users.user_dayof FROM users WHERE id_user=[archives].id_user),(SELECT  users.user_education FROM users WHERE id_user=[archives].id_user) AS Образование,(SELECT  users.hours_kat FROM users WHERE id_user=[archives].id_user) FROM[archives] Where (SELECT  users.date_kat FROM users WHERE id_user=[archives].id_user)<=" + dat + " and (SELECT users.hours_kat FROM users WHERE id_user=[archives].id_user)<=" + housnorm + " Group by archives.id_user;"); // создаем запрос
			sql1.Connection = oleDbConn1; // привязываем запрос к конекту
			sql1.ExecuteNonQuery(); //выполнение
			System.Data.DataTable dt1 = new System.Data.DataTable();
			OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
			da1.Fill(dt1);
			dt1.Columns["id_user"].ColumnName = "№";
			dt1.Columns["Expr1008"].ColumnName = "Дата рождения";
			dt1.Columns["Expr1006"].ColumnName = "Общий стаж";
			dt1.Columns["Expr1007"].ColumnName = "Пед стаж";
			dt1.Columns["Expr1010"].ColumnName = "Часы";
			allcourse1.DataSource = dt1;

			oleDbConn1.Close();

			int RowCount = allcourse1.Rows.Count;
			int ColumnCount = allcourse1.Columns.Count;
			Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

			//дабавление рядов
			int r = 0;
			for (int c = 0; c <= ColumnCount - 1; c++)
			{
				for (r = 0; r <= RowCount - 1; r++)
				{
					DataArray[r, c] = allcourse1.Rows[r].Cells[c].Value;
				}
			}
			Microsoft.Office.Interop.Word.Application applicationl = new Microsoft.Office.Interop.Word.Application();
			Microsoft.Office.Interop.Word.Document oDoc = applicationl.Documents.Open(Directory.GetCurrentDirectory() + @"\шаблон\template2.docx");
			oDoc.Application.Visible = true;
			oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

			Microsoft.Office.Interop.Word.Range oRange1 = oDoc.Range();
			dynamic oRange = oDoc.Content.Application.Selection.Range;

			string oTemp = "";
			for (r = 0; r < RowCount - 1; r++)
			{
				for (int c = 0; c < ColumnCount; c++)
				{
					if (r + 1 == RowCount - 1 && c >= 10)
					{
						oTemp = oTemp + DataArray[r, c];
					}
					else
					{
						oTemp = oTemp + DataArray[r, c] + "%";
					}
				}
			}
			string[] str = oTemp.Split('%');
			int yu = -1;
			int ii = -1;
			int i = 0;
			int n = 1;
			Microsoft.Office.Interop.Word.Range rng = oDoc.Range();
			Microsoft.Office.Interop.Word.Table t = oDoc.Tables.Add(oDoc.Paragraphs[2].Range, RowCount, ColumnCount);
			t.Columns[1].Width = 30;
			t.Columns[2].Width = 80;
			t.Columns[3].Width = 120;
			t.Columns[4].Width = 100;
			t.Columns[7].Width = 50;
			t.Columns[8].Width = 50;
			t.Columns[10].Width = 100;
			t.Columns[11].Width = 40;
			t.Borders.Enable = 1;
			r = 0;
			foreach (Microsoft.Office.Interop.Word.Row row in t.Rows)
			{
				foreach (Microsoft.Office.Interop.Word.Cell cell in row.Cells)
				{
					if (cell.RowIndex == 1)
					{
						ii++;
						if (ii < ColumnCount)
						{
							cell.Range.Text = allcourse1.Columns[ii].HeaderText;
						}
						//дизайн таблицы
						cell.Range.Font.Name = "times new roman";
						cell.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
						cell.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
					}
					else if (r < RowCount)
					{
						yu++;
						if (yu == 0)
						{
							cell.Range.Text = "" + n;
						}
						else if (yu < ColumnCount)
						{
							cell.Range.Text = str[i];
						}
						if (yu + 1 == ColumnCount)
						{
							yu = -1;
							n++;
						}
						i++;
						cell.Range.Font.Name = "times new roman";
						cell.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
						cell.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
					}
				}
				r++;
				//i = -1;
			}
			//#############################################################
			//#############################################################
			//заполнение шаблона
			ReplaceWordStub("{year}", Convert.ToString(dt.Year), oDoc);
			ReplaceWordStub("{metod}", login.lFIO, oDoc);
		}
		private void ReplaceWordStub(string stubToReplace, string text, Microsoft.Office.Interop.Word.Document wordDocument)
		{
			var range = wordDocument.Content;
			range.Find.ClearFormatting();
			range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
		}

		public void search_info()
		{
			if (qstring.Text == "")
			{
				updatetable();
			}
			else
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM users WHERE status<>3 and user_name like '%" + qstring.Text + "%';");
				sql2.Connection = conn1;
				sql2.ExecuteNonQuery();
				try
				{
					//##############
					//conn1.Open();
					OleDbCommand sql1 = new OleDbCommand("SELECT * FROM archives;");
					sql1.Connection = conn1;
					sql1.ExecuteNonQuery();
					OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
					System.Data.DataTable dt2 = new System.Data.DataTable();
					da1.Fill(dt2);
					int monthy = 0;
					int yeary = 0;
					int idd = 0;
					int koll = 0;
					//##############################
					OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
					System.Data.DataTable dt1 = new System.Data.DataTable();
					da2.Fill(dt1);
					//добавление заголовков
					dt1.Columns["user_name"].ColumnName = "ФИО";
					dt1.Columns["user_mail"].ColumnName = "Почта";
					dt1.Columns["user_education"].ColumnName = "Образование";
					dt1.Columns["user_position"].ColumnName = "Должность";
					dt1.Columns["user_exP"].ColumnName = "Пед стаж";
					dt1.Columns["user_kat"].ColumnName = "Категория";
					dt1.Columns["user_qualification"].ColumnName = "Квалификация";
					allusers.DataSource = dt1;
					DateTime dt = DateTime.Today;
					for (int i = 0; i < allusers.Rows.Count - 1; i++)
					{
						string dates = dt1.Rows[i].ItemArray.GetValue(18).ToString();
						string[] datemass = dates.Split('.');
						int dayyn = Convert.ToInt32(datemass[0]);
						int monthyn = Convert.ToInt32(datemass[1]);
						int yearyn = Convert.ToInt32(datemass[2]);
						int idn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(0).ToString());
						for (int ii = 0; ii < dt2.Rows.Count - 1; ii++)
						{
							int dayyy = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(5).ToString());
							int monthyy = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(8).ToString());
							int yearyy = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(6).ToString());
							idd = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(1).ToString());
							if (idn == idd)
							{
								int dat = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(7).ToString());
								if (dayyy >= dayyn && monthyy >= monthyn && yearyy >= yearyn || dayyy < dayyn && monthyy > monthyn && yearyy >= yearyn || dayyy >= dayyn && monthyy < monthyn && yearyy > yearyn || dayyy < dayyn && monthyy < monthyn && yearyy > yearyn)
								{
									koll += dat;
								}
							}

						}
						if (Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(11).ToString()) - dt.Year <= 4 && Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(12).ToString()) < housnorm)
						{
							spat.Visible = true;
							allusers.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
						}
					}

					allusers.Columns[1].DisplayIndex = 1;
					allusers.Columns[5].DisplayIndex = 7;
					allusers.Columns[9].DisplayIndex = 10;
					allusers.Columns[10].DisplayIndex = 13;
					allusers.Columns[13].DisplayIndex = 9;
					allusers.Columns[7].DisplayIndex = 5;
					allusers.Columns[1].Width = 260;
					allusers.Columns[5].Width = 140;
					allusers.Columns[9].Width = 134;
					allusers.Columns[10].Width = 120;
					allusers.Columns[13].Width = 160;
					allusers.Columns[7].Width = 140;
					allusers.Columns[0].Visible = false;
					allusers.Columns[3].Visible = false;
					allusers.Columns[4].Visible = false;
					allusers.Columns[2].Visible = false;
					allusers.Columns[6].Visible = false;
					allusers.Columns[8].Visible = false;
					allusers.Columns[11].Visible = false;
					allusers.Columns[12].Visible = false;
					allusers.Columns[15].Visible = false;
					allusers.Columns[14].Visible = false;
					allusers.Columns[16].Visible = false;
					allusers.Columns[17].Visible = false;
					allusers.Columns[18].Visible = false;
					allusers.Columns[19].Visible = false;
					//###########################################
					OleDbCommand sql3 = new OleDbCommand("SELECT * FROM settingO;");
					sql3.Connection = conn1;
					sql3.ExecuteNonQuery();
				}
				catch
				{

				}
			}
		}
		private void qsearch_Click(object sender, EventArgs e)
		{
			search_info();
		}

		private void allusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//updatetable();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			helper.key = 1;
			helper main = new helper();
			//this.Visible = false;
			main.ShowDialog();
		}

		private void qstring_TextChanged(object sender, EventArgs e)
		{

		}

		private void qstring_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar < 'А' && e.KeyChar != 8 && e.KeyChar != 32  || e.KeyChar > 'я' && e.KeyChar != 8 && e.KeyChar != 32)
			{
				e.Handled = true;
			}
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
		}
	}
}
