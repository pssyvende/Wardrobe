using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class ItemProp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemPropID { get; set; }

        [Required]
        [StringLength(7, MinimumLength = 4)]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int ItemID { get; set; }

        public Item Item { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<ItemSize> ItemSizes { get; set; }
    }
}
