using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class StaffDTO
    {
        public int StaffID { get; set; }
        public string SName { get; set; }
        public string SPhone { get; set; }
        public string SRole { get; set; }


        public StaffDTO(int staffID, string sName, string sPhone, string sRole)
        {
            this.StaffID = staffID;
            this.SName = sName;
            this.SPhone = sPhone;
            this.SRole = sRole;
        }


        public StaffDTO() { }
    }
}
