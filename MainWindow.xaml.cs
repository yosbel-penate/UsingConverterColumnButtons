using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
namespace UsingConverterColumnButtons
{
    public class VisibilityConverter2 : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            bool visibility = (bool)value;
            return visibility ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Visible);
        }
    }
    public class VisibilityConverter : IValueConverter
    {
       
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            bool visibility = (bool)value;
            return visibility ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility == Visibility.Visible);
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            List<MyData> sampleData = new List<MyData>
{
    new MyData
    {
        Name = "Apple iPhone 3G",
        IsBuyable = false
    },
    new MyData
    {
        Name = "Microsoft Silverlight 2",
        IsBuyable = true,
    },
    new MyData
    {
        Name = "Microsoft .NET Framework 3.5",
        IsBuyable = true
    },
    new MyData
    {
        Name = "Microsoft Visual Studio 2008",
        IsBuyable = true
    },
    new MyData
    {
        Name = "Microsoft Windows Vista Ultimate",
        IsBuyable = false
    }
};

            SampleGrid.ItemsSource = sampleData;
        }

        private void button02_Click(object sender, RoutedEventArgs e)
        {
            MyData model = (sender as Button).DataContext as MyData;
            model.IsBuyable = true;
        }

        private void button01_Click(object sender, RoutedEventArgs e)
        {
            MyData model = (sender as Button).DataContext as MyData;
            model.IsBuyable = false;
        }
    }
}
