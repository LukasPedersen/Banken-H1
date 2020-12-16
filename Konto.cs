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
        public Konto(string _navn)
        {
            navn = _navn;
            saldo = 0;
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
