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
    /// WriteView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WriteView : Page
    {
        public WriteView()
        {
            InitializeComponent();
        }

        private void tb_Write_TextChanged(object sender, TextChangedEventArgs e)
        {
            string strTemp = tb_Write.Text;

            string[] arrTemp = strTemp.Split('\n');

            if (arrTemp[arrTemp.Length - 1].Length >= 150) 
            {
                strTemp += Environment.NewLine;
            }

            tb_Write.Text = strTemp;
            tb_Write.Select(tb_Write.Text.Length, 0); 
            tb_Write.Focus();
        }

        private void HHI_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/Cancel.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("/View/Cancel.xaml", UriKind.Relative);
            NavigationService.Navigate(uri);
        }

    }
}
