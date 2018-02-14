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
using Bibliothek_Reisekatalog;

namespace Reisekatalog_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Katalog kat = new Katalog();   
            InitializeComponent();

            // wir binden eine Datenquelle an das Fenster
            this.DataContext = kat.getZiele();

            /*  liste1.Items.Add("Ziel 1");
                liste1.Items.Add("Ziel 2");
            */

            /* foreach(Reiseziel ziel in kat.getZiele())
            {
                liste1.Items.Add(ziel.Ort);
            }
            */
        }

        private void cmbZiel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ich hole mir den ausgewählten Indes aus der ComboBox
            int index = cmbZiel.SelectedIndex;

            liste2.Items.Clear();
            liste2.Items.Add(new Katalog().getZiele()[index].ort);
        }
    }
}
