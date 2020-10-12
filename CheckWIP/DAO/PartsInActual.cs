using CheckWIP.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWIP.DAO
{
    public class PartsInActual
    {
        private static PartsInActual instance;

        public static PartsInActual Instance { get => instance==null?new PartsInActual():instance; set => instance = value; }
        public PartsInActual() { }

        public DataTable LoadPartsInActual(string code)
        {
            string query = $"select Seri, Station from VAC_InventoryActual where InventoryPeriod = '{code}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void addPart(string seri, string station, string inventoryPeriod)
        {
            string query = $@"insert into VAC_InventoryActual(Seri, Station, InventoryPeriod, [User], CreatedDate)
                                values ('{seri}', '{station}', '{inventoryPeriod}', 'admin', '{DateTime.Now}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void deletePartsByPeriodCode(string code)
        {
            string query = $"delete VAC_InventoryActual where InventoryPeriod = '{code}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
