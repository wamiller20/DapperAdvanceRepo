using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace MSSQLInfo
{
    using MSSQLInfo.Entities;
    using RepoDomain.Extenstions;
    using RepoDomain.Interfaces;

    public class TableInfoService
    {
        private string? serverName;
        private string? databaseName;
        private string? connectionString;

        public TableInfoService(string serverName, string databaseName)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.connectionString = $"data source={this.serverName};initial catalog = {this.databaseName}; Encrypt=False; persist security info = True;Integrated Security = SSPI;";
        }

        public IDBInfo GetAllDBInfo()
        {
            var database = GetDatabaseService();
            var dbInfo = new DBInfo();
            dbInfo.DBName = this.databaseName;

            foreach (Table table in database.Tables)
            {
                if (table.Name.StartsWith("A") && table.Schema.StartsWith("dbo"))
                {
                    dbInfo.Tables.Add(GetTable(table));
                }
            }
            return dbInfo;
        }

        public IDBInfo GetSelectedDBInfo(List<ITableOrViewItem> Items)
        {
            var database = GetDatabaseService();
            var dbInfo = new DBInfo();
            dbInfo.DBName = this.databaseName;

            foreach (var item in Items)
            {
                if(item.TypeOfItem.ToLower() == "table")
                {
                    var table = database.Tables.ItemById(item.ItemID);
                    dbInfo.Tables.Add(GetTable(table));
                }
                else if(item.TypeOfItem.ToLower() == "view")
                {
                    //todo: Finish doing Views
                }
                
            }
            return dbInfo;
        }

        public List<ITableOrViewItem> GetAllTables()
        {
            var database = GetDatabaseService();
            var tableItems = new List<ITableOrViewItem>();
            foreach (Table table in database.Tables)
            {
                if (table.Name.StartsWith("A") && table.Schema.StartsWith("dbo"))
                {
                    tableItems.Add(new TableItem() { SchemaName = table.Schema, ItemName = table.Name, ItemID = table.ID });
                }
            }
            return tableItems;
        }

        public List<ITableOrViewItem> GetAllViews()
        {
            var database = GetDatabaseService();
            var viewItems = new List<ITableOrViewItem>();
            foreach (View view in database.Views)
            {
                if (view.Name.StartsWith("A") && view.Schema.StartsWith("dbo"))
                {
                    viewItems.Add(new ViewItem() { SchemaName = view.Schema, ItemName = view.Name, ItemID = view.ID });
                }
            }
            return viewItems;
        }

        private Database GetDatabaseService()
        {
            var server = GetServer();
            return server.Databases[this.databaseName];
        }

        private void SetupDBFields(string serverName, string databaseName)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.connectionString = $"data source={this.serverName};initial catalog = {this.databaseName}; Encrypt=False; persist security info = True;Integrated Security = SSPI;";
        }

        private Server GetServer()
        {
            var serverConnection = new ServerConnection(this.serverName);
            serverConnection.ConnectionString = this.connectionString;
            serverConnection.TrustServerCertificate = true;
            return new Server(serverConnection);
        }

        private ITableInfo GetTable(Table table)
        {
            var tableInfo = new TableInfo();
            tableInfo.TableName = table.Name;
            tableInfo.SchemaName = table.Schema;
            foreach (Column column in table.Columns)
            {
                tableInfo.Columns.Add(GetColumn(column));
            }
            return tableInfo;
        }

        private IColumnInfo GetColumn(Column column)
        {
            var columnInfo = new ColumnInfo();
            columnInfo.ColumnName = column.Name;
            columnInfo.PrimaryKey = column.InPrimaryKey;
            columnInfo.ColumnDataType = column.DataType.Name.SqlTypeToCSharpType();
            columnInfo.IsIdentity = column.Identity;
            return columnInfo;
        }
    }
}
