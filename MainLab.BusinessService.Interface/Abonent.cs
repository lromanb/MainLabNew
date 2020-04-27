using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.BusinessService
{
    public class Abonent
    {
        public string FIO { get; set; }
        public string Account { get; set; }
        public Tariff Trf { get; set; }
        public TrafficType WatchTrafficType { get; set; }
    }
}
