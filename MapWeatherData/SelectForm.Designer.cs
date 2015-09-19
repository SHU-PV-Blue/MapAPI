namespace MapWeatherData
{
	partial class SelectForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbxSelectPart = new System.Windows.Forms.ComboBox();
			this.cbxSelectTable = new System.Windows.Forms.ComboBox();
			this.btnSendArgu = new System.Windows.Forms.Button();
			this.labPart = new System.Windows.Forms.Label();
			this.labTables = new System.Windows.Forms.Label();
			this.lblLon = new System.Windows.Forms.Label();
			this.lblLat = new System.Windows.Forms.Label();
			this.lblPartInfo = new System.Windows.Forms.Label();
			this.lblTableInfo = new System.Windows.Forms.Label();
			this.btnSelectCoord = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbxSelectPart
			// 
			this.cbxSelectPart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSelectPart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxSelectPart.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbxSelectPart.FormattingEnabled = true;
			this.cbxSelectPart.Location = new System.Drawing.Point(88, 106);
			this.cbxSelectPart.Name = "cbxSelectPart";
			this.cbxSelectPart.Size = new System.Drawing.Size(653, 26);
			this.cbxSelectPart.Sorted = true;
			this.cbxSelectPart.TabIndex = 1;
			this.cbxSelectPart.SelectedIndexChanged += new System.EventHandler(this.cbxSelectPart_SelectedIndexChanged);
			// 
			// cbxSelectTable
			// 
			this.cbxSelectTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSelectTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxSelectTable.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbxSelectTable.FormattingEnabled = true;
			this.cbxSelectTable.Location = new System.Drawing.Point(88, 145);
			this.cbxSelectTable.Name = "cbxSelectTable";
			this.cbxSelectTable.Size = new System.Drawing.Size(653, 26);
			this.cbxSelectTable.Sorted = true;
			this.cbxSelectTable.TabIndex = 2;
			// 
			// btnSendArgu
			// 
			this.btnSendArgu.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSendArgu.Location = new System.Drawing.Point(149, 200);
			this.btnSendArgu.Name = "btnSendArgu";
			this.btnSendArgu.Size = new System.Drawing.Size(100, 42);
			this.btnSendArgu.TabIndex = 1;
			this.btnSendArgu.Text = "确定";
			this.btnSendArgu.UseVisualStyleBackColor = true;
			// 
			// labPart
			// 
			this.labPart.AutoSize = true;
			this.labPart.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.labPart.Location = new System.Drawing.Point(31, 114);
			this.labPart.Name = "labPart";
			this.labPart.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labPart.Size = new System.Drawing.Size(55, 21);
			this.labPart.TabIndex = 2;
			this.labPart.Text = "类别:";
			// 
			// labTables
			// 
			this.labTables.AutoSize = true;
			this.labTables.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.labTables.Location = new System.Drawing.Point(31, 153);
			this.labTables.Name = "labTables";
			this.labTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labTables.Size = new System.Drawing.Size(55, 21);
			this.labTables.TabIndex = 2;
			this.labTables.Text = "表项:";
			// 
			// lblLon
			// 
			this.lblLon.AutoSize = true;
			this.lblLon.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblLon.Location = new System.Drawing.Point(179, 41);
			this.lblLon.Name = "lblLon";
			this.lblLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLon.Size = new System.Drawing.Size(55, 21);
			this.lblLon.TabIndex = 2;
			this.lblLon.Text = "经度:";
			// 
			// lblLat
			// 
			this.lblLat.AutoSize = true;
			this.lblLat.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblLat.Location = new System.Drawing.Point(473, 41);
			this.lblLat.Name = "lblLat";
			this.lblLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLat.Size = new System.Drawing.Size(55, 21);
			this.lblLat.TabIndex = 2;
			this.lblLat.Text = "纬度:";
			// 
			// lblPartInfo
			// 
			this.lblPartInfo.AutoSize = true;
			this.lblPartInfo.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblPartInfo.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.lblPartInfo.Location = new System.Drawing.Point(742, 110);
			this.lblPartInfo.Name = "lblPartInfo";
			this.lblPartInfo.Size = new System.Drawing.Size(25, 16);
			this.lblPartInfo.TabIndex = 3;
			this.lblPartInfo.Text = "？";
			this.lblPartInfo.Click += new System.EventHandler(this.lblPartInfo_Click);
			// 
			// lblTableInfo
			// 
			this.lblTableInfo.AutoSize = true;
			this.lblTableInfo.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblTableInfo.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.lblTableInfo.Location = new System.Drawing.Point(744, 150);
			this.lblTableInfo.Name = "lblTableInfo";
			this.lblTableInfo.Size = new System.Drawing.Size(25, 16);
			this.lblTableInfo.TabIndex = 3;
			this.lblTableInfo.Text = "？";
			this.lblTableInfo.Click += new System.EventHandler(this.lblTableInfo_Click);
			// 
			// btnSelectCoord
			// 
			this.btnSelectCoord.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSelectCoord.Location = new System.Drawing.Point(459, 200);
			this.btnSelectCoord.Name = "btnSelectCoord";
			this.btnSelectCoord.Size = new System.Drawing.Size(100, 42);
			this.btnSelectCoord.TabIndex = 1;
			this.btnSelectCoord.Text = "坐标重选";
			this.btnSelectCoord.UseVisualStyleBackColor = true;
			this.btnSelectCoord.Click += new System.EventHandler(this.btnSelectCoord_Click);
			// 
			// SelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 254);
			this.Controls.Add(this.lblTableInfo);
			this.Controls.Add(this.lblPartInfo);
			this.Controls.Add(this.labTables);
			this.Controls.Add(this.lblLat);
			this.Controls.Add(this.lblLon);
			this.Controls.Add(this.labPart);
			this.Controls.Add(this.btnSelectCoord);
			this.Controls.Add(this.btnSendArgu);
			this.Controls.Add(this.cbxSelectTable);
			this.Controls.Add(this.cbxSelectPart);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectForm";
			this.ShowIcon = false;
			this.Text = "选择相关数据项";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
			this.Load += new System.EventHandler(this.SelectForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxSelectPart;
		private System.Windows.Forms.ComboBox cbxSelectTable;
		private System.Windows.Forms.Button btnSendArgu;
		private System.Windows.Forms.Label labPart;
		private System.Windows.Forms.Label labTables;
		private System.Windows.Forms.Label lblLon;
		private System.Windows.Forms.Label lblLat;
		private System.Windows.Forms.Label lblPartInfo;
		private System.Windows.Forms.Label lblTableInfo;
		private System.Windows.Forms.Button btnSelectCoord;
	}
}