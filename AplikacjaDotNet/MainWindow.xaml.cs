using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Shapes;

namespace NadajPrzesylkeWPF
{
    public partial class MainWindow : Window
    {
        static string m_path = Directory.GetCurrentDirectory() + "//images//";

        public MainWindow()
        {
            InitializeComponent();
            PrzesylkaImage.Source = new BitmapImage(new Uri(m_path + "pocztowka.jpg"));
        }

    
        private void CheckPriceButton_Click(object sender, RoutedEventArgs e)
        {
            if (RadioPocztowka.IsChecked == true)
            {
                PrzesylkaImage.Source = new BitmapImage(new Uri(m_path + "pocztowka.jpg"));
                CenaLabel.Content = "Cena: 1 zł";
            }
            else if (RadioList.IsChecked == true)
            {

                PrzesylkaImage.Source = new BitmapImage(new Uri(m_path + "koperta.jpg"));
                CenaLabel.Content = "Cena: 1,5 zł";
            }
            else if (RadioPaczka.IsChecked == true)
            {
                PrzesylkaImage.Source = new BitmapImage(new Uri(m_path + "paczku.jpg"));
                CenaLabel.Content = "Cena: 10 zł";
            }
        }

     
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string kodPocztowy = KodTextBox.Text;

         
            if (kodPocztowy.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!int.TryParse(kodPocztowy, out _))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }
    }
}