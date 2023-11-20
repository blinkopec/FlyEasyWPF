using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Claims;
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

namespace integrationWPF
{
    enum TableEnum
    {
        Route,
        Customer,
        Order,
        City,
        Class,
        admin,
    }
    /// <summary>
    /// Логика взаимодействия для AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        private bool isRoute;
        private bool isCustomer;
        private bool isOrder;
        private bool isCity;
        private bool isClass;
        private bool isAdmin;

        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void RoutesButton_Click(object sender, RoutedEventArgs e)
        {
            IdentificationTable(TableEnum.Route);
            dg.ItemsSource = integrationWPFEntities.GetContext().Route.ToList();
            dg.Columns[10].MaxWidth = 0;
            dg.Columns[11].MaxWidth = 0;
            dg.Columns[12].MaxWidth = 0;
            dg.Columns[13].MaxWidth = 0;
        }


        private void CustomerButton_Click(object sender, RoutedEventArgs e)
        {
            IdentificationTable(TableEnum.Customer);
            dg.ItemsSource = integrationWPFEntities.GetContext().Customer.ToList();
            dg.Columns[7].MaxWidth = 0;
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            IdentificationTable(TableEnum.Order);
            dg.ItemsSource = integrationWPFEntities.GetContext().OrderAero.ToList();
            dg.Columns[3].MaxWidth = 0;
            dg.Columns[4].MaxWidth = 0;
        }

        private void CitiesButton_Click(object sender, RoutedEventArgs e)
        {
            IdentificationTable(TableEnum.City);
            dg.ItemsSource = integrationWPFEntities.GetContext().cities.ToList();
            dg.Columns[4].MaxWidth = 0;
            dg.Columns[5].MaxWidth = 0;
        }

        private void ClassButton_Click(object sender, RoutedEventArgs e)
        {
            IdentificationTable(TableEnum.Class);
            dg.ItemsSource = integrationWPFEntities.GetContext().@class.ToList();
            dg.Columns[2].MaxWidth = 0;
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            IdentificationTable(TableEnum.admin);
            dg.ItemsSource = integrationWPFEntities.GetContext().administrator.ToList();
        }

        private void IdentificationTable(TableEnum table)
        {
            if (table == TableEnum.Route) 
            {
                isRoute = true;
                isCustomer = false;
                isCity = false;
                isClass = false;
                isOrder = false;
                isAdmin = false;
            }
            if (table == TableEnum.Customer)
            {
                isRoute = false;
                isCustomer = true;
                isCity = false;
                isClass = false;
                isOrder = false;
                isAdmin = false;
            }
            if (table == TableEnum.City)
            {
                isRoute = false;
                isCustomer = false;
                isCity = true;
                isClass = false;
                isOrder = false;
                isAdmin = false;
            }
            if (table == TableEnum.Order) 
            {
                isRoute = false;
                isCustomer = false;
                isCity = false;
                isClass = false;
                isOrder = true;
                isAdmin = false;
            }
            if (table == TableEnum.Class)
            {
                isRoute = false;
                isCustomer = false;
                isCity = false;
                isClass = true;
                isOrder = false;
                isAdmin = false;
            }
            if (table == TableEnum.admin)
            {
                isRoute = false;
                isCustomer = false;
                isCity = false;
                isClass = true;
                isOrder = false;
                isAdmin = true;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (isAdmin)
            {
                administrator tmp = dg.SelectedItem as administrator;
                if (tmp != null)
                {
                    if (tmp.id == 0)
                        integrationWPFEntities.GetContext().administrator.Add(tmp);
                    integrationWPFEntities.GetContext().SaveChanges();
                    List<administrator> ad = integrationWPFEntities.GetContext().administrator.ToList();
                    dg.ItemsSource = ad;
                }
            }

            if (isClass)
            {
                @class tmp = dg.SelectedItem as @class;
                if (tmp != null)
                {
                    if (tmp.id == 0)
                        integrationWPFEntities.GetContext().@class.Add(tmp);
                    integrationWPFEntities.GetContext().SaveChanges();
                    var ls = integrationWPFEntities.GetContext().@class.ToList();
                    List<@class> upd = new List<@class>();
                    foreach (var t in ls)
                    {
                        upd.Add((@class)RemoveSpaces(t, TableEnum.Class));
                    }
                    dg.ItemsSource = upd;
                }    
            }
            if (isCustomer)
            {
                Customer tmp = dg.SelectedItem as Customer;
                if (tmp != null)
                {
                    if (tmp.id == 0)
                        integrationWPFEntities.GetContext().Customer.Add(tmp);
                    integrationWPFEntities.GetContext().SaveChanges();
                    var ls = integrationWPFEntities.GetContext().Customer.ToList();
                    List<Customer> upd = new List<Customer>();
                    foreach (var t in ls)
                    {
                        upd.Add((Customer)RemoveSpaces(t, TableEnum.Customer));
                    }
                    dg.ItemsSource = upd;
                }
            }
            if (isOrder)
            {
                OrderAero tmp = dg.SelectedItem as OrderAero;
                if (tmp != null)
                {
                    if (tmp.id == 0)
                        integrationWPFEntities.GetContext().OrderAero.Add(tmp);
                    integrationWPFEntities.GetContext().SaveChanges();
                    var ls = integrationWPFEntities.GetContext().OrderAero.ToList();
                    List<OrderAero> upd = new List<OrderAero>();
                    foreach (var t in ls)
                    {
                        upd.Add((OrderAero)RemoveSpaces(t, TableEnum.Order));
                    }
                    dg.ItemsSource = upd;
                }
            }
            if (isCity)
            {
                cities tmp = dg.SelectedItem as cities;
                if (tmp != null)
                {
                    if (tmp.id == 0)
                        integrationWPFEntities.GetContext().cities.Add(tmp);
                    integrationWPFEntities.GetContext().SaveChanges();
                    var ls = integrationWPFEntities.GetContext().cities.ToList();
                    List<cities> upd = new List<cities>();
                    foreach (var t in ls)
                    {
                        upd.Add((cities)RemoveSpaces(t, TableEnum.City));
                    }
                    dg.ItemsSource = upd;
                }
            }
            if (isRoute)
            {
                Route tmp = dg.SelectedItem as Route;
                if (tmp != null)
                {
                    if (tmp.id == 0)
                        integrationWPFEntities.GetContext().Route.Add(tmp);
                    integrationWPFEntities.GetContext().SaveChanges();
                    var ls = integrationWPFEntities.GetContext().Route.ToList();
                    List<Route> upd = new List<Route>();
                    foreach (var t in ls)
                    {
                        upd.Add((Route)RemoveSpaces(t, TableEnum.Route));
                    }
                    dg.ItemsSource = upd;
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                if (isAdmin)
                {
                    administrator tmp = dg.SelectedItem as administrator;
                    if (tmp != null)
                    {
                        integrationWPFEntities.GetContext().administrator.Remove(tmp);
                        integrationWPFEntities.GetContext().SaveChanges();
                        List<administrator> ad = integrationWPFEntities.GetContext().administrator.ToList();
                        dg.ItemsSource = ad;
                    }
                }

                if (isClass)
                {
                    @class tmp = dg.SelectedItem as @class;
                    if (tmp != null)
                    {
                        integrationWPFEntities.GetContext().@class.Remove(tmp);
                        integrationWPFEntities.GetContext().SaveChanges();
                        var ls = integrationWPFEntities.GetContext().@class.ToList();
                        List<@class> upd = new List<@class>();
                        foreach (var t in ls)
                        {
                            upd.Add((@class)RemoveSpaces(t, TableEnum.Class));
                        }
                        dg.ItemsSource = upd;
                    }
                }

                if (isCustomer)
                {
                    Customer tmp = dg.SelectedItem as Customer;
                    if (tmp != null)
                    {
                        integrationWPFEntities.GetContext().Customer.Remove(tmp);
                        integrationWPFEntities.GetContext().SaveChanges();
                        var ls = integrationWPFEntities.GetContext().Customer.ToList();
                        List<Customer> upd = new List<Customer>();
                        foreach (var t in ls)
                        {
                            upd.Add((Customer)RemoveSpaces(t, TableEnum.Customer));
                        }
                        dg.ItemsSource = upd;
                    }
                }
                if (isOrder)
                {
                    OrderAero tmp = dg.SelectedItem as OrderAero;
                    if (tmp != null)
                    {
                        integrationWPFEntities.GetContext().OrderAero.Remove(tmp);
                        integrationWPFEntities.GetContext().SaveChanges();
                        var ls = integrationWPFEntities.GetContext().OrderAero.ToList();
                        List<OrderAero> upd = new List<OrderAero>();
                        foreach (var t in ls)
                        {
                            upd.Add((OrderAero)RemoveSpaces(t, TableEnum.Order));
                        }
                        dg.ItemsSource = upd;
                    }
                }
                if (isCity)
                {
                    cities tmp = dg.SelectedItem as cities;
                    if (tmp != null)
                    {
                        integrationWPFEntities.GetContext().cities.Remove(tmp);
                        integrationWPFEntities.GetContext().SaveChanges();
                        var ls = integrationWPFEntities.GetContext().cities.ToList();
                        List<cities> upd = new List<cities>();
                        foreach (var t in ls)
                        {
                            upd.Add((cities)RemoveSpaces(t, TableEnum.City));
                        }
                        dg.ItemsSource = upd;
                    }
                }
                if (isRoute)
                {
                    Route tmp = dg.SelectedItem as Route;
                    if (tmp != null)
                    {
                        integrationWPFEntities.GetContext().Route.Remove(tmp);
                        integrationWPFEntities.GetContext().SaveChanges();
                        var ls = integrationWPFEntities.GetContext().Route.ToList();
                        List<Route> upd = new List<Route>();
                        foreach (var t in ls)
                        {
                            upd.Add((Route)RemoveSpaces(t, TableEnum.Route));
                        }
                        dg.ItemsSource = upd;
                    }
                }
            }
        }

        private static object RemoveSpaces(object obj, TableEnum s)
        {
            if (obj != null)
            {
                if (s == TableEnum.Customer)
                {
                    Customer tmp = obj as Customer;
                    tmp.surname = tmp.surname.Replace(" ", "");
                    tmp.middlename = tmp.middlename.Replace(" ", "");
                    tmp.name = tmp.name.Replace(" ", "");
                    tmp.login = tmp.login.Replace(" ", "");
                    tmp.password = tmp.password.Replace(" ", "");
                    return tmp;
                }

                if (s == TableEnum.City)
                {
                    cities tmp = obj as cities;
                    tmp.name = tmp.name.Replace(" ", "");
                    tmp.cut = tmp.cut.Replace(" ", "");
                    tmp.country = tmp.country.Replace(" ", "");
                    return tmp;
                }
                if (s ==  TableEnum.Class)
                {
                    @class tmp = obj as @class;
                    tmp.name = tmp.name.Replace(" ", "");
                   
                    return tmp;
                }
                if (s == TableEnum.Route)
                {
                    Route tmp = obj as Route;
                    tmp.name = tmp.name.Replace(" ", "");
                    
                    return tmp;
                }
            }
            return null;
        }
    }
}
