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

namespace Anagraphic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (float.Parse(txtAge.Text) > 20 && float.Parse(txtAge.Text) < 130)
            {
                if (rdnFootball.IsChecked == true)
                {
                    if (rdnBarcellona.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Team {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Barcellona", MessageBoxButton.OK);
                    }
                    else if (rdnJuventus.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Team {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Juventus", MessageBoxButton.OK);
                    }
                    else if (rdnSassuolo.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Team {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Sassuolo", MessageBoxButton.OK);
                    }
                }
                else if (rdnSwimming.IsChecked == true)
                {
                    if (rdnMarco.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Player {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Marco", MessageBoxButton.OK);
                    }
                    else if (rdnSimone.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Player {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Simone", MessageBoxButton.OK);
                    }
                    else if (rdnLuigi.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Player {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Luigi", MessageBoxButton.OK);
                    }
                }
                else
                {
                    if (rdnThomas.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Player {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Thomas", MessageBoxButton.OK);
                    }
                    else if (rdnJimmy.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Player {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Jimmy", MessageBoxButton.OK);
                    }
                    else if (rdnPieros.IsChecked == true)
                    {
                        MessageBox.Show($"Nice Player {txtName.Text} {txtSurname.Text} with {txtAge.Text} yo.", "Pieros", MessageBoxButton.OK);
                    }
                }
            }
        }

        private void rdnFootball_Checked(object sender, RoutedEventArgs e)
        {
            rdnBarcellona.IsEnabled = true;
            rdnJuventus.IsEnabled = true;
            rdnSassuolo.IsEnabled = true;

            rdnMarco.IsEnabled = false;
            rdnSimone.IsEnabled = false;
            rdnLuigi.IsEnabled = false;
            rdnThomas.IsEnabled = false;
            rdnJimmy.IsEnabled = false;
            rdnPieros.IsEnabled = false;
        }

        private void rdnSwimming_Checked(object sender, RoutedEventArgs e)
        {
            rdnMarco.IsEnabled = true;
            rdnSimone.IsEnabled = true;
            rdnLuigi.IsEnabled = true;

            rdnBarcellona.IsEnabled = false;
            rdnJuventus.IsEnabled = false;
            rdnSassuolo.IsChecked = false;
            rdnThomas.IsEnabled = false;
            rdnJimmy.IsEnabled = false;
            rdnPieros.IsEnabled = false;
        }

        private void rdnVolleyball_Checked(object sender, RoutedEventArgs e)
        {
            rdnThomas.IsEnabled = true;
            rdnJimmy.IsEnabled = true;
            rdnPieros.IsEnabled = true;

            rdnBarcellona.IsEnabled = false;
            rdnJuventus.IsEnabled = false;
            rdnSassuolo.IsChecked = false;
            rdnMarco.IsEnabled = false;
            rdnSimone.IsEnabled = false;
            rdnLuigi.IsEnabled = false;
        }
    }
}
