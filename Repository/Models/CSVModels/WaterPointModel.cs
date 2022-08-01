using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public sealed class WaterPointModel : Facility
    {
        public string? de_Type_of_Water_Point { get; set; }
        public string? fm_Capacity_of_the_water_point { get; set; }
        public string? fm_Indicate_the_Yield_per_Hour { get; set; }
        public string? fm_Capacity_of_reservoir_tank { get; set; }
        public int am_Source_of_power_Electricity { get; set; }
        public int am_Source_of_power_Solar { get; set; }
        public int am_Source_of_power_Other { get; set; }
    }
}
