using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class PosDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }
        public string CategoryName { get; set; }
        public byte[] ProductImage { get; set; }

        public PosDTO()
        {
        }

        public PosDTO(int productID, string productName, float price, string categoryName, byte[] productImage)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            CategoryName = categoryName;
            ProductImage = productImage;
            Quantity = 0;
            Total = 0;
        }
    }
}
