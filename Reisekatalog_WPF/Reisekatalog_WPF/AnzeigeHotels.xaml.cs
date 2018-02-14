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
using Bibliothek_Reisekatalog;

namespace Reisekatalog_WPF
{
    /// <summary>
    /// Interaction logic for AnzeigeHotels.xaml
    /// </summary>
    public partial class AnzeigeHotels : Window
    {
        // wenn ein Fenster erstell twerden soll, brauchen wir Suchkriterien
        public AnzeigeHotels(String Land, String Ort)
        {
            InitializeComponent();
            // das Fenster dient zur Anzeige von Hoteldaten -- Datenbindung bezieht sich auf Hotel[]
            this.DataContext = new Katalog().getHotels(Land, Ort);
        }

    }
}
