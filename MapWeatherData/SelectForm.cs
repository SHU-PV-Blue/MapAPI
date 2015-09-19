//*****************************************************************************
//
// 文件名(File Name): SelectForm.cs
// 
// 描述(Description): 选着天气表并显示相关天气数据
//
// 引用(Using): 
// SHUPV.Database.dll
// SHUPV.Database.Connection.dll
// SHUPV.Database.Core.dll
//
// 作者(Author): 方朝增
//
// 日期(Create Date): 2015/09/19
//
//*****************************************************************************

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
		//数据连接层对象，用于进行数据连接相关调用
		WeatherData _weatherData = new WeatherData();

		//声明一个父类指向Mapform，用于进行二者之间的通信。
		MapForm _parentForm;

		/// <summary>
		/// 初始化构造函数
		/// </summary>
		public SelectForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 构造函数重载
		/// </summary>
		/// <param name="form"></param>
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

		/// <summary>
		/// 启动函数，此form启动时需要做 的工作
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectForm_Load(object sender, EventArgs e)
		{
			//设置尺寸信息
			this.ClientSize = new System.Drawing.Size(820, 292);			

			//设置经纬度信息
			lblLon.Text = "经度：" + MapForm._lon.ToString();				
			lblLat.Text = "纬度：" + MapForm._lat.ToString();


			//填充下拉框cbxSelctPart相关数据
			List<string> dataPart = _weatherData.GetPartNames();			
			//cbxSelectPart.DataSource = dataPart;
			cbxSelectPart.Items.AddRange(dataPart.ToArray());
			cbxSelectPart.Text = dataPart.ToArray().GetValue(0).ToString();

			//隐藏下拉框cbxSelectTable即相关控件
			lblTables.Visible = false;										
			cbxSelectTable.Visible = false;
			lblTableInfo.Visible = false;

		}

		/// <summary>
		/// 显示下拉框cbxSelectTable即相关控件
		/// 供内部调用
		/// </summary>
		private void Show_cobxTable()
		{
			lblTables.Visible = true;
			cbxSelectTable.Visible = true;
			lblTableInfo.Visible = true;
		}

		/// <summary>
		/// 当第一个下拉框(cbxSeletePart)选中数据是，自动填充cbxSelectTable的数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// 点击“坐标重选”，关闭当前窗口，调用MapForm窗口。
		/// _close值为false,显示MapForm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSelectCoord_Click(object sender, EventArgs e)
		{
			_close = false;
			this.Close();
		}

		/// <summary>
		/// 点击“关闭”，关闭所有窗口
		/// _close值为true，关闭所有窗口
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClose_Click(object sender, EventArgs e)
		{
			_close = true;
			this.Close();
		}

		/// <summary>
		/// FormClosing 相应事件代码，对_close不同的值做不同处理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_close)
				_parentForm.Close();
			else
				_parentForm.Visible = true;
		}

		/// <summary>
		/// "确定"按钮，
		/// 1.重新调整窗口大小
		/// 2.显示datagridview并显示相关数据
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			//不做任何处理
		}

		/// <summary>
		/// 焦点在 cbxSelectPart上面时候的 KeyDown事件响应，按下回车
		/// 相当于选中数据类故而直接调用该函数
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbxSelectPart_KeyDown(object sender, KeyEventArgs e)
		{
			//调用函数
			if (e.KeyCode == Keys.Enter)
				cbxSelectPart_SelectedIndexChanged(sender, e);
		}

		/// <summary>
		/// cbxSelectTable_KeyDown事件响应函数。
		/// 执行btnSendArgu函数
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbxSelectTable_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btnSendArgu_Click(sender, e);
		}
	}
}
