using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ShopApp.Entities
{
    public class ProductCategory
    {
      
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        //ilişki kurmak için 
        //tabloları birleştirdik ama o categorinnin bilgisinin gelmesi için de category tipinde categorii yazdık 

    }
}
