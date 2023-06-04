using Microsoft.Extensions.Logging;
using Serilog;

ILoggerFactory loggerFactory = new LoggerFactory().AddSerilog
(
    new LoggerConfiguration()
        .MinimumLevel.Verbose()
        .WriteTo.Console()
        .CreateLogger()
);

ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Hello World!");

// var serverConfigurationBuilder = new ChatEntranceServerConfigurationBuilder();