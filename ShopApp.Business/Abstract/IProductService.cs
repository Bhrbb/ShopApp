using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.Entities;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetPopularProducts();
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
    }
}
