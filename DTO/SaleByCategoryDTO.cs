using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class SaleByCategoryDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }

}
