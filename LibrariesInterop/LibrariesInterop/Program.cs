﻿using Microsoft.AspNetCore.Blazor.Hosting;
using System.Threading.Tasks;

namespace LibrariesInterop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.RootComponents.Add<App>("app");
            await builder.Build().RunAsync();
        }
    }
}
