namespace Examen_1
{
    public partial class Form1 : Form
    { 
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //Opciones opciones = new Opciones();
            //opciones.ShowDialog();
            int a;
            a = Convert.ToInt32(txtMonto.Text);
            string b = comboBox1.SelectedItem.ToString();
            double res1, res2, res3, res4;

            if (b == "USD - Dólar Estadounidense")
            {
                res1 = a * 20.25;
                txtMXM.Text = "$" + res1.ToString();
                res2 = a * 1.36;
                txtCAD.Text = "$" + res2.ToString();
                res3 = a * 144.33;
                txtJPY.Text = "¥" + res3.ToString();
                res4 = a * 1.03;
                txtEUR.Text = "€" + res4.ToString();
                txtUSD.Text = "$" + a.ToString();
            }
            if (b == "MXM - Peso Mexicano")
            {
                res1 = a * 0.05;
                txtUSD.Text = "$" + res1.ToString();
                res2 = a * 0.07;
                txtCAD.Text = "$" + res2.ToString();
                res3 = a * 7.13;
                txtJPY.Text = "¥" + res3.ToString();
                res4 = a * 0.05;
                txtEUR.Text = "€" + res4.ToString();
                txtMXM.Text = "$" + a.ToString();

            }
            if (b == "EUR - Euro")
            {
                res1 = a * 0.97;
                txtUSD.Text = "$" + res1.ToString();
                res2 = a * 19.62;
                txtMXM.Text = "$" + res2.ToString();
                res3 = a * 1.32;
                txtCAD.Text = "$" + res3.ToString();
                res4 = a * 139.89;
                txtJPY.Text = "¥" + res4.ToString();
                txtEUR.Text = "€" + a.ToString();
            }
            if (b == "JPY - Yen Japonés")
            {
                res1 = a * 0.01;
                txtUSD.Text = "$" + res1.ToString();
                res2 = a * 0.14;
                txtMXM.Text = "$" + res2.ToString();
                res3 = a * 0.01;
                txtCAD.Text = "$" + res3.ToString();
                res4 = a * 0.01;
                txtEUR.Text = "€" + res4.ToString();
                txtJPY.Text = "¥" + a.ToString();
            }
            if (b == "CAD - Dólar Canadiense")
            {
                res1 = a * 0.73;
                txtUSD.Text = "$" + res1.ToString();
                res2 = a * 14.84;
                txtMXM.Text = "$" + res2.ToString();
                res3 = a * 0.76;
                txtEUR.Text = "€" + res3.ToString();
                res4 = a * 105.4;
                txtJPY.Text = "¥" + res4.ToString();
                txtCAD.Text = "$" + a.ToString();
            }

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}