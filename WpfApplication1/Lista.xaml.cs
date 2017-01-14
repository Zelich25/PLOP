using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;
using baza;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Lista.xaml
    /// </summary>
    
    public partial class Lista : Window
    {
        ListaZawodnikow z;
        ObservableCollection<zawodnik> sklad;
        public Lista()
        {
            InitializeComponent();
            z = ListaZawodnikow.OdczytajTXT();
            sklad = new ObservableCollection<zawodnik>(z.lista);
            listBox.ItemsSource = sklad;
        }

        private void buttonStatystyki_Click(object sender, RoutedEventArgs e)
        {
            zawodnik zaw = listBox.SelectedItem as zawodnik;
            int index = listBox.SelectedIndex;
            if (zaw != null)
            {
                Statystyki okno = new Statystyki(zaw);
                okno.ShowDialog();
                sklad[index] = zaw;
                z.lista[index] = zaw;
            }
        }

        private void button_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            zawodnik zaw = new zawodnik();
            DodajZawodnika okno = new DodajZawodnika(zaw);
            okno.ShowDialog();
            sklad.Add(zaw);
            z.lista.Add(zaw);
            StreamWriter SW;
            SW = File.AppendText(@"C:\Users\Tomek\Desktop\PLOP\baza\bin\Debug\zawodnicy.txt");
            SW.Write(zaw.Imie+" "+zaw.Nazwisko+" "+zaw.Pozycja+" 0 0 0");
            SW.WriteLine();
            SW.Close();
        }

        private void button_Usun_Click(object sender, RoutedEventArgs e)
        {
            int zaznaczony = listBox.SelectedIndex;
            sklad.RemoveAt(zaznaczony);
            z.lista.RemoveAt(zaznaczony);

            //FileStream plik = new FileStream(@"C:\Users\pitek\Documents\Visual Studio 2015\Projects\baza\baza\bin\Debug\zawodnicy2.txt", FileMode.CreateNew);
            //StreamWriter f = new StreamWriter(plik);
            //foreach(zawodnik i in z.lista)
            //{
            //    f.WriteLine(i);
            //}
            //f.Close();
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
