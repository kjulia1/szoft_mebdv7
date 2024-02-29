using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villogogomb
{
    internal class Szinezodogomb : Button
    {
        public Szinezodogomb()
        {
            Width = 20;
            Height = 20;
            MouseClick += Szinezodogomb_MouseClick;
        }

        private void Szinezodogomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
