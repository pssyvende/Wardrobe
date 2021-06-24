using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }

        [Required]
        public string ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

       
        [Required]
        public string OrderTableID { get; set; }

        public OrderTable OrderTable { get; set; }
    }
}