using System.Collections.Generic;
using Wardrobe.Helpers;
using Wardrobe.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wardrobe.Data;


namespace Wardrobe.Pages
{
    public class BagModel : PageModel
    {
        private readonly Wardrobe.Data.WardrobeContext _context;

        public BagModel(Wardrobe.Data.WardrobeContext context)
        {
            _context = context;
        }

        public int OrderLevel { get; set; }
        public List<ProductList> bag { get; set; }
        public double Total { get; set; }
        public static bool IsEmpty { get; set; }

        public void OnGet(int orderLevel)
        {
            if (orderLevel == 2)
                OrderLevel = 2;
            else
                OrderLevel = 1;
            bag = SessionHelper.GetObjectFromJson<List<ProductList>>(HttpContext.Session, "bag");
            if(IsEmpty == true)
            Total = Math.Round(bag.Sum(i => i.Product.Price * i.Quantity), 2);
        }

        public IActionResult OnGetBuyNow(int id, string name, double price, int size, string photo)
        {
            IsEmpty = true;
            bag = SessionHelper.GetObjectFromJson<List<ProductList>>(HttpContext.Session, "bag");
            Product product = new Product()
            {
                Id = id,
                Name = name,
                Price = price/100,  //decimal - sorting & session parameters
                Size = size,
                Photo = photo
            };
            if (bag == null)
            {
                bag = new List<ProductList>();
                bag.Add(new ProductList
                {
                    Product = product,
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "bag", bag);
            }
            else
            {
                int index = Exists(bag, id);
                if (index == -1)
                {
                    bag.Add(new ProductList
                    {
                        Product = product,
                        Quantity = 1
                    });
                }
                else
                {
                    bag[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "bag", bag);
            }
            return RedirectToPage("Bag");
        }

        public IActionResult OnGetDelete(int id)
        {
            bag = SessionHelper.GetObjectFromJson<List<ProductList>>(HttpContext.Session, "bag");
            int index = Exists(bag, id);
            bag.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "bag", bag);
            if (bag.Count() == 0)
                IsEmpty = false;
            return RedirectToPage("Bag");
        }

        public IActionResult OnPostUpdate(int[] quantities)
        {
            bag = SessionHelper.GetObjectFromJson<List<ProductList>>(HttpContext.Session, "bag");
            for (var i = 0; i < bag.Count; i++)
            {
                bag[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "bag", bag);
            return RedirectToPage("Bag");
        }

        private int Exists(List<ProductList> bag, int id)
        {
            for (var i = 0; i < bag.Count; i++)
            {
                if (bag[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        #nullable enable
        public IActionResult OnPostOrder(string email, string firstName, string lastName, 
            string telephoneNumber, string streetName, string houseNumber, string apartmentNumber, string postal, string city, string details)
        {
            bag = SessionHelper.GetObjectFromJson<List<ProductList>>(HttpContext.Session, "bag");

            Random r = new Random();
            string numID = "";
            string num2ID = "";
            for (int i = 0; i<10; i++)
            {
                numID += r.Next(0, 10).ToString();
                num2ID += r.Next(0, 10).ToString();
            }
            string customerID = firstName.ToLower().Substring(0, 1) + lastName.ToLower().Substring(0, 3) + numID;
            
            _context.Database.ExecuteSqlRaw("INSERT INTO CUSTOMER VALUES({0},{1},{2},{3},{4})", 
                new object[] {customerID, firstName, lastName, email, telephoneNumber });
            DateTime thisDay = DateTime.Today;
            string orderID = num2ID + customerID;
            _context.Database.ExecuteSqlRaw("INSERT INTO ORDERTABLE VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8})", 
                new object[] { orderID, thisDay, details != null ? details : "-", streetName, houseNumber, 
                    apartmentNumber != null ? apartmentNumber : "-", postal, city, customerID   });
            for (var i = 0; i < bag.Count; i++)
            {
                _context.Database.ExecuteSqlRaw("INSERT INTO ORDERDETAILS VALUES({0},{1},{2},{3})", 
                    new object[] { bag[i].Product.Id, bag[i].Quantity, bag[i].Product.Price, orderID });
            }
            
            bag.Clear();
            IsEmpty = false;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "bag", bag);
            return RedirectToPage("/All");
        }
    }
}
