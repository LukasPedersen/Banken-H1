using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Bank
    {
        Program pg = new Program();
        //Fields
        string bankNavn;
        double beholdning;

        //Bank-Constructor
        public Bank(string _bankNavn, double _beholdning)
        {
            bankNavn = _bankNavn;
            beholdning = _beholdning;
        }
        /// <summary>
        /// Simple method that returns a string
        /// </summary>
        /// <returns>************ Velkommen til {bankNavn} ************\nBankens beholdning:                        {beholdning}</returns>
        public string Status()
        {
            return $"************ Velkommen til {bankNavn} ************ \n Bankens beholdning:               {beholdning:c} ";
        }
        public string opretKonto(string navn)
        {
            Konto minKonto = new Konto(navn);
            return $"Konto oprettet med Navn:{navn}";
        }
        public string Indsæt(int beløb)
        {
            beholdning += beløb;
            return $"{beløb:c}Kr. Blev sat ind på din konto";
        }
        public string Hæv(int beløb)
        {
            beholdning -= beløb;
            return $"{beløb:c}Kr. Blev hævet fra din konto";
        }
        public string Saldo()
        {
            return $"{beholdning:c}Kr. Er på din konto";
        }
        //properties
        public string BankNavn
        {
            get
            {
                return bankNavn;
            }
            set
            {
                bankNavn = value;
            }
        }
        public double Beholdning
        {
            get
            {
                return beholdning;
            }
            set
            {
                beholdning = value;
            }
        }
    }
}
