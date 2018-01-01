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

namespace ThreeInOne.SubWindowns.WelcomeWindown
{
    /// <summary>
    /// Welcome.xaml 的交互逻辑
    /// </summary>
    public partial class Welcome : Window
    {
        private Frame login;

        public Frame sign;     
        public Welcome()
        {
            this.InitializeComponent();
            this.sign = new Frame() { Content = new SignIn(this) };
            this.login = new Frame() { Content = new LogIn(this) };
            this.returnBtn.IsEnabled = false;

            this.body.Content = this.login;
        }

        public void signIn_Click(object sender, RoutedEventArgs e)
        {
            if (this.sign == null)
            {     
                this.sign = new Frame() { Content = new SignIn(this) };
            }
            if (this.body.Content==this.sign)
            {
                this.body.Content = this.login;
            }
            else
            {
                this.body.Content = this.sign;
            }
            
        }

        private void WrapPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void returnBtn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.IsEnabled = false;
            this.body.Content = this.login;
            this.Close();
        }
    }
}
