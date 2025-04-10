using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BL.DTOs
{
    public class CreateDeptDto
    {
        [Required (ErrorMessage= "Name Is Required")]
        public required string Name { get; set; }
        public required string Code { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }


    }
}
