using KLMP.DataAccess.Repository.Models.CSVModels;
using GeoWAIS.Net.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Utils
{
    public class KCSAPBaselineDataGenerator
    {
        private string filePath = string.Empty;


        public KCSAPBaselineDataGenerator(string filePath)
        {
            this.filePath = filePath;

        }

        private List<WardCountyModel> wardsCounties = new List<WardCountyModel>();
        public List<WardCountyModel> WardsCounties
        {
            get
            {
                return wardsCounties?.Count > 0 ? wardsCounties :
                wardsCounties = ReadWriteCSVFile.ReadRootObjectFile<WardCountyModel>(Path.Combine(filePath, "Ward_County.csv"));
            }
        }

        private List<KcsapBaselineFarmer> kcsapBaselineFarmers = new List<KcsapBaselineFarmer>();
        public List<KcsapBaselineFarmer> KcsapBaselineFarmers
        {
            get
            {
                return kcsapBaselineFarmers?.Count > 0 ? kcsapBaselineFarmers :
                kcsapBaselineFarmers = ReadWriteCSVFile.ReadRootObjectFile<KcsapBaselineFarmer>(Path.Combine(filePath, "KCSAP_BASELINE.csv"));
            }
        }

        public void GenerateUniqueFarmerId(List<KcsapBaselineFarmer> baselineFarmers)
        {
            var uniqueIdentifiers = Identifiers.GetUniqueIds(300000).ToList();

            for (int i = 0; i < baselineFarmers.Count; i++)
            {
                try
                {
                    //var admin = wardsCounties?.
                    //    First(w => w.county_name.Trim() == baselineFarmers[i]?.County.Trim());
                    var admin = LocationSearch.
                        GetLocation(baselineFarmers[i]._GPS_Readings_of_the_Farm_latitude,
                        baselineFarmers[i]._GPS_Readings_of_the_Farm_longitude).
                        GetAwaiter().GetResult();
                    if (admin != null)
                    {
                        baselineFarmers[i].farmer_id = uniqueIdentifiers[i];
                        baselineFarmers[i].county_id = admin.A;
                        var test = LocationSearch.GetLocation(500, 800).GetAwaiter().GetResult();
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
