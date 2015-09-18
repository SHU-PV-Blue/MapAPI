using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using SHUPV.Database;

namespace TestAmapAPI
{
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class fmMapFrom : Form
	{

		public double _lon;		//经度
		public double _lat;		//纬度

		/// <summary>
		/// 初始界面
		/// </summary>
		public fmMapFrom()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 初始化函数，调用浏览器控件，显示地图、。
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			webBrowser1.ObjectForScripting = this;
			webBrowser1.DocumentText = Properties.Resources.HtmlCode;
		}

		/// <summary>
		/// 传出经纬度数据
		/// lon：经度
		/// lat：纬度
		/// </summary>
		/// <param name="lon"></param>
		/// <param name="lat"></param>
		public void SendLocation(String lon, String lat)
		{
			textBox1.Text = lon;
			textBox2.Text = lat;
			_lon = Convert.ToDouble(lon);
			_lat = Convert.ToDouble(lat);
		}

		private void btnSendCoord_Click(object sender, EventArgs e)
		{

		}
	}
}
