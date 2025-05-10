namespace CodingKataOCP.Kata5_FileProccessing;

public class FileProcessingService
{
    private readonly IEnumerable<IFileProcessor> _processors;

    public FileProcessingService(IEnumerable<IFileProcessor> processors)
    {
        _processors = processors;
    }

    public void ProcessAllFiles()
    {
        foreach (var processor in _processors)
        {
            processor.ProcessFile();
        }
    }
}
