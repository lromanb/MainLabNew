using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.BusinessService
{
    public interface IBusinessService
    {
        IEnumerable CreateAccBalanceReport(PassedParams ps);//Отчет по балансу абонента
        IEnumerable CreateTrafficReport(PassedParams ps);//Отчет по трафику
        IEnumerable PayAccount(PassedParams ps);//Пополнение баланса
        IEnumerable ChooseTariff(PassedParams ps);//Выбор тарифа
        IEnumerable CreateAbonent(PassedParams ps);//Создание абонента
        IEnumerable EditAbonent(PassedParams ps);//Редактирование абонента
        IEnumerable CreateTarif(PassedParams ps);//Создание тарифа
        IEnumerable EditTarif(PassedParams ps);//Редактирование тарифа
        IEnumerable ListTarifs();//Получение списка тарифов
        IEnumerable ListAbonents();//Получение списка абонентов

    }
}
