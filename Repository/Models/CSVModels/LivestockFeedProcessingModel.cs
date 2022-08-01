using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class LivestockFeedProcessingModel : Facility, IValueChain
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
        public double fm_Capacity_tonnage_per_Day { get; set; }
        public double fm_Average_processed_per_Day { get; set; }
        public string? am_Products_processed { get; set; }
    }
}
