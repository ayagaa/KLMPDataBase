using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class AgroVetMap : ClassMap<AgroVetModel>
    {
        public AgroVetMap()
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
            Map(m => m.vc_Cattle).Name("vc_Cattle");
            Map(m => m.vc_Sheep).Name("vc_Sheep");
            Map(m => m.vc_Goat).Name("vc_Goat");
            Map(m => m.vc_Poultry).Name("vc_Poultry");
            Map(m => m.vc_Pigs).Name("vc_Pigs");
            Map(m => m.vc_Camel).Name("vc_Camel");
            Map(m => m.vc_Donkey).Name("vc_Donkey");
            Map(m => m.vc_Rabbits).Name("vc_Rabbits");
            Map(m => m.vc_Bees).Name("vc_Bees");
            Map(m => m.am_AI_services).Name("am_AI_services");
            Map(m => m.am_Sales_of_veterinary_pharmaceuticals).Name("am_Sales_of_veterinary_pharmaceuticals");
            Map(m => m.am_Veterinary_clinical_services_and_extensions).Name("am_Veterinary_clinical_services_and_extensions");
            Map(m => m.am_Equipment_and_machinery).Name("am_Equipment_and_machinery");
            Map(m => m.am_Animal_feeds).Name("am_Animal_feeds");
            Map(m => m.am_Advisory_Services).Name("am_Advisory_Services");
            Map(m => m.parent_county).Name("parent_county");
        }
    }
}
