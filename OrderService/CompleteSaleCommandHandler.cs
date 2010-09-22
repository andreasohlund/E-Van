using System;
using NServiceBus;
using OrderService.Messages;

namespace OrderService
{
    public class CompleteSaleCommandHandler:IHandleMessages<CompleteSaleCommand>
    {
        public void Handle(CompleteSaleCommand message)
        {
            Console.WriteLine(string.Format("An order for product {0} arrived",message.ProductId));
        }
    }
}