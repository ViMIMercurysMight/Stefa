using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Client
    {
        public int Id { set; get; }

        public Client()
        {
            this.Orders = new List<Order>();
            this.Brands = new List<Brand>();
        }


        public UserType UserType          { set; get; }
        

        public string? FirstName           { get; set; }
        public string? SecondsName         { get; set; }

        public string? PhoneNumber         { set; get; }
        public string? Email               { set; get; }
        public Address? Address            { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<Brand> Brands { get; set; }

    }
}
