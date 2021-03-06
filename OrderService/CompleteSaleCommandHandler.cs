using System;
using NServiceBus;
using OrderService.Messages;

namespace OrderService
{
    public class CompleteSaleCommandHandler:IHandleMessages<CompleteSaleCommand>
    {
        readonly IBus bus;

        public CompleteSaleCommandHandler(IBus bus)
        {
            this.bus = bus;
        }

        public void Handle(CompleteSaleCommand message)
        {
            Console.WriteLine(string.Format("An order for product {0} arrived",message.ProductId));

            bus.Reply(new CompleteSaleResponse{Outcome=CommandOutcome.Success,CommandId = bus.CurrentMessageContext.Id});

            bus.Publish<OrderCreatedEvent>(x=>
                {
                    x.ProductId = message.ProductId;
                });
        }
    }
}