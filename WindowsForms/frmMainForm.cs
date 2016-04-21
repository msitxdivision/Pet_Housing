using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsShopping;

namespace WindowsForms
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        //================================================================
        //類別新增方法
        private void btnTest_Click(object sender, EventArgs e)
        {
            Shopping sp = new Shopping();
            var result = sp.GetCateogries();

            int height = 64;
            foreach (var x in result)
            {
                LinkLabel lb = new LinkLabel();
                lb.AutoSize = true;
                lb.Location = new System.Drawing.Point(33, height);
                lb.Name = "lb"+x.類別名稱;
                lb.Text = x.類別名稱;
                lb.Click += lb_Click;
                this.splitContainer1.Panel1.Controls.Add(lb);
                height += 30;
            }
        }

        //類別連結到產品內容
        List<ShopingItem> SIs = new List<ShopingItem>();
        void lb_Click(object sender, EventArgs e)
        {
            Shopping sp = new Shopping();
            var result= sp.GetProductsbyCategories(((LinkLabel)sender).Text);
            this.flowLayoutPanel1.Controls.Clear();
            foreach (var x in result)
            {
            //string s = string.Format("{0}:{1} {2}:{3} {4}:{5}", "產品名稱", x.產品名稱, "單價", x.單價, "庫存", x.庫存);
            //Label L = new Label();
            //L.AutoSize = true;
            //L.Text = s;
            //this.flowLayoutPanel1.Controls.Add(L);
                ShopingItem i = new ShopingItem();
                i.ProductImage = x.產品圖片;
                i.ProductName = x.產品名稱;
                i.ProductPrice = Math.Round(x.單價,0);
                i.ItemBuy += i_ItemBuy;
                this.flowLayoutPanel1.Controls.Add(i);
            }
        }

        int shopcount;
        void i_ItemBuy(object Sender)
        {
            SIs.Add((ShopingItem)Sender);
            shopcount += 1;
            this.label_ShopCount.Text = shopcount.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddProducts f = new AddProducts();
            f.ShowDialog();
        }

        private void btnpaycheck_Click(object sender, EventArgs e)
        {
            ShopDetail f = new ShopDetail();
            f.shopdetails = SIs; //將產品集合傳回Sis
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SIs.Clear();
                shopcount = 0;
                this.label_ShopCount.Text = shopcount.ToString();
            }
        }

       

        
    }
}
