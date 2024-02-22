namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 20; i++)
            {
                Sor újSor = new Sor();
                újSor.Sorszám = i;
                újSor.Érték = Fibonacci(i);

                sorok.Add(újSor);
                Button button = new Button();
                button.Top = i * 50;
                button.Width = 80;
                button.Height = 40;
                button.Text = újSor.Érték.ToString();
                Controls.Add(button);
            }
            dataGridView1.DataSource = sorok;


        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}