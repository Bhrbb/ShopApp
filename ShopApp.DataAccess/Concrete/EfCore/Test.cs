using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class Test
    {


        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count()==0)//eger migration 0 sa testi yansıt eger uygulanmamaıs mıgrations varsa test verilerini yansıtma 
            {
                if (context.Categories.Count()==0)//yani eğer categorilerde veri varsa test verisine gerek yok databaseden bak 
                {
                    context.Categories.AddRange(Categories);//liste ekle 
                }

                if (context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }

               
            }
        }

        private static Category[] Categories =
        {
            new Category() {Name = "Telefon"},
            new Category() {Name = "Bilgisayar"}


        };
        private static Product[] Products =
        {
            new Product() {Name = "Samsung S5",Price = 5500,ImageUrl = "1.jpg"},
            new Product() {Name = "Samsung S6",Price = 6500,ImageUrl = "2.jpg"},
            new Product() {Name = "Samsung S7",Price = 6750,ImageUrl = "3.jpg"},
            new Product() {Name = "Samsung S8",Price = 6800,ImageUrl = "4.jpg"},
            new Product() {Name = "İPhone 7",Price = 9500,ImageUrl = "5.jpg"},
            new Product() {Name = "İphone 8",Price = 10000,ImageUrl = "6.jpg"}
            


        };
    }
}
