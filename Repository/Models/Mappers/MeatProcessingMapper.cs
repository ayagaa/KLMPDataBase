using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class MeatProcessingMapper : ClassMap<MeatProcessingModel>
    {
        public MeatProcessingMapper()
        {
            Map(m => m.facility_id).Name("facility_id");
            Map(m => m.serial).Name("serial");
            Map(m => m.ward_id).Name("ward_id");
            Map(m => m.ward_name).Name("ward_name");
            Map(m => m.county_id).Name("county_id");
            Map(m => m.county_name).Name("county_name");
            Map(m => m.facility_type).Name("facility_type");
            Map(m => m.facility_name).Name("facility_name");
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
            Map(m => m.fm_Capacity_per_Day_Numbers_of_Carcasses).Name("fm_Capacity_per_Day_Numbers_of_Carcasses");
            Map(m => m.fm_Average_number_of_Cattle_carcasses_processed_per_day).Name("fm_Average_number_of_Cattle_carcasses_processed_per_day");
            Map(m => m.fm_Average_number_of_Sheep_carcasses_processed_per_day).Name("fm_Average_number_of_Sheep_carcasses_processed_per_day");
            Map(m => m.fm_Average_number_of_Goats_carcasses_processed_per_day).Name("fm_Average_number_of_Goats_carcasses_processed_per_day");
            Map(m => m.fm_Average_number_of_Poultry_carcasses_processed_per_day).Name("fm_Average_number_of_Poultry_carcasses_processed_per_day");
            Map(m => m.fm_Average_number_of_Pigs_carcasses_processed_per_day).Name("fm_Average_number_of_Pigs_carcasses_processed_per_day");
            Map(m => m.fm_Average_number_of_Camel_carcasses_processed_per_day).Name("fm_Average_number_of_Camel_carcasses_processed_per_day");
            Map(m => m.fm_Average_number_of_Donkeys_carcasses_processed_per_day).Name("fm_Average_number_of_Donkeys_carcasses_processed_per_day");
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
