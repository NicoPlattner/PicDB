using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace PicDB
{
    /// <summary>
    /// bla
    /// </summary>
    public partial class ImgScrollbar : UserControl, INotifyPropertyChanged
    {
        private string test = "teststring";

        public ImgScrollbar()
        {
            DataContext = this;

            InitializeComponent();

            String currDir = Directory.GetCurrentDirectory();
            string[] images = Directory.GetFiles(currDir + "\\Resources");

            foreach (string image in images)
            {
                Image img = new Image();
                img.Height = 100;
                img.Margin = new Thickness(20, 0, 20, 0);
                img.VerticalAlignment = VerticalAlignment.Center;

                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri(image, UriKind.RelativeOrAbsolute);
                logo.EndInit();

                img.Source = logo;

                ListViewItem item = new ListViewItem();
                item.Content = img;

                imgs.Items.Add(item);
            }
        }


        public static readonly DependencyProperty CompanyNameProperty = 
            DependencyProperty.Register("teststr", typeof(string), typeof(ImgScrollbar), new UIPropertyMetadata());



        public string teststr
        {
            get { return this.test; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberNameAttribute] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
