using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportServiceDemo.Services
{
    public class CsvFileImporter : IFileImporter
    {
        public void ImportFile(string filePath)
        {
            //Add Logic to import csv file here
            throw new NotImplementedException();
        }
        public IEnumerable<string> SupportedExtensions => new[] { ".csv" };
    }
}

