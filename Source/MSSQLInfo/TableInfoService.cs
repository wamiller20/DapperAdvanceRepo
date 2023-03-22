using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace MSSQLInfo
{
    using MSSQLInfo.Entities;
    using RepoDomain.Extenstions;
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
            this.connectionString = $"data source={serverName};initial catalog = {databaseName}; Encrypt=False; persist security info = True;Integrated Security = SSPI;";
        }

        public IDBInfo GetDBInfo()
        {
            var server = GetServer();
            var database = server.Databases[this.databaseName];
            var dbInfo = new DBInfo();

            foreach (Table table in database.Tables)
            {
                dbInfo.Tables.Add(GetTable(table));
                
            }
            return dbInfo;
        }

        private Server GetServer()
        {
            var serverConnection = new ServerConnection(this.serverName);
            serverConnection.ConnectionString = this.connectionString;
            serverConnection.TrustServerCertificate = true;
            return new Server(serverConnection);
        }

        private ITable GetTable(Table table)
        {
            var tableInfo = new TableInfo();
            tableInfo.TableName = table.Name;
            foreach (Column column in table.Columns)
            {
                tableInfo.Columns.Add(GetColumn(column));
            }
            return tableInfo;
        }

        private IColumn GetColumn(Column column)
        {
            var columnInfo = new ColumnInfo();
            columnInfo.ColumnName = column.Name;
            columnInfo.PrimaryKey = column.InPrimaryKey;
            columnInfo.ColumnDataType = column.DataType.Name.SqlTypeToCSharpType();
            return columnInfo;
        }
    }
}
