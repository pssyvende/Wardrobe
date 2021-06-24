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
    public class ItemDetailsModel : PageModel
    {
        private readonly Wardrobe.Data.WardrobeContext _context;

        public ItemDetailsModel(Wardrobe.Data.WardrobeContext context)
        {
            _context = context;
        }

        public ItemProp ItemProp { get; set; }
        public IList<ItemProp> ItemProps { get; set; }
        public int SelectedSize { get; set; }

        [BindProperty]
        public int Number { get; set; }


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

            ItemProps = await _context.ItemProps
                .Include(i => i.Item)
                .Where(x => x.Item.Name == ItemProp.Item.Name).AsSingleQuery()
                .ToListAsync();

            if (ItemProp == null)
            {
                return NotFound();
            }


            return Page();
        }

        //delete item
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemProp = await _context.ItemProps.FindAsync(id);

            if (ItemProp != null)
            {
                _context.ItemProps.Remove(ItemProp);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./All");
        }
    }
}