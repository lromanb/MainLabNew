using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.DataAccess
{
    public interface IDataAccess
    {
        IEnumerable GetData();
        IEnumerable SetData();
        IEnumerable GetUsersList();
    }
}
