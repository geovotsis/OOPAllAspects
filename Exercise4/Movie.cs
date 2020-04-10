using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        public string title;
        public DateTime release;
        public string director;
        public List<string> cast = new List<string>();

        public bool SearchCast(string name)
        {
            for (int i = 0; i < cast.Count; i++)
            {
                if (cast[i] == name)
                    return true;
            }
            return false;
        }
    }


}

    

