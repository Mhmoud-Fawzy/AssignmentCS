using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Entities
{
    internal class Topic
    {
        #region Convension
        //public int Id { get; set; }
        //public string Name { get; set; }
        #endregion

        #region Data Annontation
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        //[Column(TypeName = "Varchar")]
        //public string Name { get; set; }
        #endregion

        #region Fluent APIs
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
