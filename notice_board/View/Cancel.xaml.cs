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
    /// Cancel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Cancel : Page
    {
        public Cancel()
        {
            InitializeComponent();
        }

        private void Complate_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/home.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            { NavigationService.GoBack(); }

        }
    }
}
