﻿namespace Bejebeje.DataAccess.Context
{
  using Bejebeje.Common.Extensions;
  using Microsoft.EntityFrameworkCore;
  using Microsoft.EntityFrameworkCore.Metadata;

  public class BbContext : DbContext
  {
    public BbContext(DbContextOptions<BbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      foreach (IMutableEntityType entity in builder.Model.GetEntityTypes())
      {
        // replace table names
        entity.Relational().TableName = entity.Relational().TableName.ToSnakeCase();

        // replace column names
        foreach (IMutableProperty property in entity.GetProperties())
        {
          property.Relational().ColumnName = property.Name.ToSnakeCase();
        }

        foreach (IMutableKey key in entity.GetKeys())
        {
          key.Relational().Name = key.Relational().Name.ToSnakeCase();
        }

        foreach (IMutableForeignKey key in entity.GetForeignKeys())
        {
          key.Relational().Name = key.Relational().Name.ToSnakeCase();
        }

        foreach (IMutableIndex index in entity.GetIndexes())
        {
          index.Relational().Name = index.Relational().Name.ToSnakeCase();
        }
      }
    }
  }
}