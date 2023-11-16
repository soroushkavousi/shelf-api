﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShelfApi.Domain.UserAggregate;
using ShelfApi.Infrastructure.Extensions;

namespace ShelfApi.Infrastructure.Data;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");

        builder.ConfigureOrders();
        builder.ConfigureAutoGeneratedKey();
        builder.ConfigureCreatedAt();
        builder.ConfigureModifiedAt();

        builder.Property(x => x.Id)
            .HasColumnType("tinyint");
    }
}