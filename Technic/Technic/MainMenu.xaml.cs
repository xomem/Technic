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

namespace Technic
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        Window MainWin;

        public MainMenu(Window MainWindow)
        {
            InitializeComponent();
            this.MainWin = MainWindow;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MainWin.Title = "Главное меню";
        }
    }
}
