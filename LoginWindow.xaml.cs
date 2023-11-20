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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password != null && LoginBox.Text != null)
            {
                using (var context = new integrationWPFEntities())
                {
                    string passwordOnDB = null;
                    try
                    {
                        passwordOnDB = context.Customer
                            .Where(b => b.login == LoginBox.Text)
                            .Select(b => b.password)
                            .Single();
                        if (passwordOnDB != null)
                        {
                            if (PasswordBox.Password == passwordOnDB)
                            {
                                UserInfo.id = context.Customer
                                    .Where(b => b.login == LoginBox.Text)
                                    .Select(b => b.id)
                                    .Single();
                                UserInfo.status = UserStatusEnum.logged;
                                MainWindow mw = new MainWindow();
                                mw.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Неправильный логин или пароль!");
                            }

                        }
                    }
                    catch (Exception ex) { }
                    try
                    {
                        string passwordOnDB2 = context.administrator
                           .Where(b => b.login == LoginBox.Text)
                           .Select(b => b.password)
                           .Single();
                        if (passwordOnDB2 != null)
                        {
                            if (PasswordBox.Password == passwordOnDB2)
                            {
                                AdminMainWindow amw = new AdminMainWindow();
                                amw.Show();
                                this.Close();
                            }
                            else
                                MessageBox.Show("Неправильный логин или пароль!");
                        }
                    }
                    catch (Exception ex) { }

                }
            }
        }

        private void RegestrationButton_Click(object sender, RoutedEventArgs e)
        {
            RegestrationWindow rw = new RegestrationWindow();
            rw.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
