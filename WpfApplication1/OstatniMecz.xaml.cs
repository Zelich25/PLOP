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
using baza;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for OstatniMecz.xaml
    /// </summary>
    public partial class OstatniMecz : Window
    {
        public OstatniMecz()
        {
            InitializeComponent();
            ListaZawodnikow ostatni = new ListaZawodnikow();
            List<List<string>> punkty = new List<List<string>>();
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\baza\bin\Debug\sklad.txt");
            string[] linie = File.ReadAllLines(path);

            zawodnik[] zw = new zawodnik[linie.Length];
            for (int i = 0; i < linie.Length; ++i)
            {
                punkty.Add(new List<string>());
                foreach (string slowo in linie[i].Split(' '))
                {
                    punkty[i].Add(slowo);
                }
            }
            textBoximie1.Text = punkty[0][0];
            textBoxnazwisko1.Text = punkty[0][1];
            textBoximie2.Text = punkty[1][0];
            textBoxnazwisko2.Text = punkty[1][1];
            textBoximie3.Text = punkty[2][0];
            textBoxnazwisko3.Text = punkty[2][1];
            textBoximie4.Text = punkty[3][0];
            textBoxnazwisko4.Text = punkty[3][1];
            textBoximie5.Text = punkty[4][0];
            textBoxnazwisko5.Text = punkty[4][1];
            textBoximie6.Text = punkty[5][0];
            textBoxnazwisko6.Text = punkty[5][1];
            textBoximie7.Text = punkty[6][0];
            textBoxnazwisko7.Text = punkty[6][1];
            textBoximie8.Text = punkty[7][0];
            textBoxnazwisko8.Text = punkty[7][1];
            textBoximie9.Text = punkty[8][0];
            textBoxnazwisko9.Text = punkty[8][1];
            textBoximie10.Text = punkty[9][0];
            textBoxnazwisko10.Text = punkty[9][1];
            textBoximie11.Text = punkty[10][0];
            textBoxnazwisko11.Text = punkty[10][1];
        }

        private void buttonZaiwterdz_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
