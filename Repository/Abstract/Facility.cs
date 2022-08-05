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

        private string? _name = string.Empty;
        public string? facility_name
        {
            get
            {
                return _name = _name?.Replace('"'.ToString(), string.Empty)?.
                    Replace("\n", "")?.Replace("\r", "");
            }
            set
            {
                _name = value;
            }
        }

        public string? facility_type { get; set; }

        public string? facility_ownership { get; set; }

        public void CopyFacility(Facility facility)
        {
            facility_id = facility.facility_id;
            ward_id = facility.ward_id;
            ward_name = facility.ward_name;
            county_id = facility.county_id;
            county_name = facility.county_name;
            facility_type = facility.facility_type;
            facility_ownership = facility.facility_ownership;
            facility_status = facility.facility_status;
        }

        public virtual string ToString()
        {
            return string.Format("FacilityId: {0}, FacilityType: {5}, CountyId: {1}, CountyName: {2}, WardId: {3}, WardName: {4}",
                facility_id, county_id, county_name, ward_id, ward_name, facility_type);
        }
        public string? county_name { get; set; }

        private string? _contact_person = string.Empty;
        public string? contact_person
        {
            get
            {
                return _contact_person?.Replace('"'.ToString(), string.Empty)?.
                    Replace("\n", "")?.Replace("\r", ""); ;
            }
            set
            {
                _contact_person = value;
            }
        }
        public string? phone_number { get; set; }

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
