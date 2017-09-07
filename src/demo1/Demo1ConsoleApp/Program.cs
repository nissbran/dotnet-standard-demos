using NetStandard13Lib;
using NetStandard20Lib;
using System;
using System.Linq;

namespace Demo1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader16 = new Awesome13CarReader();
            var carNames16 = reader16.GetCarNames("CarData.xml");

            foreach (var car in carNames16)
            {
                Console.WriteLine(car);
            }

            var reader20 = new Awesome20CarReader();
            var carNames20 = reader20.GetCarNames("CarData.xml");

            foreach (var car in carNames20)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();

            var creator = new MyDataSetCreator();

            var carData = creator.IWantSomeData("CarData.xml");

            var schema = carData.GetXmlSchema();
            var data = carData.GetXml();

            Console.WriteLine(schema);
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
