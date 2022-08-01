using KLMP.DataAccess.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Utils
{
    public static class GetDbData
    {
        public static List<TblCounty> GetCounties()
        {
            try
            {
                using (MoDbContext moDb = new MoDbContext())
                {
                    return moDb.TblCounties.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<TblCounty>();
            }
        }

        public static List<TblWard> GetWards()
        {
            try
            {
                using (MoDbContext moDb = new MoDbContext())
                {
                    return moDb.TblWards.ToList();
                }
            }
            catch (Exception)
            {
                return new List<TblWard>();
            }
        }

        public static void GetDbStatistics(string filePath)
        {
            var facilitiesGenerator = new Generators(filePath);
            facilitiesGenerator.ShowStatistics();
            var facilities = facilitiesGenerator.GetFacilityProfiles();

            var counties = GetCounties();
            var wards = GetWards();
            Console.WriteLine(string.Format("Number of Counties {0}", counties.Count));
            Console.WriteLine(string.Format("Number of wards {0}", wards.Count));

            //var queryResult = from p in context.ParentTable
            //join c in context.ChildTable on p.ParentId equals c.ChildParentId into j1
            //from j2 in j1.DefaultIfEmpty()
            //group j2 by p.ParentId into grouped
            //select new { ParentId = grouped.Key, Count = grouped.Count(t => t.ChildId != null) }
            var countyResults = new List<CountyResult>();
            var wardResults = new List<WardResult>();
            foreach (var county in counties)
            {
                Console.WriteLine("Here");
                var countyResult = new CountyResult();
                countyResult.CountyId = county.CountyId;
                countyResult.CountyName = county.CountyName;
                countyResult.CountOfFacility = 0;
                foreach (var ward in wards)
                {
                    var wardResult = new WardResult();
                    wardResult.CountyId = county.CountyId;
                    wardResult.CountyName = county.CountyName;
                    wardResult.WardId = ward.WardId;
                    wardResult.WardName = ward.WardName;
                    wardResult.CountOfFacility = 0;
                    foreach (var facilty in facilities)
                    {
                        if (county.CountyId == ward.CountyId)
                        {
                            countyResult.CountOfFacility++;
                            wardResult.CountOfFacility++;
                        }
                    }
                    wardResults.Add(wardResult);
                }
                countyResults.Add(countyResult);

                foreach (var wardresult in wardResults)
                {
                    Console.WriteLine(String.Format("Ward Count of Facilities: County:{0} Ward:{1} Count:{2}", wardresult.CountyName, wardresult.WardName, wardresult.CountOfFacility));

                }
                foreach (var countyresult in countyResults)
                {
                    Console.WriteLine(string.Format("County Count of Facilities: County:{0} Count:{1}", countyresult.CountyName, countyresult.CountOfFacility));
                }
            }
        }

        class CountyResult
        {
            public int CountyId { get; set; }

            public string CountyName { get; set; }

            public string FaciltyType { get; set; }

            public int CountOfFacility { get; set; }
        }

        class WardResult
        {
            public int CountyId { get; set; }

            public string CountyName { get; set; }
            public int WardId { get; set; }
            public string WardName { get; set; }

            public string FaciltyType { get; set; }

            public int CountOfFacility { get; set; }
        }
    }
}
