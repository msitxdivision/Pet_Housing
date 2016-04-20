namespace WindowsForms
{
    partial class frmAdminUI
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
            System.Windows.Forms.Label 會員編號Label;
            System.Windows.Forms.Label 會員姓Label;
            System.Windows.Forms.Label 會員名Label;
            System.Windows.Forms.Label 身分證字號Label;
            System.Windows.Forms.Label 出生年月日Label;
            System.Windows.Forms.Label 性別Label;
            System.Windows.Forms.Label 電話號碼Label;
            System.Windows.Forms.Label e_MailLabel;
            System.Windows.Forms.Label 密碼Label;
            System.Windows.Forms.Label 註解Label;
            System.Windows.Forms.Label 提供環境Label;
            System.Windows.Forms.Label 寵物編號Label;
            System.Windows.Forms.Label 會員編號Label1;
            System.Windows.Forms.Label 寵物姓名Label;
            System.Windows.Forms.Label 寵物類型Label;
            System.Windows.Forms.Label 寵物品種Label;
            System.Windows.Forms.Label 寵物體型Label;
            System.Windows.Forms.Label 年齡Label;
            System.Windows.Forms.Label 體重Label;
            System.Windows.Forms.Label 介紹及注意事項Label;
            System.Windows.Forms.Label 照片Label;
            System.Windows.Forms.Label 房屋編號Label;
            System.Windows.Forms.Label 會員編號Label2;
            System.Windows.Forms.Label 活動空間Label;
            System.Windows.Forms.Label 房屋區域Label;
            System.Windows.Forms.Label 開放入住日期Label;
            System.Windows.Forms.Label 提供服務Label;
            System.Windows.Forms.Label 接受寵物類型Label;
            System.Windows.Forms.Label 接受寵物體型Label;
            System.Windows.Forms.Label 收費Label;
            System.Windows.Forms.Label 服務敘述內容Label;
            System.Windows.Forms.Label 服務狀態Label;
            System.Windows.Forms.Label 產品編號Label;
            System.Windows.Forms.Label 產品名稱Label;
            System.Windows.Forms.Label 產品敘述Label;
            System.Windows.Forms.Label 類別編號Label;
            System.Windows.Forms.Label 單價Label;
            System.Windows.Forms.Label 庫存Label;
            System.Windows.Forms.Label 產品圖片Label;
            System.Windows.Forms.Label 類別編號Label1;
            System.Windows.Forms.Label 類別名稱Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabManageMember = new System.Windows.Forms.TabPage();
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataSet = new WindowsForms.MemberDataSet();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.房屋編號TextBox = new System.Windows.Forms.TextBox();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.會員編號TextBox2 = new System.Windows.Forms.TextBox();
            this.活動空間TextBox = new System.Windows.Forms.TextBox();
            this.房屋區域TextBox = new System.Windows.Forms.TextBox();
            this.開放入住日期DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.提供服務TextBox = new System.Windows.Forms.TextBox();
            this.接受寵物類型ComboBox = new System.Windows.Forms.ComboBox();
            this.接受寵物體型ComboBox = new System.Windows.Forms.ComboBox();
            this.收費TextBox = new System.Windows.Forms.TextBox();
            this.服務敘述內容TextBox = new System.Windows.Forms.TextBox();
            this.服務狀態TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.寵物編號TextBox = new System.Windows.Forms.TextBox();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.會員編號TextBox1 = new System.Windows.Forms.TextBox();
            this.寵物姓名TextBox = new System.Windows.Forms.TextBox();
            this.寵物類型ComboBox = new System.Windows.Forms.ComboBox();
            this.寵物品種TextBox = new System.Windows.Forms.TextBox();
            this.寵物體型ComboBox = new System.Windows.Forms.ComboBox();
            this.年齡TextBox = new System.Windows.Forms.TextBox();
            this.體重TextBox = new System.Windows.Forms.TextBox();
            this.介紹及注意事項TextBox = new System.Windows.Forms.TextBox();
            this.照片PictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.會員編號TextBox = new System.Windows.Forms.TextBox();
            this.會員姓TextBox = new System.Windows.Forms.TextBox();
            this.會員名TextBox = new System.Windows.Forms.TextBox();
            this.身分證字號TextBox = new System.Windows.Forms.TextBox();
            this.出生年月日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.性別ComboBox = new System.Windows.Forms.ComboBox();
            this.電話號碼TextBox = new System.Windows.Forms.TextBox();
            this.e_MailTextBox = new System.Windows.Forms.TextBox();
            this.密碼TextBox = new System.Windows.Forms.TextBox();
            this.註解TextBox = new System.Windows.Forms.TextBox();
            this.提供環境TextBox = new System.Windows.Forms.TextBox();
            this.tabManageShop = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.類別編號TextBox1 = new System.Windows.Forms.TextBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new WindowsForms.ProductDataSet();
            this.類別名稱TextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.產品編號TextBox = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.產品名稱TextBox = new System.Windows.Forms.TextBox();
            this.產品敘述TextBox = new System.Windows.Forms.TextBox();
            this.類別編號TextBox = new System.Windows.Forms.TextBox();
            this.單價TextBox = new System.Windows.Forms.TextBox();
            this.庫存TextBox = new System.Windows.Forms.TextBox();
            this.產品圖片PictureBox = new System.Windows.Forms.PictureBox();
            this.tabManageAdmin = new System.Windows.Forms.TabPage();
            this.memberTableAdapter = new WindowsForms.MemberDataSetTableAdapters.MemberTableAdapter();
            this.tableAdapterManager = new WindowsForms.MemberDataSetTableAdapters.TableAdapterManager();
            this.houseTableAdapter = new WindowsForms.MemberDataSetTableAdapters.HouseTableAdapter();
            this.petTableAdapter = new WindowsForms.MemberDataSetTableAdapters.PetTableAdapter();
            this.productsTableAdapter = new WindowsForms.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager1 = new WindowsForms.ProductDataSetTableAdapters.TableAdapterManager();
            this.categoriesTableAdapter = new WindowsForms.ProductDataSetTableAdapters.CategoriesTableAdapter();
            會員編號Label = new System.Windows.Forms.Label();
            會員姓Label = new System.Windows.Forms.Label();
            會員名Label = new System.Windows.Forms.Label();
            身分證字號Label = new System.Windows.Forms.Label();
            出生年月日Label = new System.Windows.Forms.Label();
            性別Label = new System.Windows.Forms.Label();
            電話號碼Label = new System.Windows.Forms.Label();
            e_MailLabel = new System.Windows.Forms.Label();
            密碼Label = new System.Windows.Forms.Label();
            註解Label = new System.Windows.Forms.Label();
            提供環境Label = new System.Windows.Forms.Label();
            寵物編號Label = new System.Windows.Forms.Label();
            會員編號Label1 = new System.Windows.Forms.Label();
            寵物姓名Label = new System.Windows.Forms.Label();
            寵物類型Label = new System.Windows.Forms.Label();
            寵物品種Label = new System.Windows.Forms.Label();
            寵物體型Label = new System.Windows.Forms.Label();
            年齡Label = new System.Windows.Forms.Label();
            體重Label = new System.Windows.Forms.Label();
            介紹及注意事項Label = new System.Windows.Forms.Label();
            照片Label = new System.Windows.Forms.Label();
            房屋編號Label = new System.Windows.Forms.Label();
            會員編號Label2 = new System.Windows.Forms.Label();
            活動空間Label = new System.Windows.Forms.Label();
            房屋區域Label = new System.Windows.Forms.Label();
            開放入住日期Label = new System.Windows.Forms.Label();
            提供服務Label = new System.Windows.Forms.Label();
            接受寵物類型Label = new System.Windows.Forms.Label();
            接受寵物體型Label = new System.Windows.Forms.Label();
            收費Label = new System.Windows.Forms.Label();
            服務敘述內容Label = new System.Windows.Forms.Label();
            服務狀態Label = new System.Windows.Forms.Label();
            產品編號Label = new System.Windows.Forms.Label();
            產品名稱Label = new System.Windows.Forms.Label();
            產品敘述Label = new System.Windows.Forms.Label();
            類別編號Label = new System.Windows.Forms.Label();
            單價Label = new System.Windows.Forms.Label();
            庫存Label = new System.Windows.Forms.Label();
            產品圖片Label = new System.Windows.Forms.Label();
            類別編號Label1 = new System.Windows.Forms.Label();
            類別名稱Label = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabManageMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabManageShop.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品圖片PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // 會員編號Label
            // 
            會員編號Label.AutoSize = true;
            會員編號Label.Font = new System.Drawing.Font("新細明體", 9F);
            會員編號Label.Location = new System.Drawing.Point(11, 48);
            會員編號Label.Name = "會員編號Label";
            會員編號Label.Size = new System.Drawing.Size(71, 15);
            會員編號Label.TabIndex = 0;
            會員編號Label.Text = "會員編號:";
            // 
            // 會員姓Label
            // 
            會員姓Label.AutoSize = true;
            會員姓Label.Location = new System.Drawing.Point(11, 79);
            會員姓Label.Name = "會員姓Label";
            會員姓Label.Size = new System.Drawing.Size(56, 15);
            會員姓Label.TabIndex = 2;
            會員姓Label.Text = "會員姓:";
            // 
            // 會員名Label
            // 
            會員名Label.AutoSize = true;
            會員名Label.Location = new System.Drawing.Point(11, 110);
            會員名Label.Name = "會員名Label";
            會員名Label.Size = new System.Drawing.Size(56, 15);
            會員名Label.TabIndex = 4;
            會員名Label.Text = "會員名:";
            // 
            // 身分證字號Label
            // 
            身分證字號Label.AutoSize = true;
            身分證字號Label.Location = new System.Drawing.Point(11, 141);
            身分證字號Label.Name = "身分證字號Label";
            身分證字號Label.Size = new System.Drawing.Size(86, 15);
            身分證字號Label.TabIndex = 6;
            身分證字號Label.Text = "身分證字號:";
            // 
            // 出生年月日Label
            // 
            出生年月日Label.AutoSize = true;
            出生年月日Label.Location = new System.Drawing.Point(11, 173);
            出生年月日Label.Name = "出生年月日Label";
            出生年月日Label.Size = new System.Drawing.Size(86, 15);
            出生年月日Label.TabIndex = 8;
            出生年月日Label.Text = "出生年月日:";
            // 
            // 性別Label
            // 
            性別Label.AutoSize = true;
            性別Label.Location = new System.Drawing.Point(11, 203);
            性別Label.Name = "性別Label";
            性別Label.Size = new System.Drawing.Size(41, 15);
            性別Label.TabIndex = 10;
            性別Label.Text = "性別:";
            // 
            // 電話號碼Label
            // 
            電話號碼Label.AutoSize = true;
            電話號碼Label.Location = new System.Drawing.Point(11, 232);
            電話號碼Label.Name = "電話號碼Label";
            電話號碼Label.Size = new System.Drawing.Size(71, 15);
            電話號碼Label.TabIndex = 12;
            電話號碼Label.Text = "電話號碼:";
            // 
            // e_MailLabel
            // 
            e_MailLabel.AutoSize = true;
            e_MailLabel.Location = new System.Drawing.Point(11, 263);
            e_MailLabel.Name = "e_MailLabel";
            e_MailLabel.Size = new System.Drawing.Size(52, 15);
            e_MailLabel.TabIndex = 14;
            e_MailLabel.Text = "E-Mail:";
            // 
            // 密碼Label
            // 
            密碼Label.AutoSize = true;
            密碼Label.Location = new System.Drawing.Point(11, 294);
            密碼Label.Name = "密碼Label";
            密碼Label.Size = new System.Drawing.Size(41, 15);
            密碼Label.TabIndex = 16;
            密碼Label.Text = "密碼:";
            // 
            // 註解Label
            // 
            註解Label.AutoSize = true;
            註解Label.Location = new System.Drawing.Point(11, 325);
            註解Label.Name = "註解Label";
            註解Label.Size = new System.Drawing.Size(41, 15);
            註解Label.TabIndex = 18;
            註解Label.Text = "註解:";
            // 
            // 提供環境Label
            // 
            提供環境Label.AutoSize = true;
            提供環境Label.Location = new System.Drawing.Point(11, 356);
            提供環境Label.Name = "提供環境Label";
            提供環境Label.Size = new System.Drawing.Size(71, 15);
            提供環境Label.TabIndex = 20;
            提供環境Label.Text = "提供環境:";
            // 
            // 寵物編號Label
            // 
            寵物編號Label.AutoSize = true;
            寵物編號Label.Location = new System.Drawing.Point(6, 48);
            寵物編號Label.Name = "寵物編號Label";
            寵物編號Label.Size = new System.Drawing.Size(71, 15);
            寵物編號Label.TabIndex = 0;
            寵物編號Label.Text = "寵物編號:";
            // 
            // 會員編號Label1
            // 
            會員編號Label1.AutoSize = true;
            會員編號Label1.Location = new System.Drawing.Point(6, 79);
            會員編號Label1.Name = "會員編號Label1";
            會員編號Label1.Size = new System.Drawing.Size(71, 15);
            會員編號Label1.TabIndex = 2;
            會員編號Label1.Text = "會員編號:";
            // 
            // 寵物姓名Label
            // 
            寵物姓名Label.AutoSize = true;
            寵物姓名Label.Location = new System.Drawing.Point(6, 110);
            寵物姓名Label.Name = "寵物姓名Label";
            寵物姓名Label.Size = new System.Drawing.Size(71, 15);
            寵物姓名Label.TabIndex = 4;
            寵物姓名Label.Text = "寵物姓名:";
            // 
            // 寵物類型Label
            // 
            寵物類型Label.AutoSize = true;
            寵物類型Label.Location = new System.Drawing.Point(6, 141);
            寵物類型Label.Name = "寵物類型Label";
            寵物類型Label.Size = new System.Drawing.Size(71, 15);
            寵物類型Label.TabIndex = 6;
            寵物類型Label.Text = "寵物類型:";
            // 
            // 寵物品種Label
            // 
            寵物品種Label.AutoSize = true;
            寵物品種Label.Location = new System.Drawing.Point(6, 170);
            寵物品種Label.Name = "寵物品種Label";
            寵物品種Label.Size = new System.Drawing.Size(71, 15);
            寵物品種Label.TabIndex = 8;
            寵物品種Label.Text = "寵物品種:";
            // 
            // 寵物體型Label
            // 
            寵物體型Label.AutoSize = true;
            寵物體型Label.Location = new System.Drawing.Point(6, 201);
            寵物體型Label.Name = "寵物體型Label";
            寵物體型Label.Size = new System.Drawing.Size(71, 15);
            寵物體型Label.TabIndex = 10;
            寵物體型Label.Text = "寵物體型:";
            // 
            // 年齡Label
            // 
            年齡Label.AutoSize = true;
            年齡Label.Location = new System.Drawing.Point(6, 230);
            年齡Label.Name = "年齡Label";
            年齡Label.Size = new System.Drawing.Size(41, 15);
            年齡Label.TabIndex = 12;
            年齡Label.Text = "年齡:";
            // 
            // 體重Label
            // 
            體重Label.AutoSize = true;
            體重Label.Location = new System.Drawing.Point(6, 261);
            體重Label.Name = "體重Label";
            體重Label.Size = new System.Drawing.Size(41, 15);
            體重Label.TabIndex = 14;
            體重Label.Text = "體重:";
            // 
            // 介紹及注意事項Label
            // 
            介紹及注意事項Label.AutoSize = true;
            介紹及注意事項Label.Location = new System.Drawing.Point(6, 292);
            介紹及注意事項Label.Name = "介紹及注意事項Label";
            介紹及注意事項Label.Size = new System.Drawing.Size(116, 15);
            介紹及注意事項Label.TabIndex = 16;
            介紹及注意事項Label.Text = "介紹及注意事項:";
            // 
            // 照片Label
            // 
            照片Label.AutoSize = true;
            照片Label.Location = new System.Drawing.Point(6, 320);
            照片Label.Name = "照片Label";
            照片Label.Size = new System.Drawing.Size(41, 15);
            照片Label.TabIndex = 18;
            照片Label.Text = "照片:";
            // 
            // 房屋編號Label
            // 
            房屋編號Label.AutoSize = true;
            房屋編號Label.Location = new System.Drawing.Point(13, 48);
            房屋編號Label.Name = "房屋編號Label";
            房屋編號Label.Size = new System.Drawing.Size(71, 15);
            房屋編號Label.TabIndex = 0;
            房屋編號Label.Text = "房屋編號:";
            // 
            // 會員編號Label2
            // 
            會員編號Label2.AutoSize = true;
            會員編號Label2.Location = new System.Drawing.Point(13, 79);
            會員編號Label2.Name = "會員編號Label2";
            會員編號Label2.Size = new System.Drawing.Size(71, 15);
            會員編號Label2.TabIndex = 2;
            會員編號Label2.Text = "會員編號:";
            // 
            // 活動空間Label
            // 
            活動空間Label.AutoSize = true;
            活動空間Label.Location = new System.Drawing.Point(13, 110);
            活動空間Label.Name = "活動空間Label";
            活動空間Label.Size = new System.Drawing.Size(71, 15);
            活動空間Label.TabIndex = 4;
            活動空間Label.Text = "活動空間:";
            // 
            // 房屋區域Label
            // 
            房屋區域Label.AutoSize = true;
            房屋區域Label.Location = new System.Drawing.Point(13, 141);
            房屋區域Label.Name = "房屋區域Label";
            房屋區域Label.Size = new System.Drawing.Size(71, 15);
            房屋區域Label.TabIndex = 6;
            房屋區域Label.Text = "房屋區域:";
            // 
            // 開放入住日期Label
            // 
            開放入住日期Label.AutoSize = true;
            開放入住日期Label.Location = new System.Drawing.Point(13, 173);
            開放入住日期Label.Name = "開放入住日期Label";
            開放入住日期Label.Size = new System.Drawing.Size(101, 15);
            開放入住日期Label.TabIndex = 8;
            開放入住日期Label.Text = "開放入住日期:";
            // 
            // 提供服務Label
            // 
            提供服務Label.AutoSize = true;
            提供服務Label.Location = new System.Drawing.Point(13, 203);
            提供服務Label.Name = "提供服務Label";
            提供服務Label.Size = new System.Drawing.Size(71, 15);
            提供服務Label.TabIndex = 10;
            提供服務Label.Text = "提供服務:";
            // 
            // 接受寵物類型Label
            // 
            接受寵物類型Label.AutoSize = true;
            接受寵物類型Label.Location = new System.Drawing.Point(13, 234);
            接受寵物類型Label.Name = "接受寵物類型Label";
            接受寵物類型Label.Size = new System.Drawing.Size(101, 15);
            接受寵物類型Label.TabIndex = 12;
            接受寵物類型Label.Text = "接受寵物類型:";
            // 
            // 接受寵物體型Label
            // 
            接受寵物體型Label.AutoSize = true;
            接受寵物體型Label.Location = new System.Drawing.Point(13, 263);
            接受寵物體型Label.Name = "接受寵物體型Label";
            接受寵物體型Label.Size = new System.Drawing.Size(101, 15);
            接受寵物體型Label.TabIndex = 14;
            接受寵物體型Label.Text = "接受寵物體型:";
            // 
            // 收費Label
            // 
            收費Label.AutoSize = true;
            收費Label.Location = new System.Drawing.Point(13, 292);
            收費Label.Name = "收費Label";
            收費Label.Size = new System.Drawing.Size(41, 15);
            收費Label.TabIndex = 16;
            收費Label.Text = "收費:";
            // 
            // 服務敘述內容Label
            // 
            服務敘述內容Label.AutoSize = true;
            服務敘述內容Label.Location = new System.Drawing.Point(13, 323);
            服務敘述內容Label.Name = "服務敘述內容Label";
            服務敘述內容Label.Size = new System.Drawing.Size(101, 15);
            服務敘述內容Label.TabIndex = 18;
            服務敘述內容Label.Text = "服務敘述內容:";
            // 
            // 服務狀態Label
            // 
            服務狀態Label.AutoSize = true;
            服務狀態Label.Location = new System.Drawing.Point(13, 354);
            服務狀態Label.Name = "服務狀態Label";
            服務狀態Label.Size = new System.Drawing.Size(71, 15);
            服務狀態Label.TabIndex = 20;
            服務狀態Label.Text = "服務狀態:";
            // 
            // 產品編號Label
            // 
            產品編號Label.AutoSize = true;
            產品編號Label.Location = new System.Drawing.Point(42, 45);
            產品編號Label.Name = "產品編號Label";
            產品編號Label.Size = new System.Drawing.Size(71, 15);
            產品編號Label.TabIndex = 0;
            產品編號Label.Text = "產品編號:";
            // 
            // 產品名稱Label
            // 
            產品名稱Label.AutoSize = true;
            產品名稱Label.Location = new System.Drawing.Point(42, 76);
            產品名稱Label.Name = "產品名稱Label";
            產品名稱Label.Size = new System.Drawing.Size(71, 15);
            產品名稱Label.TabIndex = 2;
            產品名稱Label.Text = "產品名稱:";
            // 
            // 產品敘述Label
            // 
            產品敘述Label.AutoSize = true;
            產品敘述Label.Location = new System.Drawing.Point(42, 107);
            產品敘述Label.Name = "產品敘述Label";
            產品敘述Label.Size = new System.Drawing.Size(71, 15);
            產品敘述Label.TabIndex = 4;
            產品敘述Label.Text = "產品敘述:";
            // 
            // 類別編號Label
            // 
            類別編號Label.AutoSize = true;
            類別編號Label.Location = new System.Drawing.Point(42, 138);
            類別編號Label.Name = "類別編號Label";
            類別編號Label.Size = new System.Drawing.Size(71, 15);
            類別編號Label.TabIndex = 6;
            類別編號Label.Text = "類別編號:";
            // 
            // 單價Label
            // 
            單價Label.AutoSize = true;
            單價Label.Location = new System.Drawing.Point(42, 169);
            單價Label.Name = "單價Label";
            單價Label.Size = new System.Drawing.Size(41, 15);
            單價Label.TabIndex = 8;
            單價Label.Text = "單價:";
            // 
            // 庫存Label
            // 
            庫存Label.AutoSize = true;
            庫存Label.Location = new System.Drawing.Point(42, 200);
            庫存Label.Name = "庫存Label";
            庫存Label.Size = new System.Drawing.Size(41, 15);
            庫存Label.TabIndex = 10;
            庫存Label.Text = "庫存:";
            // 
            // 產品圖片Label
            // 
            產品圖片Label.AutoSize = true;
            產品圖片Label.Location = new System.Drawing.Point(42, 228);
            產品圖片Label.Name = "產品圖片Label";
            產品圖片Label.Size = new System.Drawing.Size(71, 15);
            產品圖片Label.TabIndex = 12;
            產品圖片Label.Text = "產品圖片:";
            // 
            // 類別編號Label1
            // 
            類別編號Label1.AutoSize = true;
            類別編號Label1.Location = new System.Drawing.Point(59, 52);
            類別編號Label1.Name = "類別編號Label1";
            類別編號Label1.Size = new System.Drawing.Size(71, 15);
            類別編號Label1.TabIndex = 0;
            類別編號Label1.Text = "類別編號:";
            // 
            // 類別名稱Label
            // 
            類別名稱Label.AutoSize = true;
            類別名稱Label.Location = new System.Drawing.Point(59, 83);
            類別名稱Label.Name = "類別名稱Label";
            類別名稱Label.Size = new System.Drawing.Size(71, 15);
            類別名稱Label.TabIndex = 2;
            類別名稱Label.Text = "類別名稱:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabManageMember);
            this.tabControl1.Controls.Add(this.tabManageShop);
            this.tabControl1.Controls.Add(this.tabManageAdmin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabManageMember
            // 
            this.tabManageMember.AutoScroll = true;
            this.tabManageMember.Controls.Add(this.memberBindingNavigator);
            this.tabManageMember.Controls.Add(this.groupBox3);
            this.tabManageMember.Controls.Add(this.groupBox2);
            this.tabManageMember.Controls.Add(this.groupBox1);
            this.tabManageMember.Location = new System.Drawing.Point(4, 25);
            this.tabManageMember.Name = "tabManageMember";
            this.tabManageMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageMember.Size = new System.Drawing.Size(984, 495);
            this.tabManageMember.TabIndex = 0;
            this.tabManageMember.Text = "　　會員維護　　";
            this.tabManageMember.UseVisualStyleBackColor = true;
            // 
            // memberBindingNavigator
            // 
            this.memberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberBindingNavigator.BindingSource = this.memberBindingSource;
            this.memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.memberBindingNavigator.Location = new System.Drawing.Point(342, 3);
            this.memberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memberBindingNavigator.Name = "memberBindingNavigator";
            this.memberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memberBindingNavigator.Size = new System.Drawing.Size(284, 27);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(房屋編號Label);
            this.groupBox3.Controls.Add(this.房屋編號TextBox);
            this.groupBox3.Controls.Add(會員編號Label2);
            this.groupBox3.Controls.Add(this.會員編號TextBox2);
            this.groupBox3.Controls.Add(活動空間Label);
            this.groupBox3.Controls.Add(this.活動空間TextBox);
            this.groupBox3.Controls.Add(房屋區域Label);
            this.groupBox3.Controls.Add(this.房屋區域TextBox);
            this.groupBox3.Controls.Add(開放入住日期Label);
            this.groupBox3.Controls.Add(this.開放入住日期DateTimePicker);
            this.groupBox3.Controls.Add(提供服務Label);
            this.groupBox3.Controls.Add(this.提供服務TextBox);
            this.groupBox3.Controls.Add(接受寵物類型Label);
            this.groupBox3.Controls.Add(this.接受寵物類型ComboBox);
            this.groupBox3.Controls.Add(接受寵物體型Label);
            this.groupBox3.Controls.Add(this.接受寵物體型ComboBox);
            this.groupBox3.Controls.Add(收費Label);
            this.groupBox3.Controls.Add(this.收費TextBox);
            this.groupBox3.Controls.Add(服務敘述內容Label);
            this.groupBox3.Controls.Add(this.服務敘述內容TextBox);
            this.groupBox3.Controls.Add(服務狀態Label);
            this.groupBox3.Controls.Add(this.服務狀態TextBox);
            this.groupBox3.Location = new System.Drawing.Point(643, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 419);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "會員房屋維護";
            // 
            // 房屋編號TextBox
            // 
            this.房屋編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "房屋編號", true));
            this.房屋編號TextBox.Location = new System.Drawing.Point(120, 45);
            this.房屋編號TextBox.Name = "房屋編號TextBox";
            this.房屋編號TextBox.Size = new System.Drawing.Size(200, 25);
            this.房屋編號TextBox.TabIndex = 1;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "House";
            this.houseBindingSource.DataSource = this.memberDataSet;
            // 
            // 會員編號TextBox2
            // 
            this.會員編號TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "會員編號", true));
            this.會員編號TextBox2.Location = new System.Drawing.Point(120, 76);
            this.會員編號TextBox2.Name = "會員編號TextBox2";
            this.會員編號TextBox2.Size = new System.Drawing.Size(200, 25);
            this.會員編號TextBox2.TabIndex = 3;
            // 
            // 活動空間TextBox
            // 
            this.活動空間TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "活動空間", true));
            this.活動空間TextBox.Location = new System.Drawing.Point(120, 107);
            this.活動空間TextBox.Name = "活動空間TextBox";
            this.活動空間TextBox.Size = new System.Drawing.Size(200, 25);
            this.活動空間TextBox.TabIndex = 5;
            // 
            // 房屋區域TextBox
            // 
            this.房屋區域TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "房屋區域", true));
            this.房屋區域TextBox.Location = new System.Drawing.Point(120, 138);
            this.房屋區域TextBox.Name = "房屋區域TextBox";
            this.房屋區域TextBox.Size = new System.Drawing.Size(200, 25);
            this.房屋區域TextBox.TabIndex = 7;
            // 
            // 開放入住日期DateTimePicker
            // 
            this.開放入住日期DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.houseBindingSource, "開放入住日期", true));
            this.開放入住日期DateTimePicker.Location = new System.Drawing.Point(120, 169);
            this.開放入住日期DateTimePicker.Name = "開放入住日期DateTimePicker";
            this.開放入住日期DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.開放入住日期DateTimePicker.TabIndex = 9;
            // 
            // 提供服務TextBox
            // 
            this.提供服務TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "提供服務", true));
            this.提供服務TextBox.Location = new System.Drawing.Point(120, 200);
            this.提供服務TextBox.Name = "提供服務TextBox";
            this.提供服務TextBox.Size = new System.Drawing.Size(200, 25);
            this.提供服務TextBox.TabIndex = 11;
            // 
            // 接受寵物類型ComboBox
            // 
            this.接受寵物類型ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "接受寵物類型", true));
            this.接受寵物類型ComboBox.FormattingEnabled = true;
            this.接受寵物類型ComboBox.Location = new System.Drawing.Point(120, 231);
            this.接受寵物類型ComboBox.Name = "接受寵物類型ComboBox";
            this.接受寵物類型ComboBox.Size = new System.Drawing.Size(200, 23);
            this.接受寵物類型ComboBox.TabIndex = 13;
            // 
            // 接受寵物體型ComboBox
            // 
            this.接受寵物體型ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "接受寵物體型", true));
            this.接受寵物體型ComboBox.FormattingEnabled = true;
            this.接受寵物體型ComboBox.Location = new System.Drawing.Point(120, 260);
            this.接受寵物體型ComboBox.Name = "接受寵物體型ComboBox";
            this.接受寵物體型ComboBox.Size = new System.Drawing.Size(200, 23);
            this.接受寵物體型ComboBox.TabIndex = 15;
            // 
            // 收費TextBox
            // 
            this.收費TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "收費", true));
            this.收費TextBox.Location = new System.Drawing.Point(120, 289);
            this.收費TextBox.Name = "收費TextBox";
            this.收費TextBox.Size = new System.Drawing.Size(200, 25);
            this.收費TextBox.TabIndex = 17;
            // 
            // 服務敘述內容TextBox
            // 
            this.服務敘述內容TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "服務敘述內容", true));
            this.服務敘述內容TextBox.Location = new System.Drawing.Point(120, 320);
            this.服務敘述內容TextBox.Name = "服務敘述內容TextBox";
            this.服務敘述內容TextBox.Size = new System.Drawing.Size(200, 25);
            this.服務敘述內容TextBox.TabIndex = 19;
            // 
            // 服務狀態TextBox
            // 
            this.服務狀態TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "服務狀態", true));
            this.服務狀態TextBox.Location = new System.Drawing.Point(120, 351);
            this.服務狀態TextBox.Name = "服務狀態TextBox";
            this.服務狀態TextBox.Size = new System.Drawing.Size(200, 25);
            this.服務狀態TextBox.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(寵物編號Label);
            this.groupBox2.Controls.Add(this.寵物編號TextBox);
            this.groupBox2.Controls.Add(會員編號Label1);
            this.groupBox2.Controls.Add(this.會員編號TextBox1);
            this.groupBox2.Controls.Add(寵物姓名Label);
            this.groupBox2.Controls.Add(this.寵物姓名TextBox);
            this.groupBox2.Controls.Add(寵物類型Label);
            this.groupBox2.Controls.Add(this.寵物類型ComboBox);
            this.groupBox2.Controls.Add(寵物品種Label);
            this.groupBox2.Controls.Add(this.寵物品種TextBox);
            this.groupBox2.Controls.Add(寵物體型Label);
            this.groupBox2.Controls.Add(this.寵物體型ComboBox);
            this.groupBox2.Controls.Add(年齡Label);
            this.groupBox2.Controls.Add(this.年齡TextBox);
            this.groupBox2.Controls.Add(體重Label);
            this.groupBox2.Controls.Add(this.體重TextBox);
            this.groupBox2.Controls.Add(介紹及注意事項Label);
            this.groupBox2.Controls.Add(this.介紹及注意事項TextBox);
            this.groupBox2.Controls.Add(照片Label);
            this.groupBox2.Controls.Add(this.照片PictureBox);
            this.groupBox2.Location = new System.Drawing.Point(354, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "寵物維護";
            // 
            // 寵物編號TextBox
            // 
            this.寵物編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "寵物編號", true));
            this.寵物編號TextBox.Location = new System.Drawing.Point(128, 45);
            this.寵物編號TextBox.Name = "寵物編號TextBox";
            this.寵物編號TextBox.Size = new System.Drawing.Size(121, 25);
            this.寵物編號TextBox.TabIndex = 1;
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "Pet";
            this.petBindingSource.DataSource = this.memberDataSet;
            // 
            // 會員編號TextBox1
            // 
            this.會員編號TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "會員編號", true));
            this.會員編號TextBox1.Location = new System.Drawing.Point(128, 76);
            this.會員編號TextBox1.Name = "會員編號TextBox1";
            this.會員編號TextBox1.Size = new System.Drawing.Size(121, 25);
            this.會員編號TextBox1.TabIndex = 3;
            // 
            // 寵物姓名TextBox
            // 
            this.寵物姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "寵物姓名", true));
            this.寵物姓名TextBox.Location = new System.Drawing.Point(128, 107);
            this.寵物姓名TextBox.Name = "寵物姓名TextBox";
            this.寵物姓名TextBox.Size = new System.Drawing.Size(121, 25);
            this.寵物姓名TextBox.TabIndex = 5;
            // 
            // 寵物類型ComboBox
            // 
            this.寵物類型ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "寵物類型", true));
            this.寵物類型ComboBox.FormattingEnabled = true;
            this.寵物類型ComboBox.Location = new System.Drawing.Point(128, 138);
            this.寵物類型ComboBox.Name = "寵物類型ComboBox";
            this.寵物類型ComboBox.Size = new System.Drawing.Size(121, 23);
            this.寵物類型ComboBox.TabIndex = 7;
            // 
            // 寵物品種TextBox
            // 
            this.寵物品種TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "寵物品種", true));
            this.寵物品種TextBox.Location = new System.Drawing.Point(128, 167);
            this.寵物品種TextBox.Name = "寵物品種TextBox";
            this.寵物品種TextBox.Size = new System.Drawing.Size(121, 25);
            this.寵物品種TextBox.TabIndex = 9;
            // 
            // 寵物體型ComboBox
            // 
            this.寵物體型ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "寵物體型", true));
            this.寵物體型ComboBox.FormattingEnabled = true;
            this.寵物體型ComboBox.Location = new System.Drawing.Point(128, 198);
            this.寵物體型ComboBox.Name = "寵物體型ComboBox";
            this.寵物體型ComboBox.Size = new System.Drawing.Size(121, 23);
            this.寵物體型ComboBox.TabIndex = 11;
            // 
            // 年齡TextBox
            // 
            this.年齡TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "年齡", true));
            this.年齡TextBox.Location = new System.Drawing.Point(128, 227);
            this.年齡TextBox.Name = "年齡TextBox";
            this.年齡TextBox.Size = new System.Drawing.Size(121, 25);
            this.年齡TextBox.TabIndex = 13;
            // 
            // 體重TextBox
            // 
            this.體重TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "體重", true));
            this.體重TextBox.Location = new System.Drawing.Point(128, 258);
            this.體重TextBox.Name = "體重TextBox";
            this.體重TextBox.Size = new System.Drawing.Size(121, 25);
            this.體重TextBox.TabIndex = 15;
            // 
            // 介紹及注意事項TextBox
            // 
            this.介紹及注意事項TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petBindingSource, "介紹及注意事項", true));
            this.介紹及注意事項TextBox.Location = new System.Drawing.Point(128, 289);
            this.介紹及注意事項TextBox.Name = "介紹及注意事項TextBox";
            this.介紹及注意事項TextBox.Size = new System.Drawing.Size(121, 25);
            this.介紹及注意事項TextBox.TabIndex = 17;
            // 
            // 照片PictureBox
            // 
            this.照片PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.petBindingSource, "照片", true));
            this.照片PictureBox.Location = new System.Drawing.Point(128, 320);
            this.照片PictureBox.Name = "照片PictureBox";
            this.照片PictureBox.Size = new System.Drawing.Size(121, 50);
            this.照片PictureBox.TabIndex = 19;
            this.照片PictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(會員編號Label);
            this.groupBox1.Controls.Add(this.會員編號TextBox);
            this.groupBox1.Controls.Add(會員姓Label);
            this.groupBox1.Controls.Add(this.會員姓TextBox);
            this.groupBox1.Controls.Add(會員名Label);
            this.groupBox1.Controls.Add(this.會員名TextBox);
            this.groupBox1.Controls.Add(身分證字號Label);
            this.groupBox1.Controls.Add(this.身分證字號TextBox);
            this.groupBox1.Controls.Add(出生年月日Label);
            this.groupBox1.Controls.Add(this.出生年月日DateTimePicker);
            this.groupBox1.Controls.Add(性別Label);
            this.groupBox1.Controls.Add(this.性別ComboBox);
            this.groupBox1.Controls.Add(電話號碼Label);
            this.groupBox1.Controls.Add(this.電話號碼TextBox);
            this.groupBox1.Controls.Add(e_MailLabel);
            this.groupBox1.Controls.Add(this.e_MailTextBox);
            this.groupBox1.Controls.Add(密碼Label);
            this.groupBox1.Controls.Add(this.密碼TextBox);
            this.groupBox1.Controls.Add(註解Label);
            this.groupBox1.Controls.Add(this.註解TextBox);
            this.groupBox1.Controls.Add(提供環境Label);
            this.groupBox1.Controls.Add(this.提供環境TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "會員資料維護";
            // 
            // 會員編號TextBox
            // 
            this.會員編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "會員編號", true));
            this.會員編號TextBox.Location = new System.Drawing.Point(103, 45);
            this.會員編號TextBox.Name = "會員編號TextBox";
            this.會員編號TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員編號TextBox.TabIndex = 1;
            // 
            // 會員姓TextBox
            // 
            this.會員姓TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "會員姓", true));
            this.會員姓TextBox.Location = new System.Drawing.Point(103, 76);
            this.會員姓TextBox.Name = "會員姓TextBox";
            this.會員姓TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員姓TextBox.TabIndex = 3;
            // 
            // 會員名TextBox
            // 
            this.會員名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "會員名", true));
            this.會員名TextBox.Location = new System.Drawing.Point(103, 107);
            this.會員名TextBox.Name = "會員名TextBox";
            this.會員名TextBox.Size = new System.Drawing.Size(200, 25);
            this.會員名TextBox.TabIndex = 5;
            // 
            // 身分證字號TextBox
            // 
            this.身分證字號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "身分證字號", true));
            this.身分證字號TextBox.Location = new System.Drawing.Point(103, 138);
            this.身分證字號TextBox.Name = "身分證字號TextBox";
            this.身分證字號TextBox.Size = new System.Drawing.Size(200, 25);
            this.身分證字號TextBox.TabIndex = 7;
            // 
            // 出生年月日DateTimePicker
            // 
            this.出生年月日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberBindingSource, "出生年月日", true));
            this.出生年月日DateTimePicker.Location = new System.Drawing.Point(103, 169);
            this.出生年月日DateTimePicker.Name = "出生年月日DateTimePicker";
            this.出生年月日DateTimePicker.Size = new System.Drawing.Size(200, 25);
            this.出生年月日DateTimePicker.TabIndex = 9;
            // 
            // 性別ComboBox
            // 
            this.性別ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "性別", true));
            this.性別ComboBox.FormattingEnabled = true;
            this.性別ComboBox.Location = new System.Drawing.Point(103, 200);
            this.性別ComboBox.Name = "性別ComboBox";
            this.性別ComboBox.Size = new System.Drawing.Size(200, 23);
            this.性別ComboBox.TabIndex = 11;
            // 
            // 電話號碼TextBox
            // 
            this.電話號碼TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "電話號碼", true));
            this.電話號碼TextBox.Location = new System.Drawing.Point(103, 229);
            this.電話號碼TextBox.Name = "電話號碼TextBox";
            this.電話號碼TextBox.Size = new System.Drawing.Size(200, 25);
            this.電話號碼TextBox.TabIndex = 13;
            // 
            // e_MailTextBox
            // 
            this.e_MailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "E-Mail", true));
            this.e_MailTextBox.Location = new System.Drawing.Point(103, 260);
            this.e_MailTextBox.Name = "e_MailTextBox";
            this.e_MailTextBox.Size = new System.Drawing.Size(200, 25);
            this.e_MailTextBox.TabIndex = 15;
            // 
            // 密碼TextBox
            // 
            this.密碼TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "密碼", true));
            this.密碼TextBox.Location = new System.Drawing.Point(103, 291);
            this.密碼TextBox.Name = "密碼TextBox";
            this.密碼TextBox.Size = new System.Drawing.Size(200, 25);
            this.密碼TextBox.TabIndex = 17;
            // 
            // 註解TextBox
            // 
            this.註解TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "註解", true));
            this.註解TextBox.Location = new System.Drawing.Point(103, 322);
            this.註解TextBox.Name = "註解TextBox";
            this.註解TextBox.Size = new System.Drawing.Size(200, 25);
            this.註解TextBox.TabIndex = 19;
            // 
            // 提供環境TextBox
            // 
            this.提供環境TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "提供環境", true));
            this.提供環境TextBox.Location = new System.Drawing.Point(103, 353);
            this.提供環境TextBox.Name = "提供環境TextBox";
            this.提供環境TextBox.Size = new System.Drawing.Size(200, 25);
            this.提供環境TextBox.TabIndex = 21;
            // 
            // tabManageShop
            // 
            this.tabManageShop.Controls.Add(this.groupBox5);
            this.tabManageShop.Controls.Add(this.groupBox4);
            this.tabManageShop.Location = new System.Drawing.Point(4, 25);
            this.tabManageShop.Name = "tabManageShop";
            this.tabManageShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageShop.Size = new System.Drawing.Size(984, 495);
            this.tabManageShop.TabIndex = 1;
            this.tabManageShop.Text = "　　商品維護　　";
            this.tabManageShop.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(類別編號Label1);
            this.groupBox5.Controls.Add(this.類別編號TextBox1);
            this.groupBox5.Controls.Add(類別名稱Label);
            this.groupBox5.Controls.Add(this.類別名稱TextBox);
            this.groupBox5.Location = new System.Drawing.Point(517, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 160);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "商品類別維護";
            // 
            // 類別編號TextBox1
            // 
            this.類別編號TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "類別編號", true));
            this.類別編號TextBox1.Location = new System.Drawing.Point(136, 49);
            this.類別編號TextBox1.Name = "類別編號TextBox1";
            this.類別編號TextBox1.Size = new System.Drawing.Size(122, 25);
            this.類別編號TextBox1.TabIndex = 1;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 類別名稱TextBox
            // 
            this.類別名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "類別名稱", true));
            this.類別名稱TextBox.Location = new System.Drawing.Point(136, 80);
            this.類別名稱TextBox.Name = "類別名稱TextBox";
            this.類別名稱TextBox.Size = new System.Drawing.Size(122, 25);
            this.類別名稱TextBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(產品編號Label);
            this.groupBox4.Controls.Add(this.產品編號TextBox);
            this.groupBox4.Controls.Add(產品名稱Label);
            this.groupBox4.Controls.Add(this.產品名稱TextBox);
            this.groupBox4.Controls.Add(產品敘述Label);
            this.groupBox4.Controls.Add(this.產品敘述TextBox);
            this.groupBox4.Controls.Add(類別編號Label);
            this.groupBox4.Controls.Add(this.類別編號TextBox);
            this.groupBox4.Controls.Add(單價Label);
            this.groupBox4.Controls.Add(this.單價TextBox);
            this.groupBox4.Controls.Add(庫存Label);
            this.groupBox4.Controls.Add(this.庫存TextBox);
            this.groupBox4.Controls.Add(產品圖片Label);
            this.groupBox4.Controls.Add(this.產品圖片PictureBox);
            this.groupBox4.Location = new System.Drawing.Point(115, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 408);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "商品維護";
            // 
            // 產品編號TextBox
            // 
            this.產品編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "產品編號", true));
            this.產品編號TextBox.Location = new System.Drawing.Point(119, 42);
            this.產品編號TextBox.Name = "產品編號TextBox";
            this.產品編號TextBox.Size = new System.Drawing.Size(153, 25);
            this.產品編號TextBox.TabIndex = 1;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productDataSet;
            // 
            // 產品名稱TextBox
            // 
            this.產品名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "產品名稱", true));
            this.產品名稱TextBox.Location = new System.Drawing.Point(119, 73);
            this.產品名稱TextBox.Name = "產品名稱TextBox";
            this.產品名稱TextBox.Size = new System.Drawing.Size(153, 25);
            this.產品名稱TextBox.TabIndex = 3;
            // 
            // 產品敘述TextBox
            // 
            this.產品敘述TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "產品敘述", true));
            this.產品敘述TextBox.Location = new System.Drawing.Point(119, 104);
            this.產品敘述TextBox.Name = "產品敘述TextBox";
            this.產品敘述TextBox.Size = new System.Drawing.Size(153, 25);
            this.產品敘述TextBox.TabIndex = 5;
            // 
            // 類別編號TextBox
            // 
            this.類別編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "類別編號", true));
            this.類別編號TextBox.Location = new System.Drawing.Point(119, 135);
            this.類別編號TextBox.Name = "類別編號TextBox";
            this.類別編號TextBox.Size = new System.Drawing.Size(153, 25);
            this.類別編號TextBox.TabIndex = 7;
            // 
            // 單價TextBox
            // 
            this.單價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "單價", true));
            this.單價TextBox.Location = new System.Drawing.Point(119, 166);
            this.單價TextBox.Name = "單價TextBox";
            this.單價TextBox.Size = new System.Drawing.Size(153, 25);
            this.單價TextBox.TabIndex = 9;
            // 
            // 庫存TextBox
            // 
            this.庫存TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "庫存", true));
            this.庫存TextBox.Location = new System.Drawing.Point(119, 197);
            this.庫存TextBox.Name = "庫存TextBox";
            this.庫存TextBox.Size = new System.Drawing.Size(153, 25);
            this.庫存TextBox.TabIndex = 11;
            // 
            // 產品圖片PictureBox
            // 
            this.產品圖片PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productsBindingSource, "產品圖片", true));
            this.產品圖片PictureBox.Location = new System.Drawing.Point(119, 228);
            this.產品圖片PictureBox.Name = "產品圖片PictureBox";
            this.產品圖片PictureBox.Size = new System.Drawing.Size(153, 145);
            this.產品圖片PictureBox.TabIndex = 13;
            this.產品圖片PictureBox.TabStop = false;
            // 
            // tabManageAdmin
            // 
            this.tabManageAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabManageAdmin.Name = "tabManageAdmin";
            this.tabManageAdmin.Size = new System.Drawing.Size(984, 495);
            this.tabManageAdmin.TabIndex = 2;
            this.tabManageAdmin.Text = "　管理者維護　";
            this.tabManageAdmin.UseVisualStyleBackColor = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HouseTableAdapter = this.houseTableAdapter;
            this.tableAdapterManager.MemberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.PetTableAdapter = this.petTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsForms.MemberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager1.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsForms.ProductDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 524);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdminUI";
            this.Text = "frmAdminUI";
            this.Load += new System.EventHandler(this.frmAdminUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabManageMember.ResumeLayout(false);
            this.tabManageMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.照片PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabManageShop.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品圖片PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManageMember;
        private System.Windows.Forms.TabPage tabManageShop;
        private System.Windows.Forms.TabPage tabManageAdmin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox 會員編號TextBox;
        private System.Windows.Forms.TextBox 會員姓TextBox;
        private System.Windows.Forms.TextBox 會員名TextBox;
        private System.Windows.Forms.TextBox 身分證字號TextBox;
        private System.Windows.Forms.DateTimePicker 出生年月日DateTimePicker;
        private System.Windows.Forms.ComboBox 性別ComboBox;
        private System.Windows.Forms.TextBox 電話號碼TextBox;
        private System.Windows.Forms.TextBox e_MailTextBox;
        private System.Windows.Forms.TextBox 密碼TextBox;
        private System.Windows.Forms.TextBox 註解TextBox;
        private System.Windows.Forms.TextBox 提供環境TextBox;
        private MemberDataSetTableAdapters.PetTableAdapter petTableAdapter;
        private System.Windows.Forms.BindingSource petBindingSource;
        private System.Windows.Forms.TextBox 寵物編號TextBox;
        private System.Windows.Forms.TextBox 會員編號TextBox1;
        private System.Windows.Forms.TextBox 寵物姓名TextBox;
        private System.Windows.Forms.ComboBox 寵物類型ComboBox;
        private System.Windows.Forms.TextBox 寵物品種TextBox;
        private System.Windows.Forms.ComboBox 寵物體型ComboBox;
        private System.Windows.Forms.TextBox 年齡TextBox;
        private System.Windows.Forms.TextBox 體重TextBox;
        private System.Windows.Forms.TextBox 介紹及注意事項TextBox;
        private System.Windows.Forms.PictureBox 照片PictureBox;
        private MemberDataSetTableAdapters.HouseTableAdapter houseTableAdapter;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private System.Windows.Forms.TextBox 房屋編號TextBox;
        private System.Windows.Forms.TextBox 會員編號TextBox2;
        private System.Windows.Forms.TextBox 活動空間TextBox;
        private System.Windows.Forms.TextBox 房屋區域TextBox;
        private System.Windows.Forms.DateTimePicker 開放入住日期DateTimePicker;
        private System.Windows.Forms.TextBox 提供服務TextBox;
        private System.Windows.Forms.ComboBox 接受寵物類型ComboBox;
        private System.Windows.Forms.ComboBox 接受寵物體型ComboBox;
        private System.Windows.Forms.TextBox 收費TextBox;
        private System.Windows.Forms.TextBox 服務敘述內容TextBox;
        private System.Windows.Forms.TextBox 服務狀態TextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ProductDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox 產品編號TextBox;
        private System.Windows.Forms.TextBox 產品名稱TextBox;
        private System.Windows.Forms.TextBox 產品敘述TextBox;
        private System.Windows.Forms.TextBox 類別編號TextBox;
        private System.Windows.Forms.TextBox 單價TextBox;
        private System.Windows.Forms.TextBox 庫存TextBox;
        private System.Windows.Forms.PictureBox 產品圖片PictureBox;
        private ProductDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.TextBox 類別編號TextBox1;
        private System.Windows.Forms.TextBox 類別名稱TextBox;
    }
}