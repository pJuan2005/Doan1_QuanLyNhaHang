using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RM.DTO
{
    public class ReportDTO
    {
        public DataTable ProductData { get; set; }
        public DataTable StaffData { get; set; }
        public List<SaleByCategoryDTO> SaleByCategoryData { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ReportDTO()
        {
            ProductData = new DataTable();
            StaffData = new DataTable();
            SaleByCategoryData = new List<SaleByCategoryDTO>();
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }
    }
}
