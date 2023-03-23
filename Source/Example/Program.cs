// See https://aka.ms/new-console-template for more information
using MSSQLInfo;
using RepoExample.Entities;

Console.WriteLine("Hello, World!");

var tableInfoService = new TableInfoService(@"localhost\SQLExpress", "BillPayEmpty");
var dbInfo = tableInfoService.GetDBInfo();
var saveLocation = "c:\\repos\\BillPayDBRepoPattern";

var pocoBuilder = new POCOBuilder(dbInfo);
pocoBuilder.Build();
pocoBuilder.Save(saveLocation);

Console.WriteLine($"Files have been saved to location: {saveLocation}");
