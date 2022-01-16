using notice_board.Models;
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
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace notice_board
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
       //  lb_Home.ItemsSource = Home.Instance.GetHome();

        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
        

            // this.Navigate(new Uri("/View/WriteView.xaml", UriKind.Relative)) ; 

        }


    }
}


