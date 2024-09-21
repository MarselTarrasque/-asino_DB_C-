using lesson2_casino.DataBase;
using lesson2_casino.SideBarPages;
using lesson2_casino.SideBarPages.Admin;
using lesson2_casino.Pages;
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

namespace lesson2_casino.Pages.components
{
    /// <summary>
    /// Логика взаимодействия для SignInForm.xaml
    /// </summary>
    public partial class SignInForm : Page
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void ButtonNav_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegForm());
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string LoginUser = LoginTxtBox.Text;
            var USER = DBConn.DBCONNECT.Client.FirstOrDefault(name => name.Login == LoginUser);

            if (USER == null)
            {
                MessageBox.Show("Пользователь с таким логином не существует!");
            }
            else if (USER.Password != PasswordTxtBox.Text)
            {
                MessageBox.Show("Неправильный пароль!");
            }
            else {
                MessageBox.Show("Вход прошел успешно!");
                if(Convert.ToString(USER.Roles) == "1")
                {
                    MainWindow.Instance.FrameSideBar.Navigate(new SideBarMenuAdmin(USER.Login));
                    MainWindow.Instance.FRAME.Navigate(new HomePage.HomePage());
                }
                else
                {
                    MainWindow.Instance.FrameSideBar.Navigate(new SideBarMenu(USER.Login));
                    MainWindow.Instance.FRAME.Navigate(new HomePage.HomePage());
                }
            }
        }
    }
}
