using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public Category   Category   { get; set; }
        public PriceGroup PriceGroup { get; set; }
        
        public decimal Price     { get; set; }
        public string?  Name      { get; set; }
        public int Qty           { get; set; }
        public virtual Brand? Manufacturer { get; set; }
    }
}
