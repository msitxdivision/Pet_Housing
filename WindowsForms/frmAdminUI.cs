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
    public partial class frmAdminUI : Form
    {
        public frmAdminUI()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.memberDataSet);

        }

        private void frmAdminUI_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'productDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.productDataSet.Categories);
            // TODO:  這行程式碼會將資料載入 'productDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.productDataSet.Products);
            // TODO:  這行程式碼會將資料載入 'memberDataSet.House' 資料表。您可以視需要進行移動或移除。
            this.houseTableAdapter.Fill(this.memberDataSet.House);
            // TODO:  這行程式碼會將資料載入 'memberDataSet.Pet' 資料表。您可以視需要進行移動或移除。
            this.petTableAdapter.Fill(this.memberDataSet.Pet);
            // TODO:  這行程式碼會將資料載入 'memberDataSet.Member' 資料表。您可以視需要進行移動或移除。
            this.memberTableAdapter.Fill(this.memberDataSet.Member);

        }
    }
}
