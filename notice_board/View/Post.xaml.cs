using System;
using notice_board.Models;
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
    /// Post.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Post : Page
    {

        public Post()
        {
            InitializeComponent();
        // lb_Post.ItemsSource = Post.Instance.GetPost();
        }

        private void Home_go_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/home.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

        private void tb_comment_C(object sender, TextChangedEventArgs e)
        {
            string strTemp = tb_comment.Text;

            string[] arrTemp = strTemp.Split('\n');

            if (arrTemp[arrTemp.Length - 1].Length >= 150)
            {
                strTemp += Environment.NewLine;
            }

            tb_comment.Text = strTemp;
            tb_comment.Select(tb_comment.Text.Length, 0);
            tb_comment.Focus();
        }
    }
}
