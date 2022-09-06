using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        //çokaçok 
        //birden fazla kategoriye ait olabilir 
        //bir kategorinin birden fazla ürünü olabilir
        public List<ProductCategory> ProductCategories { get; set; }




    }
}
