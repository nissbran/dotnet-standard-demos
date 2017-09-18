using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NetStandard14Lib
{
    public class Awesome14CarReader
    {
        public IEnumerable<string> GetCarNames(string xmlFileName)
        {
            var document = XDocument.Load(xmlFileName);

            var carNames = document.Descendants(XName.Get("Name"));

            return carNames.Select(element => element.Value + " 1.4");
        }
    }
}
