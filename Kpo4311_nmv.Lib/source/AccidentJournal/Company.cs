using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4311.nmv.Lib
{ 
   public class Company
    {
        public Company()
        {
            category = 0;
            loss = 0;
            downtime = 0;
        }

        public int category { get; set; }
        public double loss { get; set; }
        public int downtime { get; set; }
    }

}
