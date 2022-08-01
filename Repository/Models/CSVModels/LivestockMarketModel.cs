using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class LivestockMarketModel : Facility, IValueChain, IActivityPeriods
    {
        public string? de_Category { get; set; }
        public int vc_Cattle { get; set; }
        public int vc_Sheep { get; set; }
        public int vc_Goat { get; set; }
        public int vc_Poultry { get; set; }
        public int vc_Pigs { get; set; }
        public int vc_Camel { get; set; }
        public int vc_Donkey { get; set; }
        public int vc_Rabbits { get; set; }
        public int vc_Bees { get; set; }
        public int am_Monday { get; set; }
        public int am_Tuesday { get; set; }
        public int am_Wednesday { get; set; }
        public int am_Thursday { get; set; }
        public int am_Friday { get; set; }
        public int am_Saturday { get; set; }
        public int am_Sunday { get; set; }
        public int? fm_Average_number_of_Cattle_traded_per_market_day { get; set; }
        public int? fm_Average_number_of_Sheep_traded_per_market_day { get; set; }
        public int? fm_Average_number_of_Goats_traded_per_market_day { get; set; }
        public int? fm_Average_number_of_Poultry_traded_per_market_day { get; set; }
        public int? fm_Average_number_of_Pigs_traded_per_market_day { get; set; }
        public int? fm_Average_number_of_Camel_traded_per_market_day { get; set; }
        public int? fm_Average_number_of_Donkeys_traded_per_market_day { get; set; }
        public string? Livestock_Market_Days { get; set; }

        public int am_Loading_ramp { get; set; }
        public int am_Offloading_ramp { get; set; }
        public int am_Quarantine_facility { get; set; }
        public int am_Watering_points { get; set; }
        public int am_Crushes { get; set; }
        public int am_Sanitary_facilities_Toilet_Water { get; set; }
        public int am_Waiting_bay { get; set; }
        public int am_Agrovet_shop { get; set; }
        public int am_Mpesa_shop { get; set; }
        public int am_Weighing_scales { get; set; }
        public int am_None { get; set; }
        public int am_Other { get; set; }
        public string? am_Other_Available_Facility { get; set; }
    }
}
