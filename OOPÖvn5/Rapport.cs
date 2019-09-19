namespace OOPÖvn5
{
    internal class Rapport
    {
        //Attributer variabler
        string kund = "";
        int tid = 0;

        //Egenskaper
        public string Kund
        {
            get { return kund; }
            set { kund = value; }
        }

        //Konstruktor
        public Rapport(string k, int t)
        {
            kund = k;
            tid = HalvTillHell(t);
        }

        //Metod
        public int HalvTillHell(int t)
        {
            int min = t / 30;
            int rest = t % 30;
            if (rest != 0)
            {
                if(rest > 29)
                {
                    int del = 30 - rest;
                    min += del + rest;
                }
            }

            int m = min * 30;
            return m;
        }

        public override string ToString()
        {
            return kund + ": " + tid + " min.";
        }
    }
}