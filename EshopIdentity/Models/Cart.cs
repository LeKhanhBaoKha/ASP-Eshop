using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EshopIdentity.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        // Reference navigation property cho khóa ngoại đến User
        [ForeignKey("UserId")]
        public User User { get; set; }

        public int ProductId { get; set; }

        // Reference navigation property cho khóa ngoại đến Product
        public Product Product { get; set; }

        [DefaultValue(1)]
        public int Quantity { get; set; }

        public Cart()
        {
            Quantity = 1;
        }
    }
}
