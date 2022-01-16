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
using BaseballSample_HHI.Model;

namespace BaseballSample_HHI
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<KboRanking> ImageRanking = new List<KboRanking>();
        public string imageurl { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;


            MaxHeight = SystemParameters.PrimaryScreenHeight - SystemParameters.CaptionHeight;

            KboRanking kboranking = new KboRanking();
            lb_kboranking.ItemsSource = kboranking.GetKboRanking(1);           
            lb_kboranking2.ItemsSource = kboranking.GetKboRanking(2);
            lb_kboranking3.ItemsSource = kboranking.GetKboRanking(3);
            lb_kboranking4.ItemsSource = kboranking.GetKboRanking(4);
            lb_kboranking5.ItemsSource = kboranking.GetKboRanking(5);
            lb_kboranking6.ItemsSource = kboranking.GetKboRanking(6);
            lb_kboranking7.ItemsSource = kboranking.GetKboRanking(7);
            lb_kboranking8.ItemsSource = kboranking.GetKboRanking(8);
            lb_kboranking9.ItemsSource = kboranking.GetKboRanking(9);
            lb_kboranking10.ItemsSource = kboranking.GetKboRanking(10);
            lb_kboranking11.ItemsSource = kboranking.GetKboRanking(11);
            lb_kboranking12.ItemsSource = kboranking.GetKboRanking(12);
            //lb_kboranking13.ItemsSource = kboranking.GetKboRanking(1);
            lb_kboranking14.ItemsSource = kboranking.GetKboRanking(2);
            lb_kboranking15.ItemsSource = kboranking.GetKboRanking(3);
            lb_kboranking16.ItemsSource = kboranking.GetKboRanking(4);
            lb_kboranking17.ItemsSource = kboranking.GetKboRanking(5);
            lb_kboranking18.ItemsSource = kboranking.GetKboRanking(6);
            lb_kboranking19.ItemsSource = kboranking.GetKboRanking(7);
            lb_kboranking20.ItemsSource = kboranking.GetKboRanking(8);
            lb_kboranking21.ItemsSource = kboranking.GetKboRanking(9);
            lb_kboranking22.ItemsSource = kboranking.GetKboRanking(10);
            lb_kboranking23.ItemsSource = kboranking.GetKboRanking(11);
            lb_kboranking24.ItemsSource = kboranking.GetKboRanking(12);


            ImageRanking = kboranking.GetKboRanking(1);

            imageurl = ImageRanking.OrderBy(x => x.Ranking).FirstOrDefault().Image;
        }
        

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {            
            Team myTeam = new Team();                  

            var grid = sender as DataGrid;

            grid.ItemsSource = myTeam.GetMyTeamData();
        }

        private void Batter_Loaded(object sender, RoutedEventArgs e)
        {
            Batter_Rank myBatter_Rank = new Batter_Rank();

            var grid = sender as DataGrid;

            grid.ItemsSource = myBatter_Rank.GetMyBatterData();
        }
        private void Pitcher_Loaded(object sender, RoutedEventArgs e)
        {
            Pitcher_Rank myBatter_Rank = new Pitcher_Rank();

            var grid = sender as DataGrid;

            grid.ItemsSource = myBatter_Rank.GetMyPitcherData();
        }
    }
}


