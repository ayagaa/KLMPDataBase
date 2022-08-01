using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class MeatProcessingModel : Facility, IValueChain
    {
        public int vc_Cattle { get; set; }
        public int vc_Sheep { get; set; }
        public int vc_Goat { get; set; }
        public int vc_Poultry { get; set; }
        public int vc_Pigs { get; set; }
        public int vc_Camel { get; set; }
        public int vc_Donkey { get; set; }
        public int vc_Rabbits { get; set; }
        public int vc_Bees { get; set; }
        public int fm_Capacity_per_Day_Numbers_of_Carcasses { get; set; }
        public int? fm_Average_number_of_Cattle_carcasses_processed_per_day { get; set; }
        public int? fm_Average_number_of_Sheep_carcasses_processed_per_day { get; set; }
        public int? fm_Average_number_of_Goats_carcasses_processed_per_day { get; set; }
        public int? fm_Average_number_of_Poultry_carcasses_processed_per_day { get; set; }
        public int? fm_Average_number_of_Pigs_carcasses_processed_per_day { get; set; }
        public int? fm_Average_number_of_Camel_carcasses_processed_per_day { get; set; }
        public string? fm_Average_number_of_Donkeys_carcasses_processed_per_day { get; set; }
    }
}
