using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopIdentity.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DefaultValue(0)]
        public int Price { get; set; }

        [DefaultValue(0)]
        public int Stock { get; set; }

        public int ProductTypeId { get; set; }

        // Reference navigation property cho khóa ngoại đến ProductType
        public ProductType ProductType { get; set; }

        public string Image { get; set; }

        [DefaultValue(true)]
        public bool Status { get; set; }

        public Product()
        {
            Status = true;
        }
    }
}
