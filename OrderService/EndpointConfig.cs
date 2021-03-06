using log4net.Appender;
using log4net.Core;
using NServiceBus;

namespace OrderService
{
    public class EndpointConfig:IConfigureThisEndpoint,AsA_Publisher
    {
        
    }

    internal class LoggingConfig:IConfigureLoggingForProfile<Lite>
    {
        public void Configure(IConfigureThisEndpoint specifier)
        {
            NServiceBus.Configure.Instance.Log4Net<ConsoleAppender>(a =>
                {
                    a.Threshold = Level.Warn;
                });
        }
    }
}