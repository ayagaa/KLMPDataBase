using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class LivestockSlaughterMapper : ClassMap<LivestockSlaughterModel>
    {
        public LivestockSlaughterMapper()
        {
            Map(m => m.facility_id).Name("facility_id");
            Map(m => m.serial).Name("serial");
            Map(m => m.ward_id).Name("ward_id");
            Map(m => m.ward_name).Name("ward_name");
            Map(m => m.county_id).Name("county_id");
            Map(m => m.county_name).Name("county_name");
            Map(m => m.facility_type).Name("facility_type");
            Map(m => m.facility_name).Name("facility_name");
            Map(m => m.de_Category).Name("de_Category");
            Map(m => m.facility_ownership).Name("facility_ownership");
            Map(m => m.Slaughter_Facility_type).Name("Slaughter_Facility_type");
            Map(m => m.de_Slaughter_for_Local_Market).Name("de_Slaughter_for_Local_Market");
            Map(m => m.de_Slaughter_Facility_for_Export_Market).Name("de_Slaughter_Facility_for_Export_Market");
            Map(m => m.vc_Cattle).Name("vc_Cattle");
            Map(m => m.vc_Sheep).Name("vc_Sheep");
            Map(m => m.vc_Goat).Name("vc_Goat");
            Map(m => m.vc_Poultry).Name("vc_Poultry");
            Map(m => m.vc_Pigs).Name("vc_Pigs");
            Map(m => m.vc_Camel).Name("vc_Camel");
            Map(m => m.vc_Donkey).Name("vc_Donkey");
            Map(m => m.vc_Rabbits).Name("vc_Rabbits");
            Map(m => m.vc_Bees).Name("vc_Bees");
            Map(m => m.fm_Average_number_of_Cattle_slaughtered_per_day).Name("fm_Average_number_of_Cattle_slaughtered_per_day");
            Map(m => m.fm_Average_number_of_Sheep_slaughtered_per_day).Name("fm_Average_number_of_Sheep_slaughtered_per_day");
            Map(m => m.fm_Average_number_of_Goats_slaughtered_per_day).Name("fm_Average_number_of_Goats_slaughtered_per_day");
            Map(m => m.fm_Average_number_of_Poultry_slaughtered_per_day).Name("fm_Average_number_of_Poultry_slaughtered_per_day");
            Map(m => m.fm_Average_number_of_Pigs_slaughtered_per_day).Name("fm_Average_number_of_Pigs_slaughtered_per_day");
            Map(m => m.fm_Average_number_of_Camel_slaughtered_per_day).Name("fm_Average_number_of_Camel_slaughtered_per_day");
            Map(m => m.fm_Average_number_of_Donkeys_slaughtered_per_day).Name("fm_Average_number_of_Donkeys_slaughtered_per_day");
            Map(m => m.ap_Monday).Name("ap_Monday");
            Map(m => m.ap_Tuesday).Name("ap_Tuesday");
            Map(m => m.ap_Wednesday).Name("ap_Wednesday");
            Map(m => m.ap_Thursday).Name("ap_Thursday");
            Map(m => m.ap_Friday).Name("ap_Friday");
            Map(m => m.ap_Saturday).Name("ap_Saturday");
            Map(m => m.ap_Sunday).Name("ap_Sunday");
            Map(m => m.contact_person).Name("contact_person");
            Map(m => m.phone_number).Name("phone_number");
            Map(m => m.am_Loading_ramp).Name("am_Loading_ramp");
            Map(m => m.am_Offloading_ramp).Name("am_Offloading_ramp");
            Map(m => m.am_Quarantine_facility).Name("am_Quarantine_facility");
            Map(m => m.am_Watering_points).Name("am_Watering_points");
            Map(m => m.am_Crushes).Name("am_Crushes");
            Map(m => m.am_Sanitary_facilities_Toilet__Water).Name("am_Sanitary_facilities_Toilet_&_Water");
            Map(m => m.am_Waiting_bay).Name("am_Waiting_bay");
            Map(m => m.am_Agrovet_shop).Name("am_Agrovet_shop");
            Map(m => m.am_Mpesa_shop).Name("am_Mpesa_shop");
            Map(m => m.am_Weighing_scales).Name("am_Weighing_scales");
            Map(m => m.am_None).Name("am_None");
            Map(m => m.am_Other).Name("am_Other");
            Map(m => m.latitude).Name("latitude");
            Map(m => m.longitude).Name("longitude");
            Map(m => m.altitude).Name("altitude");
            Map(m => m.precision).Name("precision");
            Map(m => m.parent_county).Name("parent_county");
        }
    }
}
