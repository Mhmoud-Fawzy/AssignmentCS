using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Inherintace.Association.Composition
{
    internal class Order
    {
        public int Id { get; set; }
        public required string UserEmail { get; set; }
        public decimal OrderTotal { get; set; }
        public required List<OrderItem> OrderItems { get; set; }

    }
}
