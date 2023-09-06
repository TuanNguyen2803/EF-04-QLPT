﻿// <auto-generated />
using System;
using EF_04_QLPT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_04_QLPT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_04_QLPT.Model.ChiTietPhieuThu", b =>
                {
                    b.Property<int>("ChitietphieuthuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChitietphieuthuID"));

                    b.Property<int>("NguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("PhieuthuID")
                        .HasColumnType("int");

                    b.Property<int>("Soluongban")
                        .HasColumnType("int");

                    b.HasKey("ChitietphieuthuID");

                    b.HasIndex("NguyenlieuID");

                    b.HasIndex("PhieuthuID");

                    b.ToTable("ChiTietPhieuThus");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.LoaiNguyenLieu", b =>
                {
                    b.Property<int>("LoainguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoainguyenlieuID"));

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tenloai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoainguyenlieuID");

                    b.ToTable("LoaiNguyenLieus");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.NguyenLieu", b =>
                {
                    b.Property<int>("NguyenlieuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NguyenlieuID"));

                    b.Property<string>("Donvitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Giaban")
                        .HasColumnType("float");

                    b.Property<int>("LoainguyenlieuID")
                        .HasColumnType("int");

                    b.Property<int>("Soluongkho")
                        .HasColumnType("int");

                    b.Property<string>("Tennguyenlieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NguyenlieuID");

                    b.HasIndex("LoainguyenlieuID");

                    b.ToTable("NguyenLieus");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.PhieuThu", b =>
                {
                    b.Property<int>("PhieuthuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhieuthuID"));

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaylap")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nhanvienlap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Thanhtien")
                        .HasColumnType("float");

                    b.HasKey("PhieuthuID");

                    b.ToTable("PhieuThus");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.ChiTietPhieuThu", b =>
                {
                    b.HasOne("EF_04_QLPT.Model.NguyenLieu", "NguyenLieu")
                        .WithMany("ChiTietPhieuThus")
                        .HasForeignKey("NguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_04_QLPT.Model.PhieuThu", "PhieuThu")
                        .WithMany("ChiTietPhieuThus")
                        .HasForeignKey("PhieuthuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguyenLieu");

                    b.Navigation("PhieuThu");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.NguyenLieu", b =>
                {
                    b.HasOne("EF_04_QLPT.Model.LoaiNguyenLieu", "LoaiNguyenLieu")
                        .WithMany("NguyenLieus")
                        .HasForeignKey("LoainguyenlieuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiNguyenLieu");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.LoaiNguyenLieu", b =>
                {
                    b.Navigation("NguyenLieus");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.NguyenLieu", b =>
                {
                    b.Navigation("ChiTietPhieuThus");
                });

            modelBuilder.Entity("EF_04_QLPT.Model.PhieuThu", b =>
                {
                    b.Navigation("ChiTietPhieuThus");
                });
#pragma warning restore 612, 618
        }
    }
}
