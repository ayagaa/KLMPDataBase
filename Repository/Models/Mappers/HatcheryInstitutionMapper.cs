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
            Map(m => m.facility_id).Name("facility_id").Index(0);
            Map(m => m.serial).Name("serial").Index(1);
            Map(m => m.ward_id).Name("ward_id").Index(2);
            Map(m => m.ward_name).Name("ward_name").Index(3);
            Map(m => m.county_id).Name("county_id").Index(4);
            Map(m => m.county_name).Name("county_name").Index(5);
            Map(m => m.facility_type).Name("facility_type").Index(6);
            Map(m => m.facility_name).Name("facility_name").Index(7);
            Map(m => m.facility_ownership).Name("facility_ownership").Index(8);
            Map(m => m.contact_person).Name("contact_person").Index(9);
            Map(m => m.phone_number).Name("phone_number").Index(10);
            Map(m => m.latitude).Name("latitude").Index(11);
            Map(m => m.longitude).Name("longitude").Index(12);
            Map(m => m.altitude).Name("altitude").Index(13);
            Map(m => m.precision).Name("precision").Index(14);
            Map(m => m.am_Hatchery_Type_Broiler).Name("am_Hatchery_Type_Broiler");
            Map(m => m.am_Hatchery_Type_Layer).Name("am_Hatchery_Type_Layer");
            Map(m => m.am_Hatchery_Type_Kienyeji).Name("am_Hatchery_Type_Kienyeji");
            //Map(m => m.facility_ownership).Name("facility_ownership");
            Map(m => m.fm_Capacity_of_the_hatchery).Name("fm_Capacity_of_the_hatchery");
            //Map(m => m.contact_person).Name("contact_person");
            //Map(m => m.phone_number).Name("phone_number");
            //Map(m => m.latitude).Name("latitude");
            //Map(m => m.longitude).Name("longitude");
            //Map(m => m.altitude).Name("altitude");
            //Map(m => m.precision).Name("precision");
            Map(m => m.parent_county).Name("parent_county");
        }
    }
}
