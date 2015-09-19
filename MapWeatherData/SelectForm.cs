using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SHUPV.Database;
using SHUPV.Database.Connection;
using SHUPV.Database.Core;
//using MapWeatherData.Properties;

namespace MapWeatherData
{
	
	public partial class SelectForm : Form
	{
		WeatherData weatherData = new WeatherData();

		public SelectForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// bool行参数
		/// 值为true：关闭所有窗口
		/// 值为false：调出地图窗口
		/// </summary>
		public bool _close;

		/// <summary>
		/// 选择数据类的提示信息
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblPartInfo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("这一项是选择天气数据类。");
		}

		/// <summary>
		/// 选择数据项的提示信息
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblTableInfo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("这一项是选着在上面的天气数据类别下面的具体的天气数据项表格");
		}

		private void SelectForm_Load(object sender, EventArgs e)
		{
			lblLon.Text = "经度：" + MapForm._lon.ToString();
			lblLat.Text = "纬度：" + MapForm._lat.ToString() ;

			List<string> dataPart = weatherData.GetPartNames();
			//cbxSelectPart.DataSource = dataPart;
			cbxSelectPart.Items.AddRange(dataPart.ToArray());
			cbxSelectPart.Text = dataPart.ToArray().GetValue(1).ToString();
		}

		private void cbxSelectPart_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> dataTables = weatherData.GetTableNames(cbxSelectPart.Text.ToString());
			cbxSelectTable.Items.AddRange(dataTables.ToArray());
			cbxSelectTable.Text = dataTables.ToArray().GetValue(1).ToString();
		}

		private void btnSelectCoord_Click(object sender, EventArgs e)
		{
			this.Close();
			_close = false;
		}
	}
}
