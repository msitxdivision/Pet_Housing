using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ShopDetail : Form
    {
        public List<ClsShopping.ShopingItem> shopdetails = new List<ClsShopping.ShopingItem>();

        public ShopDetail()
        {
            InitializeComponent();
        }

        private void ShopDetail_Load(object sender, EventArgs e)
        {
            foreach (var x in shopdetails)
            {
                    ClsShopping.ShoppingDetails s = new ClsShopping.ShoppingDetails();
                    s.Name = "SD" + x.ProductName;
                    s.ProductName = x.ProductName;
                    s.price = Math.Round(x.ProductPrice,0);
                    s.count = x.ShoppingCount;
                    this.flowLayoutPanel1.Controls.Add(s);
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel1.Controls.Count > 0) 
            { 
            MessageBox.Show("結帳成功!");
            this.Close();
            }
            else
            {
             MessageBox.Show("購物車沒有東西!");
             if (MessageBox.Show("是否要離開?", "結帳", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
             {
                 this.Close();
             }
            }
        }

       
       

       

        
    }
}
