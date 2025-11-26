using FileMonitor.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMonitor.Core.Interfaces
{
    public interface IFileLoader
    {
        string FileExtension { get; }
        List<DataItem> Load(string filePath);
    }
}
