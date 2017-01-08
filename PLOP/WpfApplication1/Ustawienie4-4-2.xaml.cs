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
using System.Collections.ObjectModel;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Ustawienie4_4_2.xaml
    /// </summary>
    public partial class Ustawienie4_4_2 : Window
    {
        ListaZawodnikow z;
        ObservableCollection<zawodnik> sklad;
        public Ustawienie4_4_2()
        {
            InitializeComponent();
            z = ListaZawodnikow.OdczytajTXT();
            sklad = new ObservableCollection<zawodnik>(z.lista);
            foreach (zawodnik i in sklad)
            {
                if(i.Pozycja=="Napastnik")
                {
                    comboBox0.Items.Add(i);
                    comboBox1.Items.Add(i);
                }
                if(i.Pozycja=="Pomocnik")
                {
                    comboBox2.Items.Add(i);
                    comboBox3.Items.Add(i);
                    comboBox4.Items.Add(i);
                    comboBox5.Items.Add(i);
                }
                if(i.Pozycja=="Obronca")
                {
                    comboBox6.Items.Add(i);
                    comboBox7.Items.Add(i);
                    comboBox8.Items.Add(i);
                    comboBox9.Items.Add(i);
                }
                if(i.Pozycja=="Bramkarz")
                {
                    comboBox10.Items.Add(i);
                }
                
            }
            
        }

        private void buttonZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox0.Text!= comboBox1.Text)
                {
                    string[] tekst = new string[11];
                    tekst[0] = comboBox0.Text;
                    tekst[1] = comboBox1.Text;
                    tekst[2] = comboBox2.Text;
                    tekst[3] = comboBox3.Text;
                    tekst[4] = comboBox4.Text;
                    tekst[5] = comboBox5.Text;
                    tekst[6] = comboBox6.Text;
                    tekst[7] = comboBox7.Text;
                    tekst[8] = comboBox8.Text;
                    tekst[9] = comboBox9.Text;
                    tekst[10] = comboBox10.Text;
                    System.IO.File.WriteAllLines(@"C:\Users\pitek\Documents\Visual Studio 2015\Projects\baza\baza\bin\Debug\sklad.txt", tekst);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie mozesz wybrac tych samych zawodnikow!\nWybierz sklad ponownie");
                    this.Close();
                }
            
            
        }
    }
}
