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
    /// Логика взаимодействия для EditPasswordWindow.xaml
    /// </summary>
    public partial class EditPasswordWindow : Window
    {
        public EditPasswordWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (LastPasswordBox.Password != null && NewPasswordBox.Password != null)
            {
                Customer customer;
                using (var context = new integrationWPFEntities())
                {
                    customer = context.Customer
                        .Where(b => b.id == UserInfo.id)
                        .Single();
                    if (LastPasswordBox.Password == customer.password)
                    {
                        foreach (var cstmr in context.Customer)
                        {
                            if (cstmr.id == UserInfo.id)
                            {
                                cstmr.password = NewPasswordBox.Password;
                            }
                        }
                        context.SaveChanges();
                        this.Close();
                    }
                    else MessageBox.Show("Что-то не так");
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
