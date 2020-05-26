﻿// <auto-generated />
using System;
using Configuration_train.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Configuration_train.Migrations
{
    [DbContext(typeof(EmployeesDbContext))]
    [Migration("20200526193503_fix_companies_city_rel")]
    partial class fix_companies_city_rel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Configuration_train.Data.ManyToManyEntities.Employees2Companies", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("employees_companies_conn");
                });

            modelBuilder.Entity("Configuration_train.Data.ManyToManyEntities.Employees2Languages", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("LanguageId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("employees_lang_conns");
                });

            modelBuilder.Entity("Configuration_train.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Configuration_train.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("city_id")
                        .HasColumnType("int");

                    b.Property<int?>("county_id")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("comp_id");

                    b.HasIndex("city_id");

                    b.HasIndex("county_id");

                    b.ToTable("company_tbl");
                });

            modelBuilder.Entity("Configuration_train.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlagUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("country_id");

                    b.ToTable("country_tbl");
                });

            modelBuilder.Entity("Configuration_train.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("city_id")
                        .HasColumnType("int");

                    b.Property<int?>("company_id")
                        .HasColumnType("int");

                    b.Property<int?>("country_id")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("employee_id");

                    b.HasIndex("city_id");

                    b.HasIndex("company_id");

                    b.HasIndex("country_id");

                    b.ToTable("employee_tbl");
                });

            modelBuilder.Entity("Configuration_train.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("lang_id");

                    b.ToTable("lang_tbl");
                });

            modelBuilder.Entity("Configuration_train.Data.ManyToManyEntities.Employees2Companies", b =>
                {
                    b.HasOne("Configuration_train.Models.Company", "Company")
                        .WithMany("Employees2Companies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Configuration_train.Models.Employee", "Employee")
                        .WithMany("Employees2Companies")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Configuration_train.Data.ManyToManyEntities.Employees2Languages", b =>
                {
                    b.HasOne("Configuration_train.Models.Employee", "Employee")
                        .WithMany("Employees2Languages")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Configuration_train.Models.Language", "Language")
                        .WithMany("Employees2Languages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Configuration_train.Models.Company", b =>
                {
                    b.HasOne("Configuration_train.Models.City", "City")
                        .WithMany("Companies")
                        .HasForeignKey("city_id");

                    b.HasOne("Configuration_train.Models.Country", "Country")
                        .WithMany("Companies")
                        .HasForeignKey("county_id");
                });

            modelBuilder.Entity("Configuration_train.Models.Employee", b =>
                {
                    b.HasOne("Configuration_train.Models.City", "City")
                        .WithMany("Employees")
                        .HasForeignKey("city_id");

                    b.HasOne("Configuration_train.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("company_id");

                    b.HasOne("Configuration_train.Models.Country", "Country")
                        .WithMany("Employees")
                        .HasForeignKey("country_id");
                });
#pragma warning restore 612, 618
        }
    }
}
