using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderServices
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProdID { get; set; }
        public int Qty { get; set; }
        public int Amount { get; set; }

    }
}
