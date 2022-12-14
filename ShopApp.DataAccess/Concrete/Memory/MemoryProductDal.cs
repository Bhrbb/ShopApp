using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = 1, Name = "Samsung S6", ImageUrl = "1.jpg", Price = 1000

                },
                new Product()
                {
                    Id = 1, Name = "Samsung S7", ImageUrl = "1.jpg", Price = 1000

                },
                new Product()
                {
                    Id = 1, Name = "Samsung S8", ImageUrl = "1.jpg", Price = 1000

                }
            };
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
