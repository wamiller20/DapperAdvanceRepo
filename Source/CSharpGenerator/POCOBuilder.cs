// See https://aka.ms/new-console-template for more information
using RepoDomain.Interfaces;
using System.Text;

public class POCOBuilder
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
               var classOutline  = new ClassOutline(dBInfo, table);
               
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
        foreach (var classOutline in classOutlines)
        {
            using (var fileStream = File.OpenWrite(Path.Combine(path, "Entities", classOutline.ClassName + ".cs")))
            {
                fileStream.Write(Encoding.ASCII.GetBytes(classOutline.GetClassOutline()));
            }
        }

        foreach (var repoOutline in repoOutlines)
        {
            using (var fileStream = File.OpenWrite(Path.Combine(path, "Entities", repoOutline.RepoName + ".cs")))
            {
                fileStream.Write(Encoding.ASCII.GetBytes(repoOutline.ToString()));
            }
        }

    }

    public string Dump()
    {
        throw new NotImplementedException();
        // Take the built POCOs and return them as strings.
        return string.Empty;
    }
}