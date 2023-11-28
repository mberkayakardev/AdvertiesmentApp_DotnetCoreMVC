using AkarSoftware.Core.Utilities.Options;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts;
using AkarSoftware.DataAccess.Concrete.EntityFramework.UOW;
using AkarSoftware.Managers.Abstract;
using AkarSoftware.Managers.Concrete.Managers;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace AkarSoftware.Managers.Concrete.DependencyResolves.Microsoft
{
    public static class MicrosoftIOC
    {
        public static void AddCostumeServices(this IServiceCollection services, IConfiguration configuration, IHostEnvironment enviroment)
        {
            AddConfigurationFiles(services, configuration);

            AddAnotherConfigurationServices(services, configuration);

            AddDbContext(services, configuration, enviroment);

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
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration, IHostEnvironment enviroment)
        {
            services.AddDbContext<MyDbContexts>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("SqlServer"));
                if (enviroment.IsDevelopment())
                {
                    x.EnableSensitiveDataLogging(true); // veritabanı loglaması için aktif hale getirildi. 
                }
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

            services.AddScoped<IProviderServicesService, ProviderServicesManager>();
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
            #region Fluent Validation Otomatik Register
            var assemblyList = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.BaseType.Name.Contains("AbstractValidator")).ToList();
            foreach (var item in assemblyList)
            {
                var DtoType = item.BaseType.GetGenericArguments()[0];
                services.AddSingleton(typeof(IValidator<>).MakeGenericType(DtoType), item);
            }
            #endregion

            #region Manual
            //services.AddSingleton<IValidator<AddAppUserDto>, AddAppUserValidationRules>();
            //services.AddSingleton<IValidator<UpdateAppUserDto>, UpdateAppUserValidatonRules>();
            //services.AddSingleton<IValidator<DeleteAppUserDto>, DeleteAppUserDtoValidationRules>();
            #endregion

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
                    opt.ExpireTimeSpan = TimeSpan.FromDays(60);
                });
        }

        #endregion
    }
}
