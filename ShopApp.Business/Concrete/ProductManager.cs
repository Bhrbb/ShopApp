using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
       // EfCoreProductDal _productDal = new EfCoreProductDal(); bu bagımlılık olmasın diye depencdy injeksion yapıcaz //Efcore=>IProductdala baglı biz baska zaman Ef 
       //vazgectiğimiz zaman herseyi yeniden değiştirmemek için ıproducta bagımlı yapalım 
       private IProductDal _productDal;

       public ProductManager(IProductDal productDal)
       {
           _productDal = productDal;

       }

       public List<Product> GetPopularProducts()
       {
           return _productDal.GetAll(p => p.Price > 2000);
       }

       public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {

            return _productDal.GetAll().ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
