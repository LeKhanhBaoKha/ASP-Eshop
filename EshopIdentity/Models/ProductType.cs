using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopIdentity.Models
{
    public class ProductType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DefaultValue(true)]
        public bool Status { get; set; }

        public ProductType()
        {
            Status = true;
        }
    }
}
