using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Core.Utils
{
    public class JsonReader
    {
        private static IConfiguration InitConfiguration(string path, string fileName)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile(fileName)
                .Build();

            return configuration;
        }

        public static string ReadParameter(string filePath, string fileName, string parameter)
        {
            var configuration = InitConfiguration(filePath, fileName);
            return configuration[parameter];
        }

    }
}
