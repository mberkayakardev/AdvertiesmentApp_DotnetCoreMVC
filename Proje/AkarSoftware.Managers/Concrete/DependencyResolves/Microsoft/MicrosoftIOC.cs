using AkarSoftware.Core.Utilities.Options;
using AkarSoftware.DataAccess.Abstract;
using AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts;
using AkarSoftware.DataAccess.Concrete.EntityFramework.UOW;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Printing;
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
            //services.ConfigureApplicationCookie()
        }

        /// <summary>
        /// DbContext ayarlandı.
        /// </summary>
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyDbContexts>(x =>
            {
                x.UseSqlServer(configuration.GetSection("AppSettings:ConnectionString").Value.ToString());
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
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
        }

        #endregion
    }
}
