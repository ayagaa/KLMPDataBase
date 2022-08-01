using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Abstract
{
    public abstract class Facility
    {
        public string? facility_id { get; set; }
        public int serial { get; set; }
        public int ward_id { get; set; }
        public string? ward_name { get; set; }
        public int county_id { get; set; }

        public string? facility_name { get; set; }

        public string? facility_type { get; set; }

        public string? facility_ownership { get; set; }

        public virtual string ToString()
        {
            return string.Format("FacilityId: {0}, FacilityTYpe: {5}, CountyId: {1}, CountyName: {2}, WardId: {3}, WardName: {4}",
                facility_id, county_id, county_name, ward_id, ward_name, facility_type);
        }
        public string? county_name { get; set; }
        public string? contact_person { get; set; }
        public int phone_number { get; set; }

        public string? parent_county { get; set; }

        public double latitude { get; set; }
        public double longitude { get; set; }
        public double altitude { get; set; }
        public double precision { get; set; }

        public string? facility_status { get; set; }

        public virtual void GetFacilityDetails(string filePath)
        {

        }
    }
}
