using CheckWIP.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWIP.DAO
{
    public class PartsInSystem
    {
        private static PartsInSystem instance;

        public static PartsInSystem Instance { get => instance == null ? new PartsInSystem() : instance; set => instance = value; }
        public PartsInSystem() { }

        public DataTable LoadPartsInSystem(string code)
        {
            string query = $"select Seri, Station from VAC_InventorySystem where InventoryPeriod = '{code}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void addPart(string seri, string station, string inventoryPeriod)
        {
            string query = $@"insert into VAC_InventorySystem(Seri, Station, InventoryPeriod, [User], CreatedDate)
                                values ('{seri}', '{station}', '{inventoryPeriod}', 'admin', '{DateTime.Now}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void deletePartsByPeriodCode(string code)
        {
            string query = $"delete VAC_InventorySystem where InventoryPeriod = '{code}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
