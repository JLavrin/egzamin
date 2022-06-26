using System;

namespace GD63322
{
    public class Sklep
    {
        protected string adres;
        protected int iloscTowarow;

        public Sklep(string adres, int iloscTowarow)
        {
            this.adres = adres;
            this.iloscTowarow = iloscTowarow;
        }

        public string Info()
        {
            return "Adres: " + this.adres + "; liczba towarow: " + this.iloscTowarow;
        }
    }
}