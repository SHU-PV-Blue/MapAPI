﻿using System;
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
		WeatherData _weatherData = new WeatherData();
		MapForm _parentForm;
		public SelectForm()
		{
			InitializeComponent();
		}
		public SelectForm(MapForm form)
		{
			_parentForm = form;
			InitializeComponent();
		}

		/// <summary>
		/// bool行参数
		/// 值为true：关闭所有窗口
		/// 值为false：调出地图窗口
		/// </summary>
		private bool _close = true;
		double lat = MapForm._lat;
		double lon = MapForm._lon;
		string partname, tablename;

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
			this.ClientSize = new System.Drawing.Size(820, 292);


			//this.btnSendArgu.Location = new System.Drawing.Point(149, 200);
			//this.btnSelectCoord.Location = new System.Drawing.Point(349, 200);
			//this.btnClose.Location = new System.Drawing.Point(535, 200);

			lblLon.Text = "经度：" + MapForm._lon.ToString();
			lblLat.Text = "纬度：" + MapForm._lat.ToString() ;

			List<string> dataPart = _weatherData.GetPartNames();
			//cbxSelectPart.DataSource = dataPart;
			cbxSelectPart.Items.AddRange(dataPart.ToArray());
			cbxSelectPart.Text = dataPart.ToArray().GetValue(0).ToString();

			lblTables.Visible = false;
			cbxSelectTable.Visible = false;
			lblTableInfo.Visible = false;

		}

		private void Show_cobxTable()
		{
			lblTables.Visible = true;
			cbxSelectTable.Visible = true;
			lblTableInfo.Visible = true;
		}

		private void cbxSelectPart_SelectedIndexChanged(object sender, EventArgs e)
		{

			Show_cobxTable();
			try
			{
				cbxSelectTable.Items.Clear();
				List<string> dataTables = _weatherData.GetTableNames(cbxSelectPart.Text.ToString());
				cbxSelectTable.Items.AddRange(dataTables.ToArray());
				cbxSelectTable.Text = dataTables.ToArray().GetValue(0).ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show("发生了一个错误，点击继续");
			}
			
		}

		private void btnSelectCoord_Click(object sender, EventArgs e)
		{
			_close = false;
			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			_close = true;
			this.Close();
		}

		private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_close)
				_parentForm.Close();
			else
				_parentForm.Visible = true;
		}

		private void btnSendArgu_Click(object sender, EventArgs e)
		{
			Show_cobxTable();
			//设置尺寸
			this.ClientSize = new System.Drawing.Size(820, 550);
			partname = cbxSelectPart.Text.ToString();
			tablename = cbxSelectTable.Text.ToString();
			try{
				dgvwLines.DataSource = _weatherData.GetTableData(lat, lon, partname, tablename);
				//.GetLineData(MapForm._lat,MapForm._lon,cbxSelectPart.Text.ToString(),cbxSelectTable.Text.ToString(),);
			}
			catch(Exception ex)
			{
				MessageBox.Show("找不到数据，请检查相关索引");
			}
			

		}

		private void cbxSelectPart_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void cbxSelectPart_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				cbxSelectPart_SelectedIndexChanged(sender, e);
		}

		private void cbxSelectTable_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnSendArgu_Click(sender, e);
		}
	}
}
