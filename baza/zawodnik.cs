using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza
{
    public class zawodnik
    {
        string imie, nazwisko,pozycja;
        int gole, asysty,odbiory, obrony, minuty;

        public string Imie
        {
            get
            {
                return imie;
            }

            set
            {
                imie = value;
            }
        }
        public int Gole
        {
            get
            {
                return gole;
            }

            set
            {
                gole = value;
            }
        }
        public int Asysty
        {
            get
            {
                return asysty;
            }

            set
            {
                asysty = value;
            }
        }
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }

            set
            {
                nazwisko = value;
            }
        }
        public int Minuty
        {
            get
            {
                return minuty;
            }

            set
            {
                minuty = value;
            }
        }
        public string Pozycja
        {
            get
            {
                return pozycja;
            }

            set
            {
                pozycja = value;
            }
        }

        public int Odbiory
        {
            get
            {
                return odbiory;
            }

            set
            {
                odbiory = value;
            }
        }

        public int Obrony
        {
            get
            {
                return obrony;
            }

            set
            {
                obrony = value;
            }
        }

        public zawodnik()
        {

        }
        public zawodnik(string imie, string nazwisko,string pozycja)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pozycja = pozycja;
            this.Minuty = 0;
            this.Gole = 0;
            this.Asysty = 0;
            this.Odbiory = 0;
            this.Obrony = 0;
            
       }
        public zawodnik(string imie, string nazwisko, string pozycja, int minuty,int gole,int asysty, int odbiory, int obrony)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pozycja = pozycja;
            this.Minuty = minuty;
            this.Gole = gole;
            this.Asysty = asysty;
            this.Odbiory = odbiory;
            this.Obrony = obrony;

        }
        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }
    }
}
