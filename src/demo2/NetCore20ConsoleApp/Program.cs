using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetCore20ConsoleApp
{
    class Program
    {
        // C# 7.1 async Main
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello from .NET Core 2.0");

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync("http://www.squeed.com");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("It works!");
            }

            
            Console.ReadLine();
        }
    }
}