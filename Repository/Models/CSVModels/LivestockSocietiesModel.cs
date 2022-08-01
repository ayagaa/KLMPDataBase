using KLMP.DataAccess.Repository.Abstract;
using KLMP.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Models.CSVModels
{
    public class LivestockSocietiesModel : Facility, IValueChain
    {
        public string de_Group_Type { get; set; }
        public int vc_Cattle { get; set; }
        public int vc_Sheep { get; set; }
        public int vc_Goat { get; set; }
        public int vc_Poultry { get; set; }
        public int vc_Pigs { get; set; }
        public int vc_Camel { get; set; }
        public int vc_Donkey { get; set; }
        public int vc_Rabbits { get; set; }
        public int vc_Bees { get; set; }
        public string? Membership { get; set; }
        public int fm_Male_Membership_Count { get; set; }
        public int fm_Female_Membership_Count { get; set; }
    }
}
