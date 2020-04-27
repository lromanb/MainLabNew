using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.BusinessService
{
    public class PassedParams
    {
        public Abonent Abnt { get; set; }
        public Tariff Trf { get; set; }
        public Paysystem Ps { get; set; }
        public double Payment { get; set; }
        public TrafficType TrType { get; set; }
    }
}
