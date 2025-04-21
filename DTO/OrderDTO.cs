using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class OrderDTO
    {
        public int MainID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Time { get; set; }
        public string TableName { get; set; }
        public string WaiterName { get; set; }
        public string Status { get; set; }
        public string OrderType { get; set; }
        public float Total { get; set; }
        public float TotalAmount { get; set; }
        public float Received { get; set; }
        public float Change { get; set; }
        public int? CustomerID { get; set; }
        public int? DriverID { get; set; }
        public List<OrderDetailDTO> OrderDetails { get; set; }

        public OrderDTO()
        {
            OrderDetails = new List<OrderDetailDTO>();
        }

        public void CompleteOrder()
        {
            this.Status = "Complete";
        }
    }
}
