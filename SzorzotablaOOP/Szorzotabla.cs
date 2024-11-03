using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzorzotablaOOP
{
    internal class Szorzotabla
    {
        private int szam;
        private int[] eredmeny;

        
        public Szorzotabla() { }

        
        public Szorzotabla(int szam)
        {
            SetSzam(szam);
        }

        
        public void SetSzam(int szam)
        {
            if (szam >= 1 && szam <= 9)
            {
                this.szam = szam;
            }
        }

        
        public void SetEredmény()
        {
            eredmeny = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                eredmeny[i] = szam * i;
            }
        }

        
        public int[] GetEredmény()
        {
            return eredmeny;
        }
    }
}
