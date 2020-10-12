using CheckWIP.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWIP.DAO
{
    public class InventoryPeriod
    {
        private static InventoryPeriod instance;

        public static InventoryPeriod Instance { get => instance == null ? new InventoryPeriod() : instance; set => instance = value; }
        public InventoryPeriod() { }

        public DataTable LoadInventoryPeriod()
        {
            string query = $"select PeriodCode, Description, [Date] as [Check Date] from VAC_InventoryPeriod";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }

        public void AddInventoryPeriod(string periodCode, string description, DateTime checkDate)
        {
            string query = $@"insert into VAC_InventoryPeriod(PeriodCode,[Description],[Date],[Status],[User],[Created Date]) 
                                values ('{periodCode}', '{description}', '{checkDate}', 1, 'admin', '{DateTime.Now}')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void deleteInventoryPeriod(string periodCode)
        {
            string query = $"delete VAC_InventoryPeriod where PeriodCode = '{periodCode}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
