﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ProductsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:9001")
                .UseStartup<Startup>();
    }
}
