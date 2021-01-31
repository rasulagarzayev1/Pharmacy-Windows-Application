using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P208_Pharmacy.Model
{
    public class OrderedMedicine
    {
        public Medicine Medicine { get; set; }
        public int OrderCount { get; set; }
    }
}
