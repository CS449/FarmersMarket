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
        private static string ConnectionString => ConfigurationManager.ConnectionStrings["SQLServerLocal"].ConnectionString;

        private static DataTable LoadDataTable(string query)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Connection.Open();
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        /* ------------------------------------------------------ */

        public static DataTable GetVendors() => LoadDataTable(Queries.GetVendors);
        public static DataTable GetOwners() => LoadDataTable(Queries.GetOwners);
    }
}