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

namespace lesson2_casino
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            FrameSideBar.NavigationService.Navigate(new SideBarPages.SIdeBarLog());
            FRAME.NavigationService.Navigate(new Pages.Reg_LogPage());
        }

        private void FRAME_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
