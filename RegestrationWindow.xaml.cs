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
    /// Логика взаимодействия для RegestrationButton.xaml
    /// </summary>
    public partial class RegestrationWindow : Window
    {
        public RegestrationWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void RegestrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (SurnameBox.Text != null && NameBox.Text != null && LoginBox.Text != null &&
                PasswordTextBox.Password != null)
            {
                try
                {
                    Customer customer = new Customer()
                    {
                        name = NameBox.Text,
                        surname = SurnameBox.Text,
                        login = LoginBox.Text,
                        password = PasswordTextBox.Password
                    };

                    integrationWPFEntities.GetContext().Customer.Add(customer);
                }
                catch (Exception ex) { }
                finally
                {
                    integrationWPFEntities.GetContext().SaveChanges();

                    LoginWindow lw = new LoginWindow();
                    lw.Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Ошибка, неправильно введены данные!");
        }
    }
}
