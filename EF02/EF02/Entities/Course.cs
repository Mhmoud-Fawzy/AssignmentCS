using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Course
    {
        #region By Convension
        //public int Id { get; set; }
        //public string Name { get; set; } = null!;
        //public string? Description { get; set; }
        //public int? Duration { get; set; }
        //public int  Top_id { get; set; }



        ////public int TopicId { get; set; } 
        #endregion

        #region Fluent APIs
        public int Id { get; set; }

        public string Name { get; set; }

        public DateOnly Duration { get; set; }

        public string Description { get; set; }

        public int TopicId { get; set; }

        public int Top_id { get; set; }

        #endregion
    }
}
