﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ServiceCore.Model;
using System;

namespace ServiceCore.Migrations
{
    [DbContext(typeof(DB))]
    [Migration("20171028164919_stuDB")]
    partial class stuDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceCore.Base.DATA_Class", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassInfo");

                    b.Property<string>("ClassName");

                    b.Property<string>("DATA_StudentId");

                    b.Property<string>("Teacher");

                    b.Property<int>("section");

                    b.HasKey("id");

                    b.HasIndex("DATA_StudentId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("ServiceCore.Base.DATA_Student", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ServiceCore.Base.DATA_Class", b =>
                {
                    b.HasOne("ServiceCore.Base.DATA_Student")
                        .WithMany("Classes")
                        .HasForeignKey("DATA_StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
