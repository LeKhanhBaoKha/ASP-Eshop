using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EshopIdentity.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string UserId { get; set; }

        // Reference navigation property cho khóa ngoại đến User
        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime IssuedDate { get; set; }

        public string ShippingAddress { get; set; }

        public string ShippingPhone { get; set; }

        [DefaultValue(0)]
        public int Total { get; set; }

        [DefaultValue(true)]
        public bool Status { get; set; }

        public Invoice()
        {
            Total = 0;
            Status = true;
        }
    }
}
