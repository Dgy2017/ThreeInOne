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
    /// Game1.xaml 的交互逻辑
    /// </summary>
    public partial class Game1 : Page
    {
        private Window par;
        public Game1(Window par)
        {
            InitializeComponent();
            this.par = par;
        }
    }
}
