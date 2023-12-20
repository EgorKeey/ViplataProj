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
using System.Windows.Shapes;
using ViplataProject.Infrastructure.Consts;
using ViplataProject.Infrastructure;
namespace ViplataProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {

            InitializeComponent();
            Title = "Окно авторизации";
        }



        private void LoginButton_Click(object sender, RoutedEventArgs e)

        {
            if (LoginBox.Text == "" && PasswordBox.Password == "")
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми строками!");
                return;
            }
            if (LoginBox.Text == "")
            {
                MessageBox.Show("Логин не может быть пустой строкой!");
                return;
            }
            if (PasswordBox.Password == "")
            {
                MessageBox.Show("Пароль не может быть пустой строкой!");
                return;
            }
            using (Infrastructure.Context context = new Infrastructure.Context())
            {
                var user = context.User.FirstOrDefault(x => x.Login == LoginBox.Text && x.Password == PasswordBox.Password);
                if (user != null)
                {
                //    string rolename = context.Role.FirstOrDefault(x => x.ID == user.RoleId).Name_Role;
                    var employee = context.Employee.FirstOrDefault(x => x.UserId == user.ID);
                    Application.Current.Resources[UserInfoConsts.RoleId] = user.RoleId;
                    Application.Current.Resources[UserInfoConsts.RoleName] = context.Role.FirstOrDefault(x => x.ID == user.RoleId).Name_Role;
                    Application.Current.Resources[UserInfoConsts.Username] = employee.Name;
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль)");
                }
            }


        }

        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources[UserInfoConsts.RoleId] = 1;
            Application.Current.Resources[UserInfoConsts.RoleName] = "Гость";
            Application.Current.Resources[UserInfoConsts.Username] = "Гость";
            MainWindow mainWindow = new MainWindow()
            {
                Title = "Главное меню"
            };
            mainWindow.Show();
            Close();
        }
    }
}
