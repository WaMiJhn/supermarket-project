namespace RobertHeijnDesktopApp
{
	partial class CategoryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvCategories = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAddCategory);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.tbSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1044, 170);
			this.panel2.TabIndex = 1;
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCategory.FlatAppearance.BorderSize = 0;
			this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddCategory.ForeColor = System.Drawing.Color.White;
			this.btnAddCategory.Location = new System.Drawing.Point(34, 46);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(170, 50);
			this.btnAddCategory.TabIndex = 9;
			this.btnAddCategory.Text = "Add category";
			this.btnAddCategory.UseVisualStyleBackColor = false;
			this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.label2.Location = new System.Drawing.Point(369, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Search:";
			// 
			// tbSearch
			// 
			this.tbSearch.BackColor = System.Drawing.Color.Gainsboro;
			this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbSearch.Location = new System.Drawing.Point(369, 79);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(203, 24);
			this.tbSearch.TabIndex = 8;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvCategories);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 170);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1044, 421);
			this.panel3.TabIndex = 2;
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
            this.Column4});
			this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCategories.GridColor = System.Drawing.Color.White;
			this.dgvCategories.Location = new System.Drawing.Point(0, 0);
			this.dgvCategories.MultiSelect = false;
			this.dgvCategories.Name = "dgvCategories";
			this.dgvCategories.ReadOnly = true;
			this.dgvCategories.RowHeadersVisible = false;
			this.dgvCategories.RowTemplate.Height = 25;
			this.dgvCategories.ShowEditingIcon = false;
			this.dgvCategories.Size = new System.Drawing.Size(1044, 421);
			this.dgvCategories.TabIndex = 2;
			this.dgvCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategories_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "id";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CategoryName";
			this.Column2.HeaderText = "Category";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ParentCategory";
			this.Column3.HeaderText = "Parent Category";
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
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Text = "Edit";
			this.Column4.UseColumnTextForButtonValue = true;
			// 
			// CategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1044, 591);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CategoryForm";
			this.Text = "CategoryForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Panel panel2;
		private Panel panel3;
		private DataGridView dgvCategories;
		private Label label2;
		private TextBox tbSearch;
		private Button btnAddCategory;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewButtonColumn Column4;
	}
}