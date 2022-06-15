using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum OrderStatus
    {
        AtDestinationPlace,
        Opened            ,
        Bokked            ,
        AtWork            ,
        Packing           ,
        Sending           ,
        Payed             ,
        Closed
    }
}
