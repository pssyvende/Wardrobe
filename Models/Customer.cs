using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wardrobe.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(320)]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string Telephone { get; set; }

        public ICollection<OrderTable> Orders { get; set; }
    }
}