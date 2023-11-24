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
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        private Ticket ticket;
        public PaymentWindow(Ticket ticket)
        {
            this.ticket = ticket;
            InitializeComponent();
            CostLabel.Content = ticket.Cost;
        }

        private void PaymentButton_Click(object sender, RoutedEventArgs e)
        {
            if (ticket == null) 
                return;

            OrderAero orderAero = new OrderAero()
            {
                idCustomer = UserInfo.id,
                idRoute = ticket.idRoute,
            };

            integrationWPFEntities.GetContext().OrderAero.Add(orderAero);
            integrationWPFEntities.GetContext().SaveChanges();

            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();   
        }

        private void DateBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DateBox.Text.Length == 2)
            {
                DateBox.Text += "/";
                DateBox.SelectionStart = DateBox.Text.Length;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
                e.Handled = true;


            if (numberCardBox.Text.Length == 4)
            {
                numberCardBox.Text += " ";
            }
            if (numberCardBox.Text.Length == 9)
            {
                numberCardBox.Text += " ";
            }
            if (numberCardBox.Text.Length == 14)
            {
                numberCardBox.Text += " ";
            }
            if (numberCardBox.Text.Length == 19)
            {
                numberCardBox.Text += " ";
            }

            numberCardBox.SelectionStart = numberCardBox.Text.Length;
        }

        private void NameBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsLetter(e.Text, 0))
                e.Handled = true;
        }

        private void CVCBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void DateBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (numberCardBox.Text.Length == 4)
            {
                numberCardBox.Text += " ";
            }
            if (numberCardBox.Text.Length == 9)
            {
                numberCardBox.Text += " ";
            }
            if (numberCardBox.Text.Length == 14)
            {
                numberCardBox.Text += " ";
            }
            if (numberCardBox.Text.Length == 19)
            {
                numberCardBox.Text += " ";
            }

            numberCardBox.SelectionStart = numberCardBox.Text.Length;   
        }
    }
}
