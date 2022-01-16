using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace notice_board
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* Uri uri = new Uri("/View/post.xaml", UriKind.Relative);
            NavigationService.Navigate(uri); */
        }

        private void TextBox_num(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
           /* Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text); */
        }
    }
}
