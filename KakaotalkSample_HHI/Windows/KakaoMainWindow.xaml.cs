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

namespace KakaotalkSample_HHI.Windows
{
    /// <summary>
    /// KakaoMainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class KakaoMainWindow : Window
    {
        public KakaoMainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Setting_Click(object sender, RoutedEventArgs e)
        {
            Tab_KakaoMain.SelectedIndex = 2;
        }

        private void Btn_Chat_Click(object sender, RoutedEventArgs e)
        {
            Tab_KakaoMain.SelectedIndex = 1;
        }

        private void Btn_Friend_Click(object sender, RoutedEventArgs e)
        {
            Tab_KakaoMain.SelectedIndex = 0;
        }

        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Maximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
        }

        private void Btn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
