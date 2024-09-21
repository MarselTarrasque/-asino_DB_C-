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

namespace lesson2_casino.Pages
{
    /// <summary>
    /// Логика взаимодействия для Reg_LogPage.xaml
    /// </summary>
    public partial class Reg_LogPage : Page
    {
        public Reg_LogPage()
        {
            InitializeComponent();
            formreg.NavigationService.Navigate(new components.SignInForm());
        }
    }
}
