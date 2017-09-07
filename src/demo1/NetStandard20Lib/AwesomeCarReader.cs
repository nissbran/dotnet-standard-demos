using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NetStandard20Lib
{
    public class Awesome20CarReader
    {
        public IEnumerable<string> GetCarNames(string xmlFileName)
        {
            var document = XDocument.Load(xmlFileName);

            var carNames = document.Descendants(XName.Get("Name"));
            
            return carNames.Select(element => element.Value + " 2.0");
        }
    }
}
