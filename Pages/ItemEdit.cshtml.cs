using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wardrobe.Data;
using Wardrobe.Models;

namespace Wardrobe.Pages
{
    public class ItemEditModel : PageModel
    {
        private readonly Wardrobe.Data.WardrobeContext _context;

        public ItemEditModel(Wardrobe.Data.WardrobeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemProp ItemProp { get; set; }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemProp = await _context.ItemProps
                .Include(i => i.Item)
                .Include(i => i.Photos).Include(i => i.ItemSizes).AsSingleQuery()
                .FirstOrDefaultAsync(m => m.ItemPropID == id);

            if (ItemProp == null)
            {
                return NotFound();
            }

            Item = await _context.Items.FirstOrDefaultAsync(i => i.ItemID == ItemProp.ItemID);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }

        //edit
        #nullable enable
        public async Task<IActionResult> OnPost(int? itemID, int? itempropID, string? name, decimal? price, string? description)
        {
            await Task.Run(() =>
            {
                if (itemID != null && name != null && description != null)
                    _context.Database.ExecuteSqlRaw("UPDATE ITEM SET NAME = {0}, DESCRIPTION = {1}  WHERE ITEMID = {2}", new object[] { name, description, itemID });

                if (itempropID != null && price != null)
                    _context.Database.ExecuteSqlRaw("UPDATE ITEMPROP SET PRICE = {0} WHERE ITEMPROPID = {1}", new object[] { price, itempropID });
            });

            return RedirectToPage("./All");
        }
    }
}
