﻿// <auto-generated />
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
    [Migration("20220514175801_FixedForeign")]
    partial class FixedForeign
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

                    b.Property<int>("Movieid")
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Personid");

                    b.ToTable("person");
                });

            modelBuilder.Entity("ProjectSoPro.Models.PersonRoles", b =>
                {
                    b.Property<int>("RolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolesId"), 1L, 1);

                    b.Property<int>("Movieid")
                        .HasColumnType("int");

                    b.Property<int>("Personid")
                        .HasColumnType("int");

                    b.Property<string>("actors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Actors");

                    b.Property<string>("directors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Directors");

                    b.Property<string>("producers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Producers");

                    b.HasKey("RolesId");

                    b.HasIndex("Movieid");

                    b.HasIndex("Personid");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Genre", b =>
                {
                    b.HasOne("ProjectSoPro.Models.Movie", "Movie")
                        .WithMany("Genres")
                        .HasForeignKey("Movieid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ProjectSoPro.Models.PersonRoles", b =>
                {
                    b.HasOne("ProjectSoPro.Models.Movie", "Movie")
                        .WithMany("PersonRoles")
                        .HasForeignKey("Movieid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectSoPro.Models.Person", "Person")
                        .WithMany("PersonRoles")
                        .HasForeignKey("Personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Movie", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("PersonRoles");
                });

            modelBuilder.Entity("ProjectSoPro.Models.Person", b =>
                {
                    b.Navigation("PersonRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
