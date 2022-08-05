using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Models.CSVModels;
using KLMP.DataAccess.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models
{
    public class FacilitiesDataModel
    {
        private string folderPath;

        public FacilitiesDataModel(string folderPath)
        {
            this.folderPath = folderPath;
        }

        private List<RootObject> PopulateObjects<RootObject>(List<RootObject> rootObjects, string objectType)
        {
            Console.WriteLine(string.Format("Processing {0} records of facility type {1}", rootObjects.Count, GetFacilityType(objectType)));
            var resultList = new List<RootObject>();
            var identifiers = Identifiers.GetUniqueIds(20000).ToList();
            Console.WriteLine(string.Format("Number of records: {0} Number of Identifiers: {1}", rootObjects.Count, identifiers.Count));
            for (int i = 0; i < rootObjects.Count; i++)
            {
                var rootObject = rootObjects[i] as Facility;

                PopulateObject(ref rootObject, i, identifiers, objectType);
                var result = CopyFacilityDetails(rootObjects[i], rootObject, objectType);
                resultList.Add(result);
            }
            Console.WriteLine(string.Format("Done processing {1} records of facilty type", GetFacilityType(objectType), resultList.Count));
            return resultList;
        }

        private void PopulateObject(ref Facility? facility, int index, List<string> identifiers, string objectType)
        {
            if (this.WardsCounties?.Count > 0)
            {
                foreach (var ward in this.WardsCounties)
                {
                    if (facility?.ward_name?.Trim() == ward?.ward_name?.Trim() &&
                        facility?.parent_county?
                        .Replace("WARD BASELINE TOOL KLMP - ", String.Empty)?
                        .Replace("FINAL", String.Empty)?.Trim() == ward?.county_name?.Trim())
                    {
                        try
                        {
                            facility.facility_id = ward?.county_id.ToString()?.PadLeft(2, '0') +
                                                   ward?.ward_id?.PadLeft(4, '0') +
                                                   objectType +
                                                   identifiers[index];
                            facility.facility_type = GetFacilityType(objectType);
                            facility.county_id = ward.county_id;
                            facility.county_name = ward?.county_name;
                            facility.ward_id = int.Parse(ward?.ward_id);
                        }
                        catch (FormatException ex)
                        {

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }

        private string GetFacilityType(string objectType)
        {
            switch (objectType)
            {
                case "AV":
                    return "Agro-Vet Facility";
                case "BN":
                    return "Bandas Facility";
                case "BK":
                    return "Bee Keeping Workshop";
                case "BP":
                    return "Bee Product Processing Facility";
                case "EC":
                    return "Ectoparasite Control Facility";
                case "HI":
                    return "Hatchery Institution Facility";
                case "LF":
                    return "Livestock Feed Processing Facility";
                case "LM":
                    return "Livestock Market Facility";
                case "MC":
                    return "Milk Cooling Facility";
                case "LS":
                    return "Slaughter Facility";
                case "SG":
                    return "Societies and Groups";
                case "MP":
                    return "Meet Processing Facility";
                case "MA":
                    return "Milk ATM Facility";
                case "VS":
                    return "Vaccination Site Facility";
                case "WP":
                    return "Water Point Facility";
                default:
                    return string.Empty;
            }
        }


        private dynamic CopyFacilityDetails<RootObject>(RootObject rootObject, Facility? facility, string objectType)
        {
            switch (objectType)
            {
                case "AV":
                    {
                        var resultObject = new AgroVetModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "BN":
                    {
                        var resultObject = new BandasModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "BK":
                    {
                        var resultObject = new BeeKeepingWSModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "BP":
                    {
                        var resultObject = new BeeProductProcessingModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "EC":
                    {
                        var resultObject = new EctoparasiteControlModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "HI":
                    {
                        var resultObject = new HatcheryInstitutionModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "LF":
                    {
                        var resultObject = new LivestockFeedProcessingModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "LM":
                    {
                        var resultObject = new LivestockMarketModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "MC":
                    {
                        var resultObject = new LivestockMilkCoolingModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "LS":
                    {
                        var resultObject = new LivestockSlaughterModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "SG":
                    {
                        var resultObject = new LivestockSocietiesModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "MP":
                    {
                        var resultObject = new MeatProcessingModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "MA":
                    {
                        var resultObject = new MilkATMModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "VS":
                    {
                        var resultObject = new VaccinationSiteModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                case "WP":
                    {
                        var resultObject = new WaterPointModel();
                        ObjectCopier.CopyPropertiesTo(rootObject, resultObject);
                        ObjectCopier.CopyPropertiesTo(facility, resultObject);
                        return resultObject;
                    };
                default:
                    return default(RootObject);
            }
        }

        private List<WardCountyModel> wardsCounties = new List<WardCountyModel>();
        public List<WardCountyModel> WardsCounties
        {
            get
            {
                return wardsCounties?.Count > 0 ? wardsCounties :
                wardsCounties = ReadWriteCSVFile.ReadRootObjectFile<WardCountyModel>(Path.Combine(folderPath, "Ward_County.csv"));
            }
        }

        private List<AgroVetModel> agroVets = new List<AgroVetModel>();
        public List<AgroVetModel> AgroVets
        {
            get
            {
                return agroVets?.Count > 0 ? agroVets :
                agroVets = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<AgroVetModel>(Path.Combine(folderPath, "agro_vet_facility.csv")), "AV");
            }
        }

        public List<BandasModel> bandas = new List<BandasModel>();
        public List<BandasModel> Bandas
        {
            get
            {
                return bandas?.Count > 0 ? bandas :
                bandas = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<BandasModel>(Path.Combine(folderPath, "Bandas.csv")), "BN");
            }
        }

        private List<BeeKeepingWSModel> beeKeepingWs = new List<BeeKeepingWSModel>();
        public List<BeeKeepingWSModel> BeeKeepingWs
        {
            get
            {
                return beeKeepingWs?.Count > 0 ? beeKeepingWs :
                beeKeepingWs = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<BeeKeepingWSModel>(Path.Combine(folderPath, "Bee_Keeping_WS.csv")), "BK");
            }
        }

        private List<BeeProductProcessingModel> beeProductProcessing = new List<BeeProductProcessingModel>();
        public List<BeeProductProcessingModel> BeeProductProcessing
        {
            get
            {
                return beeProductProcessing?.Count > 0 ? beeProductProcessing :
                beeProductProcessing = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<BeeProductProcessingModel>(Path.Combine(folderPath, "Bee_Product_Processing.csv")), "BP");
            }
        }

        private List<EctoparasiteControlModel> ectoparasiteControl = new List<EctoparasiteControlModel>();
        public List<EctoparasiteControlModel> EctoparasiteControl
        {
            get
            {
                return ectoparasiteControl?.Count > 0 ? ectoparasiteControl :
                ectoparasiteControl = PopulateObjects(ReadWriteCSVFile.
                    ReadRootObjectFile<EctoparasiteControlModel>(Path.Combine(folderPath, "Ectoparasite_Control.csv")), "EC");
            }
        }

        private List<HatcheryInstitutionModel> hatcheryInstitutions = new List<HatcheryInstitutionModel>();
        public List<HatcheryInstitutionModel> HatcheryInstitutions
        {
            get
            {
                return hatcheryInstitutions?.Count > 0 ? hatcheryInstitutions :
                hatcheryInstitutions = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<HatcheryInstitutionModel>(Path.Combine(folderPath, "Hatchery_Institution.csv")), "HI");
            }
        }

        private List<LivestockFeedProcessingModel> livestockFeedProcessing = new List<LivestockFeedProcessingModel>();
        public List<LivestockFeedProcessingModel> LivestockFeedProcessing
        {
            get
            {
                return livestockFeedProcessing?.Count > 0 ? livestockFeedProcessing :
                livestockFeedProcessing = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<LivestockFeedProcessingModel>(Path.Combine(folderPath, "Livestock_Feed_Processing.csv")), "LF");
            }
        }

        private List<LivestockMarketModel> livestockMarkets = new List<LivestockMarketModel>();
        public List<LivestockMarketModel> LivestockMarkets
        {
            get
            {
                return livestockMarkets?.Count > 0 ? livestockMarkets :
                livestockMarkets = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<LivestockMarketModel>(Path.Combine(folderPath, "Livestock_Market.csv")), "LM");
            }
        }

        private List<LivestockMilkCoolingModel> livestockMilkCooling = new List<LivestockMilkCoolingModel>();
        public List<LivestockMilkCoolingModel> LivestockMilkCooling
        {
            get
            {
                return livestockMilkCooling?.Count > 0 ? livestockMilkCooling :
                livestockMilkCooling = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<LivestockMilkCoolingModel>(Path.Combine(folderPath, "Livestock_Milk_Cooling.csv")), "MC");
            }
        }

        private List<LivestockSlaughterModel> livestockSlaughter = new List<LivestockSlaughterModel>();
        public List<LivestockSlaughterModel> LivestockSlaughter
        {
            get
            {
                return livestockSlaughter?.Count > 0 ? livestockSlaughter :
                livestockSlaughter = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<LivestockSlaughterModel>(Path.Combine(folderPath, "Livestock_Slaughter.csv")), "LS");
            }
        }

        public List<LivestockSocietiesModel> livestockSocieties = new List<LivestockSocietiesModel>();
        public List<LivestockSocietiesModel> LivestockSocieties
        {
            get
            {
                return livestockSocieties?.Count > 0 ? livestockSocieties :
                livestockSocieties = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<LivestockSocietiesModel>(Path.Combine(folderPath, "Livestock_Societies.csv")), "SG");
            }
        }

        private List<MeatProcessingModel> meatProcessings = new List<MeatProcessingModel>();
        public List<MeatProcessingModel> MeatProcessings
        {
            get
            {
                return meatProcessings?.Count > 0 ? meatProcessings :
                meatProcessings = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<MeatProcessingModel>(Path.Combine(folderPath, "Meat_Processing_Facility.csv")), "MP");
            }
        }

        private List<MilkATMModel> milkATMs = new List<MilkATMModel>();
        public List<MilkATMModel> MilkATMs
        {
            get
            {
                return milkATMs?.Count > 0 ? milkATMs :
                milkATMs = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<MilkATMModel>(Path.Combine(folderPath, "milk_atms.csv")), "MA");
            }
        }

        private List<VaccinationSiteModel> vaccinationSites = new List<VaccinationSiteModel>();
        public List<VaccinationSiteModel> VaccinationSites
        {
            get
            {
                return vaccinationSites?.Count > 0 ? vaccinationSites :
                vaccinationSites = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<VaccinationSiteModel>(Path.Combine(folderPath, "Vaccination_Site.csv")), "VS");
            }
        }

        private List<WaterPointModel> waterPoints = new List<WaterPointModel>();
        public List<WaterPointModel> WaterPoints
        {
            get
            {
                return waterPoints?.Count > 0 ? waterPoints :
                waterPoints = PopulateObjects(ReadWriteCSVFile.
                ReadRootObjectFile<WaterPointModel>(Path.Combine(folderPath, "Water_Point.csv")), "WP");
            }
        }
    }
}
