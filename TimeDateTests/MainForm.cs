using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace TimeDateTests
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void BtTestClick(object sender, EventArgs e)
		{
			if(Convert.ToDateTime(tbDTNow.Text)<Convert.ToDateTime("06:00")){
				lbShift.Text="Noche";
			}else{
				
				if(Convert.ToDateTime(tbDTNow.Text)<Convert.ToDateTime("14:00")){
					lbShift.Text="Mañana";
				}else{
					if(Convert.ToDateTime(tbDTNow.Text)<Convert.ToDateTime("22:00")){
						lbShift.Text="Tarde";
					}else{
						lbShift.Text="Noche";
					}
				}
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			tbDTNow.Text=DateTime.Now.ToString("HH:MM");
		}
	}
}
/*
		string Filtro;
		DateTime dt1 = DateTime.Now;
		DateTime dtb = Convert.ToDateTime("07:00:00");
	                                  
		if(dt1.TimeOfDay < dtb.TimeOfDay){
			Filtro = "'" + dt1.Date.ToString("yyyy-MM") + "-" + (Convert.ToInt32(dt1.Day)-1).ToString() + " 07:00:00' and '" + dt1.ToString("yyyy-MM-dd") + " 06:59:59'";
		}else{
			Filtro = "'" + dt1.ToString("yyyy-MM-dd")  + " 07:00:00' and '" + dt1.Date.ToString("yyyy-MM") + "-" + (Convert.ToInt32(dt1.Day)+1).ToString() +" 06:59:59'" ;
		}
*/