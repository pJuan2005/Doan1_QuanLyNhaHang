using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class OrderDetailDTO
    {
        public int DetailID { get; set; }
        public int MainID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public float Total { get; set; }
        public string ProductName { get; set; }
    }
}
