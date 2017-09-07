using System.Data;
using System.IO;

namespace NetStandard20Lib
{
    public class MyDataSetCreator
    {
        public DataSet IWantSomeData(string fileName)
        {
            var dataset = new DataSet();

            dataset.ReadXml(fileName);

            return dataset;
        }
    }
}
