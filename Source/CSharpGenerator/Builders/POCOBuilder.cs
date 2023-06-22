// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;
using System.Text;

public class POCOBuilder
{
    private IDBInfo dBInfo;
    private List<POCOClassOutline> classOutlines;
    private List<RepoOutline> repoOutlines;

    public POCOBuilder(IDBInfo dBInfo)
    {
        this.dBInfo = dBInfo;
        classOutlines = new List<POCOClassOutline>();
        repoOutlines = new List<RepoOutline>();
    }
    
    // Take the input and turn it into objects that can be saved to files or 
    // dumped to stdout.
    public void Build()
    {
        foreach(var table in dBInfo.Tables)
        {
            try
            {
               var classOutline  = new POCOClassOutline(dBInfo, table);
               this.classOutlines.Add(classOutline);
               this.repoOutlines.Add(new RepoOutline(classOutline.ClassName, table));
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
        }
    }
    
    public void Save(string path)
    {
        foreach (var classOutline in classOutlines)
        {
            var folderPath = Path.Combine(path, "Entities");
            var filePath = Path.Combine(folderPath, classOutline.ClassName + ".cs");
            Directory.CreateDirectory(folderPath);
            File.WriteAllText(filePath, classOutline.GetPOCOClassOutline());
        }

        foreach (var repoOutline in repoOutlines)
        {
            var folderPath = Path.Combine(path, "Repos");
            var filePath = Path.Combine(folderPath, repoOutline.RepoName + ".cs");
            Directory.CreateDirectory(folderPath);
            File.WriteAllText(filePath, repoOutline.ToString());
        }

    }

    public string Dump()
    {
        throw new NotImplementedException();
        // Take the built POCOs and return them as strings.
        return string.Empty;
    }
}