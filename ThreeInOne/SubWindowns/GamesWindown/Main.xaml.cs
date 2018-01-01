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

namespace ThreeInOne.SubWindowns.GamesWindown
{
    /// <summary>
    /// Main.xaml 的交互逻辑
    /// </summary>
    public partial class Main : Page
    {
        private MainWindow par;
        public Main(MainWindow par)
        {
            InitializeComponent();
            this.par = par;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            this.par.body.Content = this.par.frames[Int32.Parse(btn.Name.Substring(3,1))];
            this.par.returnBtn.IsEnabled = true;
            this.par.save.IsEnabled = true;
            this.par.recovery.IsEnabled = true;
        }
    }
}
