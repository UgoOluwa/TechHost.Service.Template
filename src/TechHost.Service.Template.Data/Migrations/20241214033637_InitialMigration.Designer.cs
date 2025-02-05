﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TechHost.Service.Template.Data.Contexts;

#nullable disable

namespace TechHost.Service.Template.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241214033637_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TechHost.Service.Template.Model.Entities.WeatherForecast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Summary")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("WeatherForcasts", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
