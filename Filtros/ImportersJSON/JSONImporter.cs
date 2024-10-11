using IImporter;
using Models.In;

namespace ImportersJSON;

public class JSONImporter : ImporterInterface
{
    public string GetName()
    {
        return "JSON Importer";
    }

    public List<MovieImporter> ImportMovie()
    {
        return new List<MovieImporter> { 
            new MovieImporter {Title="chuek json" }, 
            new MovieImporter {Title="avatar json" }  
        };
    }
}