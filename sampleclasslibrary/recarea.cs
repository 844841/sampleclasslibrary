using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleclasslibrary
{
    public class recarea
    {
        public int length { get; set; }

        public int breadth { get; set; }

        public string Area()
        {
            return string.Format("area={0}", length * breadth);

        }
    }
}
