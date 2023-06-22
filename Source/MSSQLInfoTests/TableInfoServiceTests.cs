using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSSQLInfo;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQLInfo.Tests
{
    [TestClass]
    public class TableInfoServiceTests
    {
        private TableInfoService tableInfoService;

        [TestInitialize]
        [TestMethod]
        public void Setup()
        {
            this.tableInfoService = new TableInfoService(@"localhost\SQLExpress", "BillPayEmpty");
            this.tableInfoService.ShouldNotBeNull();
        }

        [TestMethod]
        public void GetDBInfoTest()
        {
            var dbInfo = this.tableInfoService.GetAllDBInfo();

            dbInfo.ShouldNotBeNull();
            dbInfo.Tables.First().TableName.ShouldNotBeNullOrWhiteSpace();
            dbInfo.Tables.Count().ShouldBeGreaterThan(1);
            dbInfo.Tables.First().Columns.Count().ShouldBeGreaterThan(1);
            dbInfo.Tables.First().Columns.First().ColumnName.ShouldNotBeNullOrWhiteSpace();
            dbInfo.Tables.First().Columns.First().ColumnDataType.ShouldNotBeNullOrWhiteSpace();
        }
    }
}