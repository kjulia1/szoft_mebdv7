namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irany_x = 1;
        int irany_y = 0;

        int l�p�ssz�m;
        int hossz = 30;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            

            fej_x += irany_x * K�gy�Elem.M�ret;
            fej_y += irany_y * K�gy�Elem.M�ret;


            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.LimeGreen;
            Controls.Add(ke);
            k�gy�.Add(ke);

            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);

                Controls.Remove(lev�gand�);
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irany_y = -1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irany_y = 0;
                irany_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irany_y = 0;
                irany_x = 1;
            }
        }
    }
}