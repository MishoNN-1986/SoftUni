using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            ShowImageAsync(Image1, "https://http.cat/101");
            ShowImageAsync(Image2, "https://http.cat/201");
            ShowImageAsync(Image3, "https://http.cat/203");
            ShowImageAsync(Image4, "https://http.cat/301");
            ShowImageAsync(Image5, "https://http.cat/400");
            ShowImageAsync(Image6, "https://http.cat/402");
        }

        private async Task ShowImageAsync(Image image, string url)
        {
            //HttpClient httpClient = new HttpClient();
            //httpClient.GetAsync("http://");
            WebClient wc = new WebClient();
            var result = await wc.DownloadDataTaskAsync(url);
            await Task.Run(() => Thread.Sleep(2000));
            image.Source = LoadImage(result);
        }

        private static BitmapImage LoadImage(byte[] imageData) //copy from google (byte array to image wpf)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
