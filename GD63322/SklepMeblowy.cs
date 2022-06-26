namespace GD63322
{
    public class SklepMeblowy : Sklep
    {
        private char klasa;

        public SklepMeblowy(string adres, int iloscTowarow, char klasa) : base(adres, iloscTowarow)
        {
            this.klasa = klasa;
        }

        public bool Dostepnosc(int wartosc)
        {
            return wartosc >= 0 && wartosc < 13;
        }
    }
}