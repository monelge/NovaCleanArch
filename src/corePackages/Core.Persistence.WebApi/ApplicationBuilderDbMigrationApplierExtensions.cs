using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Nova.Core.Persistence.DbMigrationApplier;

namespace Nova.Core.Persistence.WebApi;

public static class ApplicationBuilderDbMigrationApplierExtensions
{
    public static IApplicationBuilder UseDbMigrationApplier(this IApplicationBuilder app)
    {
        IEnumerable<IDbMigrationApplierService> migrationCreatorServices =
            app.ApplicationServices.GetServices<IDbMigrationApplierService>();
        foreach (IDbMigrationApplierService service in migrationCreatorServices)
            service.Initialize();

        return app;
    }
}
