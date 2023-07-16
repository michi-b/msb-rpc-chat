using Microsoft.Extensions.Logging;
using MsbRpcChatContract.Generated;
using Serilog;

ILoggerFactory loggerFactory = new LoggerFactory().AddSerilog
(
    new LoggerConfiguration()
        .MinimumLevel.Verbose()
        .WriteTo.Console()
        .CreateLogger()
);

ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

var serverConfiguration = new ChatEntranceServerConfigurationBuilder
{
    LoggerFactory = loggerFactory,
    MessengerListenerConfiguration = { LoggerFactory = loggerFactory },
    EndPointRegistryConfiguration = { LoggerFactory = loggerFactory }
};

// ChatEntranceServer server = ChatEntranceServer.Run();