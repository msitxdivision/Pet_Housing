namespace WindowsForms
{
    partial class frmLogin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabLoginForm = new System.Windows.Forms.TabControl();
            this.tabMemberLogin = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMemberLogin = new System.Windows.Forms.Button();
            this.tabMemberAdd = new System.Windows.Forms.TabPage();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.會員姓Label = new System.Windows.Forms.Label();
            this.會員姓TextBox = new System.Windows.Forms.TextBox();
            this.會員名Label = new System.Windows.Forms.Label();
            this.會員名TextBox = new System.Windows.Forms.TextBox();
            this.身分證字號Label = new System.Windows.Forms.Label();
            this.身分證字號TextBox = new System.Windows.Forms.TextBox();
            this.出生年月日Label = new System.Windows.Forms.Label();
            this.出生年月日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.性別Label = new System.Windows.Forms.Label();
            this.性別TextBox = new System.Windows.Forms.TextBox();
            this.電話號碼Label = new System.Windows.Forms.Label();
            this.電話號碼TextBox = new System.Windows.Forms.TextBox();
            this.e_MailLabel = new System.Windows.Forms.Label();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.密碼Label = new System.Windows.Forms.Label();
            this.密碼TextBox = new System.Windows.Forms.TextBox();
            this.tabAdminLogin = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.tabLoginForm.SuspendLayout();
            this.tabMemberLogin.SuspendLayout();
            this.tabMemberAdd.SuspendLayout();
            this.tabAdminLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLoginForm
            // 
            this.tabLoginForm.Controls.Add(this.tabMemberLogin);
            this.tabLoginForm.Controls.Add(this.tabMemberAdd);
            this.tabLoginForm.Controls.Add(this.tabAdminLogin);
            this.tabLoginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLoginForm.Location = new System.Drawing.Point(0, 0);
            this.tabLoginForm.Name = "tabLoginForm";
            this.tabLoginForm.SelectedIndex = 0;
            this.tabLoginForm.Size = new System.Drawing.Size(357, 499);
            this.tabLoginForm.TabIndex = 1;
            // 
            // tabMemberLogin
            // 
            this.tabMemberLogin.Controls.Add(this.textBox2);
            this.tabMemberLogin.Controls.Add(this.textBox1);
            this.tabMemberLogin.Controls.Add(this.label2);
            this.tabMemberLogin.Controls.Add(this.label1);
            this.tabMemberLogin.Controls.Add(this.btnMemberLogin);
            this.tabMemberLogin.Location = new System.Drawing.Point(4, 25);
            this.tabMemberLogin.Name = "tabMemberLogin";
            this.tabMemberLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemberLogin.Size = new System.Drawing.Size(349, 470);
            this.tabMemberLogin.TabIndex = 0;
            this.tabMemberLogin.Text = "　　登入　　";
            this.tabMemberLogin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "會員帳號：";
            // 
            // btnMemberLogin
            // 
            this.btnMemberLogin.Location = new System.Drawing.Point(84, 222);
            this.btnMemberLogin.Name = "btnMemberLogin";
            this.btnMemberLogin.Size = new System.Drawing.Size(167, 23);
            this.btnMemberLogin.TabIndex = 0;
            this.btnMemberLogin.Text = "登入";
            this.btnMemberLogin.UseVisualStyleBackColor = true;
            this.btnMemberLogin.Click += new System.EventHandler(this.btnMemberLogin_Click);
            // 
            // tabMemberAdd
            // 
            this.tabMemberAdd.AutoScroll = true;
            this.tabMemberAdd.Controls.Add(this.btnMemberAdd);
            this.tabMemberAdd.Controls.Add(this.會員姓Label);
            this.tabMemberAdd.Controls.Add(this.會員姓TextBox);
            this.tabMemberAdd.Controls.Add(this.會員名Label);
            this.tabMemberAdd.Controls.Add(this.會員名TextBox);
            this.tabMemberAdd.Controls.Add(this.身分證字號Label);
            this.tabMemberAdd.Controls.Add(this.身分證字號TextBox);
            this.tabMemberAdd.Controls.Add(this.出生年月日Label);
            this.tabMemberAdd.Controls.Add(this.出生年月日DateTimePicker);
            this.tabMemberAdd.Controls.Add(this.性別Label);
            this.tabMemberAdd.Controls.Add(this.性別TextBox);
            this.tabMemberAdd.Controls.Add(this.電話號碼Label);
            this.tabMemberAdd.Controls.Add(this.電話號碼TextBox);
            this.tabMemberAdd.Controls.Add(this.e_MailLabel);
            this.tabMemberAdd.Controls.Add(this.e_MailTextBox);
            this.tabMemberAdd.Controls.Add(this.密碼Label);
            this.tabMemberAdd.Controls.Add(this.密碼TextBox);
            this.tabMemberAdd.Location = new System.Drawing.Point(4, 25);
            this.tabMemberAdd.Name = "tabMemberAdd";
            this.tabMemberAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemberAdd.Size = new System.Drawing.Size(349, 470);
            this.tabMemberAdd.TabIndex = 1;
            this.tabMemberAdd.Text = "　加入會員　";
            this.tabMemberAdd.UseVisualStyleBackColor = true;
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Location = new System.Drawing.Point(57, 327);
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.Size = new System.Drawing.Size(218, 23);
            this.btnMemberAdd.TabIndex = 16;
            this.btnMemberAdd.Text = "確認加入";
            this.btnMemberAdd.UseVisualStyleBackColor = true;
            this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
            // 
            // 會員姓Label
            // 
            this.會員姓Label.AutoSize = true;
            this.會員姓Label.Location = new System.Drawing.Point(18, 114);
            this.會員姓Label.Name = "會員姓Label";
            this.會員姓Label.Size = new System.Drawing.Size(56, 15);
            this.會員姓Label.TabIndex = 0;
            this.會員姓Label.Text = "會員姓:";
            // 
            // 會員姓TextBox
            // 
            this.會員姓TextBox.Location = new System.Drawing.Point(110, 111);
            this.會員姓TextBox.Name = "會員姓TextBox";
            this.會員姓TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員姓TextBox.TabIndex = 1;
            // 
            // 會員名Label
            // 
            this.會員名Label.AutoSize = true;
            this.會員名Label.Location = new System.Drawing.Point(18, 145);
            this.會員名Label.Name = "會員名Label";
            this.會員名Label.Size = new System.Drawing.Size(56, 15);
            this.會員名Label.TabIndex = 2;
            this.會員名Label.Text = "會員名:";
            // 
            // 會員名TextBox
            // 
            this.會員名TextBox.Location = new System.Drawing.Point(110, 142);
            this.會員名TextBox.Name = "會員名TextBox";
            this.會員名TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員名TextBox.TabIndex = 3;
            // 
            // 身分證字號Label
            // 
            this.身分證字號Label.AutoSize = true;
            this.身分證字號Label.Location = new System.Drawing.Point(18, 176);
            this.身分證字號Label.Name = "身分證字號Label";
            this.身分證字號Label.Size = new System.Drawing.Size(86, 15);
            this.身分證字號Label.TabIndex = 4;
            this.身分證字號Label.Text = "身分證字號:";
            // 
            // 身分證字號TextBox
            // 
            this.身分證字號TextBox.Location = new System.Drawing.Point(110, 173);
            this.身分證字號TextBox.Name = "身分證字號TextBox";
            this.身分證字號TextBox.Size = new System.Drawing.Size(200, 25);
            this.身分證字號TextBox.TabIndex = 5;
            // 
            // 出生年月日Label
            // 
            this.出生年月日Label.AutoSize = true;
            this.出生年月日Label.Location = new System.Drawing.Point(18, 208);
            this.出生年月日Label.Name = "出生年月日Label";
            this.出生年月日Label.Size = new System.Drawing.Size(86, 15);
            this.出生年月日Label.TabIndex = 6;
            this.出生年月日Label.Text = "出生年月日:";
            // 
            // 出生年月日DateTimePicker
            // 
            this.出生年月日DateTimePicker.Location = new System.Drawing.Point(110, 204);
            this.出生年月日DateTimePicker.Name = "出生年月日DateTimePicker";
            this.出生年月日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.出生年月日DateTimePicker.TabIndex = 7;
            // 
            // 性別Label
            // 
            this.性別Label.AutoSize = true;
            this.性別Label.Location = new System.Drawing.Point(18, 238);
            this.性別Label.Name = "性別Label";
            this.性別Label.Size = new System.Drawing.Size(41, 15);
            this.性別Label.TabIndex = 8;
            this.性別Label.Text = "性別:";
            // 
            // 性別TextBox
            // 
            this.性別TextBox.Location = new System.Drawing.Point(110, 235);
            this.性別TextBox.Name = "性別TextBox";
            this.性別TextBox.Size = new System.Drawing.Size(200, 25);
            this.性別TextBox.TabIndex = 9;
            // 
            // 電話號碼Label
            // 
            this.電話號碼Label.AutoSize = true;
            this.電話號碼Label.Location = new System.Drawing.Point(18, 269);
            this.電話號碼Label.Name = "電話號碼Label";
            this.電話號碼Label.Size = new System.Drawing.Size(71, 15);
            this.電話號碼Label.TabIndex = 10;
            this.電話號碼Label.Text = "電話號碼:";
            // 
            // 電話號碼TextBox
            // 
            this.電話號碼TextBox.Location = new System.Drawing.Point(110, 266);
            this.電話號碼TextBox.Name = "電話號碼TextBox";
            this.電話號碼TextBox.Size = new System.Drawing.Size(200, 25);
            this.電話號碼TextBox.TabIndex = 11;
            // 
            // e_MailLabel
            // 
            this.e_MailLabel.AutoSize = true;
            this.e_MailLabel.Location = new System.Drawing.Point(18, 52);
            this.e_MailLabel.Name = "e_MailLabel";
            this.e_MailLabel.Size = new System.Drawing.Size(52, 15);
            this.e_MailLabel.TabIndex = 12;
            this.e_MailLabel.Text = "E-Mail:";
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.Location = new System.Drawing.Point(110, 49);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(200, 25);
            this.e_MailTextBox.TabIndex = 13;
            // 
            // 密碼Label
            // 
            this.密碼Label.AutoSize = true;
            this.密碼Label.Location = new System.Drawing.Point(18, 83);
            this.密碼Label.Name = "密碼Label";
            this.密碼Label.Size = new System.Drawing.Size(41, 15);
            this.密碼Label.TabIndex = 14;
            this.密碼Label.Text = "密碼:";
            // 
            // 密碼TextBox
            // 
            this.密碼TextBox.Location = new System.Drawing.Point(110, 80);
            this.密碼TextBox.Name = "密碼TextBox";
            this.密碼TextBox.Size = new System.Drawing.Size(200, 25);
            this.密碼TextBox.TabIndex = 15;
            // 
            // tabAdminLogin
            // 
            this.tabAdminLogin.Controls.Add(this.textBox3);
            this.tabAdminLogin.Controls.Add(this.textBox4);
            this.tabAdminLogin.Controls.Add(this.label3);
            this.tabAdminLogin.Controls.Add(this.label4);
            this.tabAdminLogin.Controls.Add(this.btnAdminLogin);
            this.tabAdminLogin.Location = new System.Drawing.Point(4, 25);
            this.tabAdminLogin.Name = "tabAdminLogin";
            this.tabAdminLogin.Size = new System.Drawing.Size(349, 470);
            this.tabAdminLogin.TabIndex = 2;
            this.tabAdminLogin.Text = "管理員登入";
            this.tabAdminLogin.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 25);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 25);
            this.textBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "密碼：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "會員帳號：";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(86, 221);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(167, 23);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "登入";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 499);
            this.Controls.Add(this.tabLoginForm);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.tabLoginForm.ResumeLayout(false);
            this.tabMemberLogin.ResumeLayout(false);
            this.tabMemberLogin.PerformLayout();
            this.tabMemberAdd.ResumeLayout(false);
            this.tabMemberAdd.PerformLayout();
            this.tabAdminLogin.ResumeLayout(false);
            this.tabAdminLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLoginForm;
        private System.Windows.Forms.TabPage tabMemberLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMemberLogin;
        private System.Windows.Forms.TabPage tabMemberAdd;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.Label 會員姓Label;
        private System.Windows.Forms.TextBox 會員姓TextBox;
        private System.Windows.Forms.Label 會員名Label;
        private System.Windows.Forms.TextBox 會員名TextBox;
        private System.Windows.Forms.Label 身分證字號Label;
        private System.Windows.Forms.TextBox 身分證字號TextBox;
        private System.Windows.Forms.Label 出生年月日Label;
        private System.Windows.Forms.DateTimePicker 出生年月日DateTimePicker;
        private System.Windows.Forms.Label 性別Label;
        private System.Windows.Forms.TextBox 性別TextBox;
        private System.Windows.Forms.Label 電話號碼Label;
        private System.Windows.Forms.TextBox 電話號碼TextBox;
        private System.Windows.Forms.Label e_MailLabel;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.Label 密碼Label;
        private System.Windows.Forms.TextBox 密碼TextBox;
        private System.Windows.Forms.TabPage tabAdminLogin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdminLogin;

    }
}

