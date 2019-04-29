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

namespace UserControlsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private FirstUserControl firstUserControl;
        private SecondUserControl secondUserControl;

        public MainWindow()
        {
            InitializeComponent();
            firstUserControl = new FirstUserControl();
            secondUserControl = new SecondUserControl();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 1
            ucContainer.Content = firstUserControl;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ucContainer.Content = secondUserControl;
        }
    }
}
