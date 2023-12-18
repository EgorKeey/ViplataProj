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
using ViplataProject.Infrastructure;
using ViplataProject.Infrastructure.Database;
using ViplataProject.Infrastructure.QR;
using ViplataProject.Windows;

namespace ViplataProject.Pages
{

    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        private EmployeeRepository employee_repository;
        public EmployeesPage()
        {
            InitializeComponent();
            employee_repository = new EmployeeRepository();
            EmployeeDG.ItemsSource = employee_repository.GetList();
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = menuPage.Title;
            mainWindow.MainFrame.Navigate(menuPage);
            
        }

        private void ButtonQR_Click(object sender, RoutedEventArgs e)
        {
            var qrManager = new QRManager();
            var qrCodeImage = qrManager.Generate(EmployeeDG.SelectedItem);
            var qrWindow = new QRWindow();
            qrWindow.qrImage.Source = qrCodeImage;
            qrWindow.Show();
        }

    }
}
