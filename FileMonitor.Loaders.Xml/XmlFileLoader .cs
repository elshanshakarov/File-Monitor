using FileMonitor.Core.Interfaces;
using FileMonitor.Core.Models;
using System.Globalization;
using System.Xml.Linq;

namespace FileMonitor.Loaders.Xml
{
    public class XmlFileLoader : IFileLoader
    {
        public string FileExtension => ".xml";

        public List<DataItem> Load(string filePath)
        {
            var result = new List<DataItem>();

            var xdoc = XDocument.Load(filePath);

            foreach (var x in xdoc.Root.Elements("value"))
            {
                var trade = new DataItem
                {
                    Date = DateTime.Parse(x.Attribute("date").Value),
                    Open = decimal.Parse(x.Attribute("open").Value, CultureInfo.InvariantCulture),
                    High = decimal.Parse(x.Attribute("high").Value, CultureInfo.InvariantCulture),
                    Low = decimal.Parse(x.Attribute("low").Value, CultureInfo.InvariantCulture),
                    Close = decimal.Parse(x.Attribute("close").Value, CultureInfo.InvariantCulture),
                    Volume = long.Parse(x.Attribute("volume").Value, CultureInfo.InvariantCulture)
                };

                result.Add(trade);
            }

            return result;
        }
    }
}
