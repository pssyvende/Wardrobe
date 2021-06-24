using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class Photo
    {
        public int ID { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public int ItemPropID { get; set; }
    }
}
