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

namespace BaseballSample_HHI.Controls
{
    /// <summary>
    /// SamllCardHeader.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SamllCardHeader : UserControl
    {
        public static readonly DependencyProperty HeaderTitle =
                DependencyProperty.Register(
                "Title", typeof(string),
                typeof(string)
                );
        public string HdTitle
        {
            get { return (string)GetValue(HeaderTitle); }
            set { SetValue(HeaderTitle, value); }
        }

        public SamllCardHeader()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
