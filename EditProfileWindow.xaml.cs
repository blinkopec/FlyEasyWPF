using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;

namespace integrationWPF
{
    /// <summary>
    /// Логика взаимодействия для EditProfileWindow.xaml
    /// </summary>
    public partial class EditProfileWindow : Window
    {
        public EditProfileWindow()
        {
            InitializeComponent();

            using (var context = new integrationWPFEntities())
            {
                Customer customer = context.Customer
                    .Where(b => b.id == UserInfo.id)
                    .Single();

                NameBox.Text = customer.name;
                SurnameBox.Text = customer.surname;
                MiddlenameBox.Text = customer.middlename;

                if (customer.image != null)
                {
                    BitmapImage bitmap = new BitmapImage();
                    using (var mem = new MemoryStream(customer.image))
                    {
                        mem.Position = 0;
                        bitmap.BeginInit();
                        bitmap.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.UriSource = null;
                        bitmap.StreamSource = mem;
                        bitmap.EndInit();
                    }
                    bitmap.Freeze();
                    ImageProfile.Source = bitmap;
                }
               
            }
        }

        private void EditImageProfileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;

                ImageProfile.Source = new BitmapImage(new Uri(@dlg.FileName));

                using (var context = new integrationWPFEntities())
                {
                    foreach (var cstmr in context.Customer)
                    {
                        if (cstmr.id == UserInfo.id)
                        {
                            cstmr.image = ImageToByteArr(new BitmapImage(new Uri(@dlg.FileName)));
                        }
                    }
                    context.SaveChanges();
                }
            }
        }

        private void EditPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            EditPasswordWindow epw = new EditPasswordWindow();
            epw.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            UserWindow uw = new UserWindow();
            uw.Show();
            this.Close();
        }


        private byte[] ImageToByteArr(BitmapImage bmp)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
                return data;
            }
        }
    }
}
