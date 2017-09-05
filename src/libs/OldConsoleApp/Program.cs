using OldClassLib1;
using System;

namespace OldConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataset = DataSetCreator.CreateDataSetFromFile("TestFile.xml");

            Console.Write(dataset.GetXmlSchema());
            Console.ReadLine();
        }
    }
}
