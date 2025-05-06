using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace TaxiDatabase
{
    public class Database
    {
        public SqlConnectionStringBuilder builder;
        public int CarsLength = 0;
        public int DrivesLength = 0;
        public int OrdersLength = 0;
        public Database(string dataSource, string dbfilepath)
        {
            builder = new SqlConnectionStringBuilder();
            string dbName = Path.GetFileNameWithoutExtension(dbfilepath);
            builder.DataSource = dataSource;
            builder.AttachDBFilename = dbfilepath;
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = dbName;
        }
        public SqlConnection CreateConnection()
        {
            return new SqlConnection(builder.ConnectionString);
        }
    }
}
