// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSoPro.Models;

#nullable disable

namespace ProjectSoPro.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220514172700_Fixed")]
    partial class Fixed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectSoPro.Models.Genre", b =>
                {
                    b.Property<int>("genreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("genreId"), 1L, 1);

                    b.Property<int?>("Movieid")
                        .HasColumnType("int");

                    b.Property<string>("genres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genreId");

                    b.HasIndex("Movieid");

                    b.ToTable("genre");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Movie", b =>
                {
                    b.Property<int>("Movieid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Movieid"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Movieid");

                    b.ToTable("movie");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Person", b =>
                {
                    b.Property<int>("Personid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personid"), 1L, 1);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Personid");

                    b.ToTable("person");
                });

            modelBuilder.Entity("ProjectSoPro.Models.PersonRoles", b =>
                {
                    b.Property<int>("RolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolesId"), 1L, 1);

                    b.Property<int?>("Movieid")
                        .HasColumnType("int");

                    b.Property<int?>("Personid")
                        .HasColumnType("int");

                    b.Property<string>("actors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("directors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("producers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolesId");

                    b.HasIndex("Movieid");

                    b.HasIndex("Personid");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Genre", b =>
                {
                    b.HasOne("ProjectSoPro.Models.Movie", null)
                        .WithMany("genres")
                        .HasForeignKey("Movieid");
                });

            modelBuilder.Entity("ProjectSoPro.Models.PersonRoles", b =>
                {
                    b.HasOne("ProjectSoPro.Models.Movie", null)
                        .WithMany("rolesid")
                        .HasForeignKey("Movieid");

                    b.HasOne("ProjectSoPro.Models.Person", null)
                        .WithMany("rolesid")
                        .HasForeignKey("Personid");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Movie", b =>
                {
                    b.Navigation("genres");

                    b.Navigation("rolesid");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Person", b =>
                {
                    b.Navigation("rolesid");
                });
#pragma warning restore 612, 618
        }
    }
}
