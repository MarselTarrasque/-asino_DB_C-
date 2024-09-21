using lesson2_casino.DataBase;
using lesson2_casino.Pages.HomePage;
using lesson2_casino.SideBarPages;
using lesson2_casino.SideBarPages.Admin;
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
    /// Логика взаимодействия для RegForm.xaml
    /// </summary>
    public partial class RegForm : Page
    {
        public string LOGIN { get; set; }
        public RegForm()
        {
            InitializeComponent();
        }
        private void ButtonNav_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignInForm());
        }

        private void CheckBoxAdmin_Checked(object sender, RoutedEventArgs e)
        {
            LabelKeyAdmin.Visibility = Visibility.Visible;
            KeyAdminTxtBox.Visibility = Visibility.Visible;
        }
        private void CheckBoxAdmin_Unchecked(object sender, RoutedEventArgs e)
        {
            LabelKeyAdmin.Visibility = Visibility.Hidden;
            KeyAdminTxtBox.Visibility = Visibility.Hidden;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            string LoginUser = LoginTxtBox.Text;
            var USER = DBConn.DBCONNECT.Client.FirstOrDefault(name => name.Login == LoginUser);
            if (USER != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть!");
            }
            else if (LoginUser == "" || PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else if (CheckBoxAdmin.IsChecked == true)
            {
                if(KeyAdminTxtBox.Text == "JCSKqujfSx")
                {    
                    DateTime today = DateTime.Today;
                    string dd = today.Day.ToString();
                    string mm = today.Month.ToString();
                    string yy = today.Year.ToString();
                    var tempAdmin = new Client() { Login = LoginTxtBox.Text, Password = PasswordTxtBox.Text, Id_Role = 1, Balance = 0, Date_of_registration = Convert.ToDateTime(yy+"."+mm+"."+dd)};
                    DBConn.DBCONNECT.Client.Add(tempAdmin);
                    DBConn.DBCONNECT.SaveChanges();
                    LOGIN = LoginTxtBox.Text;
                    MainWindow.Instance.FrameSideBar.Navigate(new SideBarMenuAdmin(LOGIN));
                    MainWindow.Instance.FRAME.Navigate(new HomePage.HomePage());
                    return;
                }
                else
                {
                    MessageBox.Show("Неверный ключ админа!");
                }
            }
            else if (CheckBoxAdmin.IsChecked != true)
            {

                DateTime today = DateTime.Today;
                string dd = today.Day.ToString();
                string mm = today.Month.ToString();
                string yy = today.Year.ToString();
                var tempUser = new Client() { Login = LoginTxtBox.Text, Password = PasswordTxtBox.Text, Id_Role = 2, Balance = 0, Date_of_registration = Convert.ToDateTime(yy + "." + mm + "." + dd) };
                DBConn.DBCONNECT.Client.Add(tempUser);
                DBConn.DBCONNECT.SaveChanges();
                LOGIN = LoginTxtBox.Text;
                MainWindow.Instance.FrameSideBar.Navigate(new SideBarMenu(LOGIN));
                MainWindow.Instance.FRAME.Navigate(new HomePage.HomePage());
                return;
            }
        }
    }
}
