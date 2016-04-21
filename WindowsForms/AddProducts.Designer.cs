namespace WindowsForms
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            System.Windows.Forms.Label 產品編號Label;
            System.Windows.Forms.Label 產品名稱Label;
            System.Windows.Forms.Label 類別編號Label;
            System.Windows.Forms.Label 單價Label;
            System.Windows.Forms.Label 庫存Label;
            System.Windows.Forms.Label 產品圖片Label;
            this.puppyHouseDataSet = new WindowsForms.PuppyHouseDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsForms.PuppyHouseDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new WindowsForms.PuppyHouseDataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.產品編號TextBox = new System.Windows.Forms.TextBox();
            this.產品名稱TextBox = new System.Windows.Forms.TextBox();
            this.類別編號TextBox = new System.Windows.Forms.TextBox();
            this.單價TextBox = new System.Windows.Forms.TextBox();
            this.庫存TextBox = new System.Windows.Forms.TextBox();
            this.產品圖片PictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            產品編號Label = new System.Windows.Forms.Label();
            產品名稱Label = new System.Windows.Forms.Label();
            類別編號Label = new System.Windows.Forms.Label();
            單價Label = new System.Windows.Forms.Label();
            庫存Label = new System.Windows.Forms.Label();
            產品圖片Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puppyHouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.產品圖片PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // puppyHouseDataSet
            // 
            this.puppyHouseDataSet.DataSetName = "PuppyHouseDataSet";
            this.puppyHouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.puppyHouseDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsForms.PuppyHouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(356, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 15);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.productsBindingNavigatorSaveItem.Text = "儲存資料";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click_1);
            // 
            // 產品編號Label
            // 
            產品編號Label.AutoSize = true;
            產品編號Label.Location = new System.Drawing.Point(38, 56);
            產品編號Label.Name = "產品編號Label";
            產品編號Label.Size = new System.Drawing.Size(56, 12);
            產品編號Label.TabIndex = 1;
            產品編號Label.Text = "產品編號:";
            // 
            // 產品編號TextBox
            // 
            this.產品編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "產品編號", true));
            this.產品編號TextBox.Location = new System.Drawing.Point(100, 53);
            this.產品編號TextBox.Name = "產品編號TextBox";
            this.產品編號TextBox.Size = new System.Drawing.Size(100, 22);
            this.產品編號TextBox.TabIndex = 2;
            // 
            // 產品名稱Label
            // 
            產品名稱Label.AutoSize = true;
            產品名稱Label.Location = new System.Drawing.Point(38, 84);
            產品名稱Label.Name = "產品名稱Label";
            產品名稱Label.Size = new System.Drawing.Size(56, 12);
            產品名稱Label.TabIndex = 3;
            產品名稱Label.Text = "產品名稱:";
            // 
            // 產品名稱TextBox
            // 
            this.產品名稱TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "產品名稱", true));
            this.產品名稱TextBox.Location = new System.Drawing.Point(100, 81);
            this.產品名稱TextBox.Name = "產品名稱TextBox";
            this.產品名稱TextBox.Size = new System.Drawing.Size(100, 22);
            this.產品名稱TextBox.TabIndex = 4;
            // 
            // 類別編號Label
            // 
            類別編號Label.AutoSize = true;
            類別編號Label.Location = new System.Drawing.Point(38, 112);
            類別編號Label.Name = "類別編號Label";
            類別編號Label.Size = new System.Drawing.Size(56, 12);
            類別編號Label.TabIndex = 5;
            類別編號Label.Text = "類別編號:";
            // 
            // 類別編號TextBox
            // 
            this.類別編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "類別編號", true));
            this.類別編號TextBox.Location = new System.Drawing.Point(100, 109);
            this.類別編號TextBox.Name = "類別編號TextBox";
            this.類別編號TextBox.Size = new System.Drawing.Size(100, 22);
            this.類別編號TextBox.TabIndex = 6;
            // 
            // 單價Label
            // 
            單價Label.AutoSize = true;
            單價Label.Location = new System.Drawing.Point(38, 140);
            單價Label.Name = "單價Label";
            單價Label.Size = new System.Drawing.Size(32, 12);
            單價Label.TabIndex = 7;
            單價Label.Text = "單價:";
            // 
            // 單價TextBox
            // 
            this.單價TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "單價", true));
            this.單價TextBox.Location = new System.Drawing.Point(100, 137);
            this.單價TextBox.Name = "單價TextBox";
            this.單價TextBox.Size = new System.Drawing.Size(100, 22);
            this.單價TextBox.TabIndex = 8;
            // 
            // 庫存Label
            // 
            庫存Label.AutoSize = true;
            庫存Label.Location = new System.Drawing.Point(38, 168);
            庫存Label.Name = "庫存Label";
            庫存Label.Size = new System.Drawing.Size(32, 12);
            庫存Label.TabIndex = 9;
            庫存Label.Text = "庫存:";
            // 
            // 庫存TextBox
            // 
            this.庫存TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "庫存", true));
            this.庫存TextBox.Location = new System.Drawing.Point(100, 165);
            this.庫存TextBox.Name = "庫存TextBox";
            this.庫存TextBox.Size = new System.Drawing.Size(100, 22);
            this.庫存TextBox.TabIndex = 10;
            // 
            // 產品圖片Label
            // 
            產品圖片Label.AutoSize = true;
            產品圖片Label.Location = new System.Drawing.Point(38, 193);
            產品圖片Label.Name = "產品圖片Label";
            產品圖片Label.Size = new System.Drawing.Size(56, 12);
            產品圖片Label.TabIndex = 11;
            產品圖片Label.Text = "產品圖片:";
            // 
            // 產品圖片PictureBox
            // 
            this.產品圖片PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.產品圖片PictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productsBindingSource, "產品圖片", true));
            this.產品圖片PictureBox.Location = new System.Drawing.Point(100, 193);
            this.產品圖片PictureBox.Name = "產品圖片PictureBox";
            this.產品圖片PictureBox.Size = new System.Drawing.Size(111, 71);
            this.產品圖片PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.產品圖片PictureBox.TabIndex = 12;
            this.產品圖片PictureBox.TabStop = false;
            this.產品圖片PictureBox.Click += new System.EventHandler(this.產品圖片PictureBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 303);
            this.Controls.Add(產品編號Label);
            this.Controls.Add(this.產品編號TextBox);
            this.Controls.Add(產品名稱Label);
            this.Controls.Add(this.產品名稱TextBox);
            this.Controls.Add(類別編號Label);
            this.Controls.Add(this.類別編號TextBox);
            this.Controls.Add(單價Label);
            this.Controls.Add(this.單價TextBox);
            this.Controls.Add(庫存Label);
            this.Controls.Add(this.庫存TextBox);
            this.Controls.Add(產品圖片Label);
            this.Controls.Add(this.產品圖片PictureBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puppyHouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.產品圖片PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PuppyHouseDataSet puppyHouseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private PuppyHouseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private PuppyHouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 產品編號TextBox;
        private System.Windows.Forms.TextBox 產品名稱TextBox;
        private System.Windows.Forms.TextBox 類別編號TextBox;
        private System.Windows.Forms.TextBox 單價TextBox;
        private System.Windows.Forms.TextBox 庫存TextBox;
        private System.Windows.Forms.PictureBox 產品圖片PictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}