using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Interface
{
    public interface IActivityPeriods
    {
        public int am_Monday { get; set; }
        public int am_Tuesday { get; set; }
        public int am_Wednesday { get; set; }
        public int am_Thursday { get; set; }
        public int am_Friday { get; set; }
        public int am_Saturday { get; set; }
        public int am_Sunday { get; set; }
    }
}
