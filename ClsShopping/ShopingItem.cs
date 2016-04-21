using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClsShopping
{
    public partial class ShopingItem : UserControl
    {
        public ShopingItem()
        {
            InitializeComponent();
        }

        public bool ShoppingList = false;

        public string ProductName
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public string ProductDsec
        {
            set
            {
                this.label2.Text = value;
            }
        }

        public decimal ShoppingCount
        {
 
            get
            {
                return this.numericUpDown1.Value;
            }
        }

        decimal m_ProductPrice;
        public decimal ProductPrice
        {
            get
            {
                return m_ProductPrice;
            }
            set
            {
                m_ProductPrice = value;
                this.label_price.Text = value.ToString() ;
            }
        }

        public byte[] ProductImage
        {
            set
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(value);
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            btnBuy.Tag = ((NumericUpDown)sender).Value;
        }

        public delegate void DellItemBuy(Object Sender);
        public event DellItemBuy ItemBuy;

        
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (this.numericUpDown1.Value > 0)
            {
                ItemBuy(this);
            }
        }
    }
}
