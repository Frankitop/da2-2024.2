using Models.Out;

namespace IImporter;

public interface ImporterInterface
{
    string GetName();

    List<MovieImporter> ImportMovie();
}