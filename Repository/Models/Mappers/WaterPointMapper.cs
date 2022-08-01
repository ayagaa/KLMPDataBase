using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class WaterPointMapper : ClassMap<WaterPointModel>
    {
        public WaterPointMapper()
        {
            Map(m => m.facility_id).Name("facility_id");
            Map(m => m.serial).Name("serial");
            Map(m => m.ward_id).Name("ward_id");
            Map(m => m.ward_name).Name("ward_name");
            Map(m => m.county_id).Name("county_id");
            Map(m => m.county_name).Name("county_name");
            Map(m => m.facility_type).Name("facility_type");
            Map(m => m.de_Type_of_Water_Point).Name("de_Type_of_Water_Point");
            Map(m => m.fm_Capacity_of_the_water_point).Name("fm_Capacity_of_the_water_point");
            Map(m => m.fm_Indicate_the_Yield_per_Hour).Name("fm_Indicate_the_Yield_per_Hour");
            Map(m => m.fm_Capacity_of_reservoir_tank).Name("fm_Capacity_of_reservoir_tank");
            Map(m => m.facility_ownership).Name("facility_ownership");
            Map(m => m.facility_status).Name("facility_status");
            Map(m => m.am_Source_of_power_Electricity).Name("am_Source_of_power_Electricity");
            Map(m => m.am_Source_of_power_Solar).Name("am_Source_of_power_Solar");
            Map(m => m.am_Source_of_power_Other).Name("am_Source_of_power_Other");
            Map(m => m.contact_person).Name("contact_person");
            Map(m => m.phone_number).Name("phone_number");
            Map(m => m.latitude).Name("latitude");
            Map(m => m.longitude).Name("longitude");
            Map(m => m.altitude).Name("altitude");
            Map(m => m.precision).Name("precision");
            Map(m => m.parent_county).Name("parent_county");
        }
    }
}
