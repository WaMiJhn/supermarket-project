namespace RobertHeijnDesktopApp
{
	partial class UnitContentForm
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
			this.lbId = new System.Windows.Forms.Label();
			this.lbUnitId = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lbUnit = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.pnlHeader.Controls.Add(this.lbId);
			this.pnlHeader.Controls.Add(this.lbUnitId);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.btnClose);
			this.pnlHeader.Controls.Add(this.lbUnit);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(629, 128);
			this.pnlHeader.TabIndex = 2;
			this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
			this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
			this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbId.ForeColor = System.Drawing.Color.White;
			this.lbId.Location = new System.Drawing.Point(163, 93);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(84, 28);
			this.lbId.TabIndex = 17;
			this.lbId.Text = "label1";
			this.lbId.Visible = false;
			// 
			// lbUnitId
			// 
			this.lbUnitId.AutoSize = true;
			this.lbUnitId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbUnitId.ForeColor = System.Drawing.Color.White;
			this.lbUnitId.Location = new System.Drawing.Point(61, 93);
			this.lbUnitId.Name = "lbUnitId";
			this.lbUnitId.Size = new System.Drawing.Size(90, 28);
			this.lbUnitId.TabIndex = 16;
			this.lbUnitId.Text = "Unit id:";
			this.lbUnitId.Visible = false;
			// 
			// btnMinimize
			// 
			this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.Location = new System.Drawing.Point(537, 0);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(46, 53);
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
			this.btnClose.Location = new System.Drawing.Point(583, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(46, 53);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
			this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
			// 
			// lbUnit
			// 
			this.lbUnit.AutoSize = true;
			this.lbUnit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbUnit.ForeColor = System.Drawing.Color.White;
			this.lbUnit.Location = new System.Drawing.Point(14, 23);
			this.lbUnit.Name = "lbUnit";
			this.lbUnit.Size = new System.Drawing.Size(110, 28);
			this.lbUnit.TabIndex = 0;
			this.lbUnit.Text = "Add unit";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 128);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(629, 305);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnSave);
			this.panel2.Controls.Add(this.tbName);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(14, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(601, 289);
			this.panel2.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(47, 181);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(527, 69);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Add unit";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbName
			// 
			this.tbName.BackColor = System.Drawing.Color.Gainsboro;
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tbName.Location = new System.Drawing.Point(47, 100);
			this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(527, 30);
			this.tbName.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(47, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 28);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name:";
			// 
			// UnitContentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 433);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "UnitContentForm";
			this.Text = "UnitContentForm";
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlHeader;
		private Label lbId;
		private Label lbUnitId;
		private Button btnMinimize;
		private Button btnClose;
		private Label lbUnit;
		private Panel panel1;
		private Panel panel2;
		private Button btnSave;
		private TextBox tbName;
		private Label label1;
	}
}