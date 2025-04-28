using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV04
{
    public class Movie : IEquatable<Movie>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Movie other = (Movie)obj;
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Movie other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }

}
