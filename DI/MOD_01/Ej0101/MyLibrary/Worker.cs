using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MyLibrary
{
    public class Worker(ILogger<Worker> messageWriter) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // .........
                messageWriter.LogInformation(
                    $"Worker running at: {DateTime.Now}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }


    // public class Worker(IMessageWriter messageWriter) : BackgroundService
    //{
    //    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    //    {
    //        while (!stoppingToken.IsCancellationRequested)
    //        {
    //            // .........
    //            messageWriter.Write(
    //                $"Worker running at: {DateTime.Now}");
    //            await Task.Delay(1000, stoppingToken);
    //        }
    //    }
    //}

}
