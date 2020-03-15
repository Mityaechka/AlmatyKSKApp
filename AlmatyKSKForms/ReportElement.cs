using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmatyKSKForms
{
    public class ReportElement
    {
        public Value ValueName;
        public int Collum;
        public string CustomName;
        public ReportElement(Value valueName, int collum)
        {
            ValueName = valueName;
            Collum = collum;
        }

        public ReportElement()
        {
        }

        public ReportElement(Value valueName, string customName)
        {
            ValueName = valueName;
            CustomName = customName;
        }

        public static List<Value> RequestNames = new List<Value>()
        {

            new Value("CurrencyAccountBalanceBegin","Остаток на текущем счете в банке второго уровня" ),//+
            new Value("MonthlyInstalmentsForRepairs","Ежемесячные взносы" ),//+
            new Value("PaymentForTheRent","Плата за сданное в аренду" ),
            new Value("PrivateInvestment","Иные поступления" ),
            new Value("StaffCostMaintenance","Затраты на содержание штатного персонала" ),
            new Value("ObligatoryPayment","Обязательные платежи в бюджет" ),
            new Value("BankingServicesExpenses","Расходы на банковские услуги" ),//7
            new Value("CashServicesExpenses","Оплата за расчетно-кассовое обслуживание" ),
            new Value("OfficeExpenses","Расходы на содержание офиса" ),
            new Value("StaffSalaries","Заработная плата персонала" ),
            new Value("EmergencyLighting","Дежурное освещение" ),
            new Value("MaterialCosts","Расход на материалы" ),
            new Value("WorkContracts","Договора подряда" ),
            new Value("BuildingOperationOtherName","Наименование статьи расходов 4.1.5",false ),
            new Value("BuildingOperationOtherValue","Значение статьи расходов 4.1.5" ),
            new Value("LandscapingServices","Услуги по озеленению" ),
            new Value("CleaningServices","Услуги по санитарной уборке мест общего пользования" ),
            new Value("LandOther1Name","Наименование статьи расходов 4.2.3",false ),
            new Value("LandOther1Value","Значение статьи расходов 4.3.3" ),
            new Value("LandOther2Name","Наименование статьи расходов 4.2.4",false ),
            new Value("LandOther2Value","Значение статьи расходов 4.3.4" ),
            new Value("LandOther3Name","Наименование статьи расходов 4.2.5" ,false),
            new Value("LandOther3Value","Значение статьи расходов 4.3.5" ),
            new Value("MeteringDeviceAcquisitionExpense","Расходы на приобретение, установку, эксплуатацию и поверку общедомовых приборов учета (ОПУ) потребления коммунальных услуг" ),
            new Value("CommunityFacilitiesExpenses","Расходы на оплату коммунальных услуг" ),
            new Value("HouseholdExpenses","Хозяйственные расходы" ),
            new Value("OtherDifferentExpenses1Name","Наименование статьи расходов 5.1",false ),
            new Value("OtherDifferentExpenses1Value","Значение статьи расходов 5.1" ),
            new Value("OtherDifferentExpenses2Name","Наименование статьи расходов 5.2" ,false),
            new Value("OtherDifferentExpenses2Value","Значение статьи расходов 5.2" ),
            new Value("OtherDifferentExpenses3Name","Наименование статьи расходов 5.3" ,false),
            new Value("OtherDifferentExpenses3Value","Значение статьи расходов 5.3" ),
            new Value("OtherDifferentExpenses4Name","Наименование статьи расходов 5.4" ,false),
            new Value("OtherDifferentExpenses4Value","Значение статьи расходов 5.3" ),
            new Value("OtherDifferentExpenses5Name","Наименование статьи расходов 5.5",false ),
            new Value("OtherDifferentExpenses5Value","Значение статьи расходов 5.5" ),
            new Value("CurrencyAccountBalanceEnd","Остаток на текущем счете" ),//-

        };
    }
    public class Value
    {
        public string Name;
        public string RequestName;
        public bool isNumerical;

        public Value(string requestName, string name, bool isNumerical = true)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            RequestName = requestName ?? throw new ArgumentNullException(nameof(requestName));
            this.isNumerical = isNumerical;
        }
    }
}
