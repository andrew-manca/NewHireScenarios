using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.NetworkInformation;

namespace TimerSendRESTFA
{
    public class Function1
    {
        static HttpClient client = new HttpClient();
        static Uri url = new Uri(Environment.GetEnvironmentVariable("url"));
        static int loopCount = Convert.ToInt32(Environment.GetEnvironmentVariable("loopCount"));
        static List<Uri> urls = new List<Uri>();

        [FunctionName("Function1")]
        public async Task Run([TimerTrigger("*/1 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            var tasks = new List<Task>();

            // Loop through creating the number of messages specified
            for (int i = 0; i < loopCount; i++)
            {
                var msg = new HttpRequestMessage()
                {
                    RequestUri = url,
                    Method = HttpMethod.Get
                };

                tasks.Add(client.SendAsync(msg));
            }
            
            // Await for tasks complete
            await Task.WhenAll(tasks);
        }
    }
}
