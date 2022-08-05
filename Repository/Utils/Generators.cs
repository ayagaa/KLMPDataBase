using KLMP.DataAccess.Repository.Models;
using KLMP.DataAccess.Repository.Models.CSVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Utils
{
    public class Generators
    {
        private FacilitiesDataModel facilitiesData;

        private string filePath = string.Empty;

        private List<WardCountyModel> wardsCounties = new List<WardCountyModel>();
        private List<AgroVetModel> agroVets = new List<AgroVetModel>();
        private List<BandasModel> bandas = new List<BandasModel>();
        private List<BeeKeepingWSModel> beeKeepingWs = new List<BeeKeepingWSModel>();
        private List<BeeProductProcessingModel> beeProductProcessings = new List<BeeProductProcessingModel>();
        private List<EctoparasiteControlModel> ectoparasiteControls = new List<EctoparasiteControlModel>();
        private List<HatcheryInstitutionModel> hatcheryInstitutions = new List<HatcheryInstitutionModel>();
        private List<LivestockFeedProcessingModel> livestockFeedProcessings = new List<LivestockFeedProcessingModel>();
        private List<LivestockMarketModel> livestockMarkets = new List<LivestockMarketModel>();
        private List<LivestockMilkCoolingModel> livestockMilkCoolings = new List<LivestockMilkCoolingModel>();
        private List<LivestockSlaughterModel> livestockSlaughters = new List<LivestockSlaughterModel>();
        private List<LivestockSocietiesModel> livestockSocieties = new List<LivestockSocietiesModel>();
        private List<MeatProcessingModel> meatProcessings = new List<MeatProcessingModel>();
        private List<MilkATMModel> milkATMs = new List<MilkATMModel>();
        private List<VaccinationSiteModel> vaccinationSites = new List<VaccinationSiteModel>();
        private List<WaterPointModel> waterPoints = new List<WaterPointModel>();
        public Generators(string filePath)
        {
            this.filePath = filePath;
            facilitiesData = new FacilitiesDataModel(filePath);
            wardsCounties = facilitiesData.WardsCounties;
            agroVets = facilitiesData.AgroVets.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            bandas = facilitiesData.Bandas.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            beeKeepingWs = facilitiesData.BeeKeepingWs.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            beeProductProcessings = facilitiesData.BeeProductProcessing.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            ectoparasiteControls = facilitiesData.EctoparasiteControl.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            hatcheryInstitutions = facilitiesData.HatcheryInstitutions.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            livestockFeedProcessings = facilitiesData.LivestockFeedProcessing.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            livestockMarkets = facilitiesData.LivestockMarkets.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            livestockSocieties = facilitiesData.LivestockSocieties.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            livestockMilkCoolings = facilitiesData.LivestockMilkCooling.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            livestockSlaughters = facilitiesData.LivestockSlaughter.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            meatProcessings = facilitiesData.MeatProcessings.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            milkATMs = facilitiesData.MilkATMs.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            vaccinationSites = facilitiesData.VaccinationSites.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
            waterPoints = facilitiesData.WaterPoints.
                Where(f => !string.IsNullOrEmpty(f.facility_id) && !string.IsNullOrEmpty(f.ward_name)).ToList();
        }

        private void WriteToConsole(string facilityType, int recordCount)
        {
            Console.WriteLine(string.Format("Facility type: {0} has record count: {1}", facilityType, recordCount));
        }

        public void ShowStatistics()
        {
            if (facilitiesData.AgroVets != null)
            {
                WriteToConsole("Agro-Vet Facilities", agroVets.Count);
            }
            if (facilitiesData.Bandas != null)
            {
                WriteToConsole("Bandas Facilities", bandas.Count);
            }
            if (facilitiesData.BeeKeepingWs != null)
            {
                WriteToConsole("Bee Keeping Workshops", beeKeepingWs.Count);
            }
            if (facilitiesData.BeeProductProcessing != null)
            {
                WriteToConsole("Bee Product Processing Facilities", beeProductProcessings.Count);
            }
            if (facilitiesData.EctoparasiteControl != null)
            {
                WriteToConsole("Ectoparasite Control Facilities", ectoparasiteControls.Count);
            }
            if (facilitiesData.HatcheryInstitutions != null)
            {
                WriteToConsole("Hatchery Institution Facilities", hatcheryInstitutions.Count);
            }
            if (facilitiesData.LivestockFeedProcessing != null)
            {
                WriteToConsole("Livestock Feed Processing Facilities", livestockFeedProcessings.Count);
            }
            if (facilitiesData.LivestockMarkets != null)
            {
                WriteToConsole("Livestock Market Facilities", livestockMarkets.Count);
            }
            if (facilitiesData.LivestockMilkCooling != null)
            {
                WriteToConsole("Milk Cooling Facilities", livestockMilkCoolings.Count);
            }
            if (facilitiesData.LivestockSlaughter != null)
            {
                WriteToConsole("Slaughter Facilities", livestockSlaughters.Count);
            }
            if (facilitiesData.LivestockSocieties != null)
            {
                WriteToConsole("Societies and Groups", livestockSocieties.Count);
            }
            if (facilitiesData.MeatProcessings != null)
            {
                WriteToConsole("Meat Processing Facilities", facilitiesData.MeatProcessings.Count);
            }
            if (facilitiesData.MilkATMs != null)
            {
                WriteToConsole("Milk ATM Facilities", facilitiesData.MilkATMs.Count);
            }
            if (facilitiesData.VaccinationSites != null)
            {
                WriteToConsole("Vaccination Site Facilities", facilitiesData.VaccinationSites.Count);
            }
            if (facilitiesData.WaterPoints != null)
            {
                WriteToConsole("Water Point Facilities", facilitiesData.WaterPoints.Count);
            }
        }

        public bool WriteToFiles(string outputfilePath)
        {
            try
            {
                Console.WriteLine(string.Format("Writing data to folder: {0}", outputfilePath));
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "agro_vet_facility.csv"), agroVets);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Bandas.csv"), bandas);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Bee_Keeping_WS.csv"), beeKeepingWs);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Bee_Product_Processing.csv"), beeProductProcessings);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Ectoparasite_Control.csv"), ectoparasiteControls);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Hatchery_Institution.csv"), hatcheryInstitutions);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Livestock_Feed_Processing.csv"), livestockFeedProcessings);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Livestock_Market.csv"), livestockMarkets);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Livestock_Milk_Cooling.csv"), livestockMilkCoolings);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Livestock_Slaughter.csv"), livestockSlaughters);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Livestock_Societies.csv"), livestockSocieties);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Meat_Processing_Facility.csv"), meatProcessings);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "milk_atms.csv"), milkATMs);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Vaccination_Site.csv"), vaccinationSites);
                ReadWriteCSVFile.WriteRootObjectFile(Path.Combine(outputfilePath, "Water_Point.csv"), waterPoints);
                Console.WriteLine(string.Format("Completed to write data to folder: {0}", outputfilePath));
                return true;
            }
            catch (Exception)
            {
            }

            return false;
        }

        public List<TblFacilityActivityPeriod> GetTblFacilityActivityPeriods()
        {
            var facilityActivities = new List<TblFacilityActivityPeriod>();

            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Monday == 1 ? "Monday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Tuesday == 1 ? "Tuesday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Wednesday == 1 ? "Wednesday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Thursday == 1 ? "Thursday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Friday == 1 ? "Friday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Saturday == 1 ? "Saturday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.am_Sunday == 1 ? "Sunday" : string.Empty,
                    });
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockMarket in livestockSlaughters)
                {
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Monday == 1 ? "Monday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Tuesday == 1 ? "Tuesday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Wednesday == 1 ? "Wednesday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Thursday == 1 ? "Thursday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Friday == 1 ? "Friday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Saturday == 1 ? "Saturday" : string.Empty,
                    });
                    facilityActivities.Add(new TblFacilityActivityPeriod
                    {
                        FacilityId = livestockMarket.facility_id,
                        PeriodDescription = livestockMarket.ap_Sunday == 1 ? "Sunday" : string.Empty,
                    });
                }
            }
            return facilityActivities;
        }

        public List<TblFacilityAmenity> GetTblFacilityAmenities()
        {
            var facilityAmenities = new List<TblFacilityAmenity>();

            if (agroVets?.Count > 0)
            {
                foreach (var agroVet in agroVets)
                {
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = agroVet.facility_id,
                        AmenityDescription = agroVet.am_Advisory_Services == 1 ? "Advisory Services" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = agroVet.facility_id,
                        AmenityDescription = agroVet.am_AI_services == 1 ? "AI Services" : String.Empty,
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = agroVet.facility_id,
                        AmenityDescription = agroVet.am_Animal_feeds == 1 ? "Animal Feeds Services" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = agroVet.facility_id,
                        AmenityDescription = agroVet.am_Equipment_and_machinery == 1 ? "Equipment and Machinary Services" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = agroVet.facility_id,
                        AmenityDescription = agroVet.am_Sales_of_veterinary_pharmaceuticals == 1 ? "Sales of Vetinary Pharmaceuticals Services" : String.Empty
                    });
                }
            }
            if (beeKeepingWs?.Count > 0)
            {
                foreach (var beeWS in beeKeepingWs)
                {
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Beesuit == 1 ? "Bee Equipment Beesuit" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Bee_brush == 1 ? "Bee Equipment Bee Brush" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Box_hive == 1 ? "Bee Equipment Box Hive" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Flow_hive == 1 ? "Bee Equipment Flow Hive" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Gloves == 1 ? "Bee Equipment Gloves" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Hive_knife == 1 ? "Bee Equipment Hive Knife" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_KTBH == 1 ? "Bee Equipment KTBH" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Longstroth_hive == 1 ? "Bee Equipment Longstroth Hive" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Smoker == 1 ? "Bee Equipment Smoker" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Traditional_log_hive == 1 ? "Bee Equipment Traditional Long Hive" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = beeWS.facility_id,
                        AmenityDescription = beeWS.am_Beekeeping_equipment_Veil == 1 ? "Bee Equipment Veil" : String.Empty
                    });
                }
            }
            if (hatcheryInstitutions?.Count > 0)
            {
                foreach (var hatcheryInstitute in hatcheryInstitutions)
                {
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                        AmenityDescription = hatcheryInstitute.am_Hatchery_Type_Broiler == 1 ? "Broiler Hatchery" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                        AmenityDescription = hatcheryInstitute.am_Hatchery_Type_Kienyeji == 1 ? "Kienyeji Hatchery" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                        AmenityDescription = hatcheryInstitute.am_Hatchery_Type_Layer == 1 ? "Broiler Layer" : String.Empty
                    });
                }
            }
            if (livestockFeedProcessings?.Count > 0)
            {
                foreach (var livestockFeedProcessing in livestockFeedProcessings)
                {

                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockFeedProcessing.facility_id,
                        AmenityDescription = livestockFeedProcessing.am_Products_processed
                    });
                }
            }
            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Agrovet_shop == 1 ? "Agrovet Shop" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Crushes == 1 ? "Crushes" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Loading_ramp == 1 ? "Loading Ramp" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Mpesa_shop == 1 ? "Mpesa Shop" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Offloading_ramp == 1 ? "Offloading Ramp" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = string.IsNullOrEmpty(livestockMarket.am_Other_Available_Facility) ? String.Format("Other Facility Type {0}", livestockMarket.am_Other_Available_Facility) : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Quarantine_facility == 1 ? "Quarantine Facility" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Sanitary_facilities_Toilet_Water == 1 ? "Toilet Water" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockMarket.facility_id,
                        AmenityDescription = livestockMarket.am_Offloading_ramp == 1 ? "Offloading Ramp" : String.Empty
                    });
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockSlaughter in livestockSlaughters)
                {
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Agrovet_shop == 1 ? "Agrovet Shop" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Crushes == 1 ? "Crushes" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Loading_ramp == 1 ? "Loading Ramp" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Mpesa_shop == 1 ? "Mpesa Shop" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Offloading_ramp == 1 ? "Offloading Ramp" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Other == 1 ? "Other Facilty Available" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Quarantine_facility == 1 ? "Quarentine Facility" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Sanitary_facilities_Toilet__Water == 1 ? "Sanitary Facilities Toilet and Water" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Waiting_bay == 1 ? "Waiting Bay" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Watering_points == 1 ? "Watering Points" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        AmenityDescription = livestockSlaughter.am_Weighing_scales == 1 ? "Weighing Scales" : String.Empty
                    });
                }
            }
            if (waterPoints?.Count > 0)
            {
                foreach (var waterPoint in waterPoints)
                {
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = waterPoint.facility_id,
                        AmenityDescription = waterPoint.am_Source_of_power_Electricity == 1 ? "Power source Electricity" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = waterPoint.facility_id,
                        AmenityDescription = waterPoint.am_Source_of_power_Other == 1 ? "Other source Electricity" : String.Empty
                    });
                    facilityAmenities.Add(new TblFacilityAmenity
                    {
                        FacilityId = waterPoint.facility_id,
                        AmenityDescription = waterPoint.am_Source_of_power_Solar == 1 ? "Power source Solar" : String.Empty
                    });
                }
            }
            return facilityAmenities;
        }

        public List<TblFacilityContactPerson> GetTblFacilityContacts()
        {
            var facilityContacts = new List<TblFacilityContactPerson>();

            if (agroVets?.Count > 0)
            {
                foreach (var agroVet in agroVets)
                {
                    int wardId = 0;
                    int.TryParse(agroVet.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = agroVet.facility_id,
                        ContactPerson = agroVet.contact_person,
                        CountyId = agroVet.county_id,
                        WardId = wardId,
                        PhoneNumber = agroVet?.phone_number.ToString(),
                        ContactType = agroVet?.facility_type
                    });
                }
            }
            if (beeKeepingWs?.Count > 0)
            {
                foreach (var beeWS in beeKeepingWs)
                {
                    int wardId = 0;
                    int.TryParse(beeWS.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = beeWS.facility_id,
                        ContactPerson = beeWS.contact_person,
                        CountyId = beeWS.county_id,
                        WardId = wardId,
                        PhoneNumber = beeWS?.phone_number.ToString(),
                        ContactType = beeWS?.facility_type
                    });
                }
            }
            if (beeProductProcessings?.Count > 0)
            {
                foreach (var beeProducts in beeProductProcessings)
                {
                    int wardId = 0;
                    int.TryParse(beeProducts.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = beeProducts.facility_id,
                        ContactPerson = beeProducts.contact_person,
                        CountyId = beeProducts.county_id,
                        WardId = wardId,
                        PhoneNumber = beeProducts?.phone_number.ToString(),
                        ContactType = beeProducts?.facility_type
                    });
                }
            }
            if (ectoparasiteControls?.Count > 0)
            {
                foreach (var ectoParasiteControl in ectoparasiteControls)
                {
                    int wardId = 0;
                    int.TryParse(ectoParasiteControl.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = ectoParasiteControl.facility_id,
                        ContactPerson = ectoParasiteControl.contact_person,
                        CountyId = ectoParasiteControl.county_id,
                        WardId = wardId,
                        PhoneNumber = ectoParasiteControl?.phone_number.ToString(),
                        ContactType = ectoParasiteControl?.facility_type
                    });
                }
            }
            if (hatcheryInstitutions?.Count > 0)
            {
                foreach (var hatcheryInstitute in hatcheryInstitutions)
                {
                    int wardId = 0;
                    int.TryParse(hatcheryInstitute.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                        ContactPerson = hatcheryInstitute.contact_person,
                        CountyId = hatcheryInstitute.county_id,
                        WardId = wardId,
                        PhoneNumber = hatcheryInstitute?.phone_number.ToString(),
                        ContactType = hatcheryInstitute?.facility_type
                    });
                }
            }
            if (livestockFeedProcessings?.Count > 0)
            {
                foreach (var livestockFeedProcessing in livestockFeedProcessings)
                {

                    int wardId = 0;
                    int.TryParse(livestockFeedProcessing.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = livestockFeedProcessing.facility_id,
                        ContactPerson = livestockFeedProcessing.contact_person,
                        CountyId = livestockFeedProcessing.county_id,
                        WardId = wardId,
                        PhoneNumber = livestockFeedProcessing?.phone_number.ToString(),
                        ContactType = livestockFeedProcessing?.facility_type
                    });

                }
            }
            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    int wardId = 0;
                    int.TryParse(livestockMarket.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = livestockMarket.facility_id,
                        ContactPerson = livestockMarket.contact_person,
                        CountyId = livestockMarket.county_id,
                        WardId = wardId,
                        PhoneNumber = livestockMarket?.phone_number.ToString(),
                        ContactType = livestockMarket?.facility_type
                    });
                }
            }
            if (livestockMilkCoolings?.Count > 0)
            {
                foreach (var milkCooling in livestockMilkCoolings)
                {
                    int wardId = 0;
                    int.TryParse(milkCooling.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = milkCooling.facility_id,
                        ContactPerson = milkCooling.contact_person,
                        CountyId = milkCooling.county_id,
                        WardId = wardId,
                        PhoneNumber = milkCooling?.phone_number.ToString(),
                        ContactType = milkCooling?.facility_type
                    });
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockSlaughter in livestockSlaughters)
                {
                    int wardId = 0;
                    int.TryParse(livestockSlaughter.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        ContactPerson = livestockSlaughter.contact_person,
                        CountyId = livestockSlaughter.county_id,
                        WardId = wardId,
                        PhoneNumber = livestockSlaughter?.phone_number.ToString(),
                        ContactType = livestockSlaughter?.facility_type
                    });
                }
            }
            if (facilitiesData.LivestockSocieties != null)
            {
                foreach (var livestockSociety in livestockSocieties)
                {
                    int wardId = 0;
                    int.TryParse(livestockSociety.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = livestockSociety.facility_id,
                        ContactPerson = livestockSociety.contact_person,
                        CountyId = livestockSociety.county_id,
                        WardId = wardId,
                        PhoneNumber = livestockSociety?.phone_number.ToString(),
                        ContactType = livestockSociety?.facility_type
                    });
                }
            }
            if (meatProcessings?.Count > 0)
            {
                foreach (var meatProcessing in meatProcessings)
                {
                    int wardId = 0;
                    int.TryParse(meatProcessing.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = meatProcessing.facility_id,
                        ContactPerson = meatProcessing.contact_person,
                        CountyId = meatProcessing.county_id,
                        WardId = wardId,
                        PhoneNumber = meatProcessing?.phone_number.ToString(),
                        ContactType = meatProcessing?.facility_type
                    });
                }
            }
            if (milkATMs?.Count > 0)
            {
                foreach (var milkATM in milkATMs)
                {
                    int wardId = 0;
                    int.TryParse(milkATM.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = milkATM.facility_id,
                        ContactPerson = milkATM.contact_person,
                        CountyId = milkATM.county_id,
                        WardId = wardId,
                        PhoneNumber = milkATM?.phone_number.ToString(),
                        ContactType = milkATM?.facility_type
                    });
                }
            }
            if (vaccinationSites?.Count > 0)
            {
                foreach (var vaccinationSite in vaccinationSites)
                {
                    int wardId = 0;
                    int.TryParse(vaccinationSite.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = vaccinationSite.facility_id,
                        ContactPerson = vaccinationSite.contact_person,
                        CountyId = vaccinationSite.county_id,
                        WardId = wardId,
                        PhoneNumber = vaccinationSite?.phone_number.ToString(),
                        ContactType = vaccinationSite?.facility_type
                    });
                }
            }
            if (waterPoints?.Count > 0)
            {
                foreach (var waterPoint in waterPoints)
                {
                    int wardId = 0;
                    int.TryParse(waterPoint.ward_id.ToString(), out wardId);
                    facilityContacts.Add(new TblFacilityContactPerson
                    {
                        FacilityId = waterPoint.facility_id,
                        ContactPerson = waterPoint.contact_person,
                        CountyId = waterPoint.county_id,
                        WardId = wardId,
                        PhoneNumber = waterPoint?.phone_number.ToString(),
                        ContactType = waterPoint?.facility_type
                    });
                }
            }
            return facilityContacts;
        }

        public List<TblFacilityDescription> GetFacilityDescriptions()
        {
            var facilityDescriptions = new List<TblFacilityDescription>();

            if (agroVets?.Count > 0)
            {
                foreach (var agroVet in agroVets)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = agroVet.facility_id,
                    });
                }
            }
            if (beeKeepingWs?.Count > 0)
            {
                foreach (var beeWS in beeKeepingWs)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = beeWS.facility_id,
                    });
                }
            }
            if (beeProductProcessings?.Count > 0)
            {
                foreach (var beeProducts in beeProductProcessings)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = beeProducts.facility_id
                    });
                }
            }
            if (ectoparasiteControls?.Count > 0)
            {
                foreach (var ectoParasiteControl in ectoparasiteControls)
                {

                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = ectoParasiteControl.facility_id,
                    });
                }
            }
            if (hatcheryInstitutions?.Count > 0)
            {
                foreach (var hatcheryInstitute in hatcheryInstitutions)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                    });
                }
            }
            if (livestockFeedProcessings?.Count > 0)
            {
                foreach (var livestockFeedProcessing in livestockFeedProcessings)
                {

                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = livestockFeedProcessing.facility_id,
                    });
                }
            }
            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = livestockMarket.facility_id,
                    });
                }
            }
            if (livestockMilkCoolings?.Count > 0)
            {
                foreach (var livestockCooling in livestockMilkCoolings)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = livestockCooling.facility_id,
                    });
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockSlaughter in livestockSlaughters)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = livestockSlaughter.facility_id,
                    });
                }
            }
            if (facilitiesData.LivestockSocieties != null)
            {
                foreach (var livestockSociety in livestockSocieties)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = livestockSociety.facility_id,
                    });
                }
            }
            if (meatProcessings?.Count > 0)
            {
                foreach (var meatProcessing in meatProcessings)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = meatProcessing.facility_id,
                    });
                }
            }
            if (milkATMs?.Count > 0)
            {
                foreach (var milkATM in milkATMs)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = milkATM.facility_id,
                    });
                }
            }
            if (vaccinationSites?.Count > 0)
            {
                foreach (var vaccinationSite in vaccinationSites)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = vaccinationSite.facility_id,
                    });
                }
            }
            if (waterPoints?.Count > 0)
            {
                foreach (var waterPoint in waterPoints)
                {
                    facilityDescriptions.Add(new TblFacilityDescription
                    {
                        FacilityId = waterPoint.facility_id,
                    });
                }
            }
            return facilityDescriptions;
        }

        public List<TblFacilityMetric> GetFacilityMetrics()
        {
            var facilityMetrics = new List<TblFacilityMetric>();

            if (agroVets?.Count > 0)
            {
                foreach (var agroVet in agroVets)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = agroVet.facility_id,
                    });
                }
            }
            if (beeKeepingWs?.Count > 0)
            {
                foreach (var beeWS in beeKeepingWs)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = beeWS.facility_id,
                    });
                }
            }
            if (beeProductProcessings?.Count > 0)
            {
                foreach (var beeProducts in beeProductProcessings)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = beeProducts.facility_id
                    });
                }
            }
            if (ectoparasiteControls?.Count > 0)
            {
                foreach (var ectoParasiteControl in ectoparasiteControls)
                {

                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = ectoParasiteControl.facility_id,
                    });
                }
            }
            if (hatcheryInstitutions?.Count > 0)
            {
                foreach (var hatcheryInstitute in hatcheryInstitutions)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                    });
                }
            }
            if (livestockFeedProcessings?.Count > 0)
            {
                foreach (var livestockFeedProcessing in livestockFeedProcessings)
                {

                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = livestockFeedProcessing.facility_id,
                    });
                }
            }
            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = livestockMarket.facility_id,
                    });
                }
            }
            if (livestockMilkCoolings?.Count > 0)
            {
                foreach (var livestockCooling in livestockMilkCoolings)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = livestockCooling.facility_id,


                    });
                    ;
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockSlaughter in livestockSlaughters)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = livestockSlaughter.facility_id,
                    });
                }
            }
            if (facilitiesData.LivestockSocieties != null)
            {
                foreach (var livestockSociety in livestockSocieties)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = livestockSociety.facility_id,
                    });
                }
            }
            if (meatProcessings?.Count > 0)
            {
                foreach (var meatProcessing in meatProcessings)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = meatProcessing.facility_id,
                    });
                }
            }
            if (milkATMs?.Count > 0)
            {
                foreach (var milkATM in milkATMs)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = milkATM.facility_id,
                    });
                }
            }
            if (vaccinationSites?.Count > 0)
            {
                foreach (var vaccinationSite in vaccinationSites)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = vaccinationSite.facility_id,
                    });
                }
            }
            if (waterPoints?.Count > 0)
            {
                foreach (var waterPoint in waterPoints)
                {
                    facilityMetrics.Add(new TblFacilityMetric
                    {
                        FacilityId = waterPoint.facility_id,
                    });
                }
            }
            return facilityMetrics;
        }

        public List<TblFacilityProfile> GetFacilityProfiles()
        {
            var facilityProfiles = new List<TblFacilityProfile>();
            int wardId = 0;
            float altitude = 0;
            float latitude = 0;
            float longitude = 0;
            if (agroVets?.Count > 0)
            {
                foreach (var agroVet in agroVets)
                {
                    int.TryParse(agroVet.ward_id.ToString(), out wardId);
                    float.TryParse(agroVet.altitude.ToString(), out altitude);
                    float.TryParse(agroVet.latitude.ToString(), out latitude);
                    float.TryParse(agroVet.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = agroVet.facility_id,
                        FacilityType = agroVet.facility_type,
                        FacilityName = !string.IsNullOrEmpty(agroVet.facility_name) ? agroVet.facility_name : agroVet.facility_type,
                        FacilityOwnership = agroVet.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = agroVet.precision.ToString(),
                    });
                }
            }
            if (bandas?.Count > 0)
            {
                foreach (var banda in bandas)
                {
                    int.TryParse(banda.ward_id.ToString(), out wardId);
                    float.TryParse(banda.altitude.ToString(), out altitude);
                    float.TryParse(banda.latitude.ToString(), out latitude);
                    float.TryParse(banda.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = banda.facility_id,
                        FacilityType = banda.facility_type,
                        FacilityName = !string.IsNullOrEmpty(banda.facility_name) ? banda.facility_name : banda.facility_type,
                        FacilityOwnership = banda.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = banda.precision.ToString(),
                    });
                }
            }
            if (beeKeepingWs?.Count > 0)
            {
                foreach (var beeWS in beeKeepingWs)
                {
                    int.TryParse(beeWS.ward_id.ToString(), out wardId);
                    float.TryParse(beeWS.altitude.ToString(), out altitude);
                    float.TryParse(beeWS.latitude.ToString(), out latitude);
                    float.TryParse(beeWS.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = beeWS.facility_id,
                        FacilityType = beeWS.facility_type,
                        FacilityName = !string.IsNullOrEmpty(beeWS.facility_name) ? beeWS.facility_name : beeWS.facility_type,
                        FacilityOwnership = beeWS.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = beeWS.precision.ToString(),
                    });
                }
            }
            if (beeProductProcessings?.Count > 0)
            {
                foreach (var beeProducts in beeProductProcessings)
                {
                    int.TryParse(beeProducts.ward_id.ToString(), out wardId);
                    float.TryParse(beeProducts.altitude.ToString(), out altitude);
                    float.TryParse(beeProducts.latitude.ToString(), out latitude);
                    float.TryParse(beeProducts.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = beeProducts.facility_id,
                        FacilityType = beeProducts.facility_type,
                        FacilityName = !string.IsNullOrEmpty(beeProducts.facility_name) ? beeProducts.facility_name : beeProducts.facility_type,
                        FacilityOwnership = beeProducts.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = beeProducts.precision.ToString(),
                    });
                }
            }
            if (ectoparasiteControls?.Count > 0)
            {
                foreach (var ectoParasiteControl in ectoparasiteControls)
                {
                    int.TryParse(ectoParasiteControl.ward_id.ToString(), out wardId);
                    float.TryParse(ectoParasiteControl.altitude.ToString(), out altitude);
                    float.TryParse(ectoParasiteControl.latitude.ToString(), out latitude);
                    float.TryParse(ectoParasiteControl.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = ectoParasiteControl.facility_id,
                        FacilityType = ectoParasiteControl.facility_type,
                        FacilityName = !string.IsNullOrEmpty(ectoParasiteControl.facility_name) ? ectoParasiteControl.facility_name : ectoParasiteControl.facility_type,
                        FacilityOwnership = ectoParasiteControl.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = ectoParasiteControl.precision.ToString(),
                    });
                }
            }
            if (hatcheryInstitutions?.Count > 0)
            {
                foreach (var hatcheryInstitute in hatcheryInstitutions)
                {
                    int.TryParse(hatcheryInstitute.ward_id.ToString(), out wardId);
                    float.TryParse(hatcheryInstitute.altitude.ToString(), out altitude);
                    float.TryParse(hatcheryInstitute.latitude.ToString(), out latitude);
                    float.TryParse(hatcheryInstitute.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                        FacilityType = hatcheryInstitute.facility_type,
                        FacilityName = hatcheryInstitute.facility_type,
                        FacilityOwnership = hatcheryInstitute.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = hatcheryInstitute.precision.ToString(),
                    });
                }
            }
            if (livestockFeedProcessings?.Count > 0)
            {
                foreach (var livestockFeedProcessing in livestockFeedProcessings)
                {
                    int.TryParse(livestockFeedProcessing.ward_id.ToString(), out wardId);
                    float.TryParse(livestockFeedProcessing.altitude.ToString(), out altitude);
                    float.TryParse(livestockFeedProcessing.latitude.ToString(), out latitude);
                    float.TryParse(livestockFeedProcessing.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = livestockFeedProcessing.facility_id,
                        FacilityType = livestockFeedProcessing.facility_type,
                        FacilityName = !string.IsNullOrEmpty(livestockFeedProcessing.facility_name) ? livestockFeedProcessing.facility_name : livestockFeedProcessing.facility_type,
                        FacilityOwnership = livestockFeedProcessing.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = livestockFeedProcessing.precision.ToString(),
                    });
                }
            }
            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    int.TryParse(livestockMarket.ward_id.ToString(), out wardId);
                    float.TryParse(livestockMarket.altitude.ToString(), out altitude);
                    float.TryParse(livestockMarket.latitude.ToString(), out latitude);
                    float.TryParse(livestockMarket.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = livestockMarket.facility_id,
                        FacilityType = livestockMarket.facility_type,
                        FacilityOwnership = livestockMarket.facility_ownership,
                        FacilityName = !string.IsNullOrEmpty(livestockMarket.facility_name) ? livestockMarket.facility_name : livestockMarket.facility_type,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = livestockMarket.precision.ToString(),
                    });
                }
            }
            if (livestockMilkCoolings?.Count > 0)
            {
                foreach (var livestockCooling in livestockMilkCoolings)
                {
                    int.TryParse(livestockCooling.ward_id.ToString(), out wardId);
                    float.TryParse(livestockCooling.altitude.ToString(), out altitude);
                    float.TryParse(livestockCooling.latitude.ToString(), out latitude);
                    float.TryParse(livestockCooling.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = livestockCooling.facility_id,
                        FacilityType = livestockCooling.facility_type,
                        FacilityName = !string.IsNullOrEmpty(livestockCooling.facility_name) ? livestockCooling.facility_name : livestockCooling.facility_type,
                        FacilityOwnership = livestockCooling.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = livestockCooling.precision.ToString(),
                    });
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockSlaughter in livestockSlaughters)
                {
                    int.TryParse(livestockSlaughter.ward_id.ToString(), out wardId);
                    float.TryParse(livestockSlaughter.altitude.ToString(), out altitude);
                    float.TryParse(livestockSlaughter.latitude.ToString(), out latitude);
                    float.TryParse(livestockSlaughter.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = livestockSlaughter.facility_id,
                        FacilityType = livestockSlaughter.facility_type,
                        FacilityName = !string.IsNullOrEmpty(livestockSlaughter.facility_name) ? livestockSlaughter.facility_name : livestockSlaughter.facility_type,
                        FacilityOwnership = livestockSlaughter.facility_ownership,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = livestockSlaughter.precision.ToString(),
                    });
                }
            }
            if (facilitiesData.LivestockSocieties != null)
            {
                foreach (var livestockSociety in livestockSocieties)
                {
                    int.TryParse(livestockSociety.ward_id.ToString(), out wardId);
                    float.TryParse(livestockSociety.altitude.ToString(), out altitude);
                    float.TryParse(livestockSociety.latitude.ToString(), out latitude);
                    float.TryParse(livestockSociety.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = livestockSociety.facility_id,
                        FacilityType = livestockSociety.facility_type,
                        FacilityName = !string.IsNullOrEmpty(livestockSociety.facility_name) ? livestockSociety.facility_name : livestockSociety.facility_type,
                        FacilityOwnership = String.Empty,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = livestockSociety.precision.ToString(),
                    });
                }
            }
            if (meatProcessings?.Count > 0)
            {
                foreach (var meatProcessing in meatProcessings)
                {
                    int.TryParse(meatProcessing.ward_id.ToString(), out wardId);
                    float.TryParse(meatProcessing.altitude.ToString(), out altitude);
                    float.TryParse(meatProcessing.latitude.ToString(), out latitude);
                    float.TryParse(meatProcessing.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = meatProcessing.facility_id,
                        FacilityType = meatProcessing.facility_type,
                        FacilityName = !string.IsNullOrEmpty(meatProcessing.facility_name) ? meatProcessing.facility_name : meatProcessing.facility_type,
                        FacilityOwnership = String.Empty,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = meatProcessing.precision.ToString(),
                    });
                }
            }
            if (milkATMs?.Count > 0)
            {
                foreach (var milkATM in milkATMs)
                {
                    int.TryParse(milkATM.ward_id.ToString(), out wardId);
                    float.TryParse(milkATM.altitude.ToString(), out altitude);
                    float.TryParse(milkATM.latitude.ToString(), out latitude);
                    float.TryParse(milkATM.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = milkATM.facility_id,
                        FacilityType = milkATM.facility_type,
                        FacilityName = !string.IsNullOrEmpty(milkATM.facility_name) ? milkATM.facility_name : milkATM.facility_type,
                        FacilityOwnership = String.Empty,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = milkATM.precision.ToString(),
                    });
                }
            }
            if (vaccinationSites?.Count > 0)
            {
                foreach (var vaccinationSite in vaccinationSites)
                {
                    int.TryParse(vaccinationSite.ward_id.ToString(), out wardId);
                    float.TryParse(vaccinationSite.altitude.ToString(), out altitude);
                    float.TryParse(vaccinationSite.latitude.ToString(), out latitude);
                    float.TryParse(vaccinationSite.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = vaccinationSite.facility_id,
                        FacilityType = vaccinationSite.facility_type,
                        FacilityName = !string.IsNullOrEmpty(vaccinationSite.facility_name) ? vaccinationSite.facility_name : vaccinationSite.facility_type,
                        FacilityOwnership = String.Empty,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = vaccinationSite.precision.ToString(),
                    });
                }
            }
            if (waterPoints?.Count > 0)
            {
                foreach (var waterPoint in waterPoints)
                {
                    int.TryParse(waterPoint.ward_id.ToString(), out wardId);
                    float.TryParse(waterPoint.altitude.ToString(), out altitude);
                    float.TryParse(waterPoint.latitude.ToString(), out latitude);
                    float.TryParse(waterPoint.longitude.ToString(), out longitude);

                    facilityProfiles.Add(new TblFacilityProfile
                    {
                        FacilityId = waterPoint.facility_id,
                        FacilityType = waterPoint.facility_type,
                        FacilityName = waterPoint.facility_type,
                        FacilityOwnership = String.Empty,
                        WardId = wardId,
                        Altitude = altitude,
                        Latitude = latitude,
                        Longitude = longitude,
                        Precision = waterPoint.precision.ToString(),
                    });
                }
            }
            return facilityProfiles.Where(f => f.FacilityId != null).ToList();
        }

        public List<TblFacilityValueChain> GetValueChains()
        {
            var facilityValueChains = new List<TblFacilityValueChain>();

            if (agroVets?.Count > 0)
            {
                foreach (var agroVet in agroVets)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = agroVet.facility_id,
                    });
                }
            }
            if (beeKeepingWs?.Count > 0)
            {
                foreach (var beeWS in beeKeepingWs)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = beeWS.facility_id,
                    });
                }
            }
            if (beeProductProcessings?.Count > 0)
            {
                foreach (var beeProducts in beeProductProcessings)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = beeProducts.facility_id
                    });
                }
            }
            if (ectoparasiteControls?.Count > 0)
            {
                foreach (var ectoParasiteControl in ectoparasiteControls)
                {

                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = ectoParasiteControl.facility_id,
                    });
                }
            }
            if (hatcheryInstitutions?.Count > 0)
            {
                foreach (var hatcheryInstitute in hatcheryInstitutions)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = hatcheryInstitute.facility_id,
                    });
                }
            }
            if (livestockFeedProcessings?.Count > 0)
            {
                foreach (var livestockFeedProcessing in livestockFeedProcessings)
                {

                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = livestockFeedProcessing.facility_id,
                    });
                }
            }
            if (livestockMarkets?.Count > 0)
            {
                foreach (var livestockMarket in livestockMarkets)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = livestockMarket.facility_id,
                    });
                }
            }
            if (livestockMilkCoolings?.Count > 0)
            {
                foreach (var livestockCooling in livestockMilkCoolings)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = livestockCooling.facility_id,
                    });
                }
            }
            if (livestockSlaughters?.Count > 0)
            {
                foreach (var livestockSlaughter in livestockSlaughters)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = livestockSlaughter.facility_id,
                    });
                }
            }
            if (facilitiesData.LivestockSocieties != null)
            {
                foreach (var livestockSociety in livestockSocieties)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = livestockSociety.facility_id,
                    });
                }
            }
            if (meatProcessings?.Count > 0)
            {
                foreach (var meatProcessing in meatProcessings)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = meatProcessing.facility_id,
                    });
                }
            }
            if (milkATMs?.Count > 0)
            {
                foreach (var milkATM in milkATMs)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = milkATM.facility_id,
                    });
                }
            }
            if (vaccinationSites?.Count > 0)
            {
                foreach (var vaccinationSite in vaccinationSites)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = vaccinationSite.facility_id,
                    });
                }
            }
            if (waterPoints?.Count > 0)
            {
                foreach (var waterPoint in waterPoints)
                {
                    facilityValueChains.Add(new TblFacilityValueChain
                    {
                        FacilityId = waterPoint.facility_id,
                    });
                }
            }
            return facilityValueChains;
        }

        public List<WardCountyModel> GetWardCounties()
        {
            return facilitiesData.WardsCounties;
        }

        public List<TblWard> GetWards()
        {
            var wards = new List<TblWard>();



            return wards;

        }
    }
}
