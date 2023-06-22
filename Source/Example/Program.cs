// See https://aka.ms/new-console-template for more information
using MSSQLInfo;
using Newtonsoft.Json;
using RepoDomain.Interfaces;
using RepoExample.Entities;

Console.WriteLine("Hello, World!");

var jsonPath = "c:\\repos\\DBInfo.json";
var saveLocation = "c:\\repos\\BillPayDBRepoPattern";
IDBInfo dbInfo;

//if (File.Exists(jsonPath))
//{
//    dbInfo = JsonConvert.DeserializeObject<DBInfo>(File.ReadAllText(jsonPath)) ?? new DBInfo();
//}
//else
//{
var tableInfoService = new TableInfoService(@"localhost\SQLExpress", "BillPayEmpty");
dbInfo = tableInfoService.GetAllDBInfo();
File.WriteAllText(jsonPath, JsonConvert.SerializeObject(dbInfo, Formatting.Indented));
//}


if(dbInfo == null)
{
    Console.WriteLine("DBInfo came back null.");
    return;
}

var pocoBuilder = new POCOBuilder(dbInfo);
pocoBuilder.Build();
pocoBuilder.Save(saveLocation);

Console.WriteLine($"Files have been saved to location: {saveLocation}");
