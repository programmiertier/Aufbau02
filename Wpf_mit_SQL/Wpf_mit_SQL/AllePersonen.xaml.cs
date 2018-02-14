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
using SQL_Bibliothek;

namespace Wpf_mit_SQL
{
    /// <summary>
    /// Interaktionslogik für AllePersonen.xaml
    /// </summary>
    public partial class AllePersonen : Window
    {
        Person[] personen;
        int index = 0;
        public AllePersonen()
        {
            InitializeComponent();
            personen = new AbfragePool().getPersonen();

            // erste Person anzeigen
            txtNummer.Text = personen[0].persNr;
            txtNachname.Text = personen[0].name;
            txtVorname.Text = personen[0].vorname;
        }

        private void knpfVor_Click(object sender, RoutedEventArgs e)
        {
            if (index < personen.Length - 1)
            {
                index++;
                txtNummer.Text = personen[index].persNr;
                txtNachname.Text = personen[index].name;
                txtVorname.Text = personen[index].vorname;
            }
        }

        private void knpfZurueck_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                index--;
                txtNummer.Text = personen[index].persNr;
                txtNachname.Text = personen[index].name;
                txtVorname.Text = personen[index].vorname;
            }
        }

        private void knpfClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
