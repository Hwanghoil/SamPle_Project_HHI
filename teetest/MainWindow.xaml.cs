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

namespace teetest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string strTemp = tb_tt.Text;

            string[] arrTemp = strTemp.Split('\n');

            if (arrTemp[arrTemp.Length - 1].Length >= 150) 
            {
                strTemp += Environment.NewLine;
            }

            tb_tt.Text = strTemp;
            tb_tt.Select(tb_tt.Text.Length, 0); 
            tb_tt.Focus();
        }
    }
}
