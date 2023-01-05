namespace RobertHeijnDesktopApp
{
	partial class EmployeeContentForm
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbItemId = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUserInput = new System.Windows.Forms.Panel();
            this.lbInvalidHouseNumber = new System.Windows.Forms.Label();
            this.lbZipcodeInavlid = new System.Windows.Forms.Label();
            this.lbEmailInvalid = new System.Windows.Forms.Label();
            this.lbPasswordNotMatch = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numWage = new System.Windows.Forms.NumericUpDown();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlUserInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
            this.pnlHeader.Controls.Add(this.panel3);
            this.pnlHeader.Controls.Add(this.lbId);
            this.pnlHeader.Controls.Add(this.lbItemId);
            this.pnlHeader.Controls.Add(this.lbItem);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(925, 96);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(845, 0);
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
            this.panel1.Controls.Add(this.pnlUserInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 479);
            this.panel1.TabIndex = 2;
            // 
            // pnlUserInput
            // 
            this.pnlUserInput.BackColor = System.Drawing.Color.White;
            this.pnlUserInput.Controls.Add(this.lbInvalidHouseNumber);
            this.pnlUserInput.Controls.Add(this.lbZipcodeInavlid);
            this.pnlUserInput.Controls.Add(this.lbEmailInvalid);
            this.pnlUserInput.Controls.Add(this.lbPasswordNotMatch);
            this.pnlUserInput.Controls.Add(this.tbPasswordConfirm);
            this.pnlUserInput.Controls.Add(this.label10);
            this.pnlUserInput.Controls.Add(this.tbPassword);
            this.pnlUserInput.Controls.Add(this.label9);
            this.pnlUserInput.Controls.Add(this.tbUsername);
            this.pnlUserInput.Controls.Add(this.label8);
            this.pnlUserInput.Controls.Add(this.label7);
            this.pnlUserInput.Controls.Add(this.tbZipcode);
            this.pnlUserInput.Controls.Add(this.label6);
            this.pnlUserInput.Controls.Add(this.tbHouseNumber);
            this.pnlUserInput.Controls.Add(this.label4);
            this.pnlUserInput.Controls.Add(this.tbStreet);
            this.pnlUserInput.Controls.Add(this.label5);
            this.pnlUserInput.Controls.Add(this.numWage);
            this.pnlUserInput.Controls.Add(this.tbLastName);
            this.pnlUserInput.Controls.Add(this.label2);
            this.pnlUserInput.Controls.Add(this.btnSave);
            this.pnlUserInput.Controls.Add(this.label3);
            this.pnlUserInput.Controls.Add(this.tbEmail);
            this.pnlUserInput.Controls.Add(this.tbFirstName);
            this.pnlUserInput.Controls.Add(this.label1);
            this.pnlUserInput.Location = new System.Drawing.Point(12, 0);
            this.pnlUserInput.Name = "pnlUserInput";
            this.pnlUserInput.Size = new System.Drawing.Size(901, 467);
            this.pnlUserInput.TabIndex = 0;
            // 
            // lbInvalidHouseNumber
            // 
            this.lbInvalidHouseNumber.AutoSize = true;
            this.lbInvalidHouseNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInvalidHouseNumber.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidHouseNumber.Location = new System.Drawing.Point(348, 256);
            this.lbInvalidHouseNumber.Name = "lbInvalidHouseNumber";
            this.lbInvalidHouseNumber.Size = new System.Drawing.Size(170, 18);
            this.lbInvalidHouseNumber.TabIndex = 35;
            this.lbInvalidHouseNumber.Text = "Invalid house number.";
            this.lbInvalidHouseNumber.Visible = false;
            // 
            // lbZipcodeInavlid
            // 
            this.lbZipcodeInavlid.AutoSize = true;
            this.lbZipcodeInavlid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbZipcodeInavlid.ForeColor = System.Drawing.Color.Red;
            this.lbZipcodeInavlid.Location = new System.Drawing.Point(41, 339);
            this.lbZipcodeInavlid.Name = "lbZipcodeInavlid";
            this.lbZipcodeInavlid.Size = new System.Drawing.Size(130, 18);
            this.lbZipcodeInavlid.TabIndex = 34;
            this.lbZipcodeInavlid.Text = "Invalid zip code.";
            this.lbZipcodeInavlid.Visible = false;
            // 
            // lbEmailInvalid
            // 
            this.lbEmailInvalid.AutoSize = true;
            this.lbEmailInvalid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmailInvalid.ForeColor = System.Drawing.Color.Red;
            this.lbEmailInvalid.Location = new System.Drawing.Point(41, 175);
            this.lbEmailInvalid.Name = "lbEmailInvalid";
            this.lbEmailInvalid.Size = new System.Drawing.Size(107, 18);
            this.lbEmailInvalid.TabIndex = 33;
            this.lbEmailInvalid.Text = "Invalid email.";
            this.lbEmailInvalid.Visible = false;
            // 
            // lbPasswordNotMatch
            // 
            this.lbPasswordNotMatch.AutoSize = true;
            this.lbPasswordNotMatch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPasswordNotMatch.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordNotMatch.Location = new System.Drawing.Point(577, 258);
            this.lbPasswordNotMatch.Name = "lbPasswordNotMatch";
            this.lbPasswordNotMatch.Size = new System.Drawing.Size(176, 18);
            this.lbPasswordNotMatch.TabIndex = 32;
            this.lbPasswordNotMatch.Text = "Passwords don\'t match.";
            this.lbPasswordNotMatch.Visible = false;
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPasswordConfirm.Location = new System.Drawing.Point(577, 231);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Size = new System.Drawing.Size(279, 24);
            this.tbPasswordConfirm.TabIndex = 31;
            this.tbPasswordConfirm.UseSystemPasswordChar = true;
            this.tbPasswordConfirm.TextChanged += new System.EventHandler(this.tbPasswordConfirm_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(577, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Confirm password:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(577, 148);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(279, 24);
            this.tbPassword.TabIndex = 29;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(577, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(577, 75);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(279, 24);
            this.tbUsername.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(577, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(289, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Wage:";
            // 
            // tbZipcode
            // 
            this.tbZipcode.BackColor = System.Drawing.Color.Gainsboro;
            this.tbZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZipcode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZipcode.Location = new System.Drawing.Point(41, 312);
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(213, 24);
            this.tbZipcode.TabIndex = 24;
            this.tbZipcode.TextChanged += new System.EventHandler(this.tbZipcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(41, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Zip code:";
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.tbHouseNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHouseNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHouseNumber.Location = new System.Drawing.Point(348, 231);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(154, 24);
            this.tbHouseNumber.TabIndex = 22;
            this.tbHouseNumber.TextChanged += new System.EventHandler(this.tbHouseNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(348, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "House number:";
            // 
            // tbStreet
            // 
            this.tbStreet.BackColor = System.Drawing.Color.Gainsboro;
            this.tbStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStreet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreet.Location = new System.Drawing.Point(41, 231);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(288, 24);
            this.tbStreet.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Street:";
            // 
            // numWage
            // 
            this.numWage.BackColor = System.Drawing.Color.Gainsboro;
            this.numWage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numWage.DecimalPlaces = 2;
            this.numWage.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numWage.Location = new System.Drawing.Point(289, 314);
            this.numWage.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numWage.Name = "numWage";
            this.numWage.Size = new System.Drawing.Size(213, 24);
            this.numWage.TabIndex = 18;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.Location = new System.Drawing.Point(289, 75);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(213, 24);
            this.tbLastName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(289, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Last name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(226)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(41, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(815, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Add employee";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(41, 148);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(461, 24);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Gainsboro;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.Location = new System.Drawing.Point(41, 75);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(213, 24);
            this.tbFirstName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name:";
            // 
            // EmployeeContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeContentForm";
            this.Text = "EmployeeContentForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlUserInput.ResumeLayout(false);
            this.pnlUserInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Panel pnlHeader;
		private Label lbId;
		private Label lbItemId;
		private Button btnMinimize;
		private Button btnClose;
		private Label lbItem;
		private Panel panel1;
		private Panel pnlUserInput;
		private TextBox tbLastName;
		private Label label2;
		private Button btnSave;
		private Label label3;
		private TextBox tbEmail;
		private TextBox tbFirstName;
		private Label label1;
		private Panel panel3;
		private NumericUpDown numWage;
		private Label label7;
		private TextBox tbZipcode;
		private Label label6;
		private TextBox tbHouseNumber;
		private Label label4;
		private TextBox tbStreet;
		private Label label5;
		private Label lbPasswordNotMatch;
		private TextBox tbPasswordConfirm;
		private Label label10;
		private TextBox tbPassword;
		private Label label9;
		private TextBox tbUsername;
		private Label label8;
		private Label lbEmailInvalid;
		private Label lbZipcodeInavlid;
		private Label lbInvalidHouseNumber;
	}
}