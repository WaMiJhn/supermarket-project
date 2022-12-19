namespace RobertHeijnDesktopApp
{
	partial class OrderForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.tbSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1044, 170);
			this.panel2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.label2.Location = new System.Drawing.Point(34, 45);
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
			this.tbSearch.Location = new System.Drawing.Point(34, 79);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(203, 24);
			this.tbSearch.TabIndex = 8;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvOrders);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 170);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1044, 421);
			this.panel1.TabIndex = 3;
			// 
			// dgvOrders
			// 
			this.dgvOrders.AllowUserToAddRows = false;
			this.dgvOrders.AllowUserToDeleteRows = false;
			this.dgvOrders.AllowUserToResizeColumns = false;
			this.dgvOrders.AllowUserToResizeRows = false;
			this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOrders.GridColor = System.Drawing.Color.White;
			this.dgvOrders.Location = new System.Drawing.Point(0, 0);
			this.dgvOrders.MultiSelect = false;
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.ReadOnly = true;
			this.dgvOrders.RowHeadersVisible = false;
			this.dgvOrders.RowTemplate.Height = 25;
			this.dgvOrders.ShowEditingIcon = false;
			this.dgvOrders.Size = new System.Drawing.Size(1044, 421);
			this.dgvOrders.TabIndex = 4;
			this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
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
			this.Column2.DataPropertyName = "OrderDate";
			this.Column2.HeaderText = "Order date";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "FullName";
			this.Column3.HeaderText = "Customer";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "StatusName";
			this.Column4.HeaderText = "Order status";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Column5.HeaderText = "";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Text = "View details";
			this.Column5.UseColumnTextForButtonValue = true;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1044, 591);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.MinimumSize = new System.Drawing.Size(1060, 630);
			this.Name = "OrderForm";
			this.Text = "OrdersForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel2;
		private Label label2;
		private TextBox tbSearch;
		private Panel panel1;
		private DataGridView dgvOrders;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewButtonColumn Column5;
	}
}