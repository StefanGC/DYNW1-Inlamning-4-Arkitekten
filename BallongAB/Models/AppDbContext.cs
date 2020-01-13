using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BallongAB.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Golv" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Marmor" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Färger" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Missoni Home Fireworks Black",
                Price = 12.95M,
                ShortDescription = "Fireworks Black är inspirerat av ett tyg från Missoni.",
                LongDescription = "Fireworks Black är inspirerat av ett tyg från Missoni och har ett distinkt grafiskt mönster med en flödande gradient, presenterad i tidlöst svart.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Missoni Home Fireworks White",
                Price = 18.95M,
                ShortDescription = "Fireworks White är inspirerat av ett tyg från Misson.",
                LongDescription = "Fireworks White är inspirerat av ett tyg från Missoni och har ett distinkt grafiskt mönster med en flödande gradient och beigefärgad varp.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Missoni Home Flame Patch Blanck",
                Price = 18.95M,
                ShortDescription = "Tidlöst och elegant",
                LongDescription = "Tidlöst och elegant – Flame Patch Black är ett mörkt, skuggat mönster som visar upp det bästa av vårt samarbete med Missoni. Det här golvet skapar en klassiskt nedtonad och samtidigt visuell bakgrund i varje rum.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Grön Marmor Slipad",
                Price = 15.95M,
                ShortDescription = "Fantastisk grön marmor med slipad yta.",
                LongDescription = "Denna gröna marmor passar på både golv och vägg. Lämpar sig även för hallar och entrér. Ytan är behagligt slipad.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Svart Marmor",
                Price = 13.95M,
                ShortDescription = "Nero Marquina!",
                LongDescription = "Nero Marquina är en klassik och elegant marmor med svart botten och vita vener. Marmorn kännetecknas av sin svärta och den varierande marmoreringen i vitt. Nero Marquina finns i flera utföranden och användningsområdena är stora, så låt kreativiteten flöda. Marmor kan sättas på både golv och vägg.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Beige Marmor",
                Price = 17.95M,
                ShortDescription = "Woodlight Gravin marmor i ljusa/beiga toner.",
                LongDescription = "Woodlight Gravin är en vacker marmor som med sina varma, beiga färgskiftningar skapar en harmoni i alla typer av rum. Woodlight Gravin finns i olika utföranden och användningsområdena är stora, så låt kreativiteten flöda. Marmorn kan sättas på både golv och vägg.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Ren Vit",
                Price = 15.95M,
                ShortDescription = "Ger en hård och slitstark yta - lätt att göra ren.",
                LongDescription = "Matt, vattenbaserad väggfärg med glans 7. En lättarbetad färg som passar utmärkt när du snabbt och enkelt vill fräscha upp t.ex. tonårslyan, sovrummet och vardagsrummet med ny färg.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Midsommar",
                Price = 15.95M,
                ShortDescription = "Ger en hård och slitstark yta - lätt att göra ren.",
                LongDescription = "Matt, vattenbaserad väggfärg med glans 7. En lättarbetad färg som passar utmärkt när du snabbt och enkelt vill fräscha upp t.ex. tonårslyan, sovrummet och vardagsrummet med ny färg.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Mjuka Moln",
                Price = 15.95M,
                ShortDescription = "Ger en hård och slitstark yta - lätt att göra ren.",
                LongDescription = "Matt, vattenbaserad väggfärg med glans 7. En lättarbetad färg som passar utmärkt när du snabbt och enkelt vill fräscha upp t.ex. tonårslyan, sovrummet och vardagsrummet med ny färg.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg"
            });


            //seed project
            /*
            modelBuilder.Entity<Project>().HasData(new Project
            {
                ProjectId = 1,
                Name = "Stefan",
                Orders = new List<Order>()
            });
            */
        }
    }
}