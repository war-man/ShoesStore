﻿using System;
using System.Text;
using AutoMapper;
using CoV.Common.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using CoV.DataAccess.Data;
using CoV.Service.DataModel;
using CoV.Service.Repository;
using CoV.Service.Service;
using CoV.Web.Infrastructure.Filter;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoV.Web.Infrastructure.Mapper;
using CoV.Web.Infrastructure.Middleware;
using CoV.Web.Infrastructure.Validations;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Events;


namespace CoV.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Log.Logger = new LoggerConfiguration().
                MinimumLevel.Error().
                WriteTo.RollingFile("log/log-{Date}-CoV.txt",LogEventLevel.Error)
                .CreateLogger();         
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region framework services
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //this is connect db
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            //add scope UnitOfWork    
            services.AddScoped<ExpireDateUserFilter>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IClassesService, ClassesService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IRoleService, RoleService>();
            //Producct Add Scoped
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryProductService, CategoryProductService>();
            services.AddScoped<IColorProductService, ColorProductService >();
            services.AddScoped<IGenderService, GenderService >();
            services.AddScoped<IImageProductService, ImageProductService >();
            services.AddScoped<ISizeProductService,SizeProductService >();
            services.AddScoped< IStatusProductService,StatusProductService>();
            
            services.AddTransient<IValidator<LoginModel>, LoginValidation>();
            services.AddTransient<IValidator<UserViewModel>, UserViewValidation>();
            
            //add mapping
            //services.AddAutoMapper(typeof(UserMapper.UserMapping));
            services.AddAutoMapper(typeof(UserMapper));
            services.AddAutoMapper(typeof(ClassesMapper));
            services.AddAutoMapper(typeof(StudentMapper));
            services.AddAutoMapper(typeof(RoleMapper));
            //Products
            services.AddAutoMapper(typeof(ProductMapper));
            services.AddAutoMapper(typeof(CategoryMapper));
            services.AddAutoMapper(typeof(ColorProductMapper));
            services.AddAutoMapper(typeof(SizeProductMapper));
            services.AddAutoMapper(typeof(GenderMapper));
            services.AddAutoMapper(typeof(StatusProductMapper));

            services.AddSession();
            // Config authentication
            services.AddAuthentication(options =>
                {
                    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                options.AccessDeniedPath = Constants.Route.AccessDenied;
                }         
                );
            
            // Json web token
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true, // có validate Server tạo JWT không ?
                        ValidateAudience = true,
                        ValidateLifetime = true, //có validate expire time hay không ?
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = Configuration[Constants.JwtIssuer],
                        ValidAudience = Configuration[Constants.JwtIssuer],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding
                            .UTF8.GetBytes(Configuration[Constants.JwtKey]))
                    };
                });
            
            // serilog
            services.AddLogging();
            //Claims base Authorize
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireAssertion(context => 
                    context.User.IsInRole(Constants.Role.Admin)));
                options.AddPolicy("User", policy => policy.RequireAssertion(context => 
                    context.User.IsInRole(Constants.Role.User) || context.User.IsInRole(Constants.Role.Admin)));
                
            });
            
            // Adds a default in-memory implementation of IDistributedCache
            services.AddDistributedMemoryCache();
            
            services.AddSession(options =>
            {
                options.Cookie.Name = Constants.AppSession;
                options.IdleTimeout = TimeSpan.FromMinutes(Convert
                    .ToDouble(Configuration[Constants.Settings.ExpiredSessionTime] ?? "60"));
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddFluentValidation();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env ,ILoggerFactory loggerFactory)
        {    
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // error 500. system server error
                app.UseExceptionHandler(Constants.Route.ErrorPage);
                app.UseHsts();
            }
            // add file log exception
 
            app.UseStaticFiles();  
            app.UseHttpsRedirection();
            app.UseAuthentication();  
            app.UseHttpsRedirection();          
            app.UseCookiePolicy();
            app.UseSession();
            
            // Use page logger
            loggerFactory.AddDebug();
            loggerFactory.AddSerilog();
            
            // Middleware : Page not pound 404
            app.UseRequestCulture();
            //page Authorize Accessdenid
            app.UsePageAccessdenied();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=home}/{action=home}/{id?}");
            });
        }
    }
}