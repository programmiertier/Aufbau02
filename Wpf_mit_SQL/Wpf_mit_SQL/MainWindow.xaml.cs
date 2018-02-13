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

namespace Wpf_mit_SQL
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void knpfAlle_Click(object sender, RoutedEventArgs e)
        {
            // hier soll ein neues Fenster geöffnet weerden
            AllePersonen wind = new AllePersonen();
            wind.ShowDialog();
        }

        private void knpfNeu_Click(object sender, RoutedEventArgs e)
        {
            // hier soll ein neues Fenster geöffnet werden
            EintragenPersonen wind = new EintragenPersonen();
            wind.ShowDialog();
        }

        private void knpfSuche_Click(object sender, RoutedEventArgs e)
        {
            // hier soll ein neues Fenster geöffnet werden
        }
    }
}
