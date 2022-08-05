using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Utils
{
    public static class Identifiers
    {
        public static HashSet<string> GetUniqueIds(int itemCount)
        {
            HashSet<string> uniqueIds = new HashSet<string>();
            var originalGUID = Guid.NewGuid().ToString();
            for (int i = 0; i < itemCount; i++)
            {
                originalGUID = Guid.NewGuid().ToString();
                uniqueIds.Add(originalGUID.Substring(originalGUID.Length - 5, 4));
            }
            Console.WriteLine(uniqueIds.Count);
            return uniqueIds;
        }
    }
}
