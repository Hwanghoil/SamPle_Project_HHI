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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace notice_board.View
{
    /// <summary>
    /// home.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
            lb_Home.ItemsSource = Home.Instance.GetHome();

           
        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/WriteView.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
     
        }

        private void Signup_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/Signup.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

        private void Post_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/Post.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }
    }
}
