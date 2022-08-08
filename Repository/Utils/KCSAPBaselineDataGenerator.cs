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
            var validatedRecords = new List<KcsapBaselineFarmer>();
            var unvalidatedRecords = new List<KcsapBaselineFarmer>();
            for (int i = 0; i < baselineFarmers.Count; i++)
            {
                try
                {
                    //var admin = wardsCounties?.
                    //    First(w => w.county_name.Trim() == baselineFarmers[i]?.County.Trim());
                    if (baselineFarmers[i] != null)
                    {
                        SearchResult admin = LocationSearch.GetLocation(baselineFarmers[i]._GPS_Readings_of_the_Farm_latitude,
                        baselineFarmers[i]._GPS_Readings_of_the_Farm_longitude).GetAwaiter().GetResult();

                        if (admin != null && admin.Region3 != "UNKNOWN")
                        {
                            var ward = wardsCounties.FirstOrDefault(w => w.ward_name == admin.Region3.ToUpper());
                            if (ward != null)
                            {
                                baselineFarmers[i].farmer_id = uniqueIdentifiers[i];
                                baselineFarmers[i].county_id = admin.Region1Id;
                                baselineFarmers[i].county_name = admin.Region1.ToUpper();
                                baselineFarmers[i].subcounty_id = admin.Region2Id;
                                baselineFarmers[i].subcounty_name = admin.Region2.ToUpper();
                                baselineFarmers[i].ward_id = ward?.ward_id;
                                baselineFarmers[i].ward_name = admin.Region3.ToUpper();
                                //Console.
                                //    WriteLine(string.Format("Farmer Id = {0}, County Id = {1}, County = {2}, Subcounty Id = {3} Subcounty = {4}, Ward Id = {5}, Ward = {6}",
                                //    uniqueIdentifiers[i], admin?.Region1Id, admin?.Region1.ToUpper(),
                                //    admin?.Region2Id, admin?.Region2.ToUpper(),
                                //     ward?.ward_id, admin?.Region3.ToUpper()));
                            }
                            else
                            {
                                if (admin.Region3 != "UNKNOWN")
                                    unknownRecordCount++;
                                Console.WriteLine(
                                    "Farmer Id = {0}, County Id = {1}, County = {2}, Subcounty Id = {3} Subcounty = {4}, Ward Id = {5}, Ward = {6}",
                                    uniqueIdentifiers[i], admin?.Region1Id, admin?.Region1.ToUpper(), admin?.Region2Id,
                                    admin?.Region2.ToUpper(), admin?.Region3Id, admin?.Region3.ToUpper());
                            }
                        }
                        else
                        {

                            Console.
                                WriteLine(String.
                                Format("Admin not found for latitude: {0}, longitude: {1}",
                                baselineFarmers[i]._GPS_Readings_of_the_Farm_latitude,
                                baselineFarmers[i]._GPS_Readings_of_the_Farm_longitude));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Here {0}", ex.StackTrace);
                }
            }
            Console.WriteLine("Count of unkown places: {0}", unknownRecordCount);
        }
    }
}
