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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Formato_a_un_texto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AzulRadioButton.IsChecked = true;
        }

        private void CuadroTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            MostrarTextBlock.Text = CuadroTextoTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (NegritaCheckBox.IsChecked == true)
            {
                MostrarTextBlock.FontWeight = FontWeights.Bold;
            }
        }

        private void NegritaCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (NegritaCheckBox.IsChecked == false)
            {
                MostrarTextBlock.FontWeight = FontWeights.Normal;
            }
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(CursivaCheckBox.IsChecked == true)
            {
                MostrarTextBlock.FontStyle = FontStyles.Italic;
            }
        }
        private void CursivaCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (CursivaCheckBox.IsChecked == false)
            {
                MostrarTextBlock.FontStyle = FontStyles.Normal;
            }
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MostrarTextBlock.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MostrarTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MostrarTextBlock.Foreground = Brushes.Green;
        }
    }
}
