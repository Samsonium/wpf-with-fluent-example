using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileListExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> fileList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            fileList = new ObservableCollection<string>();
            for (int i = 0; i < 10; i++)
                fileList.Add("File #" + i);
            filelist.ItemsSource = fileList;

            Console.WriteLine($"Created {fileList.Count} items");
        }
    }
}
