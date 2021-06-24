using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class OrderTable
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string OrderTableID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string House { get; set; }

        public string Apartment { get; set; }

        [Required]
        public string Postal { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string CustomerID { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderDetails> orderDetails { get; set; }
    }
}
