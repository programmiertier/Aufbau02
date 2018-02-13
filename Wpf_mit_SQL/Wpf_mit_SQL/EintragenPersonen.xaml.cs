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

namespace Wpf_mit_SQL
{
    /// <summary>
    /// Interaktionslogik für EintragenPersonen.xaml
    /// </summary>
    public partial class EintragenPersonen : Window
    {
        public EintragenPersonen()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Prüfen, ob alle Werte eingetragen, wenn NEIN, dann Fehlermeldung
            String nummer = txtNummer.Text;
            String name = txtNachname.Text;
            String vorname = txtVorname.Text;
            if (nummer.Length == 0 || name.Length == 0 || vorname.Length == 0)
            {
                result.Content = "keine Daten zum eintragen";
            }
            else
            {
                SQL_Bibliothek.AbfragePool pool = new SQL_Bibliothek.AbfragePool();
                SQL_Bibliothek.Person p = new SQL_Bibliothek.Person { persNr = nummer, name = name, vorname = vorname };
                int ergebnis = pool.einfügen(p);
                if (ergebnis == 1)
                {
                    result.Content = "Datensatz wurde eingefügt";
                }
                else
                {
                    result.Content = "Datensatz nicht gespeichert";
                }
            }
        }

        private void btnCLose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
