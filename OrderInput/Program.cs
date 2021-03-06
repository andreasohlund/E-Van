﻿using System;
using log4net.Appender;
using log4net.Core;
using NServiceBus;
using OrderService.Messages;

namespace OrderInput
{
    class Program
    {
        static void Main(string[] args)
        {
            IBus bus = Configure.With()
                .Log4Net<ConsoleAppender>(a =>
                    {
                        a.Threshold = Level.Warn;
                    })
                .DefaultBuilder()
                .XmlSerializer()
                .MsmqTransport()
                .UnicastBus()
                .DoNotAutoSubscribe()
                .LoadMessageHandlers()
                .CreateBus()
                .Start();

            while(Console.ReadLine() != "q")
            {
                bus.Send(new CompleteSaleCommand {ProductId = 2, Quantity = 3});

                Console.WriteLine("Command sent");
       
            }
         
            
        }

    }
}
