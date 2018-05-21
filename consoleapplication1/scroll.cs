using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class scroll
    {
        public int scrollID { get; set; }
        public string scrollName { get; set; }
        public double scrollStrength { get; set; }

        public scroll (int scrollID, string scrollName, double scrollStrength)
        {
            this.scrollID = scrollID;
            this.scrollName = scrollName;
            this.scrollStrength = scrollStrength;
        }

        public override string ToString()
        {
            return scrollID.ToString() + ": " + scrollName;
        }
    }
}
