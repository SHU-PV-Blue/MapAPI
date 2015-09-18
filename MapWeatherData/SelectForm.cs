using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapWeatherData
{
	public partial class SelectForm : Form
	{
		public SelectForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("这一项是选择天气数据类。");
		}
	}
}
