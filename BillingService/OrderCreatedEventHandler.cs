using System;
using NServiceBus;
using OrderService.Messages;

namespace BillingService
{
    public class OrderCreatedEventHandler:IHandleMessages<OrderCreatedEvent>
    {
        public void Handle(OrderCreatedEvent message)
        {
            Console.WriteLine("Order created for product: " + message.ProductId);
        }
    }
}