using FileMonitor.Core.Interfaces;
using FileMonitor.Core.Models;
using System.Diagnostics;
using System.Globalization;

namespace FileMonitor.Loaders.Txt
{
    public class TxtFileLoader : IFileLoader
    {
        public string FileExtension => ".txt";

        public List<DataItem> Load(string filePath)
        {
            var result = new List<DataItem>();

            var lines = File.ReadAllLines(filePath);

            bool isHeader = true;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Skip header line
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                var parts = line.Split(';');

                var trade = new DataItem
                {
                    Date = DateTime.Parse(parts[0]),
                    Open = decimal.Parse(parts[1], CultureInfo.InvariantCulture),
                    High = decimal.Parse(parts[2], CultureInfo.InvariantCulture),
                    Low = decimal.Parse(parts[3], CultureInfo.InvariantCulture),
                    Close = decimal.Parse(parts[4], CultureInfo.InvariantCulture),
                    Volume = long.Parse(parts[5], CultureInfo.InvariantCulture)
                };

                result.Add(trade);
            }

            return result;
        }
    }

}
