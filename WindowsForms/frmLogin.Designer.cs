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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label 會員姓Label;
            System.Windows.Forms.Label 會員名Label;
            System.Windows.Forms.Label 身分證字號Label;
            System.Windows.Forms.Label 出生年月日Label;
            System.Windows.Forms.Label 性別Label;
            System.Windows.Forms.Label 電話號碼Label;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label 密碼Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tabLoginForm = new System.Windows.Forms.TabControl();
            this.tabMemberLogin = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMemberLogin = new System.Windows.Forms.Button();
            this.tabMemberAdd = new System.Windows.Forms.TabPage();
            this.btnMemberAdd = new System.Windows.Forms.Button();
            this.會員姓TextBox = new System.Windows.Forms.TextBox();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataSet = new WindowsForms.MemberDataSet();
            this.會員名TextBox = new System.Windows.Forms.TextBox();
            this.身分證字號TextBox = new System.Windows.Forms.TextBox();
            this.出生年月日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.性別TextBox = new System.Windows.Forms.TextBox();
            this.電話號碼TextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.密碼TextBox = new System.Windows.Forms.TextBox();
            this.tabAdminLogin = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.memberTableAdapter = new WindowsForms.MemberDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new WindowsForms.MemberDataSetTableAdapters.TableAdapterManager();
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.memberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            會員姓Label = new System.Windows.Forms.Label();
            會員名Label = new System.Windows.Forms.Label();
            身分證字號Label = new System.Windows.Forms.Label();
            出生年月日Label = new System.Windows.Forms.Label();
            性別Label = new System.Windows.Forms.Label();
            電話號碼Label = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            密碼Label = new System.Windows.Forms.Label();
            this.tabLoginForm.SuspendLayout();
            this.tabMemberLogin.SuspendLayout();
            this.tabMemberAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).BeginInit();
            this.tabAdminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // 會員姓Label
            // 
            會員姓Label.AutoSize = true;
            會員姓Label.Location = new System.Drawing.Point(18, 114);
            會員姓Label.Name = "會員姓Label";
            會員姓Label.Size = new System.Drawing.Size(56, 15);
            會員姓Label.TabIndex = 0;
            會員姓Label.Text = "會員姓:";
            // 
            // 會員名Label
            // 
            會員名Label.AutoSize = true;
            會員名Label.Location = new System.Drawing.Point(18, 145);
            會員名Label.Name = "會員名Label";
            會員名Label.Size = new System.Drawing.Size(56, 15);
            會員名Label.TabIndex = 2;
            會員名Label.Text = "會員名:";
            // 
            // 身分證字號Label
            // 
            身分證字號Label.AutoSize = true;
            身分證字號Label.Location = new System.Drawing.Point(18, 176);
            身分證字號Label.Name = "身分證字號Label";
            身分證字號Label.Size = new System.Drawing.Size(86, 15);
            身分證字號Label.TabIndex = 4;
            身分證字號Label.Text = "身分證字號:";
            // 
            // 出生年月日Label
            // 
            出生年月日Label.AutoSize = true;
            出生年月日Label.Location = new System.Drawing.Point(18, 208);
            出生年月日Label.Name = "出生年月日Label";
            出生年月日Label.Size = new System.Drawing.Size(86, 15);
            出生年月日Label.TabIndex = 6;
            出生年月日Label.Text = "出生年月日:";
            // 
            // 性別Label
            // 
            性別Label.AutoSize = true;
            性別Label.Location = new System.Drawing.Point(18, 238);
            性別Label.Name = "性別Label";
            性別Label.Size = new System.Drawing.Size(41, 15);
            性別Label.TabIndex = 8;
            性別Label.Text = "性別:";
            // 
            // 電話號碼Label
            // 
            電話號碼Label.AutoSize = true;
            電話號碼Label.Location = new System.Drawing.Point(18, 269);
            電話號碼Label.Name = "電話號碼Label";
            電話號碼Label.Size = new System.Drawing.Size(71, 15);
            電話號碼Label.TabIndex = 10;
            電話號碼Label.Text = "電話號碼:";
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(18, 52);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(52, 15);
            e_MailLabel.TabIndex = 12;
            e_MailLabel.Text = "E-Mail:";
            // 
            // 密碼Label
            // 
            密碼Label.AutoSize = true;
            密碼Label.Location = new System.Drawing.Point(18, 83);
            密碼Label.Name = "密碼Label";
            密碼Label.Size = new System.Drawing.Size(41, 15);
            密碼Label.TabIndex = 14;
            密碼Label.Text = "密碼:";
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
            this.tabLoginForm.Size = new System.Drawing.Size(340, 456);
            this.tabLoginForm.TabIndex = 0;
            this.tabLoginForm.Click += new System.EventHandler(this.btnMemberAdd_Click);
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
            this.tabMemberLogin.Size = new System.Drawing.Size(332, 427);
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
            this.tabMemberAdd.Controls.Add(會員姓Label);
            this.tabMemberAdd.Controls.Add(this.會員姓TextBox);
            this.tabMemberAdd.Controls.Add(會員名Label);
            this.tabMemberAdd.Controls.Add(this.會員名TextBox);
            this.tabMemberAdd.Controls.Add(身分證字號Label);
            this.tabMemberAdd.Controls.Add(this.身分證字號TextBox);
            this.tabMemberAdd.Controls.Add(出生年月日Label);
            this.tabMemberAdd.Controls.Add(this.出生年月日DateTimePicker);
            this.tabMemberAdd.Controls.Add(性別Label);
            this.tabMemberAdd.Controls.Add(this.性別TextBox);
            this.tabMemberAdd.Controls.Add(電話號碼Label);
            this.tabMemberAdd.Controls.Add(this.電話號碼TextBox);
            this.tabMemberAdd.Controls.Add(e_MailLabel);
            this.tabMemberAdd.Controls.Add(this.e_MailTextBox);
            this.tabMemberAdd.Controls.Add(密碼Label);
            this.tabMemberAdd.Controls.Add(this.密碼TextBox);
            this.tabMemberAdd.Location = new System.Drawing.Point(4, 25);
            this.tabMemberAdd.Name = "tabMemberAdd";
            this.tabMemberAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemberAdd.Size = new System.Drawing.Size(332, 427);
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
            // 會員姓TextBox
            // 
            this.會員姓TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "會員姓", true));
            this.會員姓TextBox.Location = new System.Drawing.Point(110, 111);
            this.會員姓TextBox.Name = "會員姓TextBox";
            this.會員姓TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員姓TextBox.TabIndex = 1;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.memberDataSet;
            // 
            // memberDataSet
            // 
            this.memberDataSet.DataSetName = "MemberDataSet";
            this.memberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 會員名TextBox
            // 
            this.會員名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "會員名", true));
            this.會員名TextBox.Location = new System.Drawing.Point(110, 142);
            this.會員名TextBox.Name = "會員名TextBox";
            this.會員名TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員名TextBox.TabIndex = 3;
            // 
            // 身分證字號TextBox
            // 
            this.身分證字號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "身分證字號", true));
            this.身分證字號TextBox.Location = new System.Drawing.Point(110, 173);
            this.身分證字號TextBox.Name = "身分證字號TextBox";
            this.身分證字號TextBox.Size = new System.Drawing.Size(200, 25);
            this.身分證字號TextBox.TabIndex = 5;
            // 
            // 出生年月日DateTimePicker
            // 
            this.出生年月日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberBindingSource, "出生年月日", true));
            this.出生年月日DateTimePicker.Location = new System.Drawing.Point(110, 204);
            this.出生年月日DateTimePicker.Name = "出生年月日DateTimePicker";
            this.出生年月日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.出生年月日DateTimePicker.TabIndex = 7;
            // 
            // 性別TextBox
            // 
            this.性別TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "性別", true));
            this.性別TextBox.Location = new System.Drawing.Point(110, 235);
            this.性別TextBox.Name = "性別TextBox";
            this.性別TextBox.Size = new System.Drawing.Size(200, 25);
            this.性別TextBox.TabIndex = 9;
            // 
            // 電話號碼TextBox
            // 
            this.電話號碼TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "電話號碼", true));
            this.電話號碼TextBox.Location = new System.Drawing.Point(110, 266);
            this.電話號碼TextBox.Name = "電話號碼TextBox";
            this.電話號碼TextBox.Size = new System.Drawing.Size(200, 25);
            this.電話號碼TextBox.TabIndex = 11;
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "E-Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(110, 49);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(200, 25);
            this.e_MailTextBox.TabIndex = 13;
            // 
            // 密碼TextBox
            // 
            this.密碼TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "密碼", true));
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
            this.tabAdminLogin.Size = new System.Drawing.Size(332, 427);
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
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HouseTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.PetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsForms.MemberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberBindingNavigator
            // 
            this.memberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberBindingNavigator.BindingSource = this.memberBindingSource;
            this.memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.memberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.memberBindingNavigatorSaveItem});
            this.memberBindingNavigator.Location = new System.Drawing.Point(0, 429);
            this.memberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memberBindingNavigator.Name = "memberBindingNavigator";
            this.memberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memberBindingNavigator.Size = new System.Drawing.Size(340, 27);
            this.memberBindingNavigator.TabIndex = 1;
            this.memberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // memberBindingNavigatorSaveItem
            // 
            this.memberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memberBindingNavigatorSaveItem.Image")));
            this.memberBindingNavigatorSaveItem.Name = "memberBindingNavigatorSaveItem";
            this.memberBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.memberBindingNavigatorSaveItem.Text = "儲存資料";
            this.memberBindingNavigatorSaveItem.Click += new System.EventHandler(this.memberBindingNavigatorSaveItem_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 456);
            this.Controls.Add(this.memberBindingNavigator);
            this.Controls.Add(this.tabLoginForm);
            this.Name = "frmLogin";
            this.Text = "PetHouse";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.tabLoginForm.ResumeLayout(false);
            this.tabMemberLogin.ResumeLayout(false);
            this.tabMemberLogin.PerformLayout();
            this.tabMemberAdd.ResumeLayout(false);
            this.tabMemberAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).EndInit();
            this.tabAdminLogin.ResumeLayout(false);
            this.tabAdminLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage tabAdminLogin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdminLogin;
        private MemberDataSet memberDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private MemberDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
        private MemberDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memberBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton memberBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnMemberAdd;
        private System.Windows.Forms.TextBox 會員姓TextBox;
        private System.Windows.Forms.TextBox 會員名TextBox;
        private System.Windows.Forms.TextBox 身分證字號TextBox;
        private System.Windows.Forms.DateTimePicker 出生年月日DateTimePicker;
        private System.Windows.Forms.TextBox 性別TextBox;
        private System.Windows.Forms.TextBox 電話號碼TextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox 密碼TextBox;

    }
}

