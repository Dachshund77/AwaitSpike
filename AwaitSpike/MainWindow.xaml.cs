using System;
using System.Collections.Generic;
using System.Linq;
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

namespace AwaitSpike
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string test = await DoMagic("test"); //What is the best way to block this. Adding boolean to this method seems.... dirty
            Console.WriteLine(test);
        }

        private async Task<string> DoMagic(string txt)
        {
            return await Task.Run<string>(() =>
            {
                Thread.Sleep(5000);
                return txt + "Done";
            });
        }
    }
}
