using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class BandasMap : ClassMap<BandasModel>
    {
        public BandasMap()
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
            Map(m => m.de_Facility_Type_Banda).Name("de_Facility_Type_Banda");
            Map(m => m.de_Facility_Type_Tannery).Name("de_Facility_Type_Tannery");
            Map(m => m.de_Processes_Hides).Name("de_Processes_Hides");
            Map(m => m.de_Processes_Skins).Name("de_Processes_Skins");
            //Map(m => m.facility_name).Name("facility_name");
            //Map(m => m.facility_ownership).Name("facility_ownership");
            Map(m => m.fm_Hides_Capacity_in_Kgs).Name("fm_Hides_Capacity_in_Kgs");
            Map(m => m.fm_Skins_Capacity_Pieces).Name("fm_Skins_Capacity_Pieces");
            Map(m => m.fm_Average_Hides_processed_per_week_in_Kgs).Name("fm_Average_Hides_processed_per_week_in_Kgs");
            Map(m => m.fm_Average_Skins_processed_per_week_pieces).Name("fm_Average_Skins_processed_per_week_pieces");
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
