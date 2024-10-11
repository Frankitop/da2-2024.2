using IImporter;
using Models.In;

namespace ImportersCSV;

public class CSVImporter : ImporterInterface
{
    public string GetName()
    {
        return "CSV Importer";
    }

    public List<MovieImporter> ImportMovie()
    {
        // Harcodeado - Aca deberia leer el archivo CSV de verdad
        return new List<MovieImporter> { 
            new MovieImporter {Title="chuek csv" }, 
            new MovieImporter {Title="avatar csv" }  
        };
    }
}