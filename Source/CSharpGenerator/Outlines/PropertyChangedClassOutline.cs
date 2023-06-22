using RepoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerator.Outlines
{
    public class PropertyChangedClassOutline
    {
        private readonly IDBInfo dBInfo;
        private string newLine = "\n\r";
        private string tab = "\t";

        public PropertyChangedClassOutline(IDBInfo dBInfo)
        {
            this.dBInfo = dBInfo;
        }

        public string GetPropertyChangedClassOutline()
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System.Runtime.CompilerServices;");
            sb.AppendLine();
            sb.AppendLine($"namespace {POCOClassOutline.GetPOCOClassNamespace(this.dBInfo)}.Core");
            sb.AppendLine("{");
            sb.AppendLine(tab + "public abstract class PropertyChanged");
            sb.AppendLine(tab + "{");
            sb.AppendLine(tab + tab + "public PropertyChanged()");
            sb.AppendLine(tab + tab + "{");
            sb.AppendLine(tab + tab + tab + "ChangedProperties = new List<string>();");
            sb.AppendLine(tab + tab + "}");
            sb.AppendLine(tab + tab + "public List<string> ChangedProperties { get; internal protected set; }");
            sb.AppendLine(tab + tab + "protected internal virtual void PropertyHasChanged([CallerMemberName] string propertyName = string.Empty)");
            sb.AppendLine(tab + tab + "{");
            sb.AppendLine(tab + tab + tab + "if (ChangedProperties.Contains(propertyName) == false) { ChangedProperties.Add(propertyName); }");
            sb.AppendLine(tab + tab + "}");
            sb.AppendLine();
            sb.AppendLine(tab + tab + "public virtual void RemovePropertyFromBeingUpdated(string propertyName)");
            sb.AppendLine(tab + tab + "{");
            sb.AppendLine(tab + tab + tab +"if (ChangedProperties.Contains(propertyName)) { ChangedProperties.Remove(propertyName); }");
            sb.AppendLine(tab + tab + "}");
            sb.AppendLine();
            sb.AppendLine(tab + tab + "public virtual void ResetPropertyChanges()");
            sb.AppendLine(tab + tab + "{");
            sb.AppendLine(tab + tab + tab + "ChangedProperties.Clear();");
            sb.AppendLine(tab + tab + "}");
            sb.AppendLine(tab  + "}");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
