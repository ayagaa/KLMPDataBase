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


        public List<WardCountyModel> WardsCounties
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<WardCountyModel>(Path.Combine(folderPath, "Ward_County.csv"));
            }
        }

        public List<AgroVetModel> AgroVets
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<AgroVetModel>(Path.Combine(folderPath, "agro_vet_facility.csv"));
            }
        }

        public List<BandasModel> Bandas
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<BandasModel>(Path.Combine(folderPath, "Bandas.csv"));
            }
        }

        public List<BeeKeepingWSModel> BeeKeepingWs
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<BeeKeepingWSModel>(Path.Combine(folderPath, "Bee_Keeping_WS.csv"));
            }
        }
        public List<BeeProductProcessingModel> BeeProductProcessing
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<BeeProductProcessingModel>(Path.Combine(folderPath, "Bee_Product_Processing.csv"));
            }
        }

        public List<EctoparasiteControlModel> EctoparasiteControl
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<EctoparasiteControlModel>(Path.Combine(folderPath, "Ectoparasite_Control.csv"));
            }
        }

        public List<HatcheryInstitutionModel> HatcheryInstitutions
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<HatcheryInstitutionModel>(Path.Combine(folderPath, "Hatchery_Institution.csv"));
            }
        }

        public List<LivestockFeedProcessingModel> LivestockFeedProcessing
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<LivestockFeedProcessingModel>(Path.Combine(folderPath, "Livestock_Feed_Processing.csv"));
            }
        }

        public List<LivestockMarketModel> LivestockMarkets
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<LivestockMarketModel>(Path.Combine(folderPath, "Livestock_Market.csv"));
            }
        }

        public List<LivestockMilkCoolingModel> LivestockMilkCooling
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<LivestockMilkCoolingModel>(Path.Combine(folderPath, "Livestock_Milk_Cooling.csv"));
            }
        }

        public List<LivestockSlaughterModel> LivestockSlaughter
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<LivestockSlaughterModel>(Path.Combine(folderPath, "Livestock_Slaughter.csv"));
            }
        }

        public List<LivestockSocietiesModel> LivestockSocieties
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<LivestockSocietiesModel>(Path.Combine(folderPath, "Livestock_Societies.csv"));
            }
        }

        public List<MeatProcessingModel> MeatProcessings
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<MeatProcessingModel>(Path.Combine(folderPath, "Meat_Processing_Facility.csv"));
            }
        }

        public List<MilkATMModel> MilkATMs
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<MilkATMModel>(Path.Combine(folderPath, "milk_atm.csv"));
            }
        }

        public List<VaccinationSiteModel> VaccinationSites
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<VaccinationSiteModel>(Path.Combine(folderPath, "Vaccination_Site.csv"));
            }
        }

        public List<WaterPointModel> WaterPoints
        {
            get
            {
                return ReadCSVFile.ReadRootObjectFile<WaterPointModel>(Path.Combine(folderPath, "Water_Point.csv"));
            }
        }
    }
}
