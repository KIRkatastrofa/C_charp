using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.IO;
namespace Diplom_RedkinK
{
	public partial class login : Form
	{
		public static int log = 0;
		public static int iduser = 0;
		public static int ch = 0;
		public static string loginu = "";	//статус
		public static string lFIO = "";
		public static string login_user = ""; //логин пользователя
		
		public static string loginIT = "";
		public static string PasswordIT = "";

		public static int startPO = 0;

		public static string namebd = "Diplom";
		public static string passwbds = "Jet OLEDB:Database Password=root123";
		public static string passsymbol = "";
		public static string passtru = "";
		public static string mailspam = "";
		public static string passwspam = "";

		public static string dosad = "";
		public static string dosed = "";
		public static string dosde = "";
		public login()
		{
			InitializeComponent();
		}

		private void qExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		//##############---Проверка на пароль---################
		string GetHashPass(string password)
		{
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
		//################################################
		private void qEnter_Click(object sender, EventArgs e)//вход в систему
		{
			try
			{
				string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + namebd + ".mdb;" + passwbds + "";
				OleDbConnection oleDbConnect = new OleDbConnection(connect);
				oleDbConnect.Open();
				OleDbCommand sql = new OleDbCommand("SELECT * FROM user_u WHERE loginu = '" + login_user + "';");
				OleDbDataAdapter da = new OleDbDataAdapter(sql);
				DataTable dt = new DataTable();
				sql.Connection = oleDbConnect;
				sql.ExecuteNonQuery();
				oleDbConnect.Close();
			}
			catch//проверка на наличие базы
			{
				var mb = MessageBox.Show("Ошибка! База не найдена, вы хотите ее загрузить?", "Ошибка авторизации", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (mb == DialogResult.Yes)
				{
					OpenFileDialog opd = new OpenFileDialog();
					{
						MessageBox.Show("Загрузите нужную базу!", "Сообщение администратору", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
						opd.Filter = "(*.kat)|*.kat";
						if (opd.ShowDialog() == DialogResult.OK)
						{
							File.Copy(opd.FileName, "" + login.namebd + ".mdb", true);
							MessageBox.Show("База импортирована, перезапустите программу!", "Сообщение пользователю", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
			try//вход в систему
			{
				login_user = qlogin.Text;
					string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + namebd + ".mdb;" + passwbds + "";
					OleDbConnection oleDbConnect = new OleDbConnection(connect);
					oleDbConnect.Open();
					OleDbCommand sql = new OleDbCommand("SELECT * FROM user_u WHERE loginu = '" + login_user + "';");
					OleDbDataAdapter da = new OleDbDataAdapter(sql);
					DataTable dt = new DataTable();
					sql.Connection = oleDbConnect;
					sql.ExecuteNonQuery();
					da.Fill(dt);
					if (qlogin.Text != "" && qPassword.Text != "")
					{
						//получаем пароль
						string hashPassword = GetHashPass(qPassword.Text.ToString());
						string hashPasswordInDB = dt.Rows[0].ItemArray.GetValue(2).ToString();
						iduser = Convert.ToInt32(dt.Rows[0].ItemArray.GetValue(0).ToString());
						//string dostupD = dt.Rows[0].ItemArray.GetValue(19).ToString();
						//if (dostupD.Length > 10)
						//{
						//	string[] dostupm = dostupD.Split(':');
						//	dosad = dostupm[0];
						//	dosed = dostupm[1];
						//	dosde = dostupm[2];
						//}
						//--
						loginu = dt.Rows[0].ItemArray.GetValue(5).ToString();
						lFIO = dt.Rows[0].ItemArray.GetValue(3).ToString();
						//--
						if (hashPassword == hashPasswordInDB)
						{
							this.Visible = false;
							if (loginu != "3")
							{
								history main = new history();//false
								main.ShowDialog();
								this.Visible = false;
							}
							else
							{
								history main = new history();//true
								main.ShowDialog();
								this.Visible = false;
							}
						}
						else
						{
							MessageBox.Show("Введен не правильный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Введите данные", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					oleDbConnect.Close();
			}
			catch
			{
				MessageBox.Show("Ошибка! Данные введены не верна!", "Ошибка авторизации", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			}
		}
		private void login_Load(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Today;
			try
			{
				//startPO = 1;
				//using (StreamReader SR = new StreamReader("option.kat"))
				//{
				//	namebd=SR.ReadLine();
				//	passsymbol=SR.ReadLine();
				//	passtru=SR.ReadLine();
				//	mailspam = SR.ReadLine();
				//	passwspam = SR.ReadLine();
				//}
				//if (passtru=="ВЫКЛ")
				//{
				//	//breg.Enabled = false;
				//}
				qEnter.Text = "Авторизироваться";
			}
			catch
			{
				startPO = 0;
				//breg.Visible = false;
				var mb=MessageBox.Show("Первый запуск: Придумайте логин и пароль администратору!", "Сообщение администратору", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			try
			{
				string connect = "Provider= Microsoft.Jet.OLEDB.4.0; Data Source=" + namebd + ".mdb;" + passwbds + "";
				OleDbConnection conn1 = new OleDbConnection(connect);
				conn1.Open();
				DataTable dt1 = new DataTable();
				OleDbCommand sql1 = new OleDbCommand("SELECT * FROM settingO;");
				OleDbDataAdapter Data1 = new OleDbDataAdapter(sql1);
				sql1.Connection = conn1;
				sql1.ExecuteNonQuery();
				Data1.Fill(dt1);
				//резервное копирование 
				string day = Convert.ToString(dt.Day);
				string month = Convert.ToString(dt.Month);
				string year = Convert.ToString(dt.Year);
				if (day.Length != 2)
				{
					day = "0" + day;
				}
				if (month.Length != 2)
				{
					month = "0" + month;
				}
				int obr = Convert.ToInt32(dt1.Rows[0].ItemArray.GetValue(5).ToString());
				obr = obr - dt.Day;
				if (obr == -7 || obr > 0)
				{
					obr = dt.Day;
					OleDbCommand sql3 = new OleDbCommand("Update settingO set dayreserv='" + obr + "';");
					sql3.Connection = conn1;
					sql3.ExecuteNonQuery();
					Directory.CreateDirectory("Резерв");
					File.Copy("" + login.namebd + ".mdb", @"Резерв\" + day + "_" + month + "_" + year + ".kat", true);
				}
				conn1.Close();
			}
			catch
			{

			}
		}

		private void breg_Click(object sender, EventArgs e)
		{
		}
	}
}
