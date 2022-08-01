using KLMP.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class BeeProductProcessingModel : Facility
    {
        public int am_Product_Processed_Honey { get; set; }
        public int am_Product_Processed_Wax { get; set; }
        public int am_Product_Processed_Propolis { get; set; }
        public int am_Product_Processed_Royal_Jelly { get; set; }
        public string? facility_ownership { get; set; }
        public string? fm_Capacity_potential { get; set; }
        public int fm_Average_Production { get; set; }
    }
}
