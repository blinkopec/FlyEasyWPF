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

namespace integrationWPF
{
    /// <summary>
    /// Логика взаимодействия для RoutesWindow.xaml
    /// </summary>
    public partial class RoutesWindow : Window
    {
        public RoutesWindow()
        {
            InitializeComponent();

            List<Ticket> tickets = new List<Ticket>();  
            using (var context = new integrationWPFEntities())
            {
                List<OrderAero> orders = context.OrderAero
                    .Where(b => b.idCustomer == UserInfo.id)
                    .ToList();


                foreach (var order in orders)
                {
                    if (order != null)
                    {
                        tickets.Add(new Ticket((int)order.idRoute));
                    }
                }
            }

            TicketItemsControl.ItemsSource = tickets;   
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow uw = new UserWindow();
            uw.Show();
            this.Close();
        }
    }
}
