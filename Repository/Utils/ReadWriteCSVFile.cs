using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KLMP.DataAccess.Repository.Utils
{
    public static class ReadWriteCSVFile
    {
        public static List<RootObject> ReadRootObjectFile<RootObject>(string path)
        {
            try
            {
                var cultureInfo = System.Globalization.CultureInfo.InvariantCulture;
                CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(cultureInfo);
                config.MissingFieldFound = null;
                using (TextReader reader = File.OpenText(path))
                using (var csv = new CsvReader(reader, config))
                {

                    csv.Read();
                    csv.ReadHeader();
                    return csv.GetRecords<RootObject>().ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new List<RootObject>();
        }

        public static bool WriteRootObjectFile<RootObject>(string filePath, List<RootObject> rootObjects)
        {
            try
            {
                var cultureInfo = System.Globalization.CultureInfo.InvariantCulture;
                CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(cultureInfo);
                config.MissingFieldFound = null;
                using (TextWriter writer = File.CreateText(filePath))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(rootObjects);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
