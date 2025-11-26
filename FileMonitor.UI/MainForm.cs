using FileMonitor.Core.Interfaces;
using FileMonitor.Core.Models;
using FileMonitor.Core.Services;
using System.Configuration;

namespace FileMonitor.UI
{
    public partial class MainForm : Form
    {
        private DirectoryWatcher _watcher;
        private List<IFileLoader> _loaders;

        public MainForm()
        {
            InitializeComponent();
            LoadConfig();
            LoadPlugins();
            StartWatcher();
        }

        void LoadConfig()
        {
            txtFolder.Text = ConfigurationManager.AppSettings["InputFolder"];
            txtInterval.Text = ConfigurationManager.AppSettings["Interval"];
        }

        void LoadPlugins()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            _loaders = PluginLoader.LoadPlugins(path);
            listLoaders.DataSource = _loaders.Select(x => x.FileExtension).ToList();
        }

        async void StartWatcher()
        {
            _watcher = new DirectoryWatcher(
                txtFolder.Text,
                int.Parse(txtInterval.Text),
                _loaders);

            _watcher.FileProcessed += OnFileProcessed;

            await _watcher.StartAsync();
        }

        void OnFileProcessed(string file, List<DataItem> items)
        {
            Invoke(new Action(() =>
            {
                listFiles.Items.Add(Path.GetFileName(file));
                dataGrid.DataSource = items;
            }));
        }
    }
}
