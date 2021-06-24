using Wardrobe.Models;
using System;
using System.Linq;

namespace Wardrobe.Data
{
    public class DbInitializer
    {
        public static void Initialize(WardrobeContext context)
        {
            if (context.Photos.Any())
            {
                return;   // DB has been seeded
            }

            var itemCategories = new ItemCategory[]
            {
                new ItemCategory{ItemCategoryID=1, Category="Clothes", Subcategory="Coats, jackets"},
                new ItemCategory{ItemCategoryID=2, Category="Clothes", Subcategory="Dresses, jumpsuits"},
                new ItemCategory{ItemCategoryID=3, Category="Clothes", Subcategory="Jumpers, cardigans"},
                new ItemCategory{ItemCategoryID=4, Category="Clothes", Subcategory="Shirts"},
                new ItemCategory{ItemCategoryID=5, Category="Clothes", Subcategory="Blouses"},
                new ItemCategory{ItemCategoryID=6, Category="Clothes", Subcategory="T-shirts, tops"},
                new ItemCategory{ItemCategoryID=7, Category="Clothes", Subcategory="Hoodies, sweatshirts"},
                new ItemCategory{ItemCategoryID=8, Category="Clothes", Subcategory="Trousers"},
                new ItemCategory{ItemCategoryID=9, Category="Clothes", Subcategory="Jeans"},
                new ItemCategory{ItemCategoryID=10, Category="Clothes", Subcategory="Shorts"},
                new ItemCategory{ItemCategoryID=11, Category="Clothes", Subcategory="Skirts"},
                new ItemCategory{ItemCategoryID=12, Category="Clothes", Subcategory="Blazers"},
                new ItemCategory{ItemCategoryID=13, Category="Shoes", Subcategory="Heels"},
                new ItemCategory{ItemCategoryID=14, Category="Shoes", Subcategory="Flats"},
                new ItemCategory{ItemCategoryID=15, Category="Accessories", Subcategory="Bags"},
                new ItemCategory{ItemCategoryID=16, Category="Accessories", Subcategory="Belts"},
                new ItemCategory{ItemCategoryID=17, Category="Accessories", Subcategory="Sockets, tights"}
            };
            context.ItemCategories.AddRange(itemCategories);
            context.SaveChanges();


            var items = new Item[]
            {
                new Item{ItemID=1, Name="Pumps with open heel", Date=DateTime.Parse("2021-05-04"), Description="Pointed toe. Block heels. Heel height: 6 cm", ItemCategoryID=13},
                new Item{ItemID=2, Name="High-heeled boots", Date=DateTime.Parse("2021-04-03"), Description="Heel height: 7 cm", ItemCategoryID=13},
                new Item{ItemID=3, Name="Leather mule sandals", Date=DateTime.Parse("2021-05-03"), Description="Round toes. Heel height: 1,5 cm", ItemCategoryID=14}
            };
            context.Items.AddRange(items);
            context.SaveChanges();

            var itemProps = new ItemProp[]
            {
                new ItemProp{ItemPropID=1, Price=new Decimal(19.99), Color="#FFC0CB", ItemID=1 },
                new ItemProp{ItemPropID=2, Price=new Decimal(19.99), Color="#000", ItemID=1 },
                new ItemProp{ItemPropID=3, Price=new Decimal(39.99), Color="#000", ItemID=2 },
                new ItemProp{ItemPropID=4, Price=new Decimal(39.99), Color="#BC8F8F", ItemID=3 }
            };
            context.ItemProps.AddRange(itemProps);
            context.SaveChanges();

            var photos = new Photo[]
            {
                new Photo{Source="https://www.reserved.com/media/catalog/product/5/3/5351E-40X-001_6.jpg", ItemPropID=1},
                new Photo{Source="https://www.reserved.com/media/catalog/product/5/3/5351E-40X-003_6.jpg", ItemPropID=1},
                new Photo{Source="https://www.reserved.com/media/catalog/product/5/3/5351E-99X-001_8.jpg", ItemPropID=2},
                new Photo{Source="https://www.reserved.com/media/catalog/product/5/3/5351E-99X-002_8.jpg", ItemPropID=2},
                new Photo{Source="https://www.reserved.com/media/catalog/product/1/5/1594E-99X-001_2.jpg", ItemPropID=3},
                new Photo{Source="https://www.reserved.com/media/catalog/product/1/5/1594E-99X-003_2.jpg", ItemPropID=3},
                new Photo{Source="https://www.reserved.com/media/catalog/product/8/9/8995D-39X-001_5.jpg", ItemPropID=4},
                new Photo{Source="https://www.reserved.com/media/catalog/product/8/9/8995D-39X-002_5.jpg", ItemPropID=4}
            };
            context.Photos.AddRange(photos);
            context.SaveChanges();

            var itemSizes = new ItemSize[]
            {
                new ItemSize{Size=37, Number=5, ItemPropID = 1},
                new ItemSize{Size=38, Number=2, ItemPropID = 1},
                new ItemSize{Size=39, Number=1, ItemPropID = 1},
                new ItemSize{Size=40, Number=3, ItemPropID = 1},
                new ItemSize{Size=41, Number=2, ItemPropID = 1},
                new ItemSize{Size=37, Number=2, ItemPropID = 2},
                new ItemSize{Size=38, Number=3, ItemPropID = 2},
                new ItemSize{Size=39, Number=1, ItemPropID = 2},
                new ItemSize{Size=41, Number=2, ItemPropID = 2},
                new ItemSize{Size=37, Number=5, ItemPropID = 3},
                new ItemSize{Size=38, Number=2, ItemPropID = 3},
                new ItemSize{Size=39, Number=1, ItemPropID = 3},
                new ItemSize{Size=40, Number=3, ItemPropID = 3},
                new ItemSize{Size=41, Number=2, ItemPropID = 3},
                new ItemSize{Size=37, Number=8, ItemPropID = 4},
                new ItemSize{Size=38, Number=3, ItemPropID = 4},
                new ItemSize{Size=39, Number=5, ItemPropID = 4},
                new ItemSize{Size=41, Number=2, ItemPropID = 4}
            };
            context.ItemSizes.AddRange(itemSizes);
            context.SaveChanges();
        }
    }
}
