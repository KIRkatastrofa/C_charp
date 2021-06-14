using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Diplom_RedkinK
{
	public partial class predpros : Form
	{
		public static int key = 0;
		string connStr = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + "";
		public predpros()
		{
			InitializeComponent();
		}
		private void qExit_Click(object sender, EventArgs e)
		{
			specialists.key = 1;
			if (key==1)
			{
				users main = new users();//false
				this.Visible = false;
				main.ShowDialog();
			}
			else
			{
				active main = new active();//false
				this.Visible = false;
				main.ShowDialog();
			}
		}

		private void button1_Click(object sender, EventArgs e)//вывод отчета в MS Word
		{
			try
			{
				//#############################################################
				int RowCount = allcourse.Rows.Count;
				int ColumnCount = allcourse.Columns.Count-3;
				Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

				//добавление рядов
				int r = 0;
				for (int c = 0; c <= ColumnCount - 1; c++)
				{
					for (r = 0; r <= RowCount-1; r++)
					{
						DataArray[r, c] = allcourse.Rows[r].Cells[c].Value;
					}
				}
				Word.Application applicationl = new Word.Application();
				Word.Document oDoc = applicationl.Documents.Open(Directory.GetCurrentDirectory() + @"\шаблон\template.docx");
				oDoc.Application.Visible = true;


				Word.Range oRange1 = oDoc.Range();
				dynamic oRange = oDoc.Content.Application.Selection.Range;
				string oTemp = "";
				for (r = 0; r < RowCount+1; r++)
				{
					for (int c = 0; c < ColumnCount; c++)
					{
						if (r + 1 == RowCount+1 && c >= 5)
						{
							oTemp = oTemp + DataArray[r, c];
						}
						else
						{
							//заполнение данных в массив
							oTemp = oTemp + DataArray[r, c] + "%";
						}
					}
				}
				string[] str = oTemp.Split('%');
				int yu = -1;
				int ii = -1;
				int i = 0;
				int n = 1;
				Word.Range rng = oDoc.Range();
				Word.Table t = oDoc.Tables.Add(oDoc.Paragraphs[25].Range, RowCount+1, ColumnCount);
				t.Columns[1].Width = 30;
				t.Columns[2].Width = 180;
				t.Columns[5].Width = 40;
				t.Columns[3].Width = 120;
				t.Columns[4].Width = 70;
				//t.Columns[7].Width = 80;
				t.Borders.Enable = 1;
				r = 0;
				foreach (Word.Row row in t.Rows)
				{
					foreach (Word.Cell cell in row.Cells)
					{
						if (cell.RowIndex == 1)
						{
							ii++;
							if (ii < ColumnCount)
							{
								cell.Range.Text = allcourse.Columns[ii].HeaderText;//заголовок
							}
							//стиль таблицы
							cell.Range.Font.Name = "times new roman";
							cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
							cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
						}
						else if (r <= RowCount+5)
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
							cell.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
						}
					}
					r++;
				}
				//#############################################################
				//заполнение шаблона
				ReplaceWordStub("{tabNumber}", specialists.iduser, oDoc);
				ReplaceWordStub("{Fn}", specialists.Fn, oDoc);
				ReplaceWordStub("{In}", specialists.In, oDoc);
				ReplaceWordStub("{On}", specialists.On, oDoc);
				ReplaceWordStub("{obr}", specialists.obr, oDoc);
				ReplaceWordStub("{dateof}", specialists.qdayof, oDoc);
				ReplaceWordStub("{Kv}", specialists.Kv, oDoc);
				ReplaceWordStub("{dol}", specialists.dol, oDoc);
				ReplaceWordStub("{diplom}", specialists.op, oDoc);
				ReplaceWordStub("{Os}", specialists.Os, oDoc);
				ReplaceWordStub("{Ps}", specialists.Ps, oDoc);
				ReplaceWordStub("{kat}", specialists.kat, oDoc);
				ReplaceWordStub("{srok}", specialists.srok, oDoc);
				ReplaceWordStub("{datekat}", specialists.qdaykat, oDoc);
			}
			catch (Exception)
			{
			}
		}
		private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
		{
			var range = wordDocument.Content;
			range.Find.ClearFormatting();
			range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
		}

		private void predpros_Load(object sender, EventArgs e)
		{

			textBox1.Text = specialists.iduser;
			qF.Text = specialists.Fn;
			qI.Text = specialists.In;
			qO.Text = specialists.On;
			qobr.Text = specialists.obr;
			qKv.Text = specialists.Kv;
			qdol.Text = specialists.dol;
			qkat.Text = specialists.kat;
			qop.Text = specialists.op;
			qSrok.Text = specialists.srok;
			qOs.Text = specialists.Os;
			qPs.Text = specialists.Ps;
			qdayof.Text = specialists.qdayof;
			qdaykat.Text = specialists.qdaykat;
			DateTime dt = DateTime.Today;

			try
			{
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM archives Where id_user=" + specialists.iduser + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				conn1.Close();
				Update();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}
		public void Update()
		{
			try
			{
				OleDbConnection oleDbConn1 = new OleDbConnection(connStr); // создаем подключение
				DataTable dt1 = new DataTable(); // создаем таблицу 
				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM users Where id_user=" + specialists.iduser + ";"); // создаем запрос
				sql2.Connection = oleDbConn1; // привязываем запрос к конекту
				sql2.ExecuteNonQuery(); //выполнение
				DataTable dt2 = new DataTable();
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				da2.Fill(dt2);
				string dates = dt2.Rows[0].ItemArray.GetValue(18).ToString();
				string[] datemass = dates.Split('.');
				int monthy = Convert.ToInt32(datemass[1]);
				int dayy = Convert.ToInt32(datemass[0]);
				int yeary = Convert.ToInt32(datemass[2]);
				OleDbCommand sql1 = new OleDbCommand("SELECT archives.id_user, head_archive AS Название, org_archive AS Организация, day_archive&'.'&month_archive&'.' & date_archive AS Получен, kat_hour AS Часы, document_archive AS Документ,datee_archive, month_archive,day_archive FROM[archives] Where id_user = " + specialists.iduser + " order by datee_archive Desc; ");
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение

				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				dt1.Columns["id_user"].ColumnName = "№";
				//dt1.Columns["datee_archive"].ColumnName = "Срок до";
				allcourse.DataSource = dt1;
				allcourse.Columns[1].Width = 120;
				allcourse.Columns[4].Width = 30;
				allcourse.Columns[6].Visible = false;
				allcourse.Columns[7].Visible = false;
				allcourse.Columns[8].Visible = false;
				allcourse.Columns[0].Visible = false;
				//allcourse.Columns[7].Visible = false;
				for (int i = 0; i < allcourse.Rows.Count; i++)
				{
					int yearn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(6).ToString()) - 5;
					int monthn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(7).ToString());
					int dayn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(8).ToString());
					if (dayn >= dayy && monthn >= monthy && yearn >= yeary || dayn < dayy && monthn > monthy && yearn >= yeary || dayn >= dayy && monthn < monthy && yearn > yeary || dayn < dayy && monthn < monthy && yearn > yeary)
					{
						//dayn>=dayy && monthn>=monthy && yearn>=yeary || dayn < dayy && monthn > monthy && yearn >= yeary || dayn >= dayy && monthn < monthy && yearn > yeary
					}
					else
					{
						allcourse.Rows[i].DefaultCellStyle.ForeColor = Color.DarkGray;
					}
				}
				//allcourse.Rows..Visible = false;
				oleDbConn1.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}

		private void qact_CheckedChanged(object sender, EventArgs e)//проверка на актуальность 
		{
			try
			{
				if (qact.Checked == true)
				{
					for (int i = allcourse.Rows.Count - 1; i >= 0; i--)
					{
						if (allcourse.Rows[i].DefaultCellStyle.ForeColor == Color.DarkGray)
						{
							//allcourse.Rows[i].Visible = false;
							allcourse.Rows.Remove(allcourse.Rows[i]);
						}
					}
				}
				else
				{
					Update();
				}
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}
	}
}
