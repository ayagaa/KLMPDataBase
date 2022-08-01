using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLMP.DataAccess.Repository.Interface
{
    public interface IValueChain
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
    }
}
