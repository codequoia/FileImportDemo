using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportServiceDemo.Services
{
    public class TxtFileImporter : IFileImporter
    {
        public void ImportFile(string filePath)
        {
            //Add Logic to import .TXT File here
            throw new NotImplementedException();
        }
        public IEnumerable<string> SupportedExtensions => new[] { ".txt" };
    }
}
}
