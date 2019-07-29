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

namespace Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += (_, __) => DataContext = new MainWindowViewModel();
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.Source is Image)
            {
                var img = e.Source as Image;
                Clipboard.SetImage(img.Source as BitmapSource);
                //IDataObject data = new DataObject();
                //data.SetData(DataFormats.Bitmap, img, true); // true means autoconvert
                //Clipboard.SetDataObject(data); // true means copy
            }
        }

        private void DgUsers_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                SelectedImage.Source = Clipboard.GetImage();
                Clipboard.Clear();
            }
        }
    }
}
