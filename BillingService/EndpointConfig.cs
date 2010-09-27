using log4net.Appender;
using log4net.Core;
using NServiceBus;

namespace BillingService
{
    public class EndpointConfig:IConfigureThisEndpoint,AsA_Server
    {
        
    }

    internal class LoggingConfig:IConfigureLoggingForProfile<NServiceBus.Lite>
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