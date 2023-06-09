using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportServiceDemo.Services
{
    public interface IFileImporter
    {
        void ImportFile(string filePath);
        IEnumerable<string> SupportedExtensions { get; }
    }
}
