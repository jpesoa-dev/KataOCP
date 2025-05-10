using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataOCP.Kata5_FileProccessing;

public class JSONFileProcessor : IFileProcessor
{
    public void ProcessFile() => Console.WriteLine("Processing JSON file...");
}
