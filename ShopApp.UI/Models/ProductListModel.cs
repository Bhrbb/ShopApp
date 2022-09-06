using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.Entities;

namespace ShopApp.UI.Models
{
    public class ProductListModel : IEnumerable
    {
        public List<Product>Products { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
