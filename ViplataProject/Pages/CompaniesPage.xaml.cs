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

namespace ViplataProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для CompaniesPage.xaml
    /// </summary>
    /// 
    public partial class CompaniesPage : Page
    {
        private CompanyRepository company_repository;
        public CompaniesPage()
        {
            InitializeComponent();
            company_repository = new CompanyRepository();
            CompanyDG.ItemsSource = company_repository.GetList();

        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = menuPage.Title;
            mainWindow.MainFrame.Navigate(menuPage);
        }
    }
}
