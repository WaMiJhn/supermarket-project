namespace RobertHeijnDesktopApp
{
	partial class UnitForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAddUnit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvUnits = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAddUnit);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.tbSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1044, 170);
			this.panel2.TabIndex = 2;
			// 
			// btnAddUnit
			// 
			this.btnAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddUnit.FlatAppearance.BorderSize = 0;
			this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddUnit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAddUnit.ForeColor = System.Drawing.Color.White;
			this.btnAddUnit.Location = new System.Drawing.Point(34, 46);
			this.btnAddUnit.Name = "btnAddUnit";
			this.btnAddUnit.Size = new System.Drawing.Size(146, 50);
			this.btnAddUnit.TabIndex = 9;
			this.btnAddUnit.Text = "Add unit";
			this.btnAddUnit.UseVisualStyleBackColor = false;
			this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvUnits);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 170);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1044, 421);
			this.panel1.TabIndex = 3;
			// 
			// dgvUnits
			// 
			this.dgvUnits.AllowUserToAddRows = false;
			this.dgvUnits.AllowUserToDeleteRows = false;
			this.dgvUnits.AllowUserToResizeColumns = false;
			this.dgvUnits.AllowUserToResizeRows = false;
			this.dgvUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUnits.BackgroundColor = System.Drawing.Color.White;
			this.dgvUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
			this.dgvUnits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUnits.GridColor = System.Drawing.Color.White;
			this.dgvUnits.Location = new System.Drawing.Point(0, 0);
			this.dgvUnits.MultiSelect = false;
			this.dgvUnits.Name = "dgvUnits";
			this.dgvUnits.ReadOnly = true;
			this.dgvUnits.RowHeadersVisible = false;
			this.dgvUnits.RowHeadersWidth = 51;
			this.dgvUnits.RowTemplate.Height = 25;
			this.dgvUnits.ShowEditingIcon = false;
			this.dgvUnits.Size = new System.Drawing.Size(1044, 421);
			this.dgvUnits.TabIndex = 3;
			this.dgvUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnits_CellContentClick);
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
			this.Column2.DataPropertyName = "UnitName";
			this.Column2.HeaderText = "Unit";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
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
			// UnitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1044, 591);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "UnitForm";
			this.Text = "UnitForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel2;
		private Button btnAddUnit;
		private Label label2;
		private TextBox tbSearch;
		private Panel panel1;
		private DataGridView dgvUnits;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewButtonColumn Column4;
	}
}