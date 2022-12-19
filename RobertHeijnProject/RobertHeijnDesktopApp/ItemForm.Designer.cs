namespace RobertHeijnDesktopApp
{
	partial class ItemForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvItems = new System.Windows.Forms.DataGridView();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.cbxFilter = new System.Windows.Forms.ComboBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
			this.pnlTop.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvItems
			// 
			this.dgvItems.AllowUserToAddRows = false;
			this.dgvItems.AllowUserToDeleteRows = false;
			this.dgvItems.AllowUserToResizeColumns = false;
			this.dgvItems.AllowUserToResizeRows = false;
			this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvItems.BackgroundColor = System.Drawing.Color.White;
			this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvItems.GridColor = System.Drawing.Color.White;
			this.dgvItems.Location = new System.Drawing.Point(0, 0);
			this.dgvItems.MultiSelect = false;
			this.dgvItems.Name = "dgvItems";
			this.dgvItems.ReadOnly = true;
			this.dgvItems.RowHeadersVisible = false;
			this.dgvItems.RowTemplate.Height = 25;
			this.dgvItems.ShowEditingIcon = false;
			this.dgvItems.Size = new System.Drawing.Size(1044, 421);
			this.dgvItems.TabIndex = 0;
			this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
			// 
			// btnAddItem
			// 
			this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddItem.FlatAppearance.BorderSize = 0;
			this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddItem.ForeColor = System.Drawing.Color.White;
			this.btnAddItem.Location = new System.Drawing.Point(34, 46);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(135, 50);
			this.btnAddItem.TabIndex = 1;
			this.btnAddItem.Text = "Add item";
			this.btnAddItem.UseVisualStyleBackColor = false;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// cbxFilter
			// 
			this.cbxFilter.BackColor = System.Drawing.Color.Gainsboro;
			this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxFilter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbxFilter.FormattingEnabled = true;
			this.cbxFilter.Location = new System.Drawing.Point(66, 79);
			this.cbxFilter.Name = "cbxFilter";
			this.cbxFilter.Size = new System.Drawing.Size(243, 25);
			this.cbxFilter.TabIndex = 2;
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFilter.FlatAppearance.BorderSize = 0;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnFilter.ForeColor = System.Drawing.Color.White;
			this.btnFilter.Location = new System.Drawing.Point(195, 113);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(114, 33);
			this.btnFilter.TabIndex = 3;
			this.btnFilter.Text = "Apply filter";
			this.btnFilter.UseVisualStyleBackColor = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// pnlTop
			// 
			this.pnlTop.Controls.Add(this.panel2);
			this.pnlTop.Controls.Add(this.panel4);
			this.pnlTop.Controls.Add(this.panel3);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(1044, 170);
			this.pnlTop.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cbxFilter);
			this.panel2.Controls.Add(this.btnFilter);
			this.panel2.Controls.Add(this.btnClearFilter);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(677, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(367, 170);
			this.panel2.TabIndex = 8;
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClearFilter.FlatAppearance.BorderSize = 0;
			this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClearFilter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnClearFilter.ForeColor = System.Drawing.Color.White;
			this.btnClearFilter.Location = new System.Drawing.Point(66, 113);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(114, 33);
			this.btnClearFilter.TabIndex = 7;
			this.btnClearFilter.Text = "Clear filter";
			this.btnClearFilter.UseVisualStyleBackColor = false;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.label1.Location = new System.Drawing.Point(66, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Filter by category:";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.tbSearch);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(281, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(396, 170);
			this.panel4.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.label2.Location = new System.Drawing.Point(88, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Search:";
			// 
			// tbSearch
			// 
			this.tbSearch.BackColor = System.Drawing.Color.Gainsboro;
			this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbSearch.Location = new System.Drawing.Point(88, 79);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(203, 24);
			this.tbSearch.TabIndex = 6;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnAddItem);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(281, 170);
			this.panel3.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.dgvItems);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 170);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1044, 421);
			this.panel1.TabIndex = 8;
			// 
			// clmId
			// 
			this.clmId.DataPropertyName = "id";
			this.clmId.HeaderText = "Id";
			this.clmId.Name = "clmId";
			this.clmId.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "ItemName";
			this.Column2.HeaderText = "Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Price";
			this.Column3.HeaderText = "Price";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "UnitName";
			this.Column4.HeaderText = "Unit";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "CategoryName";
			this.Column5.HeaderText = "Category";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Column6.HeaderText = "";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Text = "Edit";
			this.Column6.UseColumnTextForButtonValue = true;
			// 
			// ItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1044, 591);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlTop);
			this.Name = "ItemForm";
			this.Text = "ProductsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
			this.pnlTop.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DataGridView dgvItems;
		private Button btnAddItem;
		private ComboBox cbxFilter;
		private Button btnFilter;
		private Panel pnlTop;
		private Label label1;
		private TextBox tbSearch;
		private Label label2;
		private Button btnClearFilter;
		private Panel panel1;
		private Panel panel4;
		private Panel panel3;
		private Panel panel2;
		private DataGridViewTextBoxColumn clmId;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private DataGridViewButtonColumn Column6;
	}
}