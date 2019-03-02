using System.Collections.Generic;
using System.Data.Entity;

namespace WondoorfulDesignsStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
            protected override void Seed(ProductContext context)
            {
                GetCategories().ForEach(c => context.Categories.Add(c));
                GetProducts().ForEach(p => context.Products.Add(p));
            }

            private static List<Category> GetCategories()
            {
                var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Summer"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Autumn"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Winter"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Spring"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Assorted"
                },
            };

                return categories;
            }

            private static List<Product> GetProducts()
            {
                var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Daisy",
                    Description = "Colorful and cheerful. This summer daisy is just delightful!.",
                    ImagePath="flower.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Summer Jar",
                    Description = "Nothing says sweet summertime than this delectable jar.",
                    ImagePath="jar-summer.jpg",
                    UnitPrice = 25.00,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Pineapple",
                    Description = "Delicious pinapple that's technically a berry!.",
                    ImagePath="pinapple.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Sun",
                    Description = "This sun is welcoming and bright!",
                    ImagePath="sun.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Flip Flops",
                    Description = "The perfect summer footwear. For your door!",
                    ImagePath="flops.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Acorn",
                    Description = "Squirrels will be jealous of this acorn.",
                    ImagePath="acorn.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Candy Corn",
                    Description = "Got candy? This candy corn says it all.",
                    ImagePath="candy_corn.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Pumpkin",
                    Description = "This pumpkin is sure to be a hit in the Fall.",
                    ImagePath="pumpkin.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Scarecrow",
                    Description = "Smiley and not too scary scarecrow.",
                    ImagePath="scarecrow.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Elf Feet",
                    Description = "Just in time for the Holidays.",
                    ImagePath="elf.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Raindeer",
                    Description = "Rudolph to guide Santa to your door.",
                    ImagePath="moose.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "The Grinch",
                    Description = "The Grinch that stole an ornament.",
                    ImagePath="ornament_hand.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Bunny",
                    Description = "The Spring has sprung!",
                    ImagePath="bunny.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Egg",
                    Description = "This pastel egg is not only for Easter.",
                    ImagePath="easter.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Shamrock",
                    Description = "May the luck of the Irish be with you!",
                    ImagePath="shemrock.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "UofL",
                    Description = "Display your team with pride.",
                    ImagePath="uofl.jpg",
                    UnitPrice = 35.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Fleur-de-lis",
                    Description = "Flower of the lily.",
                    ImagePath="fleur.jpg",
                    UnitPrice = 25.00,
                    CategoryID = 5
                }
            };

                return products;
            }
        }
}
