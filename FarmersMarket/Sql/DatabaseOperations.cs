using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FarmersMarket.Sql
{
    public static class DatabaseOperations
    {
        private static readonly string ConnString = ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString;

        private static DataTable LoadDataTable(string query)
        {
            using (var conn = new SqlConnection(ConnString))
            using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                var dt = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        /* ------------------------------------------------------ */

        public static DataTable GetVendors() => LoadDataTable(Queries.GetVendors);
    }
}