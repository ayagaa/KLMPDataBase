using KLMP.DataAccess.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Utils
{
    public static class InsertDbData
    {
        public static bool InsertProfileData(List<TblFacilityProfile> facilityProfiles)
        {
            try
            {
                using (MoDbContext moDb = new MoDbContext())
                {
                    moDb.AddRange(facilityProfiles);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
