namespace RobertHeijnDesktopApp
{
	partial class EmployeeForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAddEmployee = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvCategories = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAddEmployee);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.tbSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1193, 227);
			this.panel2.TabIndex = 2;
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddEmployee.FlatAppearance.BorderSize = 0;
			this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddEmployee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
			this.btnAddEmployee.Location = new System.Drawing.Point(39, 61);
			this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(203, 67);
			this.btnAddEmployee.TabIndex = 9;
			this.btnAddEmployee.Text = "Add employee";
			this.btnAddEmployee.UseVisualStyleBackColor = false;
			this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.label2.Location = new System.Drawing.Point(422, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 28);
			this.label2.TabIndex = 7;
			this.label2.Text = "Search:";
			// 
			// tbSearch
			// 
			this.tbSearch.BackColor = System.Drawing.Color.Gainsboro;
			this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbSearch.Location = new System.Drawing.Point(422, 105);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(232, 30);
			this.tbSearch.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvCategories);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 227);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1193, 561);
			this.panel1.TabIndex = 3;
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
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCategories.GridColor = System.Drawing.Color.White;
			this.dgvCategories.Location = new System.Drawing.Point(0, 0);
			this.dgvCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvCategories.MultiSelect = false;
			this.dgvCategories.Name = "dgvCategories";
			this.dgvCategories.ReadOnly = true;
			this.dgvCategories.RowHeadersVisible = false;
			this.dgvCategories.RowHeadersWidth = 51;
			this.dgvCategories.RowTemplate.Height = 25;
			this.dgvCategories.ShowEditingIcon = false;
			this.dgvCategories.Size = new System.Drawing.Size(1193, 561);
			this.dgvCategories.TabIndex = 3;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "id";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CategoryName";
			this.Column2.HeaderText = "Category";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ParentCategory";
			this.Column3.HeaderText = "Parent Category";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Column4.HeaderText = "";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Text = "Edit";
			this.Column4.UseColumnTextForButtonValue = true;
			// 
			// Column5
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Column5.HeaderText = "";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Text = "Delete";
			this.Column5.UseColumnTextForButtonValue = true;
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1193, 788);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "EmployeeForm";
			this.Text = "EmployeeForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel2;
		private Button btnAddEmployee;
		private Label label2;
		private TextBox tbSearch;
		private Panel panel1;
		private DataGridView dgvCategories;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewButtonColumn Column4;
		private DataGridViewButtonColumn Column5;
	}
}