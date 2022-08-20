namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double ilknumara;

        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void sifir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "0";

            }

            else

            {

                textBox1.Text = textBox1.Text + "0";

            }
        }

        private void bir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "1";

            }

            else

            {

                textBox1.Text = textBox1.Text + "1";

            }
        }

        private void iki_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "2";

            }

            else

            {

                textBox1.Text = textBox1.Text + "2";

            }
        }

        private void uc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "3";

            }

            else

            {

                textBox1.Text = textBox1.Text + "3";

            }
        }

        private void dort_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "4";

            }

            else

            {

                textBox1.Text = textBox1.Text + "4";

            }
        }

        private void bes_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "5";

            }

            else

            {

                textBox1.Text = textBox1.Text + "5";

            }
        }

        private void alti_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "6";

            }

            else

            {

                textBox1.Text = textBox1.Text + "6";

            }
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "7";

            }

            else

            {

                textBox1.Text = textBox1.Text + "7";

            }
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "8";

            }

            else

            {

                textBox1.Text = textBox1.Text + "8";

            }
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)

            {

                textBox1.Text = "9";

            }

            else

            {

                textBox1.Text = textBox1.Text + "9";

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";

        }



        private void button12_Click(object sender, EventArgs e)

        {

            ilknumara = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "+";
        }

        private void cýkar_Click(object sender, EventArgs e)
        {
            ilknumara = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "-";
        }

        private void carp_Click(object sender, EventArgs e)
        {
            ilknumara = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "*";
        }

        private void bol_Click(object sender, EventArgs e)
        {
            ilknumara = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "/";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            ilknumara = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "+";
        }

        private void sil_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            double SecondNumber;

            double Result;



            SecondNumber = Convert.ToDouble(textBox1.Text);



            if (Operation == "+")

            {

                Result = (ilknumara + SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                ilknumara = Result;

            }

            if (Operation == "-")

            {

                Result = (ilknumara - SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                ilknumara = Result;



            }

            if (Operation == "*")

            {

                Result = (ilknumara * SecondNumber);

                textBox1.Text = Convert.ToString(Result);

                ilknumara = Result;

            }

            if (Operation == "/")

                if (SecondNumber == 0)

                {

                    textBox1.Text = "Uygulanamaz";

                }

                else

                {

                    Result = (ilknumara / SecondNumber);

                    textBox1.Text = Convert.ToString(Result);

                    ilknumara = Result;

                }
        }
    }
}