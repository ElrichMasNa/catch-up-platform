using CatchUpPlatform.API.shared.infrastructure.Persistence.EFC.Interceptors;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CatchUpPlatform.API.shared.infrastructure.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreateUpdateInterceptor();
        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(builder);
        builder.UseSnakeCaseNamingConvention();
    }
}