using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BionixTool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //Added a new line in VS 2017
            // New line BXT-127 asecahusada
            // New line added directly into BIONIX_ENHANCEMENTS asecahusada 
            // New line added directly into BIONIX_ENHANCEMENTS asecahusada #2
            // New line added directly into BIONIX_ENHANCEMENTS asecahusada #3
            // New line added directly into BIONIX_ENHANCEMENTS asecahusada #4
            // New line added directly into BXT-123 asecahusada #5
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
