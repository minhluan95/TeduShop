namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateCategoryExample(context);
            CreateUserExample(context);
            CreateSlideExample(context);

        }
        public void CreateUserExample(TeduShopDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Administrator"

            };

            manager.Create(user, "123123");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("admin@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
        public void CreateCategoryExample(TeduShop.Data.TeduShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> lstCate = new List<ProductCategory>()
                {
                new ProductCategory(){Name="Giầy dép",Alias="giay-dep",Status=true},
                new ProductCategory(){Name="Túi xách",Alias="tui-xach",Status=true},
                new ProductCategory(){Name="Đồng hồ",Alias="dong-ho",Status=true},
                new ProductCategory(){Name="Trang sức",Alias="trang-suc",Status=true},
                new ProductCategory(){Name="Mỹ phẫm",Alias="my-pham",Status=true}
                };
                context.ProductCategories.AddRange(lstCate);
                context.SaveChanges();
            }
        }
        public void CreateSlideExample(TeduShop.Data.TeduShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> lstSlide = new List<Slide>()
                {
                    new Slide(){
                        Name ="Slide 1",
                        URL ="#",
                        Status=true,
                        DisplayOrder=1,
                        Image ="/Assets/client/images/bag.jpg",
                        Content =@"<h2>FLAT 50% 0FF</h2>
								<label>FOR ALL PURCHASE <b>VALUE</b></label>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>					
								<span class=""on-get"">GET NOW</span>"},
                    new Slide(){
                        Name ="Slide 2",
                        DisplayOrder=2,
                        Status=true,
                        URL ="#",
                        Image ="/Assets/client/images/bag1.jpg",
                        Content =@"<h2>FLAT 50% 0FF</h2>
								<label>FOR ALL PURCHASE <b>VALUE</b></label>
								<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et </p>					
								<span class=""on-get"">GET NOW</span>"}
                };
                context.Slides.AddRange(lstSlide);
                context.SaveChanges();
            }
        }
    }
}