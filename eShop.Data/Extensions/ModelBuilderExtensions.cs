using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage of eShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is homepage of eShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is homepage of eShop" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                    CategoryTranslations = new List<CategoryTranslation>()
                    {
                    }
                },
                   new Category()
                   {
                       id = 2,
                       IsShowOnHome = true,
                       ParentId = null,
                       SortOrder = 2,
                       Status = Status.Active,
                       CategoryTranslations = new List<CategoryTranslation>()
                       {
                       }
                   }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation() { id = 1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                    new CategoryTranslation() { id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                    new CategoryTranslation() { id = 3, CategoryId = 2, Name = "Áo Nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                    new CategoryTranslation() { id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   id = 1,
                   DateCreated = DateTime.Now,
                   OriginalPrice = 100000,
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
               });
            modelBuilder.Entity<ProductTranslation>().HasData(
                  new ProductTranslation() { id = 1, ProductId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam", Details = "Mô tả sản phẩm", Description = "" },
                  new ProductTranslation() { id = 2, ProductId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men", Details = "Description of product", Description = "" }
                   );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nguyenson2303@gmail.com",
                NormalizedEmail = "nguyenson2303@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Son",
                LastName = "Nguyen",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}

