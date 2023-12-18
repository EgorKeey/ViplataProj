using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViplataProject.Windows;
using ViplataProject.Infrastructure;

namespace ViplataProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ClientButton_Click(object sender, RoutedEventArgs e)
        {
            ClientsPage clientsPage = new ClientsPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = clientsPage.Title;
            mainWindow.MainFrame.Navigate(clientsPage);



        }
        private void EmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeesPage employeesPage = new EmployeesPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = employeesPage.Title;
            mainWindow.MainFrame.Navigate(employeesPage);
        }

        private void SessionButton_Click(object sender, RoutedEventArgs e)
        {
            SessionsPage sessionsPage = new SessionsPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = sessionsPage.Title;
            mainWindow.MainFrame.Navigate(sessionsPage);
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            PaymentsPage paymentsPage = new PaymentsPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = paymentsPage.Title;
            mainWindow.MainFrame.Navigate(paymentsPage);
        }

        private void CompanyButton_Click(object sender, RoutedEventArgs e)
        {
            CompaniesPage companiesPage = new CompaniesPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = companiesPage.Title;
            mainWindow.MainFrame.Navigate(companiesPage);
        }
    }
}
