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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DodajZawodnika.xaml
    /// </summary>
    public partial class DodajZawodnika : Window
    {
        zawodnik zaw;
        public DodajZawodnika()
        {
            InitializeComponent();
        }
        public DodajZawodnika(zawodnik zaw):this()
        {
            this.zaw = zaw;
            comboBox.Items.Add("Napastnik");
            comboBox.Items.Add("Pomocnik");
            comboBox.Items.Add("Obronca");
            comboBox.Items.Add("Bramkarz");
            //textBox_pozycja.Text = zaw.Pozycja;
            //textBox_imie.Text = zaw.Imie;
            //textBox_nazwisko.Text = zaw.Nazwisko;
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            zaw.Pozycja = comboBox.Text;
            zaw.Imie = textBox_imie.Text;
            zaw.Nazwisko = textBox_nazwisko.Text;
            this.Close();
            
        }
    }
}
