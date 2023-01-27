//// Default URL for triggering event grid function in the local environment.
//// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using System;
using System.ComponentModel.DataAnnotations;
using Azure.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        private readonly ILogger _logger;

        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
        }

        [Function("Function1")]
        public void Run([EventGridTrigger] MyEvent[] input)
        {
            for (int x = 0; x < input.Length; x++) //foreach (var cloudEvent in input)
            {
                _logger.LogInformation(input[x]?.Id?.ToString());
            }

            //_logger.LogInformation(input.Data.ToString());
        }
    }

    public class MyEvent
{
    public string Id { get; set; }

    public string Topic { get; set; }

    public string Subject { get; set; }

    public string EventType { get; set; }

    public DateTime EventTime { get; set; }

    public string Data { get; set; }
    public string DataVersion { get; set; }
        
    }
}
