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
                var stream = await response.Content.ReadAsStreamAsync();

                using (var reader = new StreamReader(stream))
                {
                    await reader.ReadLineAsync();
                    var secondLine = await reader.ReadLineAsync();
                    Console.WriteLine(secondLine);
                }
            }

            
            Console.ReadLine();
        }
    }
}