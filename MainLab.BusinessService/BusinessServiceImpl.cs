using MainLab.DataAccess;
using MainLab.Logger;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.BusinessService
{
    public class BusinessServiceImpl : IBusinessService
    {
        IDataAccess da;
        ILogger logger;

        public BusinessServiceImpl(IDataAccess da, ILogger logger)
        {
            this.da = da;
            this.logger = logger;
        }

        IEnumerable IBusinessService.ChooseTariff(PassedParams ps)
        {
            return da.SetData();
        }

        IEnumerable IBusinessService.CreateAbonent(PassedParams ps)
        {
            return da.SetData();
        }

        IEnumerable IBusinessService.CreateAccBalanceReport(PassedParams ps)
        {
            return da.GetData();
        }

        IEnumerable IBusinessService.CreateTarif(PassedParams ps)
        {
            return da.SetData();
        }

        IEnumerable IBusinessService.CreateTrafficReport(PassedParams ps)
        {
            return da.GetData();
        }

        IEnumerable IBusinessService.EditAbonent(PassedParams ps)
        {
            return da.SetData();
        }

        IEnumerable IBusinessService.EditTarif(PassedParams ps)
        {
            return da.SetData();
        }

        IEnumerable IBusinessService.ListAbonents()
        {
            return da.GetData();
        }

        IEnumerable IBusinessService.ListTarifs()
        {
            return da.GetData();
        }

        IEnumerable IBusinessService.PayAccount(PassedParams ps)
        {
            return da.SetData();
        }
    }
}
