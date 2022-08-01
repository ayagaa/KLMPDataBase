using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Utils
{
    internal class DataHeadersUtils
    {
        internal static List<string> FacilityProfileHeaders = new List<string>()
        {
            "facility_id",
            "ward_id",
            "ward_name",
            "county_id",
            "county_name",
            "facility_name",
            "facility_ownership",
            "facility_status",
            "facility_type",
            "latitude",
            "longitude",
            "altitude",
            "precision"
        };

        internal static List<string> FacilityContactHeaders = new List<string>()
        {
            "facility_id",
            "contact_person",
            "phone_number"
        };

        internal static List<string> FacilityActivityPeriodHeaders = new List<string>()
        {
            "facility_id",
            "period_description",
            "ap-Monday",
            "ap-Tuesday",
            "ap-Wednesday",
            "ap-Thursday",
            "ap-Friday",
            "ap-Saturday",
            "ap-Sunday"
        };

        internal static List<string> FacilityDescriptionHeaders = new List<string>()
        {
            "facility_id",
            "de-Type",
            "de-Facility Type Banda",
            "de-Facility Type Tannery",
            "de-Broiler Hatchery",
            "de-Layer Hatchery",
            "de-Kienyeji Hatchery",
            "de-Category",
            "de-Group Type",
            "de-Facility Type",
            "de-Type of Facility",
            "de-Type of Water Point",
            "de-Other Type of Water Point",
            "de-Processes Hides",
            "de-Processes Skins",
            "de-Slaughter for Local Market",
            "de-Slaughter Facility for Export Market"
        };

        internal static List<string> FacilityValueChainHeaaders = new List<string>()
        {
            "facility_id",
            "vc-Cattle",
            "vc-Sheep",
            "vc-Goat",
            "vc-Poultry",
            "vc-Pigs",
            "vc-Camel",
            "vc-Donkey",
            "vc-Rabbits",
            "vc-Bees"
        };

        internal static List<string> FacilityAmenityHeaders = new List<string>()
        {
            "facility_id",
            "am-AI services",
            "am-Sales of veterinary pharmaceuticals",
            "am-Services offered/Veterinary clinical services and extensions",
            "am-Equipment and machinery",
            "am-Animal feeds",
            "am-Advisory Services",
            "am-Longstroth hive",
            "am-Box hive",
            "am-Traditional log hive",
            "am-Flow hive",
            "am-Beesuit",
            "am-Veil",
            "am-Gloves",
            "am-Smoker",
            "am-Bee brush",
            "am-Hive knife",
            "am-Products processed",
            "am-Loading ramp",
            "am-Offloading ramp",
            "am-Quarantine facility",
            "am-Watering points",
            "am-Crushes",
            "am-Sanitary facilities (Toilet & Water)",
            "am-Waiting bay",
            "am-Agrovet shop",
            "am-Mpesa shop",
            "am-Weighing scales",
            "am-Other Available Facility",
            "am-None",
            "am-Beekeeping equipment - KTBH",
            "am-Beekeeping equipment - Longstroth hive",
            "am-Beekeeping equipment - Box hive",
            "am-Beekeeping equipment - Traditional log hive",
            "am-Beekeeping equipment - Flow hive",
            "am-Beekeeping equipment - Beesuit",
            "am-Beekeeping equipment - Veil",
            "am-Beekeeping equipment - Gloves",
            "am-Beekeeping equipment - Smoker",
            "am-Beekeeping equipment - Bee brush",
            "am-Beekeeping equipment - Hive knife",
            "am-Source of power Electricity",
            "am-Source of power Solar",
            "am-Source of power Other",


        };

        internal static List<string> FacilityMetricHeaders = new List<string>()
        {
            "facility_id",
            "fm-Hides Capacity (in Kgs)",
            "fm-Skins Capacity (Pieces)",
            "fm-Average Hides processed per week (in Kgs)",
            "fm-Average Skins processed per week (pieces)",
            "fm-Capacity(potential)",
            "fm-Average Production",
            "fm-Average Number of Animals attended per Week",
            "fm-Capacity of the hatchery",
            "fm-Capacity (tonnage/Day)",
            "fm-Average processed per Day",
            "fm-Average number of Cattle traded per market day",
            "fm-Average number of Sheep traded per market day",
            "fm-Average number of Goats traded per market day",
            "fm-Average number of Poultry traded per market day",
            "fm-Average number of Pigs traded per market day",
            "fm-Average number of Camel traded per market day",
            "fm-Average number of Donkeys traded per market day",
            "fm-Capacity of the facility (Liters)",
            "fm-Average handled per Day",
            "fm-Average number of Cattle slaughtered per day",
            "fm-Average number of Sheep slaughtered per day",
            "fm-Average number of Goats slaughtered per day",
            "fm-Average number of Poultry slaughtered per day",
            "fm-Average number of Pigs slaughtered per day",
            "fm-Average number of Camel slaughtered per day",
            "fm-Average number of Donkeys slaughtered per day",
            "fm-Male Membership",
            "fm-Female Membership",
            "fm-Capacity per Day (Numbers of Carcasses)",
            "fm-Average number of Cattle carcasses processed per day",
            "fm-Average number of Sheep carcasses processed per day",
            "fm-Average number of Goats carcasses processed per day",
            "fm-Average number of Poultry carcasses processed per day",
            "fm-Average number of Pigs carcasses processed per day",
            "fm-Average number of Camel carcasses processed per day",
            "fm-Average number of Donkeys carcasses processed per day",
            "fm-Capacity of milk ATM",
            "fm-Average sold per day milk bar and ATM",
            "fm-Capacity of the water point",
            "fm-The Yield/Hour",
            "fm-Capacity of reservoir tank",
            "fm-Male Membership Count",
            "fm-Female Membership Count",

        };
    }
}
