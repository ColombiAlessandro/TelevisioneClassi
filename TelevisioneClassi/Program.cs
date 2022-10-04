using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisioneClassi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Televisione
    {
        public string produttore;
        public string modello;
        public string[] connettori;
        public bool stato;
        public int canale;
        public void cambiaStato()
        {
            stato = !stato;
        }
        public void cambiaCanale()
        {
            int tmp= int.Parse(Console.ReadLine());
            if (tmp >= 0 && tmp <= 999)
            {
                canale = int.Parse(Console.ReadLine());
            }
            else Console.WriteLine("Canale non trovato");
        }
    }
}
