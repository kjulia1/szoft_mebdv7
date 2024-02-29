using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villogogomb
{
    internal class Szamologomb : Button
    {
        int szam = 0;
        public Szamologomb() 
        {
            Width = 20;
            Height = 20;
            MouseClick += Szamologomb_MouseClick;
        }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            if (szam > 5) {
                szam = 0;
            }
        }
    }
}
