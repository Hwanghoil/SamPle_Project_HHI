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
using StackoverflowSample_HHI.Models;

namespace StackoverflowSample_HHI
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lb_Question.ItemsSource = Question.Instance.GetQuestion();

            InitializeComponent();
            lb_Blog.ItemsSource = Blog.Instance.GetBlog();

            InitializeComponent();
            lb_meta.ItemsSource = Meta.Instance.GetMeta();
        }


        private void ListBox_Selected(object sender, RoutedEventArgs e)
        {

        }
    }


}
