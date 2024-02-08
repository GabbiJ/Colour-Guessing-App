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

namespace Colour_Guessing_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string rectColour;
        public MainWindow()
        {
            InitializeComponent();
            fillRectangleWithRandomColour();
            btnTryAgain.Visibility = Visibility.Collapsed;
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            string guess = txtGuess.Text;
            //if guess is correct then display message
            if (guess.Equals(rectColour, StringComparison.OrdinalIgnoreCase))
            {
                txbResult.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2D13FF00"));
                txbResult.Text = "Well done you guessed correct!";
                btnGuess.Visibility = Visibility.Collapsed;
                btnTryAgain.Visibility = Visibility.Visible;
            }
            //if guess is incorrect display message
            else
            {
                txbResult.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2DFF0000"));
                txbResult.Text = "It's wrong.";
                btnGuess.Visibility = Visibility.Collapsed;
                btnTryAgain.Visibility = Visibility.Visible;
            }
            txbResult.Text += $"\nThe answer: {rectColour}";
        }

        private void fillRectangleWithRandomColour()
        {
            //generating a random number for each RGB value
            Random r = new Random();
            byte red = (byte)(r.Next() % 255);
            string hexValueRed = red.ToString("X2");
            byte green = (byte)(r.Next() % 255);
            string hexValueGreen = green.ToString("X2");
            byte blue = (byte)(r.Next() % 255);
            string hexValueBlue = blue.ToString("X2");

            rectColour = "#" + hexValueRed + hexValueGreen + hexValueBlue;
            rectangleForColour.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(rectColour));

        }

        private void btnTryAgain_Click(object sender, RoutedEventArgs e)
        {
            fillRectangleWithRandomColour();
            btnGuess.Visibility = Visibility.Visible;
            txbResult.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202020"));
            txbResult.Text = null;
            txtGuess.Clear();
            btnTryAgain.Visibility = Visibility.Collapsed;
        }

        private void txtGuess_TextChanged(object sender, TextChangedEventArgs e)
        {
            //changing colour of right hand rectangle as user guesses
            try
            {
                rectCurrentGuessColour.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(txtGuess.Text));
            }
            catch (Exception ex)
            {
                txbResult.Text += ex.ToString();
            }
            txbResult.Text = null;
            
        }
    }
}
