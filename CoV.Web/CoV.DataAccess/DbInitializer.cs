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
                        RoleName = Constants.Role.User,
                    };
                    var role3 = new Role
                    {
                        RoleName = Constants.Role.Customer,
                    };
                    
                    context.Roles.Add(role);
                    context.Roles.Add(role2);
                    context.Roles.Add(role3);
                    context.SaveChanges();
                    
                    

                }
                
                // Add User 
                if (!context.Users.Any())
                {
                    var user = new User
                    {
                        UserName = Constants.Role.Admin,
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
                        UserName = Constants.Role.User,
                        Password = Constants.Role.User,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.MaxValue,
                        RoleId = (int)Common.Infrastructure.Role.User,
                    };
                    context.Users.Add(user2);
                    context.SaveChanges();
                    
                    var user3 = new User
                    {
                        UserName = Constants.Role.UserEndDate,
                        Password = Constants.Role.User,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.Now.AddDays(-5),
                        RoleId = (int)Common.Infrastructure.Role.Customer,
                    };
                    context.Users.Add(user3);
                    context.SaveChanges();
                    
                    var Customer = new User
                    {
                        UserName = Constants.Role.Customer,
                        Password = Constants.Role.Customer,
                        FirstDate = DateTime.Now,
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        ExpiredDate = DateTime.Now.AddDays(-5),
                        RoleId = (int)Common.Infrastructure.Role.Customer,
                    };
                    context.Users.Add(Customer);
                    context.SaveChanges();
                    
                    var CustomerNew = new User
                    {
                        UserName = Constants.Role.CustomerNew,
                        Password = Encryptor.CalculateHash(Constants.Role.Admin),
                        ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                        FirstDate = DateTime.Now,
                        ExpiredDate = DateTime.MaxValue,
                        RoleId = (int)Common.Infrastructure.Role.Admin,
                    };
                    context.Users.Add(CustomerNew);
                    context.SaveChanges();
                    
                    
                    for (int i = 2; i < 100; i++)
                    {
                        var user5 = new User
                        {
                            UserName = Constants.Role.User + i,
                            Password = Constants.Role.User,
                            ImageAvatar = Constants.ImageUserDefail.imageAvatar,
                            FirstDate = DateTime.Now,
                            ExpiredDate = DateTime.Now.AddDays(-5),
                            RoleId = (int)Common.Infrastructure.Role.User,
                        };
                        context.Users.Add(user5);
                    }
                    
                    context.SaveChanges();
                    
                }

               
                // insert classes auto
                if (!context.Classeses.Any())
                {
                    for (int i = 0; i < 50; i++)
                    {
                        var classes = new Classes
                        {
                            ClassName = Constants.Classes.ClassName + " " + i,
                            ClassMember = Constants.Classes.ClassMember + i,
                        };
                        context.Classeses.Add(classes);
                    }

                    context.SaveChanges();
                }
                
                // Inser Color
                if (!context.ColorProducts.Any())
                {
                    var RED = new ColorProduct
                    {
                        Color = Constants.ColorProduct.RED
                    };
                    var BLACK = new ColorProduct
                    {
                        Color = Constants.ColorProduct.BLACK
                    };
                    var BLUE = new ColorProduct
                    {
                        Color = Constants.ColorProduct.BLUE
                    };
                    var GREEN = new ColorProduct
                    {
                        Color = Constants.ColorProduct.GREEN
                    };
                    var WHITE = new ColorProduct
                    {
                        Color = Constants.ColorProduct.WHITE
                    };
                    var YELLOW = new ColorProduct
                    {
                        Color = Constants.ColorProduct.YELLOW
                    };
                    
                    context.ColorProducts.Add(RED);
                    context.ColorProducts.Add(BLUE);
                    context.ColorProducts.Add(BLACK);
                    context.ColorProducts.Add(GREEN);
                    context.ColorProducts.Add(YELLOW);
                    context.ColorProducts.Add(WHITE);
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
                        status = Constants.StatusProduct.action
                    };
                    var stop = new StatusProduct
                    {
                        status = Constants.StatusProduct.stop
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
                    context.CategoryProducts.Add(category);
                    context.CategoryProducts.Add(category1);
                    context.CategoryProducts.Add(category2);
                    context.CategoryProducts.Add(category3);
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
                    var UnknownGender = new Gender
                    {
                        GenderName = Constants.GenderProduct.UnknownGender,
                    };

                    context.Genders.Add(male);
                    context.Genders.Add(female);
                    context.Genders.Add(UnknownGender);
                    context.SaveChanges();
                }

                if (!context.Products.Any())
                {
                    var product = new Product
                    {
                        name = "Ustraboost",
                        Sku = "Das12",
                        Price = 25000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 1,
                        MakerProductId = 1,
                        StatusProductId = 1,
                        CategoryProductId = 1,
                        GenderProductId = 1,

                    };
                    
                    
                    var product1 = new Product
                    {
                        name = "Vans Old School",
                        Sku = "vans",
                        Price = 220000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 2,
                        MakerProductId = 3,
                        StatusProductId = 2,
                        CategoryProductId = 2,
                        GenderProductId = 2,

                    };
                    
                    
                    var product2 = new Product
                    {
                        name = "Yeezy 350",
                        Sku = "Yeezy12",
                        Price = 35000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 1,
                        MakerProductId = 1,
                        StatusProductId = 1,
                        CategoryProductId = 1,
                        GenderProductId = 1,

                    };
                    
                    
                    var product3 = new Product
                    {
                        name = "Giầy running Adidas ASWEEGO",
                        Sku = "adidas1",
                        Price = 255000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 3,
                        MakerProductId = 2,
                        StatusProductId = 1,
                        CategoryProductId = 2,
                        GenderProductId = 2,
                    };
                    
                    var product4 = new Product
                    {
                        name = "P.rophere Grey Solar Red",
                        Sku = "P1",
                        Price = 55000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 5,
                        MakerProductId = 3,
                        StatusProductId =1,
                        CategoryProductId = 3,
                        GenderProductId = 1,
                    };
                    
                    
                    var product5 = new Product
                    {
                        name = "CV Chuck 70 Low Top Black (1970s)",
                        Sku = "CV1",
                        Price = 252000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 1,
                        MakerProductId = 3,
                        StatusProductId = 1,
                        CategoryProductId = 4,
                        GenderProductId = 2,
                    };
                    
                    var product6 = new Product
                    {
                        name = "Old Skool Classic Black",
                        Sku = "v1",
                        Price = 500000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 4,
                        MakerProductId = 3,
                        StatusProductId = 1,
                        CategoryProductId = 1,
                        GenderProductId = 1,
                    };
                    
                    var product7 = new Product
                    {
                        name = "Style 36 “Marshmallow” Racing Red",
                        Sku = "v23",
                        Price = 990000    ,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 1,
                        MakerProductId = 1,
                        StatusProductId = 1,
                        CategoryProductId = 1,
                        GenderProductId = 2,
                    };
                    
                    var product8 = new Product
                    {
                        name = "NMD R1 Triple White",
                        Sku = "NMD",
                        Price = 1190000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 1,
                        MakerProductId = 1,
                        StatusProductId = 1,
                        CategoryProductId = 1,
                        GenderProductId = 1,
                    };
                    
                    var product9 = new Product
                    {
                        name = "Alphabounce Beyond Cloud White",
                        Sku = "Al1",
                        Price = 9900000,
                        FirstDate = DateTime.Now,
                        Details = "Product new ",
                        AddressProduction = "HA NOI",
                        Number = 25,
                        AvatarDetails = "1248d9c8-37be-4cb9-bf38-061c1f56ac9f_Wap102 (1).jpg",
                        ColorProductId = 3,
                        MakerProductId = 1,
                        StatusProductId = 1,
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
            }
        }
    }
}