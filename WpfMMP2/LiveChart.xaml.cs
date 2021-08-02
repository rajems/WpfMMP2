using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace WpfMMP2
{
    /// <summary>
    /// Interaction logic for LiveChart.xaml
    /// </summary>
    public partial class LiveChart : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public LiveChart()
        {
            InitializeComponent();
            SeriesCollection = new SeriesCollection
                {
                new LineSeries
                {
                    Title = "Pleth",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 },
                    PointGeometry= null,
                    Stroke= Brushes.Green


                }
            };

        }
    }
}
