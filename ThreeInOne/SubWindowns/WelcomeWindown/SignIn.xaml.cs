﻿using System;
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

namespace ThreeInOne.SubWindowns.WelcomeWindown
{
    /// <summary>
    /// SignIn.xaml 的交互逻辑
    /// </summary>
    public partial class SignIn : Page
    {
        private Window par;
        public SignIn(Window par)
        {
            InitializeComponent();
            this.par = par;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
