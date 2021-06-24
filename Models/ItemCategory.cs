using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class ItemCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemCategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(255)]
        public string Subcategory { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
