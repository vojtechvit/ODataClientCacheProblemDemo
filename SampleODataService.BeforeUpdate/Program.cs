using Microsoft.Owin.Hosting;
using System;

namespace SampleODataService.BeforeUpdate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Website BEFORE UPDATE started on {baseAddress}. Press [Enter] to stop it.");
                Console.ReadLine();
            }
        }
    }
}