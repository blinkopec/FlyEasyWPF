using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

namespace integrationWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            using (var context = new integrationWPFEntities())
            {
                List<string> wordsCities = new List<string>(); 
                List<string> wordsClass = new List<string>();
                List<cities> cities = context.cities.ToList();
                List<@class> classes = context.@class.ToList();
                foreach (var c in cities)
                {
                    if (c != null)
                    {
                        wordsCities.Add(c.name + "   " + c.cut);
                    }
                }

                foreach (var c in classes)
                {
                    if (c != null)
                    {
                        wordsClass.Add(c.name);
                    }
                }
                SendingPointCombo.ItemsSource = wordsCities;
                ClassCombo.ItemsSource = wordsClass;
                DestinationCombo.ItemsSource= wordsCities;
            }
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserInfo.status == UserStatusEnum.loggedOut)
            {
                LoginWindow lw = new LoginWindow();
                lw.Show();
                this.Close();
            }
            else
            {
                UserWindow uw = new UserWindow();
                uw.Show();
                this.Close();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Ticket> routes = new List<Ticket>();
            using (var context = new integrationWPFEntities())
            {
                foreach (var route in context.Route)
                {
                    if (route != null)
                    {
                        try
                        {
                            string stmp = SendingPointCombo.SelectedItem.ToString().Split(' ').First();
                            int tmp = context.cities
                                .Where(b => b.name == stmp)
                                .Select(b => b.id)
                                .Single();
                            if (route.sending_point == tmp)
                            {
                                string stmp2 = DestinationCombo.SelectedItem.ToString().Split(' ').First();
                                int tmp2 = context.cities
                                   .Where(b => b.name == stmp2)
                                   .Select(b => b.id)
                                   .Single();
                                if (route.destination == tmp2)
                                {
                                    int tmp3 = context.@class
                                       .Where(b => b.name == ClassCombo.SelectedItem)
                                       .Select(b => b.id)
                                       .Single();
                                    if (route.@class == tmp3)
                                    {
                                        if (route.data == datePicker.DisplayDate.Date)
                                        {       
                                            Ticket ticket = new Ticket(route.id);
                                            routes.Add(ticket);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex) { }
                    }
                }
            }

            TicketItemsControl.ItemsSource = routes;
        }

        
        private void SelectTicketButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            var item = button.DataContext as Ticket;


            if (UserInfo.status == UserStatusEnum.loggedOut)
            {
                LoginWindow lw = new LoginWindow();
                lw.Show();
                this.Close();
            }
            else
            {
                PaymentWindow pw = new PaymentWindow(item);
                pw.Show();
                this.Close();
            }
        }
    }
}

