namespace RobertHeijnDesktopApp
{
	partial class OrderContentForm
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
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.lbOrderId = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.lbOrderDate = new System.Windows.Forms.Label();
			this.cbxOrderStatus = new System.Windows.Forms.ComboBox();
			this.lbOrderStatus = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvCategories = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pnlHeader.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.pnlHeader.Controls.Add(this.panel3);
			this.pnlHeader.Controls.Add(this.lbOrderId);
			this.pnlHeader.Controls.Add(this.label);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(600, 96);
			this.pnlHeader.TabIndex = 2;
			this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
			this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
			this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnClose);
			this.panel3.Controls.Add(this.btnMinimize);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(520, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(80, 96);
			this.panel3.TabIndex = 18;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(40, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Location = new System.Drawing.Point(0, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(40, 40);
			this.btnMinimize.TabIndex = 5;
			this.btnMinimize.Text = "-";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// lbOrderId
			// 
			this.lbOrderId.AutoSize = true;
			this.lbOrderId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbOrderId.ForeColor = System.Drawing.Color.White;
			this.lbOrderId.Location = new System.Drawing.Point(144, 17);
			this.lbOrderId.Name = "lbOrderId";
			this.lbOrderId.Size = new System.Drawing.Size(69, 23);
			this.lbOrderId.TabIndex = 17;
			this.lbOrderId.Text = "label1";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(12, 17);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(91, 23);
			this.label.TabIndex = 16;
			this.label.Text = "Order id:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.lbOrderDate);
			this.panel1.Controls.Add(this.cbxOrderStatus);
			this.panel1.Controls.Add(this.lbOrderStatus);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 190);
			this.panel1.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(453, 119);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(111, 25);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lbOrderDate
			// 
			this.lbOrderDate.AutoSize = true;
			this.lbOrderDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbOrderDate.ForeColor = System.Drawing.Color.Black;
			this.lbOrderDate.Location = new System.Drawing.Point(162, 40);
			this.lbOrderDate.Name = "lbOrderDate";
			this.lbOrderDate.Size = new System.Drawing.Size(132, 23);
			this.lbOrderDate.TabIndex = 14;
			this.lbOrderDate.Text = "dd-mm-yyyy";
			// 
			// cbxOrderStatus
			// 
			this.cbxOrderStatus.BackColor = System.Drawing.Color.Gainsboro;
			this.cbxOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxOrderStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxOrderStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbxOrderStatus.FormattingEnabled = true;
			this.cbxOrderStatus.Location = new System.Drawing.Point(172, 119);
			this.cbxOrderStatus.Name = "cbxOrderStatus";
			this.cbxOrderStatus.Size = new System.Drawing.Size(248, 25);
			this.cbxOrderStatus.TabIndex = 13;
			// 
			// lbOrderStatus
			// 
			this.lbOrderStatus.AutoSize = true;
			this.lbOrderStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbOrderStatus.ForeColor = System.Drawing.Color.Black;
			this.lbOrderStatus.Location = new System.Drawing.Point(31, 116);
			this.lbOrderStatus.Name = "lbOrderStatus";
			this.lbOrderStatus.Size = new System.Drawing.Size(125, 23);
			this.lbOrderStatus.TabIndex = 6;
			this.lbOrderStatus.Text = "Order status:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(31, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Order date:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgvCategories);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 286);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(600, 314);
			this.panel2.TabIndex = 4;
			// 
			// dgvCategories
			// 
			this.dgvCategories.AllowUserToAddRows = false;
			this.dgvCategories.AllowUserToDeleteRows = false;
			this.dgvCategories.AllowUserToResizeColumns = false;
			this.dgvCategories.AllowUserToResizeRows = false;
			this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
			this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCategories.GridColor = System.Drawing.Color.White;
			this.dgvCategories.Location = new System.Drawing.Point(0, 0);
			this.dgvCategories.MultiSelect = false;
			this.dgvCategories.Name = "dgvCategories";
			this.dgvCategories.ReadOnly = true;
			this.dgvCategories.RowHeadersVisible = false;
			this.dgvCategories.RowHeadersWidth = 51;
			this.dgvCategories.RowTemplate.Height = 25;
			this.dgvCategories.ShowEditingIcon = false;
			this.dgvCategories.Size = new System.Drawing.Size(600, 314);
			this.dgvCategories.TabIndex = 4;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "Item id";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CategoryName";
			this.Column2.HeaderText = "Item name";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ParentCategory";
			this.Column3.HeaderText = "Amount";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// OrderContentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OrderContentForm";
			this.Text = "OrderContentForm";
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlHeader;
		private Panel panel3;
		private Button btnClose;
		private Button btnMinimize;
		private Label lbOrderId;
		private Label label;
		private Panel panel1;
		private Panel panel2;
		private DataGridView dgvCategories;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private Label lbOrderStatus;
		private Label label1;
		private ComboBox cbxOrderStatus;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label lbOrderDate;
		private Button btnSave;
	}
}