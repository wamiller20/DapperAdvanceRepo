using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDomain.Extenstions
{
    public static class DataTypeConversionExtensions
    {
        public static string SqlTypeToCSharpType(this string sqlDataType)
        {
            switch (sqlDataType.ToLower())
            {
                case "bigint":
                    return "long";
                case "smallint":
                    return "short";
                case "int":
                    return "int";
                case "tinyint":
                    return "byte";
                case "bit":
                    return "bool";
                case "decimal":
                case "numeric":
                case "money":
                case "smallmoney":
                    return "decimal";
                case "float":
                    return "double";
                case "real":
                    return "float";
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                    return "DateTime";
                case "time":
                    return "TimeSpan";
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                    return "string";
                case "binary":
                case "varbinary":
                case "image":
                    return "byte[]";
                case "timestamp":
                    return "byte[]";
                case "uniqueidentifier":
                    return "Guid";
                case "xml":
                    return "Xml";
                case "sql_variant":
                    return "object";
                case "geometry":
                    return "SqlGeometry";
                case "geography":
                    return "SqlGeography";
                case "hierarchyid":
                    return "SqlHierarchyId";
                default:
                    return "unknown";
            }
        }

    }
}
