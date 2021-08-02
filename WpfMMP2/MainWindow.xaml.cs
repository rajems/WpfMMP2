using System;
using System.Collections.Generic;
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

namespace WpfMMP2
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
        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            RenderChart.Children.Clear();
            RenderChart.Children.Add(new LiveChart());
            //RenderChart1.Children.Clear();
            //RenderChart1.Children.Add(new LiveChart());
            //RenderChart2.Children.Clear();
            //RenderChart2.Children.Add(new LiveChart());
            //RenderChart3.Children.Clear();
            //RenderChart3.Children.Add(new LiveChart());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RenderChart.Children.Clear();
            RenderChart.Children.Add(new LiveChart());
            //RenderChart1.Children.Clear();
            //RenderChart1.Children.Add(new LiveChart());
            //RenderChart2.Children.Clear();
            //RenderChart2.Children.Add(new LiveChart());
            //RenderChart3.Children.Clear();
            //RenderChart3.Children.Add(new LiveChart());
        }
    }
}
