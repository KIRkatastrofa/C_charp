using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diplom_RedkinK
{
	public partial class helper : Form
	{
		public static int key = 0;
		public helper()
		{
			InitializeComponent();
		}

		private void qclose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void helper_Load(object sender, EventArgs e)
		{
			if(key==1)
			{
				label1.Text = "Красная запись - сотрудники которые должны пройти курсы";
			}
			else if(key==2)
			{
				label1.Text =@"Зеленная запись - не активные курсы 
Черная - запись актуальная по сроку действия категории";
			}

		}
	}
}
