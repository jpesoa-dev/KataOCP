using CodingKataOCP.Kata5_FileProccessing;

class Program
{
    static void Main()
    {
        var processors = new List<IFileProcessor>
            {
                new TextFileProcessor(),
                new CSVFileProcessor(),
                new XMLFileProcessor(),
                new JSONFileProcessor()
            };

        var service = new FileProcessingService(processors);
        service.ProcessAllFiles();
    }
}
