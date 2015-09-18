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
			this.labLon = new System.Windows.Forms.Label();
			this.labLat = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbxSelectPart
			// 
			this.cbxSelectPart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSelectPart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxSelectPart.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbxSelectPart.FormattingEnabled = true;
			this.cbxSelectPart.Location = new System.Drawing.Point(88, 106);
			this.cbxSelectPart.Name = "cbxSelectPart";
			this.cbxSelectPart.Size = new System.Drawing.Size(146, 29);
			this.cbxSelectPart.Sorted = true;
			this.cbxSelectPart.TabIndex = 0;
			// 
			// cbxSelectTable
			// 
			this.cbxSelectTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbxSelectTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbxSelectTable.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.cbxSelectTable.FormattingEnabled = true;
			this.cbxSelectTable.Location = new System.Drawing.Point(88, 145);
			this.cbxSelectTable.Name = "cbxSelectTable";
			this.cbxSelectTable.Size = new System.Drawing.Size(146, 29);
			this.cbxSelectTable.Sorted = true;
			this.cbxSelectTable.TabIndex = 0;
			// 
			// btnSendArgu
			// 
			this.btnSendArgu.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSendArgu.Location = new System.Drawing.Point(106, 187);
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
			// labLon
			// 
			this.labLon.AutoSize = true;
			this.labLon.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.labLon.Location = new System.Drawing.Point(31, 25);
			this.labLon.Name = "labLon";
			this.labLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labLon.Size = new System.Drawing.Size(55, 21);
			this.labLon.TabIndex = 2;
			this.labLon.Text = "经度:";
			// 
			// labLat
			// 
			this.labLat.AutoSize = true;
			this.labLat.Font = new System.Drawing.Font("华文宋体", 14.25F, System.Drawing.FontStyle.Bold);
			this.labLat.Location = new System.Drawing.Point(31, 60);
			this.labLat.Name = "labLat";
			this.labLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labLat.Size = new System.Drawing.Size(55, 21);
			this.labLat.TabIndex = 2;
			this.labLat.Text = "纬度:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.label1.Location = new System.Drawing.Point(240, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "？";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.label2.Location = new System.Drawing.Point(240, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "？";
			// 
			// SelectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 259);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labTables);
			this.Controls.Add(this.labLat);
			this.Controls.Add(this.labLon);
			this.Controls.Add(this.labPart);
			this.Controls.Add(this.btnSendArgu);
			this.Controls.Add(this.cbxSelectTable);
			this.Controls.Add(this.cbxSelectPart);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(312, 297);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(312, 297);
			this.Name = "SelectForm";
			this.ShowIcon = false;
			this.Text = "选择相关数据项";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxSelectPart;
		private System.Windows.Forms.ComboBox cbxSelectTable;
		private System.Windows.Forms.Button btnSendArgu;
		private System.Windows.Forms.Label labPart;
		private System.Windows.Forms.Label labTables;
		private System.Windows.Forms.Label labLon;
		private System.Windows.Forms.Label labLat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}