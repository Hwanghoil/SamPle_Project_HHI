using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XboxSample_HHI
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

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            var cm = ContextMenuService.GetContextMenu(sender as DependencyObject);
            if (cm == null)
            {
                return;
            }
            cm.Placement = PlacementMode.Top;
            cm.PlacementTarget = sender as UIElement;
            cm.IsOpen = true;
        }

        private void Menu_Plus_Click(object sender, RoutedEventArgs e)
        {
            var cm = ContextMenuService.GetContextMenu(sender as DependencyObject);
            if (cm == null)
            {
                return;
            }
            cm.Placement = PlacementMode.Right;
            cm.PlacementTarget = sender as UIElement;
            cm.IsOpen = true;
        }

        private void Microsoft_Click(object sender, RoutedEventArgs e)
        {
            var cm = ContextMenuService.GetContextMenu(sender as DependencyObject);
            if (cm == null)
            {
                return;
            }
            cm.Placement = PlacementMode.Custom;
            cm.CustomPopupPlacementCallback += (Size popupSize, Size targetSize, Point offset) =>
            new[] { new CustomPopupPlacement() { Point = new Point(targetSize.Width - popupSize.Width, targetSize.Height) } };
            cm.PlacementTarget = sender as UIElement;
            cm.IsOpen = true;
        }

        private void textBlock_MouseDown(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = Resources["MoveAnimationKey"] as DoubleAnimation;
            TextBlock textBlock = sender as TextBlock;

            doubleAnimation.To = -(int.Parse(textBlock.Text) - 1) * 1900;

            this.imageSlideStackPanel.BeginAnimation(Canvas.LeftProperty, doubleAnimation, HandoffBehavior.Compose);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ctm_Search.IsOpen = false;
        }
    }
}
