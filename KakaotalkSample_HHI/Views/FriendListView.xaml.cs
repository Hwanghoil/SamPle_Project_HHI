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
using KakaotalkSample_HHI.Model;

namespace KakaotalkSample_HHI.Views
{
    /// <summary>
    /// FrendListView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FriendListView : UserControl
    {        
        public FriendListView()
        {
            InitializeComponent();
            Lb_List.ItemsSource = FriendListModel.GetFriendLists();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }       
        
        private void Btn_Close_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


