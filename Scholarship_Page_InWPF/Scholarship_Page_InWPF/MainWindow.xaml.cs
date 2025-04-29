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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Scholarship_Page_InWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tbmarquee_MouseMove(object sender, MouseEventArgs e)
        {
            double height = canMain.ActualHeight - tbmarquee.ActualHeight;
            tbmarquee.Margin = new Thickness(0, height / 1, 0, 0);
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = -tbmarquee.ActualWidth;
            doubleAnimation.To = canMain.ActualWidth;
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(10));
            tbmarquee.BeginAnimation(Canvas.LeftProperty, doubleAnimation);
        }

        private void tbmarquee1_MouseMove(object sender, MouseEventArgs e)
        {
            double height = canMain2.ActualHeight - tbmarquee1.ActualHeight;
            tbmarquee1.Margin = new Thickness(0, height / 1, 0, 0);
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = -tbmarquee1.ActualWidth;
            doubleAnimation.To = canMain2.ActualWidth;
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(10));
            tbmarquee1.BeginAnimation(Canvas.LeftProperty, doubleAnimation);
        }
    }
}
