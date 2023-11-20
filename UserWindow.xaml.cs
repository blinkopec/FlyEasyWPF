using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            using (var context = new integrationWPFEntities())
            {
                Customer customer = context.Customer
                    .Where(b => b.id == UserInfo.id)
                    .Single();

                NameLabel.Content = customer.name;
                SurnameLabel.Content = customer.surname;
                MiddlenameLabel.Content = customer.middlename;

                if (customer.image != null) 
                    ImageProfile.Source = ImgFromBytes(customer.image);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void EditProfileButton_Click(object sender, RoutedEventArgs e)
        {
            EditProfileWindow mw = new EditProfileWindow();
            mw.Show();
            this.Close();   
        }

        private void MyRoutesButton_Click(object sender, RoutedEventArgs e)
        {
            RoutesWindow mw = new RoutesWindow();   
            mw.Show();
            this.Close();
        }

        private static BitmapImage ImgFromBytes(byte[] arr)
        {
            var image = new BitmapImage();

            using (var mem = new MemoryStream(arr))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();

            return image;
        }
    }
}
