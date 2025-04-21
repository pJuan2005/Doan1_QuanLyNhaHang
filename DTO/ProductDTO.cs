using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class ProductDTO
    {
        public int PID { get; set; }  // Mã sản phẩm
        public string PName { get; set; } // Tên sản phẩm
        public float PPrice { get; set; } // Giá sản phẩm
        public int CategoryID { get; set; } // Mã danh mục
        public byte[] PImage { get; set; } // Hình ảnh sản phẩm
        public string CatName { get; set; } // Tên danh mục (dùng để hiển thị)

        // Constructor mặc định
        public ProductDTO() { }

        // Constructor có tham số
        public ProductDTO(int pID, string pName, float pPrice, int categoryID, byte[] pImage, string catName)
        {
            this.PID = pID;
            this.PName = pName;
            this.PPrice = pPrice;
            this.CategoryID = categoryID;
            this.PImage = pImage;
            this.CatName = catName;
        }
    }
}
