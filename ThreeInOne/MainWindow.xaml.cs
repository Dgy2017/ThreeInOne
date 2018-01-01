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

using ThreeInOne.SubWindowns.GamesWindown;

namespace ThreeInOne
{
    using ThreeInOne.SubWindowns.WelcomeWindown;

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public Frame[] frames;
        public MainWindow()
        {
            this.InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.frames = new Frame[4]
                              {
                                  new Frame() { Content = new Main(this) }, new Frame() { Content = new Game1(this) },
                                  new Frame() { Content = new Game2(this) }, new Frame() { Content = new Game3(this) },
                              };
            this.body.Content = this.frames[0];
            this.returnBtn.IsEnabled = false;
        }

        private void Window_SourceInitialized(object sender, EventArgs e)
        {
            Welcome wel = new Welcome();
            wel.ShowDialog();
        }

        private void WrapPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void returnBtn_Click(object sender, RoutedEventArgs e)
        {
            //todo
            if (MessageBox.Show("确认退出？", "ThreeInOne", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                this.body.Content = this.frames[0];
                this.returnBtn.IsEnabled = false;
                this.recovery.IsEnabled = false;
                this.save.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
