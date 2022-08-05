using KLMP.DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class BeeKeepingWSModel : Facility
    {
        public int am_Beekeeping_equipment_KTBH { get; set; }
        public int am_Beekeeping_equipment_Longstroth_hive { get; set; }
        public int am_Beekeeping_equipment_Box_hive { get; set; }
        public int am_Beekeeping_equipment_Traditional_log_hive { get; set; }
        public int am_Beekeeping_equipment_Flow_hive { get; set; }
        public int am_Beekeeping_equipment_Beesuit { get; set; }
        public int am_Beekeeping_equipment_Veil { get; set; }
        public int am_Beekeeping_equipment_Gloves { get; set; }
        public int am_Beekeeping_equipment_Smoker { get; set; }
        public int am_Beekeeping_equipment_Bee_brush { get; set; }
        public int am_Beekeeping_equipment_Hive_knife { get; set; }
        public int fm_Average_Production { get; set; }

        public string? fm_Capacitypotential { get; set; }
    }
}
