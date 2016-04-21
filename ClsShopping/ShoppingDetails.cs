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
    public partial class ShoppingDetails : UserControl
    {
        public ShoppingDetails()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            set
            {
                this.label_name.Text = value;
            }
        }

        decimal m_price;
        public decimal price
        {
            set
            {
                m_price = value;
                this.label_price.Text = value.ToString();
            }
        }


        

        decimal m_count;
        decimal m_total;
        public decimal count
        {
            set
            {
                m_count = value;
                this.numericUpDown_Count.Value = value;

                m_total = m_price * m_count;
                this.label_total.Text = Convert.ToString(m_total);
            }
        }

        private void numericUpDown_Count_ValueChanged(object sender, EventArgs e)
        {
            this.count = ((NumericUpDown)sender).Value;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
