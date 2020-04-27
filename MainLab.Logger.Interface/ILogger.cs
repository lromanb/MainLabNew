using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.Logger
{
    public interface ILogger
    {
        void WriteToLog(String message);
    }
}
