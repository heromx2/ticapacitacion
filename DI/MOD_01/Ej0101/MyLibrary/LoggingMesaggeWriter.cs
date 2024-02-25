using Microsoft.Extensions.Logging;
namespace MyLibrary
{
    public class LoggingMesaggeWriter(ILogger<LoggingMesaggeWriter> logger) : IMessageWriter
    {
        public void Write(string message) =>
            logger.LogInformation("LoggingMesaggeWriter: {msg}", message);
    }
}
