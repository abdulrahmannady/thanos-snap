using Microsoft.Extensions.Configuration;
using System.IO;

namespace ThanosSnap
{
    public static class FileManager
    {
        public static string GetDirectory()
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var dir = builder.Build().GetSection("Directory").Value;

            return dir;
        }

        public static string[] GetFileExtensions()
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var extensions = builder.Build().GetSection("FileExtensions").Value;
            return extensions.Split(",");
        }
    }
}
