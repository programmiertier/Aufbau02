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
        public AllePersonen()
        {
            InitializeComponent();
            AbfragePool pool = new AbfragePool();
            Person[] personen = pool.getGesamt();
        }

        private void knpfVor_Click(object sender, RoutedEventArgs e)
        {
            if (indexer < personen.Length - 1)
            {
                indexer++;
                txtNummer.Text = personen[index].persNr;
                txtNachname.Text = personen[index].name;
                txtVorname.Text = personen[index].vorname;
            }
        }

        private void knpfZurueck_Click(object sender, RoutedEventArgs e)
        {

        }

        private void knpfClose_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
