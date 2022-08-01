using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class AgroVetModel : Facility, IValueChain
    {
        public int vc_Cattle { get; set; }
        public int vc_Sheep { get; set; }
        public int vc_Goat { get; set; }
        public int vc_Poultry { get; set; }
        public int vc_Pigs { get; set; }
        public int vc_Camel { get; set; }
        public int vc_Donkey { get; set; }
        public int vc_Rabbits { get; set; }
        public int vc_Bees { get; set; }
        public int am_AI_services { get; set; }
        public int am_Sales_of_veterinary_pharmaceuticals { get; set; }
        public int am_Veterinary_clinical_services_and_extensions { get; set; }
        public int am_Equipment_and_machinery { get; set; }
        public int am_Animal_feeds { get; set; }
        public int am_Advisory_Services { get; set; }
    }
}
