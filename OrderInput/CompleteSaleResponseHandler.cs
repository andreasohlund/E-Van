using System;
using NServiceBus;
using OrderService.Messages;

namespace OrderInput
{
    public class CompleteSaleResponseHandler : IHandleMessages<CompleteSaleResponse>
    {
        public void Handle(CompleteSaleResponse message)
        {
            Console.WriteLine(string.Format("Outcome for id: {0} is {1}", message.CommandId, message.Outcome));
        }
    }
}