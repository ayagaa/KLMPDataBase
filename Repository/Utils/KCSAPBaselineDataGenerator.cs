using GeoWAIS.Models.ProductModels;
using GeoWAIS.Net.DataAccess;
using KLMP.DataAccess.Repository.Models.CSVModels;

namespace KLMP.DataAccess.Repository.Utils
{
    public class KCSAPBaselineDataGenerator
    {
        private string filePath = string.Empty;


        public KCSAPBaselineDataGenerator(string filePath)
        {
            //Console.WriteLine("Initializing Generator");
            this.filePath = filePath;
            wardsCounties = WardsCounties;
            kcsapBaselineFarmers = KcsapBaselineFarmers;
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
        public List<KcsapBaselineFarmer> KcsapBaselineFarmers =>
            kcsapBaselineFarmers?.Count > 0 ? kcsapBaselineFarmers :
                kcsapBaselineFarmers = ReadWriteCSVFile.ReadRootObjectFile<KcsapBaselineFarmer>(Path.Combine(filePath, "KCSAP_BASELINE.csv"));

        public void GenerateUniqueFarmerId(List<KcsapBaselineFarmer> baselineFarmers)
        {
            var uniqueIdentifiers = Identifiers.GetUniqueIds(300000).ToList();
            Console.WriteLine("Count of farmers is {0}", baselineFarmers.Count);
            var unknownRecordCount = 0;
            var unfoundAdminRecords = new List<KcsapBaselineFarmer>();
            var validatedRecords = new List<KcsapBaselineFarmer>();
            var unvalidatedRecords = new List<KcsapBaselineFarmer>();
            for (int i = 0; i < baselineFarmers.Count; i++)
            {
                try
                {
                    if (baselineFarmers[i] != null)
                    {
                        SearchResult admin = LocationSearch.GetLocation(baselineFarmers[i]._GPS_Readings_of_the_Farm_latitude,
                        baselineFarmers[i]._GPS_Readings_of_the_Farm_longitude).GetAwaiter().GetResult();

                        if (admin != null && admin.Region3 != "UNKNOWN")
                        {
                            var ward = wardsCounties.FirstOrDefault(w => w.ward_name == admin.Region3.ToUpper());
                            if (ward != null)
                            {
                                baselineFarmers[i].farmer_id = ward?.county_id.ToString()?.PadLeft(2, '0') +
                                                               ward?.ward_id?.PadLeft(4, '0') + uniqueIdentifiers[i];
                                baselineFarmers[i].county_id = admin.Region1Id;
                                baselineFarmers[i].county_name = admin.Region1.ToUpper();
                                baselineFarmers[i].subcounty_id = admin.Region2Id;
                                baselineFarmers[i].subcounty_name = admin.Region2.ToUpper();
                                baselineFarmers[i].ward_id = ward?.ward_id;
                                baselineFarmers[i].ward_name = admin.Region3.ToUpper();

                                validatedRecords.Add(baselineFarmers[i]);
                            }
                            else
                            {
                                if (admin.Region3 != "UNKNOWN")
                                    unfoundAdminRecords.Add(baselineFarmers[i]);
                            }
                        }
                        else
                        {
                            unvalidatedRecords.Add(baselineFarmers[i]);
                            //Console.
                            //    WriteLine(String.
                            //    Format("Admin not found for latitude: {0}, longitude: {1}",
                            //    baselineFarmers[i]._GPS_Readings_of_the_Farm_latitude,
                            //    baselineFarmers[i]._GPS_Readings_of_the_Farm_longitude));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Here {0}", ex.StackTrace);
                }
            }

            Console.WriteLine("Validated record count: {0}", validatedRecords.Count);
            Console.WriteLine("Unvalidated record count: {0}", unvalidatedRecords.Count);
            Console.WriteLine("Count of unkown places: {0}", unfoundAdminRecords.Count);
        }
    }
}
