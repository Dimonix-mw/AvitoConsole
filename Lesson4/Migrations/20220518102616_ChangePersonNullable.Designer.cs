﻿// <auto-generated />
using Lesson4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lesson4.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220518102616_ChangePersonNullable")]
    partial class ChangePersonNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lesson4.Models.Announcement", b =>
                {
                    b.Property<int>("AnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AnnouncementId"));

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeAnnouncementId")
                        .HasColumnType("integer");

                    b.HasKey("AnnouncementId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TypeAnnouncementId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Lesson4.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Lesson4.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("TypeProductId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId");

                    b.HasIndex("TypeProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Lesson4.Models.TypeAnnouncement", b =>
                {
                    b.Property<int>("TypeAnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TypeAnnouncementId"));

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("TypeAnnouncementId");

                    b.ToTable("TypeAnnouncements");
                });

            modelBuilder.Entity("Lesson4.Models.TypeProduct", b =>
                {
                    b.Property<int>("TypeProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TypeProductId"));

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("TypeProductId");

                    b.ToTable("TypeProducts");
                });

            modelBuilder.Entity("Lesson4.Models.Announcement", b =>
                {
                    b.HasOne("Lesson4.Models.Person", "Person")
                        .WithMany("Announcements")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lesson4.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lesson4.Models.TypeAnnouncement", "TypeAnnouncement")
                        .WithMany()
                        .HasForeignKey("TypeAnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Product");

                    b.Navigation("TypeAnnouncement");
                });

            modelBuilder.Entity("Lesson4.Models.Product", b =>
                {
                    b.HasOne("Lesson4.Models.TypeProduct", "TypeProduct")
                        .WithMany()
                        .HasForeignKey("TypeProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("Lesson4.Models.Person", b =>
                {
                    b.Navigation("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
