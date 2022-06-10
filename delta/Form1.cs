namespace delta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2, x3, delta;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            delta = (Math.Pow(b, 2) - 4 * a * c);
            double deltaRoot = Math.Sqrt(delta);
            x1 = ((-1) * b + deltaRoot) / (2 * a);
            x2 = ((-1) * b - deltaRoot) / (2 * a);
            x3 = ((-1) * b) / (2 * a);
            odp3.Text = delta.ToString("n2");
            if (delta > 0)
            {
                odp1.Text = x1.ToString("n2");
                odp2.Text = x2.ToString("n2");
                odp4.Text = "s¹ dwa miejsca zerowe";
                odp5.Text = "delata dodatnia";
            }
            else
            {
                if (delta < 0)
                {
                    odp1.Text = "---";
                    odp2.Text = "---";
                    odp4.Text = "nie ma miejsc zerowych";
                    odp5.Text = "delata ujemna";
                }
                else if (delta == 0)
                {
                    odp1.Text = x3.ToString("n2");
                    odp2.Text = "---";
                    odp4.Text = "jest jedno miejsce zerowe";
                    odp5.Text = "delata równa zero";
                }
            }
        }
    }
}