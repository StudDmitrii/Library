﻿// <auto-generated />
using System;
using Library.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Library.Migrations
{
    [DbContext(typeof(Model.ApplicationContext))]
    [Migration("20231225112640_feo")]
    partial class feo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("integer");

                    b.Property<int>("BooksId")
                        .HasColumnType("integer");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("integer");

                    b.Property<int>("GenresId")
                        .HasColumnType("integer");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("Library.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Library.Model.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PublisherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Library.Model.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("FactReturnDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("PlanReturnDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TakeDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("WorkerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("Library.Model.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Library.Model.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("Library.Model.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Library.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Library.Model.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("Library.Model.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("Library.Model.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Model.Book", b =>
                {
                    b.HasOne("Library.Model.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Library.Model.Entry", b =>
                {
                    b.HasOne("Library.Model.Book", "Book")
                        .WithMany("Entries")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.User", "User")
                        .WithMany("Entries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Worker", "Worker")
                        .WithMany("Entries")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("Library.Model.Worker", b =>
                {
                    b.HasOne("Library.Model.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Library.Model.Book", b =>
                {
                    b.Navigation("Entries");
                });

            modelBuilder.Entity("Library.Model.Position", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("Library.Model.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Model.User", b =>
                {
                    b.Navigation("Entries");
                });

            modelBuilder.Entity("Library.Model.Worker", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}