using Microsoft.EntityFrameworkCore;
namespace CatchUpPlatform.API.shared.infrastructure.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void UseSnakeCaseNamingConvention(this ModelBuilder builder)
    {
        foreach (var entity in builder.Model.GetEntityTypes())
        {
            var tableName = entity.GetTableName();
            if (!string.IsNullOrEmpty(tableName)) entity.SetTableName(tableName.ToPlural().ToSnakeCase());
            foreach (var property in entity.GetProperties())
                property.SetColumnName(property.GetColumName.ToSnakeCase());
            foreach (var key in entity.GetKeys())
            {
                var keyName = key.GetName();
                if (!string.IsNullOrEmpty(keyName)) keyName.SetName(keyName.ToSnakeCase());
            }
            foreach (var index in entity.GetIndexes())
            {
                var indexName = index.GetDatabaseName();
                if (!string.IsNullOrEmpty(indexName)) 
                    index.SetName(indexName.ToSnakeCase());
            }

            foreach (var key in entity.GetForeignKeys())
            {
                var foreignKeyName = foreignKey.GetConstraintName();
                if(!string.IsNullOrEmpty(foreignKeyName))
                foreignKey.SetConstraintName(foreignKeyName.ToSnakeCase());
            }
        }
    }
}

