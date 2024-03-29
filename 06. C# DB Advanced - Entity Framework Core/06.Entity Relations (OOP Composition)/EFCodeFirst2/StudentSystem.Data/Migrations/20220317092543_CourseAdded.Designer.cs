﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

namespace StudentSystem.Data.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20220317092543_CourseAdded")]
    partial class CourseAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentSystem.Data.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(80)");

                    b.Property<decimal>("Price")
                        .HasColumnType("MONEY");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentSystem.Data.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("ResourceType");

                    b.Property<string>("Url")
                        .HasColumnType("VARCHAR(MAX)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("StudentSystem.Data.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday");

                    b.Property<string>("PhoneNumber");

                    b.Property<DateTime>("RegisteredOn");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentSystem.Data.Resource", b =>
                {
                    b.HasOne("StudentSystem.Data.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StudentSystem.Data.Student", b =>
                {
                    b.OwnsOne("StudentSystem.Data.PersonName", "Name", b1 =>
                        {
                            b1.Property<int>("StudentId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnName("LastName");

                            b1.HasKey("StudentId");

                            b1.ToTable("Students");

                            b1.HasOne("StudentSystem.Data.Student")
                                .WithOne("Name")
                                .HasForeignKey("StudentSystem.Data.PersonName", "StudentId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
