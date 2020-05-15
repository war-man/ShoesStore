using System;
using System.Linq;
using CoV.Common.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;


namespace CoV.DataAccess.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context, IConfiguration configuration)
        {
            // if DB Not Exists 
            if (!((RelationalDatabaseCreator) context.Database.GetService<IDatabaseCreator>()).Exists())
            {
                context.Database.EnsureCreated();
                // Look for any accounts.
                if (!context.Roles.Any())
                {
                    var role = new Role
                    {
                        RoleName = Constants.Role.Admin,
                    };
                    var role2 = new Role
                    {
                        RoleName = Constants.Role.Accountant,
                    };
                    var role3 = new Role
                    {
                        RoleName = Constants.Role.Employee,
                    };
                    var role4 = new Role
                    {
                        RoleName = Constants.Role.Shiper,
                    };
                    context.Roles.Add(role);
                    context.Roles.Add(role2);
                    context.Roles.Add(role3);
                    context.Roles.Add(role4);
                    context.SaveChanges();
                }
                
                // Add User 
                if (!context.Users.Any())
                {
                    var user = new User
                    {
                        UserName = "admin@gmail.com",
                        Password = Constants.Role.Admin,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.MaxValue,
                        RoleId = (int)Common.Infrastructure.Role.Admin,
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                    
                    var user2 = new User
                    {
                        UserName = "user@gmail.com" ,
                        Password = Constants.Role.Admin,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.MaxValue,
                        RoleId = (int)Common.Infrastructure.Role.Accountant,
                    };
                    context.Users.Add(user2);
                    context.SaveChanges();
                    
                    var user3 = new User
                    {
                        UserName = "employee@gmail.com",
                        Password = Constants.Role.Admin,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.MaxValue,
                        RoleId = (int)Common.Infrastructure.Role.Employee,
                    };
                    context.Users.Add(user3);
                    context.SaveChanges();
                    
                    var shipper = new User
                    {
                        UserName = "shipper@gmail.com",
                        Password = Constants.Role.Admin,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.MaxValue,
                        RoleId = (int)Common.Infrastructure.Role.Shiper,
                    };
                    context.Users.Add(shipper);
                    context.SaveChanges();
                }
                
                // Inser Color
                if (!context.ColorProducts.Any())
                {
                    var red = new ColorProduct
                    {
                        Color = Constants.ColorProduct.Red
                    };
                    var black = new ColorProduct
                    {
                        Color = Constants.ColorProduct.Black
                    };
                    var blue = new ColorProduct
                    {
                        Color = Constants.ColorProduct.Blue
                    };
                    var green = new ColorProduct
                    {
                        Color = Constants.ColorProduct.Green
                    };
                    var white = new ColorProduct
                    {
                        Color = Constants.ColorProduct.White
                    };
                    var yellow = new ColorProduct
                    {
                        Color = Constants.ColorProduct.Yellow
                    };
                    var pinl = new ColorProduct
                    {
                        Color = Constants.ColorProduct.Pink
                    };
                    
                    context.ColorProducts.Add(red);
                    context.ColorProducts.Add(blue);
                    context.ColorProducts.Add(black);
                    context.ColorProducts.Add(green);
                    context.ColorProducts.Add(yellow);
                    context.ColorProducts.Add(white);
                    context.SaveChanges();
                }
                
                // insert classes auto
                
                if (!context.MakerProducts.Any())
                {
                    var maker1 = new MakerProduct
                    {
                        MakerName = Constants.MakerProduct.Nike,
                    };
                    
                    var maker2 = new MakerProduct
                    {
                        MakerName = Constants.MakerProduct.Convert,
                    };
                    
                    var maker3 = new MakerProduct
                    {
                        MakerName = Constants.MakerProduct.Adidas,
                    };
                    
                    var maker4 = new MakerProduct
                    {
                        MakerName = Constants.MakerProduct.Vans,
                    };
                    context.MakerProducts.Add(maker1);
                    context.MakerProducts.Add(maker2);
                    context.MakerProducts.Add(maker3);
                    context.MakerProducts.Add(maker4);
                    context.SaveChanges();
                }
                
                if (!context.StatusProducts.Any())
                {
                    var action = new StatusProduct
                    {
                        status = Constants.StatusProduct.Action
                    };
                    var stop = new StatusProduct
                    {
                        status = Constants.StatusProduct.Stop
                    };
                    context.StatusProducts.Add(action);
                    context.StatusProducts.Add(stop);
                    context.SaveChanges();
                }
                //insert Product Category
                if (!context.CategoryProducts.Any())
                {
                    var category = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.ShoesLong,
                    };
                    
                    var category1 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.Shoeshirst,
                    };
                    
                    var category2 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.Giayluoi,
                    };
                    
                    var category3 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.Giaythethao,
                    };
                    
                    var category4 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.GiayDangYeu,
                    };
                    var category5 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.GiayPhongCach,
                    };
                    var category6 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.ShoesCs,
                    };
                    var category7 = new CategoryProduct
                    {
                        CategoryName = Constants.CategoryProduct.GiayDa,
                    };
                    context.CategoryProducts.Add(category);
                    context.CategoryProducts.Add(category1);
                    context.CategoryProducts.Add(category2);
                    context.CategoryProducts.Add(category3);
                    context.CategoryProducts.Add(category4);
                    context.CategoryProducts.Add(category5);
                    context.CategoryProducts.Add(category6);
                    context.CategoryProducts.Add(category7);
                    context.SaveChanges();
                }
                
                //insert Gender 
                if (!context.Genders.Any())
                {
                    var male = new Gender
                    {
                        GenderName = Constants.GenderProduct.Male,
                    };
                    var female = new Gender
                    {
                        GenderName = Constants.GenderProduct.Female,
                    };
                    var unknownGender = new Gender
                    {
                        GenderName = Constants.GenderProduct.UnknownGender,
                    };
                    var Baby = new Gender
                    {
                        GenderName = Constants.GenderProduct.Baby,
                    };

                    context.Genders.Add(male);
                    context.Genders.Add(female);
                    context.Genders.Add(unknownGender);
                    context.Genders.Add(Baby);
                    context.SaveChanges();
                }

                if (!context.Products.Any())
                {
                    var product = new Product
                    {
                        Name = "Ustraboost",
                        Sku = "Das12",
                        Price = 25000,
                        PriceNew = 24000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 1,
                        GenderProductId = 1,
                    };
                    
                    
                    var product1 = new Product
                    {
                        Name = "Vans Old School",
                        Sku = "vans",
                        Price = 220000,
                        PriceNew = 24000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 2,
                        GenderProductId = 2,
                    };
                    
                    
                    var product2 = new Product
                    {
                        Name = "Yeezy 350",
                        Sku = "Yeezy12",
                        Price = 35000,
                        PriceNew = 35000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 1,
                        GenderProductId = 1,

                    };
                    
                    
                    var product3 = new Product
                    {
                        Name = "Giầy running Adidas ASWEEGO",
                        Sku = "adidas1",
                        Price = 255000,
                        PriceNew = 255000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 2,
                        GenderProductId = 2,
                    };
                    
                    var product4 = new Product
                    {
                        Name = "P.rophere Grey Solar Red",
                        Sku = "P1",
                        Price = 55000,
                        PriceNew = 55000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 3,
                        GenderProductId = 1,
                    };
                    
                    
                    var product5 = new Product
                    {
                        Name = "CV Chuck 70 Low Top Black (1970s)",
                        Sku = "CV1",
                        Price = 252000,
                        PriceNew = 252000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 4,
                        GenderProductId = 2,
                    };
                    
                    var product6 = new Product
                    {
                        Name = "Old Skool Classic Black",
                        Sku = "v1",
                        Price = 500000,
                        PriceNew = 500000,
                        FirstDate = DateTime.Now,
                        MakerProductId = 1,
                        Details = "Product new ",
                        AvatarDetails = "img-detail-02.jpg",
                        CategoryProductId = 1,
                        GenderProductId = 1,
                    };
                    
                    var product7 = new Product
                    {
                        Name = "Style 36 “Marshmallow” Racing Red",
                        Sku = "v23",
                        Price = 990000    ,
                        PriceNew = 990000    ,
                        MakerProductId = 1,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AvatarDetails = "img-detail-02.jpg",
                        CategoryProductId = 1,
                        GenderProductId = 2,
                    };
                    
                    var product8 = new Product
                    {
                        Name = "NMD R1 Triple White",
                        Sku = "NMD",
                        Price = 1190000,
                        PriceNew= 1190000,
                        MakerProductId = 1,
                        FirstDate = DateTime.Now,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 1,
                        GenderProductId = 1,
                    };
                    
                    var product9 = new Product
                    {
                        Name = "Alphabounce Beyond Cloud White",
                        Sku = "Al1",
                        Price = 9900000,
                        PriceNew = 9900000,
                        MakerProductId = 1,
                        FirstDate = DateTime.Now,
                        AvatarDetails = "img-detail-02.jpg",
                        Details = "Product new ",
                        CategoryProductId = 1,
                        GenderProductId = 2,
                    };
                    context.Products.Add(product);
                    context.Products.Add(product1);
                    context.Products.Add(product2);
                    context.Products.Add(product3);
                    context.Products.Add(product4);
                    context.Products.Add(product5);
                    context.Products.Add(product6);
                    context.Products.Add(product7);
                    context.Products.Add(product8);
                    context.Products.Add(product9);
                    context.SaveChanges();
                }
                
                
                if (!context.StatusOrder.Any())
                {
                    var status = new StatusOrder
                    {
                        Status = Constants.StatusOrder.XN,
                    };
                    var status1 = new StatusOrder
                    {
                        Status = Constants.StatusOrder.HoanHang,
                    };
                    var status2 = new StatusOrder
                    {
                        Status = Constants.StatusOrder.WIN,
                    };
                    var status3 = new StatusOrder
                    {
                        Status = Constants.StatusOrder.DVC,
                    };
                    var status4 = new StatusOrder
                    {
                        Status = Constants.StatusOrder.DC,
                    };
                    var status5 = new StatusOrder
                    {
                        Status = Constants.StatusOrder.DH,
                    };
                    context.StatusOrder.Add(status);
                    context.StatusOrder.Add(status1);
                    context.StatusOrder.Add(status2);
                    context.StatusOrder.Add(status3);
                    context.StatusOrder.Add(status4);
                    context.StatusOrder.Add(status5);
                    context.SaveChanges();
                }
            }
        }
    }
}