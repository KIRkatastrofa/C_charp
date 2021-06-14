using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Diplom_RedkinK
{
	public partial class active : Form
	{
		string idcourse = "";
		int colh = 0;
		int coll = 0;
		int id_specialist;
		string FIO = "";
		string dateof = "";
		string mail = "";
		string category = "";
		string status = "";
		string days = "";
		string daym = "";
		string monthm = "";
		string yearm = "";
		int col_hours = 0;
		int years = 0;
		public static int N = 0;
		public static int NN = 0;
		string connStr = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + login.namebd + ".mdb;" + login.passwbds + "";
		public active()
		{
			InitializeComponent();
		}

		private void active_Load(object sender, EventArgs e)
		{
			qFIO.Text = specialists.Fn + " " + specialists.In + " " + specialists.On;
			Uppdate();
		}
		public void Uppdate()//Обновление Datagridview
		{
			try
			{
				DateTime dt = DateTime.Today;
				OleDbConnection oleDbConn2 = new OleDbConnection(connStr);
				oleDbConn2.Open(); // открываем подключение к базе
				OleDbCommand sql2 = new OleDbCommand("SELECT * FROM users Where id_user=" + specialists.iduser + ";"); // создаем запрос
				sql2.Connection = oleDbConn2; // привязываем запрос к конекту
				sql2.ExecuteNonQuery(); //выполнение
				DataTable dt2 = new DataTable();
				OleDbDataAdapter da2 = new OleDbDataAdapter(sql2);
				da2.Fill(dt2);
				string dates = dt2.Rows[0].ItemArray.GetValue(18).ToString();
				string[] datemass = dates.Split('.');
				int monthy = Convert.ToInt32(datemass[1]);
				int dayy = Convert.ToInt32(datemass[0]);
				int yeary = Convert.ToInt32(datemass[2]);
				oleDbConn2.Close();
				OleDbConnection oleDbConn1 = new OleDbConnection(connStr);
				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql1 = new OleDbCommand("SELECT archives.id_archive, archives.id_user, (SELECT  users.user_name FROM users WHERE id_user=[archives].id_user) AS ФИО, head_archive AS Название, org_archive AS Организация, orgs_archive AS Сокращение, day_archive&'.'&month_archive&'.'&date_archive AS Получен, kat_hour AS Часы,document_archive AS Документ, datee_archive, daykat_archive,month_archive,day_archive FROM[archives] Where id_user=" + specialists.iduser + " order by datee_archive Desc;"); // создаем запрос
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение
				DataTable dt1 = new DataTable();
				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				dt1.Columns["id_user"].ColumnName = "№";
				dt1.Columns["datee_archive"].ColumnName = "Действует до";
				allcourse.DataSource = dt1;
				for (int i = 0; i < allcourse.Rows.Count - 1; i++)
				{
				int yearn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(9).ToString())-5;
				int monthn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(11).ToString());
				int dayn = Convert.ToInt32(dt1.Rows[i].ItemArray.GetValue(12).ToString());
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
				allcourse.Columns[2].Visible = false;
				allcourse.Columns[10].Visible = false;
				allcourse.Columns[9].Visible = false;
				allcourse.Columns[11].Visible = false;
				allcourse.Columns[5].Visible = false;
				allcourse.Columns[12].Visible = false;
				//allcourse.Columns[2].Width = 317;
				//allcourse.Columns[1].Width = 60;
				allcourse.Columns[7].Width = 120;
				allcourse.Columns[3].Width = 517;
				allcourse.Columns[4].Width = 200;

				oleDbConn1.Close();
				qamg.Text = "Количество записей: " + Convert.ToString(Convert.ToInt32(allcourse.Rows.Count - 1));
		}
			catch
			{

			}
		}
		//##################---счетчик----#######################
		public void VISITS_COUNT2()
		{
			try
			{
				OleDbConnection oleDbConn1 = new OleDbConnection(connStr); // создаем подключение
				DataTable dt1 = new DataTable(); // создаем таблицу 

				oleDbConn1.Open(); // открываем подключение к базе
				OleDbCommand sql1 = new OleDbCommand("SELECT COUNT(*) FROM [archives];"); // создаем запрос
				sql1.Connection = oleDbConn1; // привязываем запрос к конекту
				sql1.ExecuteNonQuery(); //выполнение

				OleDbDataAdapter da1 = new OleDbDataAdapter(sql1);
				da1.Fill(dt1);
				//qamg.Text = "Количество записей: " + dt1.Rows[0].ItemArray.GetValue(0).ToString();
				NN = Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(0).ToString());
				oleDbConn1.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! База данных не найдена!", "Сообщение пользователю", MessageBoxButtons.OK);
			}
		}
		//кнопки перехода
		private void bhistory_Click(object sender, EventArgs e)
		{
			history main = new history();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void barchive_Click(object sender, EventArgs e)
		{
			archive main = new archive();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void boptions_Click(object sender, EventArgs e)
		{
		}

		private void bactive_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			ToolTip t = new ToolTip();
			t.SetToolTip(button6, "Личная карточка");

			specialists.key = 1;
			specialists main = new specialists();//false
			this.Visible = false;
			main.ShowDialog();
		}
		//################################################
		
		private void bup_Click(object sender, EventArgs e)//кнопка обновления данных работника
		{
			try
			{
				if (qdocument.Text == "" || qn.Text == "" || qorg.Text == "" || qorgs.Text == "" || qhead.Text == "" || dayok.Text == "" || qh.Text == "")
				{
					MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					DateTime dt = DateTime.Today;
					string sroks = "";
					//^^^^
					string dates = dayok.Text;
					string[] datemass = dates.Split('.');
					daym = datemass[0];
					monthm = datemass[1];
					yearm = datemass[2];
					status = Convert.ToString(Convert.ToInt32(yearm) + 5);
					coll = col_hours + Convert.ToInt32(qh.Text);//добавление часов
                    //OleDbConnection conn1 = new OleDbConnection(connStr);
                    //conn1.Open();
                    //OleDbCommand sql = new OleDbCommand("UPDATE users SET hours_kat=" + Convert.ToInt32(col_hours) + sroks + " Where id_user=" + Convert.ToInt32(id_specialist) + ";");
                    //sql.Connection = conn1;
                    //sql.ExecuteNonQuery();
                    //conn1.Close();
					archiver();
				}
			}
			catch
			{
				MessageBox.Show("Заполните поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		public void archiver()//функция добавления курсов
		{
			try
			{
				years = Convert.ToInt32(yearm);
				DateTime DT = DateTime.Today;
				int id = Convert.ToInt32(qn.Text);
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				string[] st = specialists.qdaykat.Split('.');
				string yearK = st[1]+"."+st[2];
				OleDbCommand sql = new OleDbCommand("INSERT INTO archives (id_archive,id_user,document_archive,org_archive,head_archive,day_archive,date_archive,kat_hour,orgs_archive,month_archive,datee_archive,daykat_archive) VALUES (" + id + "," + specialists.iduser + ",'" + qdocument.Text + "','" + qorg.Text + "','" + qhead.Text + "','" + daym + "'," + years + "," + Convert.ToInt32(qh.Text) + ",'" + qorgs.Text + "','" + monthm + "'," + status + ",'" + yearK + "');");
				sql.Connection = conn1;
				sql.ExecuteNonQuery();
				conn1.Close();
				qn.Text = "";
				MessageBox.Show("Курс добавлен!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Uppdate();
			}
			catch
			{
				MessageBox.Show("Заполните поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void bact_Click(object sender, EventArgs e)
		{

		}

		private void allcourse_Sorted(object sender, EventArgs e)
		{
			Uppdate();
		}

		private void allcourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//управление элементами Datagridview
		{
			try
			{
				idcourse = allcourse.SelectedCells[0].Value.ToString();
				OleDbConnection conn1 = new OleDbConnection(connStr);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM archives Where id_archive = " + Convert.ToInt32(idcourse) + ";");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				DateTime dt = DateTime.Today;
				qn.Text = idcourse;
				qn.Enabled = false;
				qdocument.Text = dt1.Rows[0].ItemArray.GetValue(2).ToString();
				qorg.Text = dt1.Rows[0].ItemArray.GetValue(3).ToString();
				qhead.Text = dt1.Rows[0].ItemArray.GetValue(4).ToString();
				string daym = dt1.Rows[0].ItemArray.GetValue(5).ToString();
				string monthm = dt1.Rows[0].ItemArray.GetValue(8).ToString();
				yearm = dt1.Rows[0].ItemArray.GetValue(6).ToString();
				dayok.Text = daym + "." + monthm + "." + yearm;
				qh.Text = dt1.Rows[0].ItemArray.GetValue(7).ToString();
				qorgs.Text = dt1.Rows[0].ItemArray.GetValue(10).ToString();
				qEd.Enabled = true;
				qDel.Enabled = true;
				bup.Enabled = false;
				button1.Enabled = true;
				conn1.Close();
			}
			catch
			{
				qn.Text = "";
				qn.Enabled = true;
				qorg.Text = "";
				qhead.Text = "";
				qh.Text = "";
				qorgs.Text = "";
				qEd.Enabled = false;
				qDel.Enabled = false;
				bup.Enabled = true;
				button1.Enabled = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			qn.Text = "";
			qn.Enabled = true;
			qorg.Text = "";
			qhead.Text = "";
			qh.Text = "";
			qorgs.Text = "";
			qEd.Enabled = false;
			qDel.Enabled = false;
			bup.Enabled = true;
			button1.Enabled = false;
		}

		private void qEd_Click(object sender, EventArgs e)//редактирование курсов
		{
			if (qdocument.Text == "" || qn.Text == "" || qorg.Text == "" || qorgs.Text == "" || qhead.Text == "" || dayok.Text == "" || qh.Text == "")
			{
				MessageBox.Show("Ошибка! Заполните все поля!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				try
				{
					DialogResult dialogResult = MessageBox.Show("Редактировать данные?", "Сообщение пользователю", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (dialogResult == DialogResult.Yes)
					{
						string[] st = specialists.qdaykat.Split('.');
						string yearK = st[1]+"."+st[2];
						string dates = dayok.Text;
						string[] datemass = dates.Split('.');
						daym = datemass[0];
						monthm = datemass[1];
						yearm = datemass[2];
						status = Convert.ToString(Convert.ToInt32(yearm) + 5);
						int id = Convert.ToInt32(qn.Text);
						OleDbConnection conn1 = new OleDbConnection(connStr);
						conn1.Open();
						OleDbCommand sql = new OleDbCommand("Update archives set document_archive='" + qdocument.Text + "',org_archive='" + qorg.Text + "',head_archive='" + qhead.Text + "',day_archive='" + daym + "',date_archive=" + Convert.ToInt32(yearm) + ",kat_hour=" + Convert.ToInt32(qh.Text) + ",orgs_archive='" + qorgs.Text + "',month_archive='" + monthm + "',datee_archive=" + status + ",daykat_archive='"+yearK+"' where id_archive=" + idcourse + ";");
						sql.Connection = conn1;
						sql.ExecuteNonQuery();
						conn1.Close();
						MessageBox.Show("Курс обновлен!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Uppdate();
					}
				}
				catch
				{

				}
			}
		}

		private void qDel_Click(object sender, EventArgs e)//удаление курсов
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("Удалить данные?", "Сообщение пользователю", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				if (dialogResult == DialogResult.Yes)
				{
					OleDbConnection conn1 = new OleDbConnection(connStr);
					conn1.Open();
					OleDbCommand sql = new OleDbCommand("DELETE FROM archives Where id_archive=" + idcourse + ";");
					sql.Connection = conn1;
					sql.ExecuteNonQuery();
					conn1.Close();
					MessageBox.Show("Данные удалены", "Сообщение пользователю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					qn.Text = "";
					qn.Enabled = true;
					qorg.Text = "";
					qhead.Text = "";
					qh.Text = "";
					qorgs.Text = "";
					qEd.Enabled = false;
					qDel.Enabled = false;
					bup.Enabled = true;
					button1.Enabled = false;
					Uppdate();
				}
			}
			catch
			{

			}
		}

		private void qh_KeyPress(object sender, KeyPressEventArgs e)//проверка на ввод текста
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

		private void qh_TextChanged(object sender, EventArgs e)//проверка на изменение текста
		{
			if (qh.Text == "0")// && k >= 5)
			{
				qh.Text = "1";
			}
			if (qn.Text == "0")// && k >= 5)
			{
				qn.Text = "1";
			}
		}

		private void qsee_Click(object sender, EventArgs e)
		{
			predpros.key = 2;
			predpros main = new predpros();//false
			this.Visible = false;
			main.ShowDialog();
		}

		private void button6_MouseHover(object sender, EventArgs e)
		{
			ToolTip t = new ToolTip();
			t.SetToolTip(button6, "Сотрудники");
		}
	}
}
