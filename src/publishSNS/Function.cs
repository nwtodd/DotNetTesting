using System;

using Amazon;
using Amazon.Lambda.Core;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.LambdaJsonSerializer))]

namespace Function
{
    public class Function
    {
        public dynamic FunctionHandler(dynamic eventTrigger)
        {
            Console.WriteLine(eventTrigger);
            Console.WriteLine("got this far in lambda");
            /*
            var client = new AmazonSimpleNotificationServiceClient(region: Amazon.RegionEndpoint.USWest2);
            var request = new PublishRequest
            {
                Message = message,
                PhoneNumber = number
            };

            try
            {
                var response = client.Publish(request);

                Console.WriteLine("Message sent to " + number + ":");
                Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception publishing request:");
                Console.WriteLine(ex.Message);
            }
            */ 
            return new {};
        }
    }
}
