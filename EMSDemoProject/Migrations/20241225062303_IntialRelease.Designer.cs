﻿// <auto-generated />
using EMSDemoProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EMSDemoProject.Migrations
{
    [DbContext(typeof(EmsDBContext))]
    [Migration("20241225062303_IntialRelease")]
    partial class IntialRelease
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EMSDemoProject.Models.Employee", b =>
                {
                    b.Property<int>("empId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("empId"));

                    b.Property<string>("empName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("empSalary")
                        .HasColumnType("integer");

                    b.HasKey("empId");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
