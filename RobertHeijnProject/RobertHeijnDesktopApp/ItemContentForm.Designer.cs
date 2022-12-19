namespace RobertHeijnDesktopApp
{
	partial class ItemContentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemContentForm));
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lbId = new System.Windows.Forms.Label();
			this.lbItemId = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbItem = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chxAvailable = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxUnit = new System.Windows.Forms.ComboBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbImageSrc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numPrice = new System.Windows.Forms.NumericUpDown();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.pnlHeader.Controls.Add(this.lbId);
			this.pnlHeader.Controls.Add(this.lbItemId);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.btnClose);
			this.pnlHeader.Controls.Add(this.lbItem);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(550, 96);
			this.pnlHeader.TabIndex = 0;
			this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
			this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
			this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbId.ForeColor = System.Drawing.Color.White;
			this.lbId.Location = new System.Drawing.Point(143, 70);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(69, 23);
			this.lbId.TabIndex = 17;
			this.lbId.Text = "label1";
			this.lbId.Visible = false;
			// 
			// lbItemId
			// 
			this.lbItemId.AutoSize = true;
			this.lbItemId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbItemId.ForeColor = System.Drawing.Color.White;
			this.lbItemId.Location = new System.Drawing.Point(53, 70);
			this.lbItemId.Name = "lbItemId";
			this.lbItemId.Size = new System.Drawing.Size(79, 23);
			this.lbItemId.TabIndex = 16;
			this.lbItemId.Text = "Item id:";
			this.lbItemId.Visible = false;
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Location = new System.Drawing.Point(470, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(40, 40);
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.Text = "-";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(510, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// lbItem
			// 
			this.lbItem.AutoSize = true;
			this.lbItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbItem.ForeColor = System.Drawing.Color.White;
			this.lbItem.Location = new System.Drawing.Point(12, 17);
			this.lbItem.Name = "lbItem";
			this.lbItem.Size = new System.Drawing.Size(96, 23);
			this.lbItem.TabIndex = 0;
			this.lbItem.Text = "Add item";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 514);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.chxAvailable);
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.cbxUnit);
			this.panel2.Controls.Add(this.cbxCategory);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.tbImageSrc);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.numPrice);
			this.panel2.Controls.Add(this.tbName);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(526, 502);
			this.panel2.TabIndex = 0;
			// 
			// chxAvailable
			// 
			this.chxAvailable.AutoSize = true;
			this.chxAvailable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.chxAvailable.FlatAppearance.BorderSize = 4;
			this.chxAvailable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.chxAvailable.Location = new System.Drawing.Point(41, 358);
			this.chxAvailable.Name = "chxAvailable";
			this.chxAvailable.Size = new System.Drawing.Size(120, 27);
			this.chxAvailable.TabIndex = 16;
			this.chxAvailable.Text = "Available";
			this.chxAvailable.UseVisualStyleBackColor = true;
			this.chxAvailable.Visible = false;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(41, 410);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(461, 52);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Add item";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(315, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Unit:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(41, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Category:";
			// 
			// cbxUnit
			// 
			this.cbxUnit.BackColor = System.Drawing.Color.Gainsboro;
			this.cbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbxUnit.FormattingEnabled = true;
			this.cbxUnit.Location = new System.Drawing.Point(315, 293);
			this.cbxUnit.Name = "cbxUnit";
			this.cbxUnit.Size = new System.Drawing.Size(187, 25);
			this.cbxUnit.TabIndex = 13;
			// 
			// cbxCategory
			// 
			this.cbxCategory.BackColor = System.Drawing.Color.Gainsboro;
			this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(41, 293);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(187, 25);
			this.cbxCategory.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(41, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Image source:";
			// 
			// tbImageSrc
			// 
			this.tbImageSrc.BackColor = System.Drawing.Color.Gainsboro;
			this.tbImageSrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbImageSrc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbImageSrc.Location = new System.Drawing.Point(41, 169);
			this.tbImageSrc.Name = "tbImageSrc";
			this.tbImageSrc.Size = new System.Drawing.Size(461, 24);
			this.tbImageSrc.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(382, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Price:";
			// 
			// numPrice
			// 
			this.numPrice.BackColor = System.Drawing.Color.Gainsboro;
			this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numPrice.DecimalPlaces = 2;
			this.numPrice.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numPrice.Location = new System.Drawing.Point(382, 75);
			this.numPrice.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
			this.numPrice.Name = "numPrice";
			this.numPrice.Size = new System.Drawing.Size(120, 24);
			this.numPrice.TabIndex = 8;
			// 
			// tbName
			// 
			this.tbName.BackColor = System.Drawing.Color.Gainsboro;
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbName.Location = new System.Drawing.Point(41, 75);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(242, 24);
			this.tbName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(41, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name:";
			// 
			// ItemContentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(550, 610);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ItemContentForm";
			this.Text = "AddItemForm";
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlHeader;
		private Label lbItem;
		private Button btnClose;
		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private TextBox tbName;
		private Label label3;
		private TextBox tbImageSrc;
		private Label label2;
		private NumericUpDown numPrice;
		private Label label5;
		private Label label4;
		private ComboBox cbxUnit;
		private ComboBox cbxCategory;
		private Button btnMinimize;
		private Button btnSave;
		private Label lbItemId;
		private Label lbId;
		private CheckBox chxAvailable;
	}
}