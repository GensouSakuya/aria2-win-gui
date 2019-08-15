﻿// <auto-generated />
using GensouSakuya.Aria2.Desktop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GensouSakuya.Aria2.Desktop.Model.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20190815031848_Add_TaskType")]
    partial class Add_TaskType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("GensouSakuya.Aria2.Desktop.Model.DownloadTask", b =>
                {
                    b.Property<string>("GID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CompletedLength");

                    b.Property<string>("Link");

                    b.Property<int>("Status");

                    b.Property<string>("TaskName");

                    b.Property<int>("TaskType");

                    b.Property<long>("TotalLength");

                    b.HasKey("GID");

                    b.ToTable("DownloadTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
