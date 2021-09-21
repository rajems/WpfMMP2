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

namespace WpfMMP3
{
    /// <summary>
    /// Interaction logic for LiveChart.xaml
    /// </summary>
    public partial class LiveChart : UserControl
    {
        public static readonly DependencyProperty SeriesCollectionProperty = DependencyProperty.Register(
    "SeriesCollection",
    typeof(SeriesCollection),
    typeof(LiveChart),
    new PropertyMetadata(default(SeriesCollection)));
        public SeriesCollection SeriesCollection {
            get => (SeriesCollection)GetValue(LiveChart.SeriesCollectionProperty);
            set => SetValue(LiveChart.SeriesCollectionProperty, value);
        }
        public static readonly DependencyProperty SeriesCollection2Property = DependencyProperty.Register(
    "SeriesCollection2",
    typeof(SeriesCollection),
    typeof(LiveChart),
    new PropertyMetadata(default(SeriesCollection)));
        public SeriesCollection SeriesCollection2
        {
            get => (SeriesCollection)GetValue(LiveChart.SeriesCollection2Property);
            set => SetValue(LiveChart.SeriesCollection2Property, value);
        }
        public LiveChart()
        {
            InitializeComponent();
            
            SeriesCollection = new SeriesCollection
                {
                new LineSeries
                {
                    Title = "ECG",
                    Values = new ChartValues<double> { 0, 6, 1, 5 ,0,6, 1, 5 ,0,6, 1, 5 ,0 },
                    PointGeometry= null,
                    Stroke= Brushes.Green


                }
               
            };
            SeriesCollection2 = new SeriesCollection
                {
                new LineSeries
                {
                    Title = "Pleth",
                    Values = new ChartValues<double> { 0, 6, 5, 1 ,0,6, 5, 1 ,0,6, 5, 1 ,0 },
                    PointGeometry= null,
                    Stroke= Brushes.Blue


                }

            };
            this.DataContext = this;
        }
    }
}
