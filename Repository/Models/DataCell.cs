using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models
{
    public class DataCell
    {
        internal int RowIndex { get; set; }
        internal int ColumnIndex { get; set; }
        internal string ColumnName { get; set; }

        internal string CellValue { get; set; }

        internal string DestinationColumn { get; set; }

        internal bool IsHeader { get; set; }
    }
}
