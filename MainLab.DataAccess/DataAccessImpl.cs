using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.DataAccess
{
    public class DataAccessImpl : IDataAccess
    {
        public IEnumerable GetData()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Get data result");
            return resultList;
        }

        public IEnumerable GetUsersList()
        {
            return new List<string>()
            {
                "admin:adm:1",
                "user1:usr1:2",
            };
        }

        public IEnumerable SetData()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Set data result");
            return resultList;

        }
    }
}
