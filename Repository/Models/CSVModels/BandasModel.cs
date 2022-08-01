using KLMP.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class BandasModel : Facility
    {
        public int de_Facility_Type_Banda { get; set; }
        public int de_Facility_Type_Tannery { get; set; }
        public int? de_Processes_Hides { get; set; }
        public int? de_Processes_Skins { get; set; }
        public int? fm_Hides_Capacity_in_Kgs { get; set; }
        public int? fm_Skins_Capacity_Pieces { get; set; }
        public int? fm_Average_Hides_processed_per_week_in_Kgs { get; set; }
        public int? fm_Average_Skins_processed_per_week_pieces { get; set; }
    }
}
