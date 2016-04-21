using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsShopping
{
    public class Shopping
    {

        PuppyHouse ds = new PuppyHouse();
        PuppyHouseTableAdapters.CategoriesTableAdapter Cad = new PuppyHouseTableAdapters.CategoriesTableAdapter();
        PuppyHouseTableAdapters.ProductsTableAdapter Pad = new PuppyHouseTableAdapters.ProductsTableAdapter();


        public Shopping()
        {
            Cad.Fill(ds.Categories);
            Pad.Fill(ds.Products);
        }

       public PuppyHouse.CategoriesDataTable GetCateogries()
        {
            var result = Cad.GetDataByCategoriesName();

                return result;
        }

        public PuppyHouse.ProductsDataTable GetProductsbyCategories(string CategoriesName)
        {
            var result = Pad.GetDataByCategoriesGetProducts(CategoriesName);
            return result;
        }
    }
}
