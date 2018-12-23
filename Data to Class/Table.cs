using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_to_Class
{
    class Table
    {
        public string tableName;
        public List<Column> columnArray;
        public string classText;

        public Table()
        {
            tableName = "";
            columnArray = new List<Column>();
            classText = "";
        }
    }
}
