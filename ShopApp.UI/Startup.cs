using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.DataAccess.Concrete.Memory;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.DataAccess.Concrete.EfCore;

namespace ShopApp.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductDal, EfCoreProductDal>();
            //conretelere bagımlılık olmaması gerekiyor interface bagımlı olabilirsin 
            //ben IproductDal cagırdıgımda bana MemoryProductı gönder(productManager cagırıyor )
            services.AddScoped<IProductService, ProductManager>();
            //IProductServisi istediğimde Productmanager gönder ileride Manageri değiştirebilmek kolay
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())//geliştirme aşaması
            {
                app.UseDeveloperExceptionPage();
                Test.Seed();
            }

            app.UseMvcWithDefaultRoute();
           
        }
    }
}
