using System.Runtime.Serialization.Json;
using System.Threading;
using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Core;
namespace QueueSender
{
    class Program
    {
        // connection string to your Service Bus namespace
        static string connectionString = "Endpoint=sb://ibasnamespace69.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=NdMuFtETrZzdPjnjUeDqUVHiO7ooooY469lXkrvjrro=";

        // static string connectionString = "Endpoint=sb://ibasnamespace1604.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=T2A10PvUFmCkIGvLUouFfEQ3LrHsCpCCoJmxQlR7syA=";

        // name of your Service Bus queue
        static string queueName = "IBASProductionQueue";
        // the client that owns the connection and can be used to create senders and receivers
        static ServiceBusClient? client;
        // the sender used to publish messages to the queue
        static ServiceBusSender? sender;
        // number of messages to be sent to the queue
        private const int numOfMessages = 4;


        static async Task Main()
        {
            Employee ansatPOCO = new Employee
            {
                Id = 23,
                Name = "Lars",
                Department = "IT"
            };

            string json = JsonSerializer.Serialize(ansatPOCO);

            // The Service Bus client types are safe to cache and use as a singleton for the lifetime
            // of the application, which is best practice when messages are being published or read
            // regularly.
    
            // Create the clients that we'll use for sending and processing messages.
            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(queueName);
            // create a batch
            using ServiceBusMessageBatch messageBatch = await
            sender.CreateMessageBatchAsync();
            for (int i = 1; i <= numOfMessages; i++)
            {
                // try adding a message to the batch
                if (!messageBatch.TryAddMessage(new ServiceBusMessage(json)))
                {
                    // if it is too large for the batch
                    throw new Exception($"The message {i} is too large to fit in the batch.");
                }
            }
            try
            {
                // Use the producer client to send the batch of messages to the Service Bus queue
                await sender.SendMessagesAsync(messageBatch);
                Console.WriteLine($"A batch of {numOfMessages} messages has been published to the queue.");
            }
            finally
            {
                // Calling DisposeAsync on client types is required to ensure that network
                // resources and other unmanaged objects are properly cleaned up.
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }
            Console.WriteLine("Press any key to end the application");
            Console.Read();
        }
    }
}