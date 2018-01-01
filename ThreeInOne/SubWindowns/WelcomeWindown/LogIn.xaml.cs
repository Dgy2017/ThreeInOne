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

using ThreeInOne.dto.request;
using ThreeInOne.dto.response;
using ThreeInOne.Restful;
using ThreeInOne.SubWindowns.NotificationWindown;

namespace ThreeInOne.SubWindowns.WelcomeWindown
{
    /// <summary>
    /// LogIn.xaml 的交互逻辑
    /// </summary>
    public partial class LogIn : Page
    {
        private Welcome par;
        public LogIn(Welcome par)
        {
            InitializeComponent();
            this.par = par;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            UserLoginRequest userLoginRequest = new UserLoginRequest(userName.Text, userPassword.Password);
            RestfulClient<UserLoginResponse> restful = new RestfulClient<UserLoginResponse>(userLoginRequest);

            UserLoginResponse response = await restful.GetResponse();

            if (response != null)
            {
                (App.Current as App).showNotification(new NotifyData("ThreeInOne", "登录成功，欢迎" + response.user.name));
                this.par.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.par.returnBtn.IsEnabled = true;
            this.par.body.Content = this.par.sign;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.par.Close();
        }
    }
}
