using AkarSoftware.Core.Utilities.Options;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts;
using AkarSoftware.DataAccess.Concrete.EntityFramework.UOW;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AkarSoftware.Managers.Concrete.DependencyResolves.Microsoft
{
    public static class MicrosoftIOC
    {
        public static void AddCostumeServices(this IServiceCollection services, IConfiguration configuration)
        {
            AddConfigurationFiles(services, configuration);

            AddAnotherConfigurationServices(services, configuration);

            AddDbContext(services, configuration);

            AddUnitOfWork(services, configuration);

            AddDependencies(services);

            AddMapper(services);

            AddAuthenticaton(services);
        }

        #region Methods
        /// <summary>
        /// Option pattern ile birlikte multiple appsettings.json u ekler enviroment ortalına göre ilgili appsettings register olur
        /// </summary>
        private static void AddConfigurationFiles(IServiceCollection services, IConfiguration configuration)
        {
            /// Otomatik algılayabildiğini öğrendim.

            //var environment = configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT");
            //var appSettingsFileName = $"appsettings.{environment}.json";
            //var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), appSettingsFileName);
            //var appSettings = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile(appSettingsPath, optional: true)
            //    .Build();
            //services.Configure<AppSettings>(configuration.GetSection("AppSettings"));

            services.Configure<AppSettingsOption>(x =>
            {
                x.DatabaseConnection = configuration.GetSection("AppSettings:ConnectionString").Value;
                x.MainterenceMode = Convert.ToBoolean(configuration.GetSection("AppSettings:MainterenceMode").Value);
            });

        }

        /// <summary>
        /// Cookie yapılanmaları ve Session Yapılanmalarını içermektedir.
        /// </summary>
        private static void AddAnotherConfigurationServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSession();
            services.AddMemoryCache(); // memoryCache eklendi .
        }

        /// <summary>
        /// DbContext ayarlandı.
        /// </summary>
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDbContexts>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("SqlServer"));
                x.EnableSensitiveDataLogging(true);
            });
        }

        private static void AddUnitOfWork(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        /// <summary>
        /// Proje bağlılıkları eklenir.
        /// </summary>
        private static void AddDependencies(IServiceCollection services)
        {
            #region Fluent Validation Otomatik Register
            var assemblyList = Assembly.GetExecutingAssembly().GetTypes().Where(x=> x.BaseType.Name.Contains("AbstractValidator")).ToList();
            foreach (var item in assemblyList)
            {
                var DtoType = item.BaseType.GetGenericArguments()[0];
                services.AddSingleton(typeof(IValidator<>).MakeGenericType(DtoType), item);

            }
            #endregion

        }
        /// <summary>
        ///  Automapper ekler 
        /// </summary>
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        private static void AddValidatons(IServiceCollection services)
        {
            //services.AddTransient<IValidator<AddAppUserDto>, AddAppUserValidationRules>();
            //services.AddTransient<IValidator<UpdateAppUserDto>, UpdateAppUserValidatonRules>();
            //services.AddTransient<IValidator<DeleteAppUserDto>, DeleteAppUserDtoValidationRules>();
        }

        private static void AddAuthenticaton(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(opt =>
                {
                    opt.LogoutPath = new PathString("/singout");
                    opt.LoginPath = new PathString("/singin");
                    opt.AccessDeniedPath = new PathString("/forbidden");

                    opt.Cookie.Name = "AkarSoftWare";
                    opt.Cookie.HttpOnly = true;
                    opt.Cookie.SameSite = SameSiteMode.Strict;
                    opt.Cookie.Expiration = TimeSpan.FromDays(80);
                });
        }

        #endregion
    }
}
