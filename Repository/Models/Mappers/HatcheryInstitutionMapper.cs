using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class HatcheryInstitutionMapper : ClassMap<HatcheryInstitutionModel>
    {
        public HatcheryInstitutionMapper()
        {
            Map(m => m.facility_id).Name("facility_id");
            Map(m => m.serial).Name("serial");
            Map(m => m.ward_id).Name("ward_id");
            Map(m => m.ward_name).Name("ward_name");
            Map(m => m.county_id).Name("county_id");
            Map(m => m.county_name).Name("county_name");
            Map(m => m.facility_type).Name("facility_type");
            Map(m => m.am_Hatchery_Type_Broiler).Name("am_Hatchery_Type_Broiler");
            Map(m => m.am_Hatchery_Type_Layer).Name("am_Hatchery_Type_Layer");
            Map(m => m.am_Hatchery_Type_Kienyeji).Name("am_Hatchery_Type_Kienyeji");
            Map(m => m.facility_ownership).Name("facility_ownership");
            Map(m => m.fm_Capacity_of_the_hatchery).Name("fm_Capacity_of_the_hatchery");
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
