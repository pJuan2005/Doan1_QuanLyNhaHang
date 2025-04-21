using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class CustomerDTO
    {
        public int CustomerID { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }

        public CustomerDTO(int customerID, string custName, string custPhone)
        {
            this.CustomerID = customerID;
            this.CustName = custName;
            this.CustPhone = custPhone;
        }

        public CustomerDTO() { }
    }
}
