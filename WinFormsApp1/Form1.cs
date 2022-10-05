namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double x, y;
            int i, f;
            //читаємо дані з форми
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            textBox4.Clear();
            String str = "x\t\t\t y\r\n";
            //табулюємо
            for (i = 0, f = 1, x = a; x <= b; x = x + h) {
                y = Func(x);        //наша функція
                i = i++;
                str = str + $"{x:F6}" + "\t\t\t " + y.ToString() + "\r\n"; //результат дописуємо у стрічку
            }
            textBox4.Text = str; //відображення результату табуляції 

        }

        private double Func(double x) {
            return x + Math.Sqrt(x) * Math.Pow(Math.Sin(x), 2) / (1 + Math.Pow(x, 2));
        }
    }
}