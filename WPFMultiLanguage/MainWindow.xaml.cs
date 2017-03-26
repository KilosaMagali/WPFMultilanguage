using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WPFMultiLanguage
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string str = FindResource("language").ToString(); 
            string str = Application.Current.Resources["language"] as string;
            labelAngu.Content = str;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CultureInfo.CurrentCulture.Name == "de-DE")
                App.SelectCulture("en-EN");
            else if (CultureInfo.CurrentCulture.Name == "en-EN")
                App.SelectCulture("fr-FR");
            else if (CultureInfo.CurrentCulture.Name == "fr-FR")
                App.SelectCulture("de-DE");
        }
    }
}
