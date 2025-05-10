using CodingKataOCP.Kata5_FileProccessing;

namespace UnitTests;

public class Kata5_FileProccessingTest
{
    [Fact]
    public void TextFileProcessor_ShouldWriteExpectedOutput()
    {
        // Arrange
        var processor = new TextFileProcessor();
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        processor.ProcessFile();

        // Assert
        var result = sw.ToString().Trim();
        Assert.Equal("Processing text file...", result);
    }

    [Fact]
    public void CSVFileProcessor_ShouldWriteExpectedOutput()
    {
        var processor = new CSVFileProcessor();
        using var sw = new StringWriter();
        Console.SetOut(sw);

        processor.ProcessFile();

        var result = sw.ToString().Trim();
        Assert.Equal("Processing CSV file...", result);
    }

    [Fact]
    public void XMLFileProcessor_ShouldWriteExpectedOutput()
    {
        var processor = new XMLFileProcessor();
        using var sw = new StringWriter();
        Console.SetOut(sw);

        processor.ProcessFile();

        var result = sw.ToString().Trim();
        Assert.Equal("Processing XML file...", result);
    }

    [Fact]
    public void JSONFileProcessor_ShouldWriteExpectedOutput()
    {
        var processor = new JSONFileProcessor();
        using var sw = new StringWriter();
        Console.SetOut(sw);

        processor.ProcessFile();

        var result = sw.ToString().Trim();
        Assert.Equal("Processing JSON file...", result);
    }
}
