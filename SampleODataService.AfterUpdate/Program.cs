using Microsoft.Owin.Hosting;
using System;

namespace SampleODataService.AfterUpdate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Website AFTER UPDATE started on {baseAddress}. Press [Enter] to stop it.");
                Console.ReadLine();
            }
        }
    }
}