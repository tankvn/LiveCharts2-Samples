using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;
using System.Windows.Media;

namespace WpfSample
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public SeriesCollection series
		{
			get
			{
				return new SeriesCollection
				{
					new LineSeries()
					{
						Values = new ChartValues<double> { 3000, 5000, 7000, 4000 },
						Stroke = Brushes.Red,
						Fill = Brushes.Yellow,
						StrokeDashArray = new DoubleCollection {2, 5, 8},
						Title = "販売"
					},
					new ColumnSeries()
					{
						Values = new ChartValues<double> { 5, 6, 2, 7},
						Stroke = Brushes.Green,
						Fill = Brushes.Black,
						StrokeThickness = 3,
						Title = "製品"
					}
				};
			}
		}

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			this.DataContext = this;
		}
	}
}
