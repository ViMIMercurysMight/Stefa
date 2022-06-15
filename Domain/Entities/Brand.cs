using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        public Brand()
        {
            Products = new List<Product>();
        }

        public Address? Address     { set; get; }
        public string?  Name        { set; get; }
        public string? Description  { set; get; }
        public ManufacturerType ManufacturerType { set; get; }
        public double Rate                       { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
