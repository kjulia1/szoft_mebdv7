namespace villogogomb
{
    public partial class Form1 : Form
    {
    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Szinezodogomb b = new Szinezodogomb();
                    b.Width = 30;
                    b.Height=30;
                    b.Top = i * b.Height;
                    b.Left= j * b.Width;
                    b.Text=(i*j).ToString();
                    //b.Left = ClientRectangle.Width / 2 - b.Width / 2;
                    //b.Top = ClientRectangle.Height / 2 - b.Height / 2;
                    Controls.Add(b);
                }
            }
        }
    }
}