namespace DTO
{
    public class CategoryDTO
    {
        public int CatID { get; set; }  // Mã danh mục
        public string CatName { get; set; } // Tên danh mục

        // Constructor mặc định
        public CategoryDTO() { }

        // Constructor có tham số
        public CategoryDTO(int catID, string catName)
        {
            this.CatID = catID;
            this.CatName = catName;
        }
    }
}
