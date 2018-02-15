using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Pizzalieferung
{
    /// <summary>
    /// Interaktionslogik für FormSite.xaml
    /// </summary>
    public partial class FormSite : Window
    {
        public FormSite()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            // Farbverlauf des Grids soll sich ändern
            // Ich könnte auf dei Eigenschaft des Grids zugreifen
            // gridNo1.Background= ...

            // eine Ressource wird geändert
            this.Resources["styleVerlauf"] = new LinearGradientBrush(Colors.Orchid, Colors.OrangeRed, 45);

        }
    }
}
