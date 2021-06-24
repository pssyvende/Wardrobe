using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class ItemSize
    {
        public int ID { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int ItemPropID { get; set; }
    }
}
