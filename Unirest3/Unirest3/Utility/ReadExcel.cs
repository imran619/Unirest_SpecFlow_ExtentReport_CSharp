using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unirest3.Utility;
using System.IO;

namespace Unirest3.Utility
{
    public class ReadExcel
    {
        public string filePathToExcel()
        {
            return @"E:\Imran\Selenium\CSProjects\UnirestProjects\Unirest3\Unirest3\Utility\data.xlsx";
            //return Path.Combine(Environment.CurrentDirectory, @"Utility\", "data.xlsx");
        }
    }
}
