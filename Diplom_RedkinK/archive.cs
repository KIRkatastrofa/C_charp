using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Diplom_RedkinK
{
	public partial class archive : Form
	{
		string searchh = "";
		string searchm = "";
		string searchy = "";
		string searchact = "";
		string searchzak = "";
		string searchneact = "";
		string search72 = "";
		string search500 = "";
		string[] mass;
		int N = 0;
		string con1 = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + ""; // строка подключения
		public archive()
		{
			InitializeComponent();
		}
		public void VISITS_COUNT()//счетчик
		{
			try
			{
				OleDbConnection oleDbConn1 = new OleDbConnection(con1); // создаем подключение
				System.Data.DataTable dt1 = new System.Data.DataTable(); // создаем таблицу 

				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql1 = new OleDbCommand("SELECT COUNT(id_archive) FROM [archives];"); // создаем запрос
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение

				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				qamg.Text= "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				oleDbConn1.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}
		public void Updatetable()//обновление данных
		{
			try
			{
				DateTime dt = DateTime.Today;
				OleDbConnection oleDbConn2 = new OleDbConnection(con1);
				oleDbConn2.Open(); // открываем подключение к базе
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM users;"); // создаем запрос
				sql2.Connection = oleDbConn2; // привязываем запрос к конекту
				sql2.ExecuteNonQuery(); //выполнение
				System.Data.DataTable dt2 = new System.Data.DataTable();
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				da2.Fill(dt2);
				int dayy = 0;
				int monthy = 0;
				int yeary = 0;
				int idd = 0;
				OleDbCommand sql1 = new OleDbCommand("SELECT archives.id_archive, archives.id_user, (SELECT  users.user_name FROM users WHERE id_user=[archives].id_user) AS ФИО, head_archive AS Название, org_archive AS Организация, orgs_archive AS Сокращение, day_archive&'.'&month_archive&'.'&date_archive AS Получен, kat_hour AS Часы,document_archive AS Документ, datee_archive, daykat_archive,month_archive,day_archive FROM[archives] order by datee_archive DESC;"); // создаем запрос
			sql1.Connection = oleDbConn2; // привязываем запрос к конекту
			sql1.ExecuteNonQuery(); //выполнение
			System.Data.DataTable dt1 = new System.Data.DataTable();
			OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
			da1.Fill(dt1);
			//dt1.Columns["id_user"].ColumnName = "Номер";
			dt1.Columns["datee_archive"].ColumnName = "Действует до";
			allcourse.DataSource = dt1;
			mass=new string[allcourse.Rows.Count - 1];
			for (int i = 0; i < allcourse.Rows.Count - 1; i++)
			{
					int idn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(1).ToString());
					for (int ii = 0; ii <= dt2.Rows.Count - 1; ii++)
					{
						idd = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(0).ToString());
						if (idn == idd)
						{
							string dates = dt2.Rows[ii].ItemArray.GetValue(18).ToString();
							string[] datemass = dates.Split('.');
							dayy = Convert.ToInt32(datemass[0]);
							monthy = Convert.ToInt32(datemass[1]);
							yeary = Convert.ToInt32(datemass[2]);
						}
					}
					int yearn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(9).ToString()) - 5;
					int dayn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(12).ToString());
					int monthn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(11).ToString());
					if (dayn >= dayy && monthn >= monthy && yearn >= yeary || dayn < dayy && monthn > monthy && yearn >= yeary || dayn >= dayy && monthn < monthy && yearn > yeary || dayn < dayy && monthn < monthy && yearn > yeary)
					{
						//dayn>=dayy && monthn>=monthy && yearn>=yeary || dayn < dayy && monthn > monthy && yearn >= yeary || dayn >= dayy && monthn < monthy && yearn > yeary
					}
					else
					{
						allcourse.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
					}
				}
				allcourse.Columns[0].Visible = false;
				allcourse.Columns[1].Visible = false;
				allcourse.Columns[9].Visible = false;
				allcourse.Columns[10].Visible = false;
				allcourse.Columns[11].Visible = false;
				allcourse.Columns[12].Visible = false;
				allcourse.Columns[2].Width = 317;
				allcourse.Columns[1].Width = 60;
				allcourse.Columns[7].Width = 70;
				allcourse.Columns[3].Width = 200;
				oleDbConn2.Close();
			VISITS_COUNT();
			}
			catch (System.Data.OleDb.OleDbException)
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}
		//кнопки перехода
		private void button6_Click(object sender, EventArgs e)
		{
			users.key = 0;
			history main = new history();
			this.Visible = false;
			main.ShowDialog();
		}

		private void bhistory_Click(object sender, EventArgs e)
		{
			history main = new history();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void boptions_Click(object sender, EventArgs e)
		{
		}

		private void bactive_Click(object sender, EventArgs e)
		{
			active main = new active();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void archive_Load(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Today;
			for(int i = dt.Year;i>1980;i--)
			{
				qyear.Items.Add(i);
			}
			Updatetable();
		}

		private void qclose_Click(object sender, EventArgs e)//кнопка отчистки
		{
			qstring.Text = "";
			qact.Update();
			Updatetable();
			qmonth.SelectedIndex=-1;
			qyear.SelectedIndex = -1;
			qact.Checked = false;
			qzak.Checked = false;
			qzackc.Checked = false;
			qneactc.Checked = false;
			qneact.Checked = false;
		}

		private void qsearch_Click(object sender, EventArgs e)//Кнопка поиска
		{
			searchh = qstring.Text;
			searchm = "";
			searchy = "";
			searchact = "";
			searchzak = "";
			searchneact = "";
			search72 = "";
			search500 = "";
			int keys = 0;
			int keym = 0;
			int keyy = 0;
			int keyact = 0;
			int keyzak = 0;
			int keyneact = 0;
			int keyactc = 0;
			if (qstring.Text!="")//Выбор поиска
			{
				keys = 1;
				searchh= " Where (SELECT  users.user_name FROM users WHERE id_user=[archives].id_user) LIKE '%" + searchh + "%'";
			}
			if(qmonth.Text!="")
			{
				keym = 1;
				if(keys==1)
				{
					searchm=" and month_archive = "+qmonth.Text+"";
				}
				else
				{
					searchm = " where month_archive = " + qmonth.Text + "";
				}
			}
			if (qyear.Text != "")
			{
				keyy = 1;
				if (keys == 1 || keym==1)
				{
					searchy = " and date_archive = " + qyear.Text + "";
				}
				else
				{
					searchy = " where date_archive = " + qyear.Text + "";
				}
			}
			DateTime dt = DateTime.Today;
			int yer = dt.Year + 1;
			if (qact.Checked==true)
			{
				keyact = 1;
			}
			if (qzak.Checked == true)
			{
				keyzak = 1;
				if (keys == 1 || keym == 1 || keyy == 1)
				{
					searchzak = " and kat_hour>=" + 16 + " and kat_hour<=" + 72+" ";
				}
				else
				{
					searchzak = " where kat_hour>=" + 16 + " and kat_hour<=" + 72 + " ";
				}
			}
			if (qneact.Checked == true)
			{
				keyneact = 1;
				if (keys == 1 || keym == 1 || keyy == 1 || keyzak==1)
				{
					searchneact = "and kat_hour >= " + 250 + " and kat_hour<= " + 500+" ";
				}
				else
				{
					searchneact = "where kat_hour>=" + 250 + " and kat_hour<=" + 500 + " ";
				}
			}
			if (qzackc.Checked == true)
			{
				keyactc = 1;
				if (keys == 1 || keym == 1 || keyy == 1 || keyzak == 1 || keyneact == 1)
				{
					search72 = "and kat_hour >= " + 72 + " ";
				}
				else
				{
					search72 = "where kat_hour>=" + 72 + " ";
				}
			}
			if (qneactc.Checked == true)
			{
				if (keys == 1 || keym == 1 || keyy == 1 || keyzak == 1 || keyneact == 1 || keyactc == 1)
				{
					search500 = "and kat_hour >= " + 500 + " ";
				}
				else
				{
					search500 = "where kat_hour>=" + 500 + " ";
				}
			}
			OleDbConnection oleDbConn2 = new OleDbConnection(con1);
			oleDbConn2.Open(); // открываем подключение к базе
			OleDbCommand sql2 = new OleDbCommand("SELECT * FROM users;"); // создаем запрос
			sql2.Connection = oleDbConn2; // привязываем запрос к конекту
			sql2.ExecuteNonQuery(); //выполнение
			System.Data.DataTable dt2 = new System.Data.DataTable();
			OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
			da2.Fill(dt2);
			int dayy =0;
			int monthy =0;
			int yeary = 0;
			int idd = 0;
			OleDbCommand sql1 = new OleDbCommand("SELECT archives.id_archive, archives.id_user, (SELECT  users.user_name FROM users WHERE id_user=[archives].id_user) AS ФИО, head_archive AS Название, org_archive AS Организация, orgs_archive AS Сокращение, day_archive&'.'&month_archive&'.'&date_archive AS Получен, kat_hour AS Часы,document_archive AS Документ, datee_archive, daykat_archive,month_archive,day_archive FROM[archives] " + searchh + " "+searchm+" "+searchy + " " +searchact + " " + searchzak + " " + searchneact+" "+search72+ " " + search500 + " order by datee_archive DESC;");
			sql1.Connection = oleDbConn2; // привязываем запрос к конекту
			sql1.ExecuteNonQuery(); //выполнение
			System.Data.DataTable dt1 = new System.Data.DataTable();
			OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
			da1.Fill(dt1);
			//dt1.Columns["id_archive"].ColumnName = "№";
			//dt1.Columns["id_user"].ColumnName = "Номер";
			dt1.Columns["datee_archive"].ColumnName = "Действует до";
			allcourse.Columns[0].Visible = false;
			allcourse.Columns[1].Visible = false;
			allcourse.Columns[9].Visible = false;
			allcourse.DataSource = dt1;
			allcourse.Columns[10].Visible = false;
			allcourse.Columns[11].Visible = false;
			allcourse.Columns[12].Visible = false;
			allcourse.Columns[2].Width = 317;
			allcourse.Columns[1].Width = 60;
			allcourse.Columns[7].Width = 70;
			allcourse.Columns[3].Width = 200;
			try
			{
				for (int i = 0; i < allcourse.Rows.Count - 1; i++)
				{
					int idn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(1).ToString());
					for (int ii = 0; ii <= dt2.Rows.Count-1; ii++)
					{
						idd = Convert.ToInt32(dt2.Rows[ii].ItemArray.GetValue(0).ToString());
						if (idn == idd)
						{
							string dates = dt2.Rows[ii].ItemArray.GetValue(18).ToString();
							string[] datemass = dates.Split('.');
							dayy = Convert.ToInt32(datemass[0]);
							monthy = Convert.ToInt32(datemass[1]);
							yeary = Convert.ToInt32(datemass[2]);
						}
					}
					int yearn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(9).ToString()) - 5;
					int monthn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(11).ToString());
					int dayn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(12).ToString());
					if (dayn >= dayy && monthn >= monthy && yearn >= yeary || dayn < dayy && monthn > monthy && yearn >= yeary || dayn >= dayy && monthn < monthy && yearn > yeary || dayn < dayy && monthn < monthy && yearn > yeary)
					{
						//dayn>=dayy && monthn>=monthy && yearn>=yeary || dayn < dayy && monthn > monthy && yearn >= yeary || dayn >= dayy && monthn < monthy && yearn > yeary
					}
					else
					{
						allcourse.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
						//allcourse.Rows[i].Visible = false;
					}
				}
			}
			catch
			{
				allcourse.DataSource = dt1;
			}
			oleDbConn2.Close();
			if (keyact == 1)
			{
				for (int i=allcourse.Rows.Count - 1; i >= 0; i--)
				{
					if (allcourse.Rows[i].DefaultCellStyle.ForeColor == Color.Green)
					{
						//allcourse.Rows[i].Visible = false;
						allcourse.Rows.Remove(allcourse.Rows[i]);
					}
				}
			}
			qamg.Text = "Количество записей: " + Convert.ToInt32(allcourse.Rows.Count - 1);
		}

		private void button1_Click(object sender, EventArgs e)//переход на справочник
		{
			users.key = 0;
			specialists.key = 1;
			users main = new users();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			active main = new active();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void allcourse_Sorted(object sender, EventArgs e)
		{
			Updatetable();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			helper.key = 2;
			helper main = new helper();
			//this.Visible = false;
			main.ShowDialog();
		}

		private void qexport_Click(object sender, EventArgs e)//экспорт данных в word таблицу
		{
			try
			{
			//string pats = System.IO.Directory.GetCurrentDirectory() + @"\" + "Exhel.xls";
			Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
			//Microsoft.Office.Interop.Excel.Workbook ExcelWB = ExcelApp.Workbooks.Add();
			//Microsoft.Office.Interop.Excel.Worksheet ExcelWS = ExcelWB.ActiveSheet;

			ExcelApp.Application.Workbooks.Add(Type.Missing);
			ExcelApp.Cells[1, 1] = "Журнал курсов";
			ExcelApp.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
			ExcelApp.get_Range("A1", "H1").Merge(false);
			ExcelApp.Cells[2, 1] = "№";
			ExcelApp.Cells[2, 2] = "ФИО";
			ExcelApp.Cells[2, 3] = "Название";
			ExcelApp.Cells[2, 4] = "Организация";
			ExcelApp.Cells[2, 5] = "Сокращение";
			ExcelApp.Cells[2, 6] = "Получен";
			ExcelApp.Cells[2, 7] = "Часы";
			ExcelApp.Cells[2, 8] = "Документ";

			for (int i = 0; i < allcourse.ColumnCount-5; i++)
			{
				for (int j = 0; j < allcourse.RowCount-1; j++)
				{
					if (i == 0)
					{
						ExcelApp.Cells[j + 3, i + 1] = j+1;
					}
					else
					{
						ExcelApp.Cells[j + 3, i + 1] = allcourse[i+1, j].Value.ToString();
					}
				}
			}
			ExcelApp.Columns.AutoFit();
			ExcelApp.Rows.AutoFit();
			//ExcelApp.get_Range("A1", "A1").HorizontalAlignment.Center;
			//ExcelApp.get_Range("A1","I2").HorizontalAlignment = HorizontalAlignment.Right;
			ExcelApp.get_Range("A2", "H"+ Convert.ToString(allcourse.RowCount+1)).Borders.Color=Color.Black;
			//ExcelApp.NewWorkbook("hggh");
			ExcelApp.Visible = true;
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}
		private void qstring_KeyPress(object sender, KeyPressEventArgs e)// проверка ввода
		{
			if (e.KeyChar < 'А' && e.KeyChar != 8 && e.KeyChar != 32 || e.KeyChar > 'я' && e.KeyChar != 8 && e.KeyChar != 32)
			{
				e.Handled = true;
			}
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
		}

		private void qneactc_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
