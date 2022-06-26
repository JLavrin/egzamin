namespace GD63322
{
    public class Supermarket : Sklep
    {
        private string siec;
        
        public Supermarket(string adres, int iloscTowarow, string siec) : base(adres, iloscTowarow)
        {
            this.siec = siec;
        }

        public string Promocja(int wartosc)
        {
            if (wartosc % 4 == 0)
                return "Promocja 25%";
            return "Brak promocji";
        }
        
    }
}