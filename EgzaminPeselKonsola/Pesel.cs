using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminPeselKonsola
{
    public class Pesel
    {
        public string numerPesel = "12345678909";
        public int[] mnozniki = [1, 3, 7, 9, 1, 3, 7, 9, 1, 3];

        public Pesel(string numerPesel)
        {
            this.numerPesel = numerPesel;
        }

        public char SprawdzPlec()
        {
            if (int.Parse(numerPesel[9].ToString()) % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        public bool WalidacjaNumeruPesel()
        {
            int s = 0;

            for (int i = 0; i < 10; i++)
            {
                s += int.Parse(numerPesel[i].ToString()) * mnozniki[i];
            }

            int m = s % 10;
            int r;

            if (m == 0)
            {
                r = 0;
            }
            else
            {
                r = 10 - m;
            }

            if (r == int.Parse(numerPesel[10].ToString())) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
