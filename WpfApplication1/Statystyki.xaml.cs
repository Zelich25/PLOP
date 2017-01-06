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
    /// Interaction logic for Statystyki.xaml
    /// </summary>
    public partial class Statystyki : Window
    {
        zawodnik z;
        public Statystyki()
        {
            InitializeComponent();
        }
        public Statystyki(zawodnik z):this()
        {
            this.z = z;
            textBox_imie.Text = z.Imie;
            textBox_pozycja.Text = z.Pozycja;
            textBox_nazwisko.Text = z.Nazwisko;
            textBox_minuty.Text = Convert.ToString(z.Minuty);
            textBox_gole.Text = Convert.ToString(z.Gole);
            textBox_asysty.Text = Convert.ToString(z.Asysty);
            textBox_odbiory.Text = Convert.ToString(z.Odbiory);
            textBox_obrony.Text = Convert.ToString(z.Obrony);
            
            if(z.Pozycja == "Bramkarz")
            {
                label_gole.Content = "Puszczone bramki";
                label_asysty.Content = "Interwencje";
            }
            else
            {
                label_gole.Content = "Gole";
                label_asysty.Content = "Asysty";
                label_odbiory.Content = "Odbiory";
                label_obrony.Content = "Obrony";
            }
            

        }

        private void buttonZamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textBox_odbiory_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
