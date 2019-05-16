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

namespace PicDB
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.75);
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.675);

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        public int method()
        {
            return 4;
        }

        private void ImgScrollbar_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
