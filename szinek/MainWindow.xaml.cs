using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace szinek
{
    public partial class MainWindow : Window
    {
        public class Szin
        {
            public int Szám { get; set; }
            public string Szín { get; set; }

            public Szin(int szam, string szin)
            {
                Szám = szam;
                Szín = szin;
            }
        }

        List<Szin> szinek = new List<Szin>();

        public MainWindow()
        {
            InitializeComponent();
            szinek.Add(new Szin(30, "Piros"));
            szinek.Add(new Szin(33, "Kék"));
            datagrid.ItemsSource = szinek;
        }

        private void kilepes(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void hozzaadas(object sender, RoutedEventArgs e)
        {
            szinek.Add(new Szin((int)slider.Value, combobox.Text));
            datagrid.Items.Refresh();
        }

        private void torles(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedItem != null && datagrid.SelectedItem is Szin)
            { 
            szinek.Remove((Szin)datagrid.SelectedItem);
            datagrid.Items.Refresh();
            }
        }

        private void dupla(object sender, RoutedEventArgs e)
        {
            if (datagrid.FontSize < 100) 
            { 
                datagrid.FontSize *= 2;
            }
        }

        private void fele(object sender, RoutedEventArgs e)
        {
            if (datagrid.FontSize > 5) 
            {
                datagrid.FontSize /= 2;
            }
        }
    }
}