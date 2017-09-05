using System.Data;

namespace OldClassLib1
{
    public static class DataSetCreator
    {
        public static DataSet CreateDataSetFromFile(string filePath)
        {
            var dataSet = new DataSet();

            dataSet.ReadXml(filePath);

            return dataSet;
        }
    }
}
