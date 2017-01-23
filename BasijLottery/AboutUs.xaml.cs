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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace BasijLottery
{
    /// <summary>
    /// Interaction logic for AboutUs.xaml
    /// </summary>
    public partial class AboutUs : MetroWindow
    {
        public AboutUs()
        {
            InitializeComponent();
            var animation = MainContainer.TryFindResource("StartAnimation") as Storyboard;
            if (animation == null)
                return;
            animation.Completed += (sender, args) =>
            {
                Hide();
                new MainWindow().Show();
            };
            animation.Begin();
        }
    }
}
