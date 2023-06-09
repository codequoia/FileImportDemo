using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileImportServiceDemo.Services
{
    public class ExcelFileImporter : IFileImporter
    {
        public void ImportFile(string filePath)
        {
            //Add your logic to import excel file here.
            throw new NotImplementedException();
        }
        public IEnumerable<string> SupportedExtensions => new[] { ".xls", ".xlsx" };
    }
}
