using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class MilkshakeOrderModel
    {
        [Required]
        [MinLength(1,ErrorMessage = "You need to select a type of milkshake.")]
        public string TypeOfMilkshake { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "You need to select a milkshake size.")]
        public string SizeOfMilkshake { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "You need to give us a name for your order.")]
        public string OrderName { get; set; }
        [Range(1,10, ErrorMessage = "Please give us a number between 1 and 10." )]
        public int Quantity { get; set; }
        public bool AddWhippedCream { get; set; }
    }
}
