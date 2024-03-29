﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lamar.Microsoft.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MyWebAPI
{
    public class Program
    {
        public static void Main()
        {
            CreateWebHostBuilder().Build().Run();
        }

       public static IWebHostBuilder CreateWebHostBuilder() =>
            WebHost.CreateDefaultBuilder().UseLamar()
                .UseStartup<Startup>();
    }
}
