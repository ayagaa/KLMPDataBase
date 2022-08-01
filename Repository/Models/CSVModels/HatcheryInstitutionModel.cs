using KLMP.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class HatcheryInstitutionModel : Facility
    {
        public int am_Hatchery_Type_Broiler { get; set; }
        public int am_Hatchery_Type_Layer { get; set; }
        public int am_Hatchery_Type_Kienyeji { get; set; }
        public string? fm_Capacity_of_the_hatchery { get; set; }
    }
}
