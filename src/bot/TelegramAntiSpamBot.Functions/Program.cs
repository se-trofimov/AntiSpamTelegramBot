using Azure.Monitor.OpenTelemetry.AspNetCore;

var builder = new HostBuilder();

builder.ConfigureFunctionsWorkerDefaults(b =>
  {
     b.UseMiddleware<AuthorizationMiddleware>();
  }
);

builder.ConfigureServices(collection =>
{
    collection.AddOpenAiService();
    collection.AddTelegramBot();
    collection.AddPersistence();
    collection.AddOpenTelemetry().UseAzureMonitor();
});

// configure logging
builder.ConfigureAppConfiguration((_, config) =>
{
    config.AddJsonFile("loggerConfig.json");
}).ConfigureLogging((hostingContext, logging) =>
{
    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
});

builder.Build().Run();
