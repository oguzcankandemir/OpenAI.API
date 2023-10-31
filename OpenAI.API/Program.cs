using OpenAI.API.Example.Services;
using OpenAI.GPT3.Extensions;
using OpenAI.GPT3.Interfaces;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "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");
        services.AddHostedService<OpenAICompletionService>();
    })
    .Build();

host.Run();
