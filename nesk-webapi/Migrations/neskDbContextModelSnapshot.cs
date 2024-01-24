﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nesk_webapi.AppDbContext;

#nullable disable

namespace nesk_webapi.Migrations
{
    [DbContext(typeof(neskDbContext))]
    partial class neskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("nesk_webapi.Models.Roles", b =>
                {
                    b.Property<Guid>("PkRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PkRoleId");

                    b.ToTable("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
