using AkarSoftware.Managers.Concrete.DependencyResolves.Microsoft;
using AkarSoftware.Managers.Concrete.Middlewares;
using NLog;
using NLog.Web;


var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureLogging(log =>
{
    log.ClearProviders();
    log.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
}).UseNLog(); // NLog İmplementetaion 


#region Services
builder.Services.AddControllersWithViews();

/// Added Costume Services
builder.Services.AddCostumeServices(builder.Configuration, builder.Environment);

#endregion


var app = builder.Build();

#region Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error/GetErrors");
    //app.UseStatusCodePagesWithReExecute("/Error/Status", "?code={0}");
    app.UseHttpsRedirection(); // HTTPS yönlendirmesi otomatik olarak gerçekleşecektir. 
}


/// Static Files Configuration
app.AddStaticMiddlewares();


/// Routing
app.UseRouting();


/// Authentication
app.UseAuthentication();


///Authorization
app.UseAuthorization();


/// Endpoints Configuration
app.UseEndpoints(x =>
{
    x.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}", defaults: new { Controller = "Home", Action = "Index", Area = "Landing" });
    
    x.MapControllerRoute(name: "areas", pattern: "{Area=Landing}/{Controller=Home}/{Action=Index}/{id?}");

});


/// Costume Middlewares
app.MyCostumeMiddlewares();
#endregion

app.Run();
