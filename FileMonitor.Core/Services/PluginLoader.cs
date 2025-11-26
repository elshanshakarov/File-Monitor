using FileMonitor.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileMonitor.Core.Services
{
    public static class PluginLoader
    {
        public static List<IFileLoader> LoadPlugins(string folder)
        {
            var loaders = new List<IFileLoader>();

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            foreach (string dll in Directory.GetFiles(folder, "*.dll"))
            {
                var asm = Assembly.LoadFrom(dll);

                var types = asm.GetTypes()
                    .Where(t => typeof(IFileLoader).IsAssignableFrom(t) && !t.IsInterface);

                foreach (var type in types)
                    loaders.Add((IFileLoader)Activator.CreateInstance(type)!);
            }

            return loaders;
        }
    }
}
