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
using ViplataProject.Infrastructure.ViewModels;
using ViplataProject.Infrastructure.Mappers;
using ViplataProject.Infrastructure.QR;
using ViplataProject.Windows;

namespace ViplataProject.Pages
{

    /// <summary>
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class CompaniesPage : Page
    {
        private CompanyRepository company_repository;
        public CompaniesPage()
        {
            InitializeComponent();
            company_repository = new CompanyRepository();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            CompanyDG.ItemsSource = company_repository.GetList();

        }

        public List<CompanyViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Company.ToList();
                return CompanyMapper.Map(items);
            }
        }

        public CompanyViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Company.FirstOrDefault(x => x.ID == id);
                return CompanyMapper.Map(item);
            }
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            MenuPage menuPage = new MenuPage();
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Title = menuPage.Title;
            mainWindow.MainFrame.Navigate(menuPage);
        }

        private void QRButton_Click(object sender, RoutedEventArgs e)
        {
            var qrManager = new QRManager();
            var qrCodeImage = qrManager.Generate(CompanyDG.SelectedItem);
            var qrWindow = new QRWindow();
            qrWindow.qrImage.Source = qrCodeImage;
            qrWindow.Show();
        }
    }

}
