using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza
{
    public class ListaZawodnikow
    {
        //List<zawodnik> lista;

        public virtual List<zawodnik> lista { get; set; }
        public ListaZawodnikow()
        {
            this.lista = new List<zawodnik>();
        }
        public void Dodaj(zawodnik z)
        {
            lista.Add(z);
        }
        public void Usun(zawodnik u)
        {
            lista.Remove(u);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (zawodnik i in lista)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }
        public static ListaZawodnikow OdczytajTXT()
        {
            ListaZawodnikow lista = new ListaZawodnikow();
            List<List<string>> punkty = new List<List<string>>();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\baza\bin\Debug\zawodnicy.txt");
            string[] linie = File.ReadAllLines(path);

            zawodnik[] zw = new zawodnik[linie.Length];
            for (int i = 0; i < linie.Length ; ++i)
            {
                punkty.Add(new List<string>());
                foreach (string slowo in linie[i].Split(' '))
                {
                    punkty[i].Add(slowo);
                }
                int a = Convert.ToInt32(punkty[i][3]);
                int b = Convert.ToInt32(punkty[i][4]);
                int c = Convert.ToInt32(punkty[i][5]);

                //KS
                int d = Convert.ToInt32(punkty[i][6]);
                int e = Convert.ToInt32(punkty[i][7]);

                zw[i] = new zawodnik(punkty[i][0], punkty[i][1], punkty[i][2], a, b, c, d,e);
                lista.Dodaj(zw[i]);
                

            }
            return lista;
        }
    }
}
