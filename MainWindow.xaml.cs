using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
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
        IsBuyable = true
    },
    new MyData
    {
        Name = "Microsoft Silverlight 2",
        IsBuyable = false,
    },
    new MyData
    {
        Name = "Microsoft .NET Framework 3.5"
    },
    new MyData
    {
        Name = "Microsoft Visual Studio 2008",
        IsBuyable = false
    },
    new MyData
    {
        Name = "Microsoft Windows Vista Ultimate",
        IsBuyable = true
    }
};

            SampleGrid.ItemsSource = sampleData;
        }
    }
}
