using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NetCore11Lib
{
    public class AwesomeCore11CarReader
    {
        public IEnumerable<string> GetCarNames(string xmlFileName)
        {
            var document = XDocument.Load(xmlFileName);

            var carNames = document.Descendants(XName.Get("Name"));

            return carNames.Select(element => element.Value + " Core 1.1");
        }
    }
}
