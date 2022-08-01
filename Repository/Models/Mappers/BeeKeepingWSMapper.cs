using CsvHelper.Configuration;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.Mappers
{
    public sealed class BeeKeepingWSMap : ClassMap<BeeKeepingWSModel>
    {
        public BeeKeepingWSMap()
        {
            Map(m => m.facility_id).Name("facility_id");
            Map(m => m.serial).Name("serial");
            Map(m => m.ward_id).Name("ward_id");
            Map(m => m.ward_name).Name("ward_name");
            Map(m => m.county_id).Name("county_id");
            Map(m => m.county_name).Name("county_name");
            Map(m => m.facility_name).Name("facility_name");
            Map(m => m.facility_type).Name("facility_type");
            Map(m => m.am_Beekeeping_equipment_KTBH).Name("am_Beekeeping_equipment_KTBH");
            Map(m => m.am_Beekeeping_equipment_Longstroth_hive).Name("am_Beekeeping_equipment_Longstroth_hive");
            Map(m => m.am_Beekeeping_equipment_Box_hive).Name("am_Beekeeping_equipment_Box_hive");
            Map(m => m.am_Beekeeping_equipment_Traditional_log_hive).Name("am_Beekeeping_equipment_Traditional_log_hive");
            Map(m => m.am_Beekeeping_equipment_Flow_hive).Name("am_Beekeeping_equipment_Flow_hive");
            Map(m => m.am_Beekeeping_equipment_Beesuit).Name("am_Beekeeping_equipment_Beesuit");
            Map(m => m.am_Beekeeping_equipment_Veil).Name("am_Beekeeping_equipment_Veil");
            Map(m => m.am_Beekeeping_equipment_Gloves).Name("am_Beekeeping_equipment_Gloves");
            Map(m => m.am_Beekeeping_equipment_Smoker).Name("am_Beekeeping_equipment_Smoker");
            Map(m => m.am_Beekeeping_equipment_Bee_brush).Name("am_Beekeeping_equipment_Bee_brush");
            Map(m => m.am_Beekeeping_equipment_Hive_knife).Name("am_Beekeeping_equipment_Hive_knife");
            Map(m => m.facility_ownership).Name("facility_ownership");
            Map(m => m.fm_Capacitypotential).Name("fm_Capacitypotential");
            Map(m => m.fm_Average_Production).Name("fm_Average_Production");
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
