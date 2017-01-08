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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLista_Click(object sender, RoutedEventArgs e)
        {
            Lista okno = new Lista();
            okno.ShowDialog();
        }

        private void button_zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonWyjsciowySklad_Click(object sender, RoutedEventArgs e)
        {
            WyborUstawienia okno = new WyborUstawienia();
            okno.ShowDialog();
        }

        private void ButtonWyjsciowySklad_Copy_Click(object sender, RoutedEventArgs e)
        {
            OstatniMecz okno = new OstatniMecz();
            okno.ShowDialog();
        }
    }
}
