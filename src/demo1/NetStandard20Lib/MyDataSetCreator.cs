using System.Data;

namespace NetStandard20Lib
{
    public class MyDataSetCreator
    {
        public DataSet CreateAwesomeDataSetFromFile(string fileName)
        {
            var dataset = new DataSet();

            dataset.ReadXml(fileName);

            return dataset;
        }
    }
}
