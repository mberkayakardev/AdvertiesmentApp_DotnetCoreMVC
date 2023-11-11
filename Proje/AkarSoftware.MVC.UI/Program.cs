using AkarSoftware.Managers.Concrete.DependencyResolves.Microsoft;
using AkarSoftware.Managers.Concrete.Middlewares;


var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllersWithViews();

/// Added Costume Services
builder.Services.AddCostumeServices(builder.Configuration);

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
    app.UseStatusCodePagesWithReExecute("/Error/Status", "?code={0}");
    app.UseHttpsRedirection();
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
    x.MapControllerRoute(name: "areas", pattern: "{Area=Landing}/{Controller=Home}/{Action=Index}/{id?}");
});


/// Costume Middlewares
app.MyCostumeMiddlewares();
#endregion

app.Run();
