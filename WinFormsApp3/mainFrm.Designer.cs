using System.Windows.Forms;

namespace LogInDemo
{
    partial class mainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.pro4Tab = new System.Windows.Forms.TabPage();
            this.changePasswordBttn = new System.Windows.Forms.Button();
            this.genderF = new System.Windows.Forms.RadioButton();
            this.genderM = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.appSignOut = new System.Windows.Forms.Button();
            this.appExit = new System.Windows.Forms.Button();
            this.saveChangeBttn = new System.Windows.Forms.Button();
            this.pro4BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pro4Name = new System.Windows.Forms.TextBox();
            this.pro4Phone = new System.Windows.Forms.TextBox();
            this.pro4Id = new System.Windows.Forms.TextBox();
            this.pro4Email = new System.Windows.Forms.TextBox();
            this.pro4Password = new System.Windows.Forms.TextBox();
            this.pro4Username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketTab = new System.Windows.Forms.TabPage();
            this.sessionFlw = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.searchBttn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCinema = new System.Windows.Forms.ComboBox();
            this.timePick = new System.Windows.Forms.DateTimePicker();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.settingTab = new System.Windows.Forms.TabControl();
            this.tabHis = new System.Windows.Forms.TabPage();
            this.hisFlw = new System.Windows.Forms.FlowLayoutPanel();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabFoods = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabRevenue = new System.Windows.Forms.TabPage();
            this.textBoxToday = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.userDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userDAOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pro4Tab.SuspendLayout();
            this.ticketTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settingTab.SuspendLayout();
            this.tabHis.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDAOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pro4Tab
            // 
            this.pro4Tab.Controls.Add(this.changePasswordBttn);
            this.pro4Tab.Controls.Add(this.genderF);
            this.pro4Tab.Controls.Add(this.genderM);
            this.pro4Tab.Controls.Add(this.label13);
            this.pro4Tab.Controls.Add(this.appSignOut);
            this.pro4Tab.Controls.Add(this.appExit);
            this.pro4Tab.Controls.Add(this.saveChangeBttn);
            this.pro4Tab.Controls.Add(this.pro4BirthDay);
            this.pro4Tab.Controls.Add(this.label9);
            this.pro4Tab.Controls.Add(this.label8);
            this.pro4Tab.Controls.Add(this.pro4Name);
            this.pro4Tab.Controls.Add(this.pro4Phone);
            this.pro4Tab.Controls.Add(this.pro4Id);
            this.pro4Tab.Controls.Add(this.pro4Email);
            this.pro4Tab.Controls.Add(this.pro4Password);
            this.pro4Tab.Controls.Add(this.pro4Username);
            this.pro4Tab.Controls.Add(this.label7);
            this.pro4Tab.Controls.Add(this.label6);
            this.pro4Tab.Controls.Add(this.label5);
            this.pro4Tab.Controls.Add(this.label4);
            this.pro4Tab.Controls.Add(this.label3);
            this.pro4Tab.Controls.Add(this.label2);
            this.pro4Tab.Location = new System.Drawing.Point(4, 32);
            this.pro4Tab.Name = "pro4Tab";
            this.pro4Tab.Padding = new System.Windows.Forms.Padding(3);
            this.pro4Tab.Size = new System.Drawing.Size(1052, 573);
            this.pro4Tab.TabIndex = 1;
            this.pro4Tab.Text = "Profile";
            this.pro4Tab.UseVisualStyleBackColor = true;
            this.pro4Tab.Click += new System.EventHandler(this.pro4Tab_Click);
            // 
            // changePasswordBttn
            // 
            this.changePasswordBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordBttn.BackColor = System.Drawing.Color.DarkCyan;
            this.changePasswordBttn.FlatAppearance.BorderSize = 0;
            this.changePasswordBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordBttn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBttn.Location = new System.Drawing.Point(744, 509);
            this.changePasswordBttn.Name = "changePasswordBttn";
            this.changePasswordBttn.Size = new System.Drawing.Size(226, 45);
            this.changePasswordBttn.TabIndex = 41;
            this.changePasswordBttn.Text = "Change Password";
            this.changePasswordBttn.UseVisualStyleBackColor = false;
            this.changePasswordBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // genderF
            // 
            this.genderF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genderF.AutoSize = true;
            this.genderF.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderF.Location = new System.Drawing.Point(771, 331);
            this.genderF.Name = "genderF";
            this.genderF.Size = new System.Drawing.Size(118, 31);
            this.genderF.TabIndex = 38;
            this.genderF.TabStop = true;
            this.genderF.Text = "Female";
            this.genderF.UseVisualStyleBackColor = true;
            // 
            // genderM
            // 
            this.genderM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.genderM.AutoSize = true;
            this.genderM.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderM.Location = new System.Drawing.Point(481, 331);
            this.genderM.Name = "genderM";
            this.genderM.Size = new System.Drawing.Size(93, 31);
            this.genderM.TabIndex = 39;
            this.genderM.TabStop = true;
            this.genderM.Text = "Male";
            this.genderM.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(66, 336);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 27);
            this.label13.TabIndex = 40;
            this.label13.Text = "Gender";
            // 
            // appSignOut
            // 
            this.appSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appSignOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.appSignOut.FlatAppearance.BorderSize = 0;
            this.appSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appSignOut.ForeColor = System.Drawing.Color.White;
            this.appSignOut.Location = new System.Drawing.Point(67, 456);
            this.appSignOut.Name = "appSignOut";
            this.appSignOut.Size = new System.Drawing.Size(191, 45);
            this.appSignOut.TabIndex = 37;
            this.appSignOut.Text = "Sign Out";
            this.appSignOut.UseVisualStyleBackColor = false;
            this.appSignOut.Click += new System.EventHandler(this.appSignOut_Click);
            // 
            // appExit
            // 
            this.appExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.appExit.BackColor = System.Drawing.Color.DarkCyan;
            this.appExit.FlatAppearance.BorderSize = 0;
            this.appExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appExit.ForeColor = System.Drawing.Color.White;
            this.appExit.Location = new System.Drawing.Point(67, 509);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(191, 45);
            this.appExit.TabIndex = 36;
            this.appExit.Text = "Exit";
            this.appExit.UseVisualStyleBackColor = false;
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // saveChangeBttn
            // 
            this.saveChangeBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangeBttn.BackColor = System.Drawing.Color.DarkCyan;
            this.saveChangeBttn.FlatAppearance.BorderSize = 0;
            this.saveChangeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangeBttn.ForeColor = System.Drawing.Color.White;
            this.saveChangeBttn.Location = new System.Drawing.Point(781, 456);
            this.saveChangeBttn.Name = "saveChangeBttn";
            this.saveChangeBttn.Size = new System.Drawing.Size(191, 45);
            this.saveChangeBttn.TabIndex = 7;
            this.saveChangeBttn.Text = "Save Change";
            this.saveChangeBttn.UseVisualStyleBackColor = false;
            this.saveChangeBttn.Click += new System.EventHandler(this.saveChangeBttn_Click);
            // 
            // pro4BirthDay
            // 
            this.pro4BirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4BirthDay.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pro4BirthDay.Location = new System.Drawing.Point(501, 161);
            this.pro4BirthDay.Name = "pro4BirthDay";
            this.pro4BirthDay.Size = new System.Drawing.Size(468, 36);
            this.pro4BirthDay.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(65, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(66, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Full Name";
            // 
            // pro4Name
            // 
            this.pro4Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4Name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4Name.Location = new System.Drawing.Point(501, 118);
            this.pro4Name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pro4Name.Name = "pro4Name";
            this.pro4Name.Size = new System.Drawing.Size(469, 36);
            this.pro4Name.TabIndex = 2;
            // 
            // pro4Phone
            // 
            this.pro4Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4Phone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4Phone.Location = new System.Drawing.Point(501, 292);
            this.pro4Phone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pro4Phone.Name = "pro4Phone";
            this.pro4Phone.Size = new System.Drawing.Size(469, 36);
            this.pro4Phone.TabIndex = 6;
            // 
            // pro4Id
            // 
            this.pro4Id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4Id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4Id.Location = new System.Drawing.Point(502, 248);
            this.pro4Id.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pro4Id.Name = "pro4Id";
            this.pro4Id.Size = new System.Drawing.Size(469, 36);
            this.pro4Id.TabIndex = 5;
            // 
            // pro4Email
            // 
            this.pro4Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4Email.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4Email.Location = new System.Drawing.Point(502, 204);
            this.pro4Email.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pro4Email.Name = "pro4Email";
            this.pro4Email.Size = new System.Drawing.Size(469, 36);
            this.pro4Email.TabIndex = 4;
            // 
            // pro4Password
            // 
            this.pro4Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4Password.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4Password.Location = new System.Drawing.Point(550, 402);
            this.pro4Password.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pro4Password.Name = "pro4Password";
            this.pro4Password.PasswordChar = '*';
            this.pro4Password.Size = new System.Drawing.Size(420, 36);
            this.pro4Password.TabIndex = 1;
            // 
            // pro4Username
            // 
            this.pro4Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pro4Username.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pro4Username.Location = new System.Drawing.Point(501, 74);
            this.pro4Username.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pro4Username.Name = "pro4Username";
            this.pro4Username.ReadOnly = true;
            this.pro4Username.Size = new System.Drawing.Size(469, 36);
            this.pro4Username.TabIndex = 0;
            this.pro4Username.TextChanged += new System.EventHandler(this.pro4Username_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.label7.Location = new System.Drawing.Point(60, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 55);
            this.label7.TabIndex = 33;
            this.label7.Text = "Profile";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(65, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "National Identification Number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enter the Password to save change";
            // 
            // ticketTab
            // 
            this.ticketTab.Controls.Add(this.sessionFlw);
            this.ticketTab.Controls.Add(this.panel1);
            this.ticketTab.Location = new System.Drawing.Point(4, 32);
            this.ticketTab.Name = "ticketTab";
            this.ticketTab.Padding = new System.Windows.Forms.Padding(3);
            this.ticketTab.Size = new System.Drawing.Size(1052, 573);
            this.ticketTab.TabIndex = 0;
            this.ticketTab.Text = "Purchase Ticket";
            this.ticketTab.UseVisualStyleBackColor = true;
            // 
            // sessionFlw
            // 
            this.sessionFlw.AutoScroll = true;
            this.sessionFlw.BackColor = System.Drawing.Color.Gainsboro;
            this.sessionFlw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionFlw.Location = new System.Drawing.Point(3, 109);
            this.sessionFlw.Name = "sessionFlw";
            this.sessionFlw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sessionFlw.Size = new System.Drawing.Size(1046, 461);
            this.sessionFlw.TabIndex = 10;
            this.sessionFlw.Paint += new System.Windows.Forms.PaintEventHandler(this.sessionFlw_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.searchBttn);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbCinema);
            this.panel1.Controls.Add(this.timePick);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Controls.Add(this.cbMovie);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 106);
            this.panel1.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cinema:";
            // 
            // searchBttn
            // 
            this.searchBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBttn.BackColor = System.Drawing.Color.DarkCyan;
            this.searchBttn.FlatAppearance.BorderSize = 0;
            this.searchBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBttn.ForeColor = System.Drawing.Color.White;
            this.searchBttn.Location = new System.Drawing.Point(901, 21);
            this.searchBttn.Name = "searchBttn";
            this.searchBttn.Size = new System.Drawing.Size(111, 61);
            this.searchBttn.TabIndex = 14;
            this.searchBttn.Text = "Search";
            this.searchBttn.UseVisualStyleBackColor = false;
            this.searchBttn.Click += new System.EventHandler(this.searchBttn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Date:";
            // 
            // cbCinema
            // 
            this.cbCinema.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbCinema.FormattingEnabled = true;
            this.cbCinema.Location = new System.Drawing.Point(549, 23);
            this.cbCinema.Name = "cbCinema";
            this.cbCinema.Size = new System.Drawing.Size(257, 31);
            this.cbCinema.TabIndex = 13;
            this.cbCinema.SelectedIndexChanged += new System.EventHandler(this.cbCinema_SelectedIndexChanged);
            // 
            // timePick
            // 
            this.timePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timePick.Location = new System.Drawing.Point(549, 56);
            this.timePick.Name = "timePick";
            this.timePick.Size = new System.Drawing.Size(257, 32);
            this.timePick.TabIndex = 10;
            this.timePick.ValueChanged += new System.EventHandler(this.timePick_ValueChanged);
            // 
            // cbArea
            // 
            this.cbArea.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(106, 21);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(252, 31);
            this.cbArea.TabIndex = 6;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            // 
            // cbMovie
            // 
            this.cbMovie.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(106, 58);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(252, 31);
            this.cbMovie.TabIndex = 7;
            this.cbMovie.SelectedIndexChanged += new System.EventHandler(this.cbMovie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Area:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Movie:";
            // 
            // settingTab
            // 
            this.settingTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingTab.Controls.Add(this.ticketTab);
            this.settingTab.Controls.Add(this.pro4Tab);
            this.settingTab.Controls.Add(this.tabHis);
            this.settingTab.Controls.Add(this.tabUsers);
            this.settingTab.Controls.Add(this.tabFoods);
            this.settingTab.Controls.Add(this.tabRevenue);
            this.settingTab.Location = new System.Drawing.Point(20, 106);
            this.settingTab.Margin = new System.Windows.Forms.Padding(10);
            this.settingTab.Name = "settingTab";
            this.settingTab.SelectedIndex = 0;
            this.settingTab.Size = new System.Drawing.Size(1060, 609);
            this.settingTab.TabIndex = 0;
            this.settingTab.SelectedIndexChanged += new System.EventHandler(this.settingTab_SelectedIndexChanged);
            // 
            // tabHis
            // 
            this.tabHis.Controls.Add(this.hisFlw);
            this.tabHis.Location = new System.Drawing.Point(4, 32);
            this.tabHis.Name = "tabHis";
            this.tabHis.Padding = new System.Windows.Forms.Padding(3);
            this.tabHis.Size = new System.Drawing.Size(1052, 573);
            this.tabHis.TabIndex = 2;
            this.tabHis.Text = "History";
            this.tabHis.UseVisualStyleBackColor = true;
            this.tabHis.Enter += new System.EventHandler(this.tabHis_Enter);
            // 
            // hisFlw
            // 
            this.hisFlw.AutoScroll = true;
            this.hisFlw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hisFlw.Location = new System.Drawing.Point(3, 3);
            this.hisFlw.Name = "hisFlw";
            this.hisFlw.Size = new System.Drawing.Size(1046, 567);
            this.hisFlw.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.label14);
            this.tabUsers.Controls.Add(this.dataGridView1);
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1052, 576);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.label14.Location = new System.Drawing.Point(397, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 36);
            this.label14.TabIndex = 3;
            this.label14.Text = "Users Management";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 592);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabFoods
            // 
            this.tabFoods.Controls.Add(this.label15);
            this.tabFoods.Controls.Add(this.dataGridView2);
            this.tabFoods.Location = new System.Drawing.Point(4, 29);
            this.tabFoods.Name = "tabFoods";
            this.tabFoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabFoods.Size = new System.Drawing.Size(1052, 576);
            this.tabFoods.TabIndex = 4;
            this.tabFoods.Text = "Foods";
            this.tabFoods.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.label15.Location = new System.Drawing.Point(394, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(307, 36);
            this.label15.TabIndex = 1;
            this.label15.Text = "Foods Management";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1040, 590);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabRevenue
            // 
            this.tabRevenue.Controls.Add(this.textBoxToday);
            this.tabRevenue.Controls.Add(this.dateTimePicker1);
            this.tabRevenue.Controls.Add(this.label18);
            this.tabRevenue.Controls.Add(this.label17);
            this.tabRevenue.Controls.Add(this.dataGridView4);
            this.tabRevenue.Controls.Add(this.label16);
            this.tabRevenue.Controls.Add(this.dataGridView3);
            this.tabRevenue.Location = new System.Drawing.Point(4, 29);
            this.tabRevenue.Name = "tabRevenue";
            this.tabRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevenue.Size = new System.Drawing.Size(1052, 576);
            this.tabRevenue.TabIndex = 5;
            this.tabRevenue.Text = "Revenue";
            this.tabRevenue.UseVisualStyleBackColor = true;
            this.tabRevenue.Click += new System.EventHandler(this.tabRevenue_Click);
            // 
            // textBoxToday
            // 
            this.textBoxToday.Location = new System.Drawing.Point(796, 352);
            this.textBoxToday.Name = "textBoxToday";
            this.textBoxToday.ReadOnly = true;
            this.textBoxToday.Size = new System.Drawing.Size(250, 32);
            this.textBoxToday.TabIndex = 8;
            this.textBoxToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxToday.TextChanged += new System.EventHandler(this.textBoxToday_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(796, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 32);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(6, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 23);
            this.label18.TabIndex = 6;
            this.label18.Text = "Revenue Today";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Yellow;
            this.label17.Location = new System.Drawing.Point(6, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 23);
            this.label17.TabIndex = 5;
            this.label17.Text = "Revenue by month";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 399);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(1040, 168);
            this.dataGridView4.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.label16.Location = new System.Drawing.Point(394, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(352, 36);
            this.label16.TabIndex = 3;
            this.label16.Text = "Revenue Management";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(1040, 244);
            this.dataGridView3.TabIndex = 2;
            // 
            // userDAOBindingSource
            // 
            this.userDAOBindingSource.DataSource = typeof(LogInDemo.DAO.UserDAO);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::LogInDemo.Properties.Resources.download_icon_CLOSE_131994911256789607_512;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1051, 0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(49, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImage = global::LogInDemo.Properties.Resources.maximize;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1002, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 24);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.BackgroundImage = global::LogInDemo.Properties.Resources.download_icon_minimize_minus_remove_sign_icon_1320085940403912850_512;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(961, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 24);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userDAOBindingSource1
            // 
            this.userDAOBindingSource1.DataSource = typeof(LogInDemo.DAO.UserDAO);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::LogInDemo.Properties.Resources.banner1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1063, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mainFrm
            // 
            this.AcceptButton = this.saveChangeBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.settingTab);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainFrm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaxy Cinema";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.pro4Tab.ResumeLayout(false);
            this.pro4Tab.PerformLayout();
            this.ticketTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingTab.ResumeLayout(false);
            this.tabHis.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabFoods.ResumeLayout(false);
            this.tabFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabRevenue.ResumeLayout(false);
            this.tabRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDAOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage pro4Tab;
        private Button appSignOut;
        private Button appExit;
        private Button saveChangeBttn;
        private DateTimePicker pro4BirthDay;
        private Label label9;
        private Label label8;
        private TextBox pro4Name;
        private TextBox pro4Phone;
        private TextBox pro4Id;
        private TextBox pro4Email;
        private TextBox pro4Password;
        private TextBox pro4Username;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage ticketTab;
        private FlowLayoutPanel sessionFlw;
        private TabControl settingTab;
        private RadioButton genderF;
        private RadioButton genderM;
        private Label label13;
        private Button changePasswordBttn;
        private Panel panel1;
        private Label label11;
        private Button searchBttn;
        private Label label12;
        private ComboBox cbCinema;
        private DateTimePicker timePick;
        private ComboBox cbArea;
        private ComboBox cbMovie;
        private Label label1;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabPage tabHis;
        private FlowLayoutPanel hisFlw;
        private TabPage tabUsers;
        private TabPage tabFoods;
        private TabPage tabRevenue;
        private DataGridView dataGridView1;
        private BindingSource userDAOBindingSource;
        private BindingSource userDAOBindingSource1;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridView dataGridView2;
        private Label label14;
        private Label label15;
        private Label label16;
        private DataGridView dataGridView3;
        private DateTimePicker dateTimePicker1;
        private Label label18;
        private Label label17;
        private DataGridView dataGridView4;
        private TextBox textBoxToday;
        private PictureBox pictureBox1;
    }
}