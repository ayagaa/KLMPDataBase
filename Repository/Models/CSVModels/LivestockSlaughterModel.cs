using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class LivestockSlaughterModel : Facility, IValueChain, IActivityPeriods
    {
        public string? de_Category { get; set; }
        public string? Slaughter_Facility_type { get; set; }
        public int de_Slaughter_for_Local_Market { get; set; }
        public int de_Slaughter_Facility_for_Export_Market { get; set; }
        public int vc_Cattle { get; set; }
        public int vc_Sheep { get; set; }
        public int vc_Goat { get; set; }
        public int vc_Poultry { get; set; }
        public int vc_Pigs { get; set; }
        public int vc_Camel { get; set; }
        public int vc_Donkey { get; set; }
        public int vc_Rabbits { get; set; }
        public int vc_Bees { get; set; }
        public int? fm_Average_number_of_Cattle_slaughtered_per_day { get; set; }
        public int? fm_Average_number_of_Sheep_slaughtered_per_day { get; set; }
        public int? fm_Average_number_of_Goats_slaughtered_per_day { get; set; }
        public int? fm_Average_number_of_Poultry_slaughtered_per_day { get; set; }
        public int? fm_Average_number_of_Pigs_slaughtered_per_day { get; set; }
        public int? fm_Average_number_of_Camel_slaughtered_per_day { get; set; }
        public int? fm_Average_number_of_Donkeys_slaughtered_per_day { get; set; }
        public int ap_Monday { get; set; }
        public int ap_Tuesday { get; set; }
        public int ap_Wednesday { get; set; }
        public int ap_Thursday { get; set; }
        public int ap_Friday { get; set; }
        public int ap_Saturday { get; set; }
        public int ap_Sunday { get; set; }
        public int am_Loading_ramp { get; set; }
        public int am_Offloading_ramp { get; set; }
        public int am_Quarantine_facility { get; set; }
        public int am_Watering_points { get; set; }
        public int am_Crushes { get; set; }
        public int am_Sanitary_facilities_Toilet__Water { get; set; }
        public int am_Waiting_bay { get; set; }
        public int am_Agrovet_shop { get; set; }
        public int am_Mpesa_shop { get; set; }
        public int am_Weighing_scales { get; set; }
        public int am_None { get; set; }
        public int am_Other { get; set; }
        public int am_Monday { get; set; }
        public int am_Tuesday { get; set; }
        public int am_Wednesday { get; set; }
        public int am_Thursday { get; set; }
        public int am_Friday { get; set; }
        public int am_Saturday { get; set; }
        public int am_Sunday { get; set; }
    }
}
