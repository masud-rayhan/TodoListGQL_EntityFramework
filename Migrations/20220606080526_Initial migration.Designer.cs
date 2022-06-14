﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoListQL.Data;

namespace TodoListGQL.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220606080526_Initial migration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("TodoListGQL.Models.ItemData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ListId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("TodoListGQL.Models.ItemList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("TodoListGQL.Models.ItemData", b =>
                {
                    b.HasOne("TodoListGQL.Models.ItemList", "ItemList")
                        .WithMany("ItemDatas")
                        .HasForeignKey("ListId")
                        .HasConstraintName("FK_ItemData_ItemList")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ItemList");
                });

            modelBuilder.Entity("TodoListGQL.Models.ItemList", b =>
                {
                    b.Navigation("ItemDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
