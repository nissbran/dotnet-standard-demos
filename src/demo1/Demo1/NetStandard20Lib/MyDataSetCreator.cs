﻿using System.Data;
using System.IO;

namespace NetStandard20Lib
{
    public class MyDataSetCreator
    {
        public DataSet IWantSomeData(string fileName)
        {
            var dataset = new DataSet();

            var stream = File.OpenRead(fileName);

            dataset.ReadXml(stream);

            return dataset;
        }
    }
}