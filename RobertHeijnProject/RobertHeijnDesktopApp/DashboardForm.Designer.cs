namespace RobertHeijnDesktopApp
{
	partial class DashboardForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlNavigation = new System.Windows.Forms.Panel();
			this.btnEmployees = new System.Windows.Forms.Button();
			this.btnUnits = new System.Windows.Forms.Button();
			this.btnCategories = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.btnItems = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMaximize = new System.Windows.Forms.Button();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlDesktop = new System.Windows.Forms.Panel();
			this.pnlNavigation.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(80, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// pnlNavigation
			// 
			this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.pnlNavigation.Controls.Add(this.btnEmployees);
			this.pnlNavigation.Controls.Add(this.btnUnits);
			this.pnlNavigation.Controls.Add(this.btnCategories);
			this.pnlNavigation.Controls.Add(this.btnLogout);
			this.pnlNavigation.Controls.Add(this.btnOrders);
			this.pnlNavigation.Controls.Add(this.btnItems);
			this.pnlNavigation.Controls.Add(this.panel3);
			this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
			this.pnlNavigation.Name = "pnlNavigation";
			this.pnlNavigation.Size = new System.Drawing.Size(220, 720);
			this.pnlNavigation.TabIndex = 3;
			// 
			// btnEmployees
			// 
			this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEmployees.FlatAppearance.BorderSize = 0;
			this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmployees.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEmployees.ForeColor = System.Drawing.Color.White;
			this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmployees.Location = new System.Drawing.Point(0, 410);
			this.btnEmployees.Name = "btnEmployees";
			this.btnEmployees.Size = new System.Drawing.Size(220, 80);
			this.btnEmployees.TabIndex = 10;
			this.btnEmployees.Text = "Employees";
			this.btnEmployees.UseVisualStyleBackColor = true;
			this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
			// 
			// btnUnits
			// 
			this.btnUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUnits.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUnits.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnUnits.FlatAppearance.BorderSize = 0;
			this.btnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUnits.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnUnits.ForeColor = System.Drawing.Color.White;
			this.btnUnits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUnits.Location = new System.Drawing.Point(0, 330);
			this.btnUnits.Name = "btnUnits";
			this.btnUnits.Size = new System.Drawing.Size(220, 80);
			this.btnUnits.TabIndex = 9;
			this.btnUnits.Text = "Units";
			this.btnUnits.UseVisualStyleBackColor = true;
			this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
			// 
			// btnCategories
			// 
			this.btnCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCategories.FlatAppearance.BorderSize = 0;
			this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCategories.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCategories.ForeColor = System.Drawing.Color.White;
			this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCategories.Location = new System.Drawing.Point(0, 250);
			this.btnCategories.Name = "btnCategories";
			this.btnCategories.Size = new System.Drawing.Size(220, 80);
			this.btnCategories.TabIndex = 8;
			this.btnCategories.Text = "Categories";
			this.btnCategories.UseVisualStyleBackColor = true;
			this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(0, 640);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(220, 80);
			this.btnLogout.TabIndex = 7;
			this.btnLogout.Text = "Log out";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnOrders
			// 
			this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnOrders.FlatAppearance.BorderSize = 0;
			this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrders.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnOrders.ForeColor = System.Drawing.Color.White;
			this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrders.Location = new System.Drawing.Point(0, 170);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new System.Drawing.Size(220, 80);
			this.btnOrders.TabIndex = 6;
			this.btnOrders.Text = "Orders";
			this.btnOrders.UseVisualStyleBackColor = true;
			this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
			// 
			// btnItems
			// 
			this.btnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnItems.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnItems.FlatAppearance.BorderSize = 0;
			this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnItems.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnItems.ForeColor = System.Drawing.Color.White;
			this.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnItems.Location = new System.Drawing.Point(0, 90);
			this.btnItems.Name = "btnItems";
			this.btnItems.Size = new System.Drawing.Size(220, 80);
			this.btnItems.TabIndex = 5;
			this.btnItems.Text = "Items";
			this.btnItems.UseVisualStyleBackColor = false;
			this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(220, 90);
			this.panel3.TabIndex = 4;
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.pnlHeader.Controls.Add(this.panel1);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(220, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1060, 90);
			this.pnlHeader.TabIndex = 4;
			this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
			this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
			this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMaximize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(940, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(120, 90);
			this.panel1.TabIndex = 5;
			// 
			// btnMaximize
			// 
			this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnMaximize.BackgroundImage = global::RobertHeijnDesktopApp.Properties.Resources.window_maximize_icon;
			this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMaximize.ForeColor = System.Drawing.Color.White;
			this.btnMaximize.Location = new System.Drawing.Point(40, 0);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Size = new System.Drawing.Size(40, 40);
			this.btnMaximize.TabIndex = 5;
			this.btnMaximize.UseVisualStyleBackColor = false;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
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
			this.btnMinimize.TabIndex = 4;
			this.btnMinimize.Text = "-";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = global::RobertHeijnDesktopApp.Properties.Resources.logo_no_background;
			this.pictureBox1.Location = new System.Drawing.Point(318, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(439, 90);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pnlDesktop
			// 
			this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDesktop.Location = new System.Drawing.Point(220, 90);
			this.pnlDesktop.Name = "pnlDesktop";
			this.pnlDesktop.Size = new System.Drawing.Size(1060, 630);
			this.pnlDesktop.TabIndex = 5;
			// 
			// DashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.pnlDesktop);
			this.Controls.Add(this.pnlHeader);
			this.Controls.Add(this.pnlNavigation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "DashboardForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashboardForm";
			this.pnlNavigation.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Button btnClose;
		private Panel pnlNavigation;
		private Button btnItems;
		private Button btnLogout;
		private Button btnOrders;
		private Panel pnlHeader;
		private PictureBox pictureBox1;
		private Panel panel3;
		private Panel pnlDesktop;
		private Button btnMinimize;
		private Button btnUnits;
		private Button btnCategories;
		private Panel panel1;
		private Button btnMaximize;
		private Button btnEmployees;
	}
}