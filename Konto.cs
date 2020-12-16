using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Konto
    {
        string navn;
        double saldo;
        int kontoNummer;
        public Konto(string _navn, int _kontoNummer)
        {
            navn = _navn;
            saldo = 0;
            kontoNummer = _kontoNummer;
        }
        public int KuntoNummer
        {
            get
            {
                return kontoNummer;
            }
        }
        public string Navn
        {
            get
            {
                return navn;
            }
        }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
    }
}
