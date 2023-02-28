﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using bookish;

#nullable disable

namespace bookish.Migrations
{
    [DbContext(typeof(BookishContext))]
    [Migration("20230228120941_BookishDataBase")]
    partial class BookishDataBase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("bookish.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("integer");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalNoOfCopies")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("bookish.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<int>("CheckoutDate")
                        .HasColumnType("integer");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<int>("ReturnDate")
                        .HasColumnType("integer");

                    b.Property<bool>("Returned")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Checkout");
                });

            modelBuilder.Entity("bookish.Models.Members", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MemberName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PhoneNo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
