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
    /// Interaktionslogik für SuchePerson.xaml
    /// </summary>
    public partial class SuchePerson : Window
    {
        
        public SuchePerson()
        {
            InitializeComponent();
            AbfragePool pool = new AbfragePool();
            Person[] personen = pool.getGesamt();

            //CmbBox mit PersNr füllen
            foreach (Person p in personen)
            {
                cmbNummer.Items.Add(p.persNr);
            }

            //erste Person anzeigen
            Person p1 = personen[0];
            cmbNummer.Text = p1.persNr;

            persName.Content = p1.vorname + " " + p1.name;

            //Liste mit Sprachen der ersten Person füllen 
            foreach (Sprachen s in p1.sprachen)
            {
                liste.Items.Add(s.sprache + " - " + s.grad);
            }
        }

        private void cmbNummer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //wenn eine andere Nummer ausgewählt wird, dann Person heraussuchen 
            AbfragePool pool = new AbfragePool();
            liste.Items.Clear();
            int index = cmbNummer.SelectedIndex;
            List<Sprachen> lst = pool.getSprachen(cmbNummer.Items[index].ToString());
            persName.Content = "Test " + cmbNummer.Items[index].ToString();
            foreach (Sprachen s in lst)
            {
                liste.Items.Add(s.sprache + " - " + s.grad);
            }

            Person p = pool.getPerson(cmbNummer.Items[index].ToString());
            //persName.Content = p.vorname + " " + p.name;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
