using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.DTO
{
    public class TableDTO
    {
        public int TableID { get; set; }
        public string TableName { get; set; }

        // Constructor có tham số
        public TableDTO(int tableID, string tableName)
        {
            this.TableID = tableID;
            this.TableName = tableName;
        }

        // Constructor mặc định 
        public TableDTO() { }

    }
}
