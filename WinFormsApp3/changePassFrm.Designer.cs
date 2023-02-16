namespace LogInDemo
{
    partial class changePassFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newRePassWord = new System.Windows.Forms.TextBox();
            this.newPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.acceptBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Retype the new Password";
            // 
            // newRePassWord
            // 
            this.newRePassWord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newRePassWord.Location = new System.Drawing.Point(263, 94);
            this.newRePassWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newRePassWord.Name = "newRePassWord";
            this.newRePassWord.PasswordChar = '*';
            this.newRePassWord.Size = new System.Drawing.Size(347, 27);
            this.newRePassWord.TabIndex = 1;
            // 
            // newPassWord
            // 
            this.newPassWord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassWord.Location = new System.Drawing.Point(263, 64);
            this.newPassWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newPassWord.Name = "newPassWord";
            this.newPassWord.PasswordChar = '*';
            this.newPassWord.Size = new System.Drawing.Size(347, 27);
            this.newPassWord.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Old Password";
            // 
            // oldPassword
            // 
            this.oldPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassword.Location = new System.Drawing.Point(263, 124);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(347, 27);
            this.oldPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Change Password...";
            // 
            // cancelBttn
            // 
            this.cancelBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelBttn.FlatAppearance.BorderSize = 0;
            this.cancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBttn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBttn.ForeColor = System.Drawing.Color.Black;
            this.cancelBttn.Location = new System.Drawing.Point(34, 172);
            this.cancelBttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(144, 29);
            this.cancelBttn.TabIndex = 4;
            this.cancelBttn.Text = "Cancel";
            this.cancelBttn.UseVisualStyleBackColor = false;
            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click);
            // 
            // acceptBttn
            // 
            this.acceptBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.acceptBttn.FlatAppearance.BorderSize = 0;
            this.acceptBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptBttn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptBttn.ForeColor = System.Drawing.Color.White;
            this.acceptBttn.Location = new System.Drawing.Point(466, 172);
            this.acceptBttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acceptBttn.Name = "acceptBttn";
            this.acceptBttn.Size = new System.Drawing.Size(144, 29);
            this.acceptBttn.TabIndex = 3;
            this.acceptBttn.Text = "Accept";
            this.acceptBttn.UseVisualStyleBackColor = false;
            this.acceptBttn.Click += new System.EventHandler(this.acceptBttn_Click);
            // 
            // changePassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(640, 218);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.acceptBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newRePassWord);
            this.Controls.Add(this.newPassWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "changePassFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox newRePassWord;
        private TextBox newPassWord;
        private Label label3;
        private TextBox oldPassword;
        private Label label4;
        private Button cancelBttn;
        private Button acceptBttn;
    }
}