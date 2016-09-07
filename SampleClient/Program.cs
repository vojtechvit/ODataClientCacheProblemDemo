using SampleClient.Model;
using Simple.OData.Client;
using System;

namespace SampleClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var settings = new ODataClientSettings
            {
                BaseUri = new Uri("http://localhost:9000/v1/"),
                IgnoreUnmappedProperties = true // Does not help
            };

            var client = new ODataClient(settings);

            Console.WriteLine("1. Run SampleODataService.BeforeUpdate");
            Console.WriteLine("2. Press [Enter]");
            Console.ReadLine();
            var test1 = client.For<Organization>().Key(1).FindEntryAsync().Result;
            Console.WriteLine($"Call to the API works: {test1.Name}");
            Console.WriteLine();
            Console.WriteLine("3. Terminate SampleODataService.BeforeUpdate");
            Console.WriteLine("4. Run SampleODataService.AfterUpdate");
            Console.WriteLine("5. Press [Enter]");
            Console.ReadLine();

            try
            {
                var test2 = client.For<Organization>().Key(1).FindEntryAsync().Result;
                Console.WriteLine($"Call to the API fails: {test2.Name}");
            }
            catch (AggregateException aggregateException)
            {
                throw aggregateException.InnerException;
            }
        }
    }
}