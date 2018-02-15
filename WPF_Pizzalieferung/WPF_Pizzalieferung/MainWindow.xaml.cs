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
using Bibliothek_Pizzalieferung;

namespace WPF_Pizzalieferung
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            FormInline wind = new FormInline();
            wind.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            FormPage wind = new FormPage();
            wind.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            FormSite wind = new FormSite();
            wind.Show();
        }
    }
}
