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
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            EmployeeDG.ItemsSource = employee_repository.GetList();

        }

        public List<EmployeeViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Employee.ToList();
                return EmployeeMapper.Map(items);
            }
        }

        public EmployeeViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Employee.FirstOrDefault(x => x.ID == id);
                return EmployeeMapper.Map(item);
            }
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
