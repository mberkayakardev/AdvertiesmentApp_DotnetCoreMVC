using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace AkarSoftware.Managers.Concrete.Middlewares
{
    public static class CostumeMiddlewares
    {
        public static void AddStaticMiddlewares(this WebApplication app)
        {
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules"))
            });

        }
        public static void MyCostumeMiddlewares(this WebApplication app)
        {

        }

    }
}
