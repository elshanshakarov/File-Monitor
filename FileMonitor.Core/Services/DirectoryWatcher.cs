using FileMonitor.Core.Interfaces;
using FileMonitor.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMonitor.Core.Services
{
    public class DirectoryWatcher
    {
        private readonly string _path;
        private readonly int _interval;
        private readonly List<IFileLoader> _loaders;
        private HashSet<string> _processed = new();

        public event Action<string, List<DataItem>>? FileProcessed;

        public DirectoryWatcher(string path, int interval, List<IFileLoader> loaders)
        {
            _path = path;
            _interval = interval;
            _loaders = loaders;
        }

        public async Task StartAsync()
        {
            // İzləniləcək folderin path-i App.config faylında qeyd edilib
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            while (true)
            {
                foreach (var file in Directory.GetFiles(_path))
                {
                    if (_processed.Contains(file)) continue;

                    _processed.Add(file);

                    _ = Task.Run(() => LoadFile(file));
                }

                await Task.Delay(_interval);
            }
        }

        private void LoadFile(string file)
        {
            var loader = _loaders.FirstOrDefault(l => file.EndsWith(l.FileExtension));
            if (loader == null) return;

            var dataItems = loader.Load(file);

            FileProcessed?.Invoke(file, dataItems);
        }
    }
}
