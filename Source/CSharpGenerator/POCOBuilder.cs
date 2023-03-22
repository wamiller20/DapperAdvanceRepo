// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;

class POCOBuilder
{
    private IDBInfo dBInfo;
    private List<ClassOutline> classOutlines;
    private List<RepoOutline> repoOutlines;

    public POCOBuilder(IDBInfo dBInfo)
    {
        this.dBInfo = dBInfo;
        classOutlines = new List<ClassOutline>();
        repoOutlines = new List<RepoOutline>();
    }
    
    // Take the input and turn it into objects that can be saved to files or 
    // dumped to stdout.
    public void Build()
    {
        foreach(Table table in dBInfo.Tables)
        {
            try
            {
               var classOutline  = new ClassOutline();
               classOutline.ClassName = table.TableName;

               classOutline.Fields = new List<Field>();
               foreach(var column in table.Columns)
               {
                   classOutline.Fields.Add(new Field(column.ColumnDataType, column.ColumnName));
               }
               
                repoOutlines.Add(new RepoOutline(classOutline.ClassName, table));
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
        }
    }
    
    public void Save(string path)
    {
        throw new NotImplementedException();

        using(var fileStream = File.OpenWrite(path))
        {
            // fileStream.Write()
        }
    }

    public string Dump()
    {
        throw new NotImplementedException();
        // Take the built POCOs and return them as strings.
        return string.Empty;
    }
}