using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace TaschenrechnerMitUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<string> zahlenList = new List<string>();
        
        // Value vom Zahlen BTN bekommen
        private void ZahlInput(object sender, RoutedEventArgs e)
        {
            var buttonValue = (sender as Button)?.Tag;
            DisplayNumber(buttonValue);
        }
        // Display Number Input
        public string DisplayNumber(object buttonValue)
        {
            var currentValue = Anzeige.Text;
            var completValue = currentValue + buttonValue;
            Anzeige.Text = (completValue);
            return currentValue;
        }
        
        // Multiplikator BTN Input
        private void MultiplikatorInput(object sender, RoutedEventArgs e)
        {
            var buttonValue = (sender as Button)?.Tag;
            var currentValue = Anzeige.Text;
            zahlenList.Add(currentValue);
            DisplayMultiplikator(buttonValue);
        }
        
        
        // Multiplikator anzeigen 
        public string DisplayMultiplikator(object buttonValue)
        {
            var currentValue = Anzeige.Text;
            var completValue = currentValue + " " + buttonValue + " ";
            Anzeige.Text = (completValue);
            return currentValue;
        }
        
        // Berechnung durchführen 
        public void Berechnen(object sender, RoutedEventArgs routedEventArgs)
        {
            string[] zahlen = zahlenList.ToArray();
            int zahl1 = Convert.ToInt32(zahlen[0]);
            if (Anzeige.Text.Contains('+'))
            {
                int zahl2 = Convert.ToInt32(Anzeige.Text.Substring(Anzeige.Text.LastIndexOf('+') + 1));
                int result = Model.Addition(zahl1, zahl2);
                DisplayResult(result);
            } else if (Anzeige.Text.Contains('-'))
            {
                int zahl2 = Convert.ToInt32(Anzeige.Text.Substring(Anzeige.Text.LastIndexOf('-') + 1));
                int result = Model.Subtraction(zahl1, zahl2);
                DisplayResult(result);
            } else if (Anzeige.Text.Contains('*'))
            {
                int zahl2 = Convert.ToInt32(Anzeige.Text.Substring(Anzeige.Text.LastIndexOf('*') + 1));
                int result = Model.Multiplication(zahl1, zahl2);
                DisplayResult(result);
            } else if (Anzeige.Text.Contains('/'))
            {
                int zahl2 = Convert.ToInt32(Anzeige.Text.Substring(Anzeige.Text.LastIndexOf('/') + 1));
                int result = Model.Division(zahl1, zahl2);
                DisplayResult(result);
            }
        }
        
        // Display Result
        public void DisplayResult(int result)
        {
            Anzeige.Text = (result).ToString();
            zahlenList.Clear(); // Reset Zahlen Array um mit Ergebniss direkt weiter zu rechnen
        }
        
        // Reset
        public void ResetBtn(object sender, RoutedEventArgs routedEventArgs)
        {
            Anzeige.Text = "";
            zahlenList.Clear();
        }
        
        // Remove Item
        public void RemoveItems(object sender, RoutedEventArgs routedEventArgs)
        {
            string test = Anzeige.Text;
            char lookUpLast = test[test.Length - 1];
            if (Char.IsWhiteSpace(lookUpLast)) // Wegen Multiplikator abfragen da dort ein Leerzeichen ist
            {
                string removeLast = test.Remove(test.Length - 2);
                Anzeige.Text = removeLast;
            }
            else
            {
                string removeLast = test.Remove(test.Length - 1);
                Anzeige.Text = removeLast;
            }

        }
        
        
        private void Window_Loaded(object sender, RoutedEventArgs e)  
        {  
            double controlsize = ((SystemParameters.PrimaryScreenWidth / 7) / 3 * 2) / 5 * 0.7;  
            System.Windows.Application.Current.Resources.Remove("ControlFontSize");  
            System.Windows.Application.Current.Resources.Add("ControlFontSize", controlsize);  
        }
    }
}