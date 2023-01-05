using System.Runtime.Serialization.Json;
using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace QueueReceiver
{
    class Program
    {
        // connection string to your Service Bus namespace
        static string connectionString = "Endpoint=sb://ibasnamespace69.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=NdMuFtETrZzdPjnjUeDqUVHiO7ooooY469lXkrvjrro=";
        // name of your Service Bus queue
        static string queueName = "IBASProductionQueue";
        // the client that owns the connection and can be used to create senders and receivers
        static ServiceBusClient? client;
        // the processor that reads and processes messages from the queue
        static ServiceBusProcessor? processor;
        // handle received messages
        static async Task MessageHandler(ProcessMessageEventArgs args)
        {
            string body = args.Message.Body.ToString();

            Employee ansatPOCO = JsonSerializer.Deserialize<Employee>(body);

            Console.WriteLine($"Received: ID: {ansatPOCO.Id}, NAME: {ansatPOCO.Name}, DEPARTMENT: {ansatPOCO.Department}");
            // complete the message. messages is deleted from the queue.
            await args.CompleteMessageAsync(args.Message);
        }
        // handle any errors when receiving messages
        static Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }
        static async Task Main()
        {
            // The Service Bus client types are safe to cache and use as a singleton for the lifetime
            // of the application, which is best practice when messages are being published or read
            // regularly.
            //
            // Create the client object that will be used to create sender and receiver objects
            client = new ServiceBusClient(connectionString);
            // create a processor that we can use to process the messages
            processor = client.CreateProcessor(queueName, new
            ServiceBusProcessorOptions());
            try
            {
                // add handler to process messages
                processor.ProcessMessageAsync += MessageHandler;
                // add handler to process any errors
                processor.ProcessErrorAsync += ErrorHandler;
                // start processing
                await processor.StartProcessingAsync();
                Console.WriteLine("Wait for a minute and then press any key to end the processing");
                Console.Read();
                // stop processing
                Console.WriteLine("\nStopping the receiver...");
                await processor.StopProcessingAsync();
                Console.WriteLine("Stopped receiving messages");
            }
            finally
            {
                // Calling DisposeAsync on client types is required to ensure that network
                // resources and other unmanaged objects are properly cleaned up.
                await processor.DisposeAsync();
                await client.DisposeAsync();
            }
        }
    }
}