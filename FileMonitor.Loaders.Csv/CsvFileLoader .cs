using FileMonitor.Core.Interfaces;
using FileMonitor.Core.Models;
using System.Diagnostics;
using System.Globalization;

namespace FileMonitor.Loaders.Csv
{
    public class CsvFileLoader : IFileLoader
    {
        public string FileExtension => ".csv";

        public List<DataItem> Load(string filePath)
        {
            var result = new List<DataItem>();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(',');

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
