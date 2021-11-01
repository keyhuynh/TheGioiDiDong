using AppModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> products { set; get; }
        public DbSet<Category> categories { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Categorys Table
            modelBuilder.Entity<Category>().HasData(
                new Category {Id=1, Name = "Điện thoại" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 2, Name = "Laptop" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 3, Name = "Tablet" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 4, Name = "Phụ kiện" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 5, Name = "Đồng hồ thông minh" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 6, Name = "Đồng hồ thời trang" });
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 7, Name = "PC, Máy in" });

            // Seed Products Table
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name= "Điện thoại Samsung Galaxy Z Fold3 5G 512GB ",
                CategoryId =  1,
                DateCreated = DateTime.Now,
                Id = 1,
                Price=43990000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/42/248284/Slider/samsung-galaxy-z-fold-3-slider-tong-quan-1020x570.jpg",
             });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Laptop Apple MacBook Air M1 2020 16GB/512GB/7-core GPU",
                CategoryId = 2,
                DateCreated = DateTime.Now,
                Id = 2,
                Price = 37490000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/44/243952/apple-macbook-air-m1-2020-z12a00050-1-org.jpg",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Máy tính bảng Huawei MatePad 11",
                CategoryId = 3,
                DateCreated = DateTime.Now,
                Id = 3,
                Price = 13490000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/522/241299/huawei-matepad-11-xam-1.jpg",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Tai nghe Bluetooth AirPods 2 Apple MV7N2 ",
                CategoryId = 4,
                DateCreated = DateTime.Now,
                Id = 4,
                Price = 2990000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/54/236016/bluetooth-airpods-2-apple-mv7n2-imei-1-org.jpg",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Apple Watch S6 40mm viền nhôm dây cao su",
                CategoryId = 5,
                DateCreated = DateTime.Now,
                Id = 5,
                Price = 9592000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/7077/229044/apple-watch-s6-40mm-vien-nhom-day-cao-su-hong-cont-1-org.jpg",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Đồng hồ Nữ Esprit ES1L286P0025",
                CategoryId = 6,
                DateCreated = DateTime.Now,
                Id = 6,
                Price = 4200000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/7264/250504/esprit-es1l286p0025-nu-1-org.jpg",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Name = "Máy In laser Trắng Đen Brother HL L2321D",
                CategoryId = 7,
                DateCreated = DateTime.Now,
                Id = 7,
                Price = 3490000,
                ThumbnailImage = "https://cdn.tgdd.vn/Products/Images/5693/115902/may-in-laser-brother-hl-l2321d-23-600x600.jpg",
            });
        }
    }
}
