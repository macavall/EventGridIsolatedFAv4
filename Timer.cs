//using System;
//using Microsoft.Azure.Functions.Worker;
//using Microsoft.Extensions.Logging;

//namespace FunctionApp1
//{
//    public class Timer
//    {
//        private readonly ILogger _logger;

//        public Timer(ILoggerFactory loggerFactory)
//        {
//            _logger = loggerFactory.CreateLogger<Timer>();
//        }

//        [Function("Timer")]
//        [EventGridOutput(TopicEndpointUri = "MyEventGridTopicUriSetting", TopicKeySetting = "MyEventGridTopicKeySetting")]
//        public MyEvent Run([TimerTrigger("*/5 * * * * *")] MyInfo myTimer)
//        {
//            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

//            var output = new MyEvent
//            {
//                Id = Guid.NewGuid().ToString(),
//                Topic = "MyTopic",
//                Subject = "MySubject",
//                EventType = "MyEventType",
//                EventTime = DateTime.Now,
//                Data = "MyString",
//                DataVersion = "1.0"
//            };

//            return (MyEvent)output;
//        }
//        //{
//        //    _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
//        //    _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
//        //}
//    }

//    public class MyInfo
//    {
//        public MyScheduleStatus ScheduleStatus { get; set; }

//        public bool IsPastDue { get; set; }
//    }

//    public class MyScheduleStatus
//    {
//        public DateTime Last { get; set; }

//        public DateTime Next { get; set; }

//        public DateTime LastUpdated { get; set; }
//    }
//}
