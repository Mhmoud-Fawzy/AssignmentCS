using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    // Association [Composition]
namespace OOP04.Inherintace.Association.Composition
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public required Product Product { get; set; }
        //public OrderItem(Product product)
        //{
        //    Product=product;
        //}
    }
}
