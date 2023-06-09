using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportServiceDemo.Services
{
    public class FileImporterFactory
    {
        public IFileImporter CreateFileImporter(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath).ToLower();

            switch (fileExtension)
            {
                case ".txt":
                    return new TxtFileImporter();
                case ".csv":
                    return new CsvFileImporter();
                case ".xlsx":
                case ".xls":
                    return new ExcelFileImporter();
                default:
                    throw new ArgumentException("Unsupported file extension: " + fileExtension);
            }
        }
    }
}
