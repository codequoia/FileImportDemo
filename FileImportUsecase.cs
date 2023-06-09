using FileImportServiceDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportServiceDemo
{
    public class FileImportUsecase
    {
        static void Main(string[] args)
        {
            string filePath = "path/to/your/file.csv"; 
            FileImporterFactory importerFactory = new FileImporterFactory();
            IFileImporter fileImporter = importerFactory.CreateFileImporter(filePath);
            fileImporter.ImportFile(filePath);

            // Extra Logic
            Console.ReadLine();
        }
    }
}
