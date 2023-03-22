using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace MSSQLInfo
{
    using MSSQLInfo.Entities;
    using RepoDomain.Interfaces;

    public class TableInfoService
    {
        private readonly string serverName;
        private readonly string databaseName;
        private readonly string connectionString;

        public TableInfoService(string serverName, string databaseName)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.connectionString = $"data source={serverName};initial catalog = {databaseName}; persist security info = True;Integrated Security = SSPI;";
        }

        public IDBInfo GetDBInfo()
        {
            var server = GetServer();
            var database = server.Databases[this.databaseName];
            var tableNames = database.EnumObjects(DatabaseObjectTypes.Table);
            return new DBInfo();
        }

        private Server GetServer()
        {
            var serverConnection = new ServerConnection(this.serverName);
            serverConnection.ConnectionString = this.connectionString;
            return new Server(serverConnection);
        }
    }
}
