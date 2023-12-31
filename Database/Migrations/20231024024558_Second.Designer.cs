﻿// <auto-generated />
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(LansContext))]
    [Migration("20231024024558_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database.Empleado", b =>
                {
                    b.Property<int>("idEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEmpleado"));

                    b.Property<int>("Nombre")
                        .HasColumnType("int");

                    b.Property<int>("idRol")
                        .HasColumnType("int");

                    b.HasKey("idEmpleado");

                    b.HasIndex("idRol");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Database.Rol", b =>
                {
                    b.Property<int>("idRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idRol"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRol");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Database.Empleado", b =>
                {
                    b.HasOne("Database.Rol", "Rol")
                        .WithMany("Empleados")
                        .HasForeignKey("idRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Database.Rol", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
