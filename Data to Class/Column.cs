using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_to_Class
{
    class Column
    {
        public string columnName { get; set; }
        public string columnDbType { get; set; }
        public string columnProgramType { get; set; }
        public string columnLength { get; set; }
        public Column()
        {
            columnName = "";
            columnDbType = "";
            columnProgramType = "";
            columnLength = "";
        }
    }
}
