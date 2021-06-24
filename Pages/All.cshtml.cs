using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Wardrobe.Data;
using Wardrobe.Models;

namespace Wardrobe.Pages
{
    public class ItemsModel : PageModel
    {
        private readonly Wardrobe.Data.WardrobeContext _context;

        public ItemsModel(Wardrobe.Data.WardrobeContext context)
        {
            _context = context;
        }

        public IList<ItemProp> ItemProp { get; set; }
        public IList<ItemCategory> ItemCategory { get; set; }

        //filters
        public string CategoryFilter { get; set; }
        public string SubcategoryFilter { get; set; }
        public string Counter { get; set; }

        //parameters
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public string SortOrderValue { get; set; }
        public string CategoryValue { get; set; }
        public string SubcategoryValue { get; set; }
        public List<int> SizesValues { get; set; }


        //query
        public class ItemAll
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public decimal Price { get; set; }
            public string Photo { get; set; }
            public string Category { get; set; }
            public string Subcategory { get; set; }
        }
        public IList<ItemAll> ItemAllElements { get; set; }

        

#nullable enable
        public async Task OnGetAsync(string sortOrder, string? category, string? subcategory, decimal? min, decimal? max, params int[] sizes)
        {
            
            var idList = from d in _context.Photos group d by d.ItemPropID into gr select gr.Max(x => x.ID);    //distinct photos
            IQueryable<ItemAll> itemPropsIQ = from i in _context.ItemProps
                                              join j in _context.Items on i.ItemID equals j.ItemID
                                              join c in _context.ItemCategories on j.ItemCategoryID equals c.ItemCategoryID
                                              join p in _context.Photos on i.ItemPropID equals p.ItemPropID
                                              where idList.Contains(p.ID)
                                              select new ItemAll
                                              {
                                                  ID = i.ItemPropID,
                                                  Name = j.Name,
                                                  Date = j.Date,
                                                  Price = i.Price,
                                                  Photo = p.Source,
                                                  Category = c.Category,
                                                  Subcategory = c.Subcategory
                                              };
            //sizes
            SizesValues = sizes.ToList();
            if (sizes.Count() != 0)
            {
                var sizesList = (from s in _context.ItemSizes where sizes.Contains(s.Size) select s.ItemPropID).Distinct();
                itemPropsIQ = itemPropsIQ.Where(x => sizesList.Contains(x.ID));

            }

            //catgory & subcategory filter
            if (subcategory != null)
            {
                CategoryValue = category;
                SubcategoryValue = subcategory;
                itemPropsIQ = itemPropsIQ.Where(x => x.Subcategory == subcategory);
                CategoryFilter = category;
                SubcategoryFilter = subcategory;
            }
            else if (category != null)
            {
                CategoryValue = category;
                itemPropsIQ = itemPropsIQ.Where(x => x.Category == category);
                CategoryFilter = category;
                SubcategoryFilter = "All";
            }
            else
            {
                CategoryFilter = "Discover more";
                SubcategoryFilter = "All items";
            }


            

            //filtering by price
            if (min != null && max != null)
            {
                MinValue = (decimal)min;
                MaxValue = (decimal)max;
                itemPropsIQ = itemPropsIQ.Where(x => min <= x.Price && x.Price < max);
            }
            else if (max != null)
            {
                MaxValue = (decimal)max;
                itemPropsIQ = itemPropsIQ.Where(x => x.Price < max);
            }
            else if (min != null)
            {
                MinValue = (decimal)min;

                itemPropsIQ = itemPropsIQ.Where(x => min <= x.Price);
            }

            //sorting
            SortOrderValue = sortOrder;
            switch (sortOrder)
            {
                case "newest":
                    itemPropsIQ = itemPropsIQ.OrderBy(s => s.Date);
                    break;
                case "price":
                    itemPropsIQ = itemPropsIQ.OrderBy(s => s.Price);
                    break;
                case "price_desc":
                    itemPropsIQ = itemPropsIQ.OrderByDescending(s => s.Price);
                    break;
                case "default":
                    itemPropsIQ = itemPropsIQ.OrderBy(s => s.Name).OrderBy(s => s.Date);
                    break;
            }

            ItemAllElements = await itemPropsIQ.AsNoTracking().ToListAsync();
            ItemCategory = await _context.ItemCategories.ToListAsync();

            //counter
            Counter = ItemAllElements.Count.ToString() + (ItemAllElements.Count != 1 ? " Products" : " Product");
        }
    }
}
