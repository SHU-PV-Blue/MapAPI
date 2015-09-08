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

namespace TestAmapAPI
{
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	[System.Runtime.InteropServices.ComVisibleAttribute(true)]
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			webBrowser1.ObjectForScripting = this;
			webBrowser1.DocumentText = Properties.Resources.HtmlCode;
		}

		public void SendLocation(String lon, String lat)
		{
			textBox1.Text = lon;
			textBox2.Text = lat;
		}
	}
}
