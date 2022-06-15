using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public Order()
        {
            this.Products = new List<Product>();
        }

        public Address? From       { set; get; }
        public Address? To         { set; get; }
        public OrderStatus Status { set; get; }

        public double Rate        { set; get; }
        public virtual List<Product> Products { set; get; }

    }
}
