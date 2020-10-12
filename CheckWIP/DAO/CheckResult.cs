using CheckWIP.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckWIP.DAO
{
    public class CheckResult
    {
        private static CheckResult instance;

        public static CheckResult Instance { get => instance==null?new CheckResult():instance; set => instance = value; }
        public CheckResult() { }

        public DataTable LoadPartsInSystemButNoActual()
        {
            string query = "";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadPartsInActualButNoSystem()
        {
            string query = "";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
