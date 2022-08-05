using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class WardCountyModel
    {
        public string ward_id { get; set; }
        public string ward_name { get; set; }
        public int county_id { get; set; }
        public string county_name { get; set; }

        public override string ToString()
        {
            return string.Format("CountyId: {0}, CountyName: {1}, WardId: {2}, WardName: {3}", county_id, county_name, ward_id, ward_name);
        }
    }
}
