using NetStandard20Lib;

namespace Demo1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new MyDataSetCreator();

            var carData = creator.IWantSomeData("MyData.xml");

            var schema = carData.GetXmlSchema();
        }
    }
}
