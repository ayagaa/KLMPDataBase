using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class LivestockMarketMapper : ClassMap<LivestockMarketModel>
    {
        public LivestockMarketMapper()
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
            Map(m => m.vc_Cattle).Name("vc_Cattle");
            Map(m => m.vc_Sheep).Name("vc_Sheep");
            Map(m => m.vc_Goat).Name("vc_Goat");
            Map(m => m.vc_Poultry).Name("vc_Poultry");
            Map(m => m.vc_Pigs).Name("vc_Pigs");
            Map(m => m.vc_Camel).Name("vc_Camel");
            Map(m => m.vc_Donkey).Name("vc_Donkey");
            Map(m => m.vc_Rabbits).Name("vc_Rabbits");
            Map(m => m.vc_Bees).Name("vc_Bees");
            Map(m => m.fm_Average_number_of_Cattle_traded_per_market_day).Name("fm_Average_number_of_Cattle_traded_per_market_day");
            Map(m => m.fm_Average_number_of_Sheep_traded_per_market_day).Name("fm_Average_number_of_Sheep_traded_per_market_day");
            Map(m => m.fm_Average_number_of_Goats_traded_per_market_day).Name("fm_Average_number_of_Goats_traded_per_market_day");
            Map(m => m.fm_Average_number_of_Poultry_traded_per_market_day).Name("fm_Average_number_of_Poultry_traded_per_market_day");
            Map(m => m.fm_Average_number_of_Pigs_traded_per_market_day).Name("fm_Average_number_of_Pigs_traded_per_market_day");
            Map(m => m.fm_Average_number_of_Camel_traded_per_market_day).Name("fm_Average_number_of_Camel_traded_per_market_day");
            Map(m => m.fm_Average_number_of_Donkeys_traded_per_market_day).Name("fm_Average_number_of_Donkeys_traded_per_market_day");
            Map(m => m.Livestock_Market_Days).Name("Livestock_Market_Days");
            Map(m => m.am_Monday).Name("am_Monday");
            Map(m => m.am_Tuesday).Name("am_Tuesday");
            Map(m => m.am_Wednesday).Name("am_Wednesday");
            Map(m => m.am_Thursday).Name("am_Thursday");
            Map(m => m.am_Friday).Name("am_Friday");
            Map(m => m.am_Saturday).Name("am_Saturday");
            Map(m => m.am_Sunday).Name("am_Sunday");
            Map(m => m.contact_person).Name("contact_person");
            Map(m => m.phone_number).Name("phone_number");
            Map(m => m.am_Loading_ramp).Name("am_Loading_ramp");
            Map(m => m.am_Offloading_ramp).Name("am_Offloading_ramp");
            Map(m => m.am_Quarantine_facility).Name("am_Quarantine_facility");
            Map(m => m.am_Watering_points).Name("am_Watering_points");
            Map(m => m.am_Crushes).Name("am_Crushes");
            Map(m => m.am_Sanitary_facilities_Toilet_Water).Name("am_Sanitary_facilities_Toilet_Water");
            Map(m => m.am_Waiting_bay).Name("am_Waiting_bay");
            Map(m => m.am_Agrovet_shop).Name("am_Agrovet_shop");
            Map(m => m.am_Mpesa_shop).Name("am_Mpesa_shop");
            Map(m => m.am_Weighing_scales).Name("am_Weighing_scales");
            Map(m => m.am_None).Name("am_None");
            Map(m => m.am_Other).Name("am_Other");
            Map(m => m.am_Other_Available_Facility).Name("am_Other_Available_Facility");
            Map(m => m.latitude).Name("latitude");
            Map(m => m.longitude).Name("longitude");
            Map(m => m.altitude).Name("altitude");
            Map(m => m.precision).Name("precision");
            Map(m => m.parent_county).Name("parent_county");
        }
    }
}
