using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF04.Data.Models
{
    //[Owned]
    public class Address
    {
        public int? Block_Number { get; set; }
        public string? Street { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
    }
}
