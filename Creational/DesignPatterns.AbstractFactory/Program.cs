using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(ctx => ctx.AddJsonFile("appsettings.json"))
    .ConfigureServices(services => { })
    .Build();

Console.WriteLine();