﻿namespace MapWeatherData
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
			this.lblPart = new System.Windows.Forms.Label();
			this.lblTables = new System.Windows.Forms.Label();
			this.lblLon = new System.Windows.Forms.Label();
			this.lblLat = new System.Windows.Forms.Label();
			this.lblPartInfo = new System.Windows.Forms.Label();
			this.lblTableInfo = new System.Windows.Forms.Label();
			this.btnSelectCoord = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvwLines = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvwLines)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxSelectPart
			// 
			this.cbxSelectPart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSelectPart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxSelectPart.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.cbxSelectPart.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbxSelectPart.FormattingEnabled = true;
			this.cbxSelectPart.Location = new System.Drawing.Point(88, 106);
			this.cbxSelectPart.Name = "cbxSelectPart";
			this.cbxSelectPart.Size = new System.Drawing.Size(653, 26);
			this.cbxSelectPart.Sorted = true;
			this.cbxSelectPart.TabIndex = 1;
			this.cbxSelectPart.SelectedIndexChanged += new System.EventHandler(this.cbxSelectPart_SelectedIndexChanged);
			this.cbxSelectPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxSelectPart_KeyDown);
			this.cbxSelectPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSelectPart_KeyPress);
			// 
			// cbxSelectTable
			// 
			this.cbxSelectTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSelectTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxSelectTable.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.cbxSelectTable.Font = new System.Drawing.Font("华文宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbxSelectTable.FormattingEnabled = true;
			this.cbxSelectTable.Location = new System.Drawing.Point(88, 145);
			this.cbxSelectTable.Name = "cbxSelectTable";
			this.cbxSelectTable.Size = new System.Drawing.Size(653, 26);
			this.cbxSelectTable.Sorted = true;
			this.cbxSelectTable.TabIndex = 2;
			this.cbxSelectTable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxSelectTable_KeyDown);
			// 
			// btnSendArgu
			// 
			this.btnSendArgu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSendArgu.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSendArgu.Location = new System.Drawing.Point(149, 490);
			this.btnSendArgu.Name = "btnSendArgu";
			this.btnSendArgu.Size = new System.Drawing.Size(100, 42);
			this.btnSendArgu.TabIndex = 3;
			this.btnSendArgu.Text = "确定";
			this.btnSendArgu.UseVisualStyleBackColor = true;
			this.btnSendArgu.Click += new System.EventHandler(this.btnSendArgu_Click);
			// 
			// lblPart
			// 
			this.lblPart.AutoSize = true;
			this.lblPart.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblPart.Location = new System.Drawing.Point(31, 114);
			this.lblPart.Name = "lblPart";
			this.lblPart.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPart.Size = new System.Drawing.Size(55, 21);
			this.lblPart.TabIndex = 2;
			this.lblPart.Text = "类别:";
			// 
			// lblTables
			// 
			this.lblTables.AutoSize = true;
			this.lblTables.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblTables.Location = new System.Drawing.Point(31, 153);
			this.lblTables.Name = "lblTables";
			this.lblTables.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTables.Size = new System.Drawing.Size(55, 21);
			this.lblTables.TabIndex = 2;
			this.lblTables.Text = "表项:";
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
			this.lblPartInfo.Cursor = System.Windows.Forms.Cursors.Hand;
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
			this.lblTableInfo.Cursor = System.Windows.Forms.Cursors.Hand;
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
			this.btnSelectCoord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSelectCoord.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSelectCoord.Location = new System.Drawing.Point(349, 490);
			this.btnSelectCoord.Name = "btnSelectCoord";
			this.btnSelectCoord.Size = new System.Drawing.Size(100, 42);
			this.btnSelectCoord.TabIndex = 4;
			this.btnSelectCoord.Text = "坐标重选";
			this.btnSelectCoord.UseVisualStyleBackColor = true;
			this.btnSelectCoord.Click += new System.EventHandler(this.btnSelectCoord_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClose.Location = new System.Drawing.Point(535, 490);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 42);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// dgvwLines
			// 
			this.dgvwLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvwLines.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvwLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvwLines.Location = new System.Drawing.Point(35, 199);
			this.dgvwLines.Name = "dgvwLines";
			this.dgvwLines.RowTemplate.Height = 23;
			this.dgvwLines.Size = new System.Drawing.Size(732, 264);
			this.dgvwLines.TabIndex = 4;
			// 
			// SelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 555);
			this.Controls.Add(this.dgvwLines);
			this.Controls.Add(this.lblTableInfo);
			this.Controls.Add(this.lblPartInfo);
			this.Controls.Add(this.lblTables);
			this.Controls.Add(this.lblLat);
			this.Controls.Add(this.lblLon);
			this.Controls.Add(this.lblPart);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSelectCoord);
			this.Controls.Add(this.btnSendArgu);
			this.Controls.Add(this.cbxSelectTable);
			this.Controls.Add(this.cbxSelectPart);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectForm";
			this.Text = "选择相关数据项";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
			this.Load += new System.EventHandler(this.SelectForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvwLines)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxSelectPart;
		private System.Windows.Forms.ComboBox cbxSelectTable;
		private System.Windows.Forms.Button btnSendArgu;
		private System.Windows.Forms.Label lblPart;
		private System.Windows.Forms.Label lblTables;
		private System.Windows.Forms.Label lblLon;
		private System.Windows.Forms.Label lblLat;
		private System.Windows.Forms.Label lblPartInfo;
		private System.Windows.Forms.Label lblTableInfo;
		private System.Windows.Forms.Button btnSelectCoord;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvwLines;
	}
}