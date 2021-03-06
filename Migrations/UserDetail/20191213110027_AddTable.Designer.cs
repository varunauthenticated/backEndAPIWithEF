﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crudOperation.Models;

namespace crudOperation.Migrations.UserDetail
{
    [DbContext(typeof(UserDetailContext))]
    [Migration("20191213110027_AddTable")]
    partial class AddTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("crudOperation.Models.UserDetail", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("userAddress")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("userMobile")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("userId");

                    b.ToTable("UserDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
