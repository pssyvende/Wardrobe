using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Required]
        public int ItemCategoryID { get; set; }

        public ItemCategory ItemCategory { get; set; }
        public ICollection<ItemProp> ItemProps { get; set; }
    }
}
