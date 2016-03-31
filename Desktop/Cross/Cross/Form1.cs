using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string wynikDobry=Policz.Oblicz();
            wyniki.AppendText(Environment.NewLine + wynikDobry);
            Rysuj.rysujWezly = true;
            Rysuj.rysujDzialki = true;
            panel1.Refresh();
        }
        private void liczbaWezlow_ValueChanged(object sender, EventArgs e)
        {
            Policz.liczbaWezlow = Convert.ToInt16(liczbaWezlow.Value);
        }
        private void liczbaDzialekWPetlach_ValueChanged(object sender, EventArgs e)
        {
            Policz.liczbaDzialek = Convert.ToInt32(liczbaDzialekWPetlach.Value);
        }

        private void liczbaPetli_ValueChanged(object sender, EventArgs e)
        {
            Policz.liczbaPetli = Convert.ToInt16(liczbaPetli.Value);
        }

        private void bladPrzeplywu_TextChanged(object sender, EventArgs e)
        {
            Policz.ilosciteracji = Convert.ToInt32(bladPrzeplywu.Text);
        }

        private void bladPrzeplywu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void X1_ValueChanged(object sender, EventArgs e)
        {
            Policz.X[1] = Convert.ToSingle(X1.Value*100);
        }
        private void X2_ValueChanged(object sender, EventArgs e)
        {
            Policz.X[2] = Convert.ToSingle(X2.Value*100);
        }
        private void X3_ValueChanged(object sender, EventArgs e)
        {
            Policz.X[3] = Convert.ToSingle(X3.Value * 100);
        }
        private void X4_ValueChanged(object sender, EventArgs e)
        {
            Policz.X[4] = Convert.ToSingle(X4.Value * 100);
        }
        private void X5_ValueChanged(object sender, EventArgs e)
        {
            Policz.X[5] = Convert.ToSingle(X5.Value * 100);
        }
        private void X6_ValueChanged(object sender, EventArgs e)
        {
            Policz.X[6] = Convert.ToSingle(X6.Value * 100);
        }
        private void Y1_ValueChanged(object sender, EventArgs e)
        {
            Policz.Y[1] = Convert.ToSingle(Y1.Value * 100);
        }
        private void Y2_ValueChanged(object sender, EventArgs e)
        {
            Policz.Y[2] = Convert.ToSingle(Y2.Value * 100);
        }
        private void Y3_ValueChanged(object sender, EventArgs e)
        {
            Policz.Y[3] = Convert.ToSingle(Y3.Value * 100);
        }
        private void Y4_ValueChanged(object sender, EventArgs e)
        {
            Policz.Y[4] = Convert.ToSingle(Y4.Value * 100);
        }
        private void Y5_ValueChanged(object sender, EventArgs e)
        {
            Policz.Y[5] = Convert.ToSingle(Y5.Value * 100);
        }
        private void Y6_ValueChanged(object sender, EventArgs e)
        {
            Policz.Y[6] = Convert.ToSingle(Y6.Value * 100);
        }

        private void oporDz1_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[1] = Convert.ToSingle(oporDz1.Text);
        }
        private void oporDz2_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[2] = Convert.ToSingle(oporDz2.Text);
        }
        private void oporDz3_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[3] = Convert.ToSingle(oporDz3.Text);
        }
        private void oporDz4_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[4] = Convert.ToSingle(oporDz4.Text);
        }
        private void oporDz5_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[5] = Convert.ToSingle(oporDz5.Text);
        }
        private void oporDz6_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[6] = Convert.ToSingle(oporDz6.Text);
        }
        private void oporDz7_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[7] = Convert.ToSingle(oporDz7.Text);
        }
        private void oporDz8_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[8] = Convert.ToSingle(oporDz8.Text);
        }
        private void oporDz9_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[9] = Convert.ToSingle(oporDz9.Text);
        }
        private void oporDz10_TextChanged(object sender, EventArgs e)
        {
            Policz.stratyNaJednostke[10] = Convert.ToSingle(oporDz10.Text);
        }

        private void oporDz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void oporDz10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void przeplywDz1_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[1] = Convert.ToSingle(przeplywDz1.Text);
            Policz.przeplyw[1] = Convert.ToSingle(przeplywDz1.Text);
        }
        private void przeplywDz2_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[2] = Convert.ToSingle(przeplywDz2.Text);
            Policz.przeplyw[2] = Convert.ToSingle(przeplywDz2.Text);

        }
        private void przeplywDz3_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[3] = Convert.ToSingle(przeplywDz3.Text);
            Policz.przeplyw[3] = Convert.ToSingle(przeplywDz3.Text);

        }
        private void przeplywDz4_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[4] = Convert.ToSingle(przeplywDz4.Text);
            Policz.przeplyw[4] = Convert.ToSingle(przeplywDz4.Text);

        }
        private void przeplywDz5_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[5] = Convert.ToSingle(przeplywDz5.Text);
            Policz.przeplyw[5] = Convert.ToSingle(przeplywDz5.Text);

        }
        private void przeplywDz6_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[6] = Convert.ToSingle(przeplywDz6.Text);
            Policz.przeplyw[6] = Convert.ToSingle(przeplywDz6.Text);

        }
        private void przeplywDz7_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[7] = Convert.ToSingle(przeplywDz7.Text);
            Policz.przeplyw[7] = Convert.ToSingle(przeplywDz7.Text);

        }
        private void przeplywDz8_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[8] = Convert.ToSingle(przeplywDz8.Text);
            Policz.przeplyw[8] = Convert.ToSingle(przeplywDz8.Text);

        }
        private void przeplywDz9_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[9] = Convert.ToSingle(przeplywDz9.Text);
            Policz.przeplyw[8] = Convert.ToSingle(przeplywDz9.Text);

        }
        private void przeplywDz10_TextChanged(object sender, EventArgs e)
        {
            Policz.przeplywPoczatkowy[10] = Convert.ToSingle(przeplywDz10.Text);
            Policz.przeplyw[10] = Convert.ToSingle(przeplywDz10.Text);

        }

        private void przeplywDz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void przeplywDz10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void istniejeDz1WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz1WPetli1.Checked)
                Policz.dzialkawPetli[1, 1] = 1;
            else
                Policz.dzialkawPetli[1, 1] = 0;
        }

        private void istniejeDz2WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz2WPetli1.Checked)
                Policz.dzialkawPetli[1, 2] = 1;
            else
                Policz.dzialkawPetli[1, 2] = 0;
        }

        private void istniejeDz3WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz3WPetli1.Checked)
                Policz.dzialkawPetli[1, 3] = 1;
            else
                Policz.dzialkawPetli[1, 3] = 0;
        }

        private void istniejeDz4WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz4WPetli1.Checked)
                Policz.dzialkawPetli[1, 4] = 1;
            else
                Policz.dzialkawPetli[1, 4] = 0;
        }

        private void istniejeDz5WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz5WPetli1.Checked)
                Policz.dzialkawPetli[1, 5] = 1;
            else
                Policz.dzialkawPetli[1, 5] = 0;
        }

        private void istniejeDz6WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz6WPetli1.Checked)
                Policz.dzialkawPetli[1, 6] = 1;
            else
                Policz.dzialkawPetli[1, 6] = 0;
        }

        private void istniejeDz7WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz7WPetli1.Checked)
                Policz.dzialkawPetli[1, 7] = 1;
            else
                Policz.dzialkawPetli[1, 7] = 0;
        }

        private void istniejeDz8WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz8WPetli1.Checked)
                Policz.dzialkawPetli[1, 8] = 1;
            else
                Policz.dzialkawPetli[1, 8] = 0;
        }

        private void istniejeDz9WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz9WPetli1.Checked)
                Policz.dzialkawPetli[1, 9] = 1;
            else
                Policz.dzialkawPetli[1, 9] = 0;
        }

        private void istniejeDz10WPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz10WPetli1.Checked)
                Policz.dzialkawPetli[1, 10] = 1;
            else
                Policz.dzialkawPetli[1, 10] = 0;
        }

        private void zgodnaDz1wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz1wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 1] = 1;
            else
                Policz.kierunekPrzeplywu[1, 1] = 0;
        }

        private void zgodnaDz2wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz2wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 2] = 1;
            else
                Policz.kierunekPrzeplywu[1, 2] = 0;
        }
        private void zgodnaDz3wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz3wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 3] = 1;
            else
                Policz.kierunekPrzeplywu[1, 3] = 0;
        }

        private void zgodnaDz4wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz4wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 4] = 1;
            else
                Policz.kierunekPrzeplywu[1, 4] = 0;
        }

        private void zgodnaDz5wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz5wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 5] = 1;
            else
                Policz.kierunekPrzeplywu[1, 5] = 0;
        }

        private void zgodnaDz6wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz6wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 6] = 1;
            else
                Policz.kierunekPrzeplywu[1, 6] = 0;
        }

        private void zgodnaDz7wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz7wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 7] = 1;
            else
                Policz.kierunekPrzeplywu[1, 7] = 0;
        }

        private void zgodnaDz8wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz8wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 8] = 1;
            else
                Policz.kierunekPrzeplywu[1, 8] = 0;
        }

        private void zgodnaDz9wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz9wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 9] = 1;
            else
                Policz.kierunekPrzeplywu[1, 9] = 0;
        }

        private void zgodnaDz10wPetli1_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz10wPetli1.Checked)
                Policz.kierunekPrzeplywu[1, 10] = 1;
            else
                Policz.kierunekPrzeplywu[1, 10] = 0;
        }

        private void istniejeDz1WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz1WPetli2.Checked)
                Policz.dzialkawPetli[2, 1] = 2;
            else
                Policz.dzialkawPetli[2, 1] = 0;
        }

        private void istniejeDz2WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz2WPetli2.Checked)
                Policz.dzialkawPetli[2, 2] = 2;
            else
                Policz.dzialkawPetli[2, 2] = 0;
        }

        private void istniejeDz3WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz3WPetli2.Checked)
                Policz.dzialkawPetli[2, 3] = 2;
            else
                Policz.dzialkawPetli[2, 3] = 0;
        }

        private void istniejeDz4WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz4WPetli2.Checked)
                Policz.dzialkawPetli[2, 4] = 2;
            else
                Policz.dzialkawPetli[2, 4] = 0;
        }

        private void istniejeDz5WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz5WPetli2.Checked)
                Policz.dzialkawPetli[2, 5] = 2;
            else
                Policz.dzialkawPetli[2, 5] = 0;
        }

        private void istniejeDz6WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz6WPetli2.Checked)
                Policz.dzialkawPetli[2, 6] = 2;
            else
                Policz.dzialkawPetli[2, 6] = 0;
        }

        private void istniejeDz7WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz7WPetli2.Checked)
                Policz.dzialkawPetli[2, 7] = 2;
            else
                Policz.dzialkawPetli[2, 7] = 0;
        }

        private void istniejeDz8WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz8WPetli2.Checked)
                Policz.dzialkawPetli[2, 8] = 2;
            else
                Policz.dzialkawPetli[2, 8] = 0;
        }

        private void istniejeDz9WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz9WPetli2.Checked)
                Policz.dzialkawPetli[2, 9] = 2;
            else
                Policz.dzialkawPetli[2, 9] = 0;
        }

        private void istniejeDz10WPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz10WPetli2.Checked)
                Policz.dzialkawPetli[2, 10] = 2;
            else
                Policz.dzialkawPetli[2, 10] = 0;
        }

        private void zgodnaDz1wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz1wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 1] = 1;
            else
                Policz.kierunekPrzeplywu[2, 1] = 0;
        }

        private void zgodnaDz2wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz2wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 2] = 1;
            else
                Policz.kierunekPrzeplywu[2, 2] = 0;
        }

        private void zgodnaDz3wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz3wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 3] = 1;
            else
                Policz.kierunekPrzeplywu[2, 3] = 0;
        }

        private void zgodnaDz4wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz4wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 4] = 1;
            else
                Policz.kierunekPrzeplywu[2, 4] = 0;
        }

        private void zgodnaDz5wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz5wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 5] = 1;
            else
                Policz.kierunekPrzeplywu[2, 5] = 0;
        }

        private void zgodnaDz6wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz6wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 6] = 1;
            else
                Policz.kierunekPrzeplywu[2, 6] = 0;
        }

        private void zgodnaDz7wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz7wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 7] = 1;
            else
                Policz.kierunekPrzeplywu[2, 7] = 0;
        }

        private void zgodnaDz8wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz8wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 8] = 1;
            else
                Policz.kierunekPrzeplywu[2, 8] = 0;
        }

        private void zgodnaDz9wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz9wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 9] = 1;
            else
                Policz.kierunekPrzeplywu[2, 9] = 0;
        }

        private void zgodnaDz10wPetli2_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz10wPetli2.Checked)
                Policz.kierunekPrzeplywu[2, 10] = 1;
            else
                Policz.kierunekPrzeplywu[2, 10] = 0;
        }

        private void istniejeDz1WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz1WPetli3.Checked)
                Policz.dzialkawPetli[3, 1] = 3;
            else
                Policz.dzialkawPetli[3, 1] = 0;
        }

        private void istniejeDz2WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz2WPetli3.Checked)
                Policz.dzialkawPetli[3, 2] = 3;
            else
                Policz.dzialkawPetli[3, 2] = 0;
        }

        private void istniejeDz3WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz3WPetli3.Checked)
                Policz.dzialkawPetli[3, 3] = 3;
            else
                Policz.dzialkawPetli[3, 3] = 0;
        }

        private void istniejeDz4WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz4WPetli3.Checked)
                Policz.dzialkawPetli[3, 4] = 3;
            else
                Policz.dzialkawPetli[3, 4] = 0;
        }

        private void istniejeDz5WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz5WPetli3.Checked)
                Policz.dzialkawPetli[3, 5] = 3;
            else
                Policz.dzialkawPetli[3, 5] = 0;
        }

        private void istniejeDz6WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz6WPetli3.Checked)
                Policz.dzialkawPetli[3, 6] = 3;
            else
                Policz.dzialkawPetli[3, 6] = 0;
        }

        private void istniejeDz7WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz7WPetli3.Checked)
                Policz.dzialkawPetli[3, 7] = 3;
            else
                Policz.dzialkawPetli[3, 7] = 0;
        }

        private void istniejeDz8WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz8WPetli3.Checked)
                Policz.dzialkawPetli[3, 8] = 3;
            else
                Policz.dzialkawPetli[3, 8] = 0;
        }

        private void istniejeDz9WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz9WPetli3.Checked)
                Policz.dzialkawPetli[3, 9] = 3;
            else
                Policz.dzialkawPetli[3, 9] = 0;
        }

        private void istniejeDz10WPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz10WPetli3.Checked)
                Policz.dzialkawPetli[3, 10] = 3;
            else
                Policz.dzialkawPetli[3, 10] = 0;
        }

        private void zgodnaDz1wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz1wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 1] = 1;
            else
                Policz.kierunekPrzeplywu[3, 1] = 0;
        }

        private void zgodnaDz2wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz2wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 2] = 1;
            else
                Policz.kierunekPrzeplywu[3, 2] = 0;
        }

        private void zgodnaDz3wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz3wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 3] = 1;
            else
                Policz.kierunekPrzeplywu[3, 3] = 0;
        }

        private void zgodnaDz4wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz4wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 4] = 1;
            else
                Policz.kierunekPrzeplywu[3, 4] = 0;
        }

        private void zgodnaDz5wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz5wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 5] = 1;
            else
                Policz.kierunekPrzeplywu[3, 5] = 0;
        }

        private void zgodnaDz6wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz6wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 6] = 1;
            else
                Policz.kierunekPrzeplywu[3, 6] = 0;
        }

        private void zgodnaDz7wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz7wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 7] = 1;
            else
                Policz.kierunekPrzeplywu[3, 7] = 0;
        }

        private void zgodnaDz8wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz8wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 8] = 1;
            else
                Policz.kierunekPrzeplywu[3, 8] = 0;
        }

        private void zgodnaDz9wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz9wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 9] = 1;
            else
                Policz.kierunekPrzeplywu[3, 9] = 0;
        }

        private void zgodnaDz10wPetli3_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz10wPetli3.Checked)
                Policz.kierunekPrzeplywu[3, 10] = 1;
            else
                Policz.kierunekPrzeplywu[3, 10] = 0;
        }

        private void istniejeDz1WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz1WPetli4.Checked)
                Policz.dzialkawPetli[4, 1] = 4;
            else
                Policz.dzialkawPetli[4, 1] = 0;
        }

        private void istniejeDz2WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz2WPetli4.Checked)
                Policz.dzialkawPetli[4, 2] = 4;
            else
                Policz.dzialkawPetli[4, 2] = 0;
        }

        private void istniejeDz3WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz3WPetli4.Checked)
                Policz.dzialkawPetli[4, 3] = 4;
            else
                Policz.dzialkawPetli[4, 3] = 0;
        }

        private void istniejeDz4WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz4WPetli4.Checked)
                Policz.dzialkawPetli[4, 4] = 4;
            else
                Policz.dzialkawPetli[4, 4] = 0;
        }

        private void istniejeDz5WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz5WPetli4.Checked)
                Policz.dzialkawPetli[4, 5] = 4;
            else
                Policz.dzialkawPetli[4, 5] = 0;
        }

        private void istniejeDz6WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz6WPetli4.Checked)
                Policz.dzialkawPetli[4, 6] = 4;
            else
                Policz.dzialkawPetli[4, 6] = 0;
        }

        private void istniejeDz7WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz7WPetli4.Checked)
                Policz.dzialkawPetli[4, 7] = 4;
            else
                Policz.dzialkawPetli[4, 7] = 0;
        }

        private void istniejeDz8WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz8WPetli4.Checked)
                Policz.dzialkawPetli[4, 8] = 4;
            else
                Policz.dzialkawPetli[4, 8] = 0;
        }

        private void istniejeDz9WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz9WPetli4.Checked)
                Policz.dzialkawPetli[4, 9] = 4;
            else
                Policz.dzialkawPetli[4, 9] = 0;
        }

        private void istniejeDz10WPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz10WPetli4.Checked)
                Policz.dzialkawPetli[4, 10] = 4;
            else
                Policz.dzialkawPetli[4, 10] = 0;
        }

        private void zgodnaDz1wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz1wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 1] = 1;
            else
                Policz.kierunekPrzeplywu[4, 1] = 0;
        }

        private void zgodnaDz2wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz2wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 2] = 1;
            else
                Policz.kierunekPrzeplywu[4, 2] = 0;
        }

        private void zgodnaDz3wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz3wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 3] = 1;
            else
                Policz.kierunekPrzeplywu[4, 3] = 0;
        }

        private void zgodnaDz4wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz4wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 4] = 1;
            else
                Policz.kierunekPrzeplywu[4, 4] = 0;
        }

        private void zgodnaDz5wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz5wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 5] = 1;
            else
                Policz.kierunekPrzeplywu[4, 5] = 0;
        }

        private void zgodnaDz6wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz6wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 6] = 1;
            else
                Policz.kierunekPrzeplywu[4, 6] = 0;
        }

        private void zgodnaDz7wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz7wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 7] = 1;
            else
                Policz.kierunekPrzeplywu[4, 7] = 0;
        }

        private void zgodnaDz8wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz8wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 8] = 1;
            else
                Policz.kierunekPrzeplywu[4, 8] = 0;
        }

        private void zgodnaDz9wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz9wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 9] = 1;
            else
                Policz.kierunekPrzeplywu[4, 9] = 0;
        }

        private void zgodnaDz10wPetli4_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz10wPetli4.Checked)
                Policz.kierunekPrzeplywu[4, 10] = 1;
            else
                Policz.kierunekPrzeplywu[4, 10] = 0;
        }

        private void istniejeDz1WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz1WPetli5.Checked)
                Policz.dzialkawPetli[5, 1] = 5;
            else
                Policz.dzialkawPetli[5, 1] = 0;
        }

        private void istniejeDz2WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz2WPetli5.Checked)
                Policz.dzialkawPetli[5, 2] = 4;
            else
                Policz.dzialkawPetli[5, 2] = 0;
        }

        private void istniejeDz3WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz3WPetli5.Checked)
                Policz.dzialkawPetli[5, 3] = 5;
            else
                Policz.dzialkawPetli[5, 3] = 0;
        }

        private void istniejeDz4WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz4WPetli5.Checked)
                Policz.dzialkawPetli[5, 4] = 5;
            else
                Policz.dzialkawPetli[5, 4] = 0;
        }

        private void istniejeDz5WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz5WPetli5.Checked)
                Policz.dzialkawPetli[5, 5] = 5;
            else
                Policz.dzialkawPetli[5, 5] = 0;
        }

        private void istniejeDz6WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz6WPetli5.Checked)
                Policz.dzialkawPetli[5, 6] = 5;
            else
                Policz.dzialkawPetli[5, 6] = 0;
        }

        private void istniejeDz7WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz7WPetli5.Checked)
                Policz.dzialkawPetli[5, 7] = 5;
            else
                Policz.dzialkawPetli[5, 7] = 0;
        }

        private void istniejeDz8WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz8WPetli5.Checked)
                Policz.dzialkawPetli[5, 8] = 5;
            else
                Policz.dzialkawPetli[5, 8] = 0;
        }

        private void istniejeDz9WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz9WPetli5.Checked)
                Policz.dzialkawPetli[5, 9] = 5;
            else
                Policz.dzialkawPetli[5, 9] = 0;
        }

        private void istniejeDz10WPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (istniejeDz10WPetli5.Checked)
                Policz.dzialkawPetli[5, 10] = 5;
            else
                Policz.dzialkawPetli[5, 10] = 0;
        }

        private void zgodnaDz1wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz1wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 1] = 1;
            else
                Policz.kierunekPrzeplywu[5, 1] = 0;
        }

        private void zgodnaDz2wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz2wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 2] = 1;
            else
                Policz.kierunekPrzeplywu[5, 2] = 0;
        }

        private void zgodnaDz3wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz3wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 3] = 1;
            else
                Policz.kierunekPrzeplywu[5, 3] = 0;
        }

        private void zgodnaDz4wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz4wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 4] = 1;
            else
                Policz.kierunekPrzeplywu[5, 4] = 0;
        }

        private void zgodnaDz5wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz5wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 5] = 1;
            else
                Policz.kierunekPrzeplywu[5, 5] = 0;
        }

        private void zgodnaDz6wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz6wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 6] = 1;
            else
                Policz.kierunekPrzeplywu[5, 6] = 0;
        }

        private void zgodnaDz7wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz7wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 7] = 1;
            else
                Policz.kierunekPrzeplywu[5, 7] = 0;
        }

        private void zgodnaDz8wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz8wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 8] = 1;
            else
                Policz.kierunekPrzeplywu[5, 8] = 0;
        }

        private void zgodnaDz9wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz9wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 9] = 1;
            else
                Policz.kierunekPrzeplywu[5, 9] = 0;
        }

        private void zgodnaDz10wPetli5_CheckedChanged(object sender, EventArgs e)
        {
            if (zgodnaDz10wPetli5.Checked)
                Policz.kierunekPrzeplywu[5, 10] = 1;
            else
                Policz.kierunekPrzeplywu[5, 10] = 0;
        }

        private void wezelPoczatkowyDz1_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[1, 0] = Convert.ToInt32(wezelPoczatkowyDz1.Value);
        }

        private void wezelPoczatkowyDz2_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[2, 0] = Convert.ToInt32(wezelPoczatkowyDz2.Value);
        }

        private void wezelPoczatkowyDz3_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[3, 0] = Convert.ToInt32(wezelPoczatkowyDz3.Value);
        }

        private void wezelPoczatkowyDz4_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[4, 0] = Convert.ToInt32(wezelPoczatkowyDz4.Value);
        }

        private void wezelPoczatkowyDz5_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[5, 0] = Convert.ToInt32(wezelPoczatkowyDz5.Value);
        }

        private void wezelPoczatkowyDz6_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[6, 0] = Convert.ToInt32(wezelPoczatkowyDz6.Value);
        }

        private void wezelPoczatkowyDz7_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[7, 0] = Convert.ToInt32(wezelPoczatkowyDz7.Value);
        }

        private void wezelPoczatkowyDz8_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[8, 0] = Convert.ToInt32(wezelPoczatkowyDz8.Value);
        }

        private void wezelPoczatkowyDz9_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[9, 0] = Convert.ToInt32(wezelPoczatkowyDz9.Value);
        }

        private void wezelPoczatkowyDz10_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[10, 0] = Convert.ToInt32(wezelPoczatkowyDz10.Value);
        }

        private void wezelKoncowyDz1_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[1, 1] = Convert.ToInt32(wezelKoncowyDz1.Value);
        }

        private void wezelKoncowyDz2_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[2, 1] = Convert.ToInt32(wezelKoncowyDz2.Value);
        }

        private void wezelKoncowyDz3_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[3, 1] = Convert.ToInt32(wezelKoncowyDz3.Value);

        }

        private void wezelKoncowyDz4_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[4, 1] = Convert.ToInt32(wezelKoncowyDz4.Value);

        }

        private void wezelKoncowyDz5_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[5, 1] = Convert.ToInt32(wezelKoncowyDz5.Value);
        }

        private void wezelKoncowyDz6_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[6, 1] = Convert.ToInt32(wezelKoncowyDz6.Value);
        }

        private void wezelKoncowyDz7_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[7, 1] = Convert.ToInt32(wezelKoncowyDz7.Value);
        }

        private void wezelKoncowyDz8_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[8, 1] = Convert.ToInt32(wezelKoncowyDz8.Value);
        }

        private void wezelKoncowyDz9_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[9, 1] = Convert.ToInt32(wezelKoncowyDz9.Value);
        }

        private void wezelKoncowyDz10_ValueChanged(object sender, EventArgs e)
        {
            Policz.wezlyDzialki[10, 1] = Convert.ToInt32(wezelKoncowyDz10.Value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            panel1.BackColor = Color.White;
            Pen ramka = new Pen(Color.Black, 3);
            g.DrawLine(ramka, 0, 0, 0, panel1.Height);
            g.DrawLine(ramka, 0, 0, panel1.Width, 0);
            g.DrawLine(ramka, panel1.Width, 0, panel1.Width, panel1.Height);
            g.DrawLine(ramka, 0, panel1.Height, panel1.Width, panel1.Height);
            Pen dzialka = new Pen(Color.Red, 4);
            Pen wezel = new Pen(Color.Black, 1);
            Font czcionka = new Font("Arial", 12);
            Pen liniaSiatki = new Pen(Color.Black, 1);
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(liniaSiatki, 100 + 100 * i, 0, 100 + 100 * i, 600);
            }
            for (int i = 0; i < 5; i++)
            {
                g.DrawLine(liniaSiatki, 0, 100 + 100 * i, 600, 100 + 100 * i);
            }
            if (Rysuj.rysujDzialki)
            {
                for (int i = 1; i < Policz.liczbaDzialek + 1; i++)
                {
                    int x1 = (int)(Policz.X[Policz.wezlyDzialki[Policz.dzialka[i], 0]]);
                    int y1 = (int)(Policz.Y[Policz.wezlyDzialki[Policz.dzialka[i], 0]]);
                    int x2 = (int)(Policz.X[Policz.wezlyDzialki[Policz.dzialka[i], 1]]);
                    int y2 = (int)(Policz.Y[Policz.wezlyDzialki[Policz.dzialka[i], 1]]);
                    if (i < Policz.liczbaDzialek + 1)
                    {
                        string oznaczenieDzialki = Convert.ToString(Policz.dzialka[i]);
                        int xx = x1;
                        int yy = y1;
                        if ((x2 > x1) && (y1 == y2))
                        {
                            xx = (x1 + x2) / 2 - 10;
                            yy = y1 - 20;
                        }
                        else if ((x1 == x2) && (y2 > y1))
                        {
                            xx = x1 - 20;
                            yy = (y1 + y2) / 2 - 10;
                        }
                        else if ((x2 > x1) && (y2 > y1))
                        {
                            xx = (x1 + x2) / 2 - 5;
                            yy = (y1 + y2) / 2 + 5;
                        }else if ((x1 == 0) || (y1 == 0))
                        {
                            xx = -20;
                            yy = -20;
                        }
                        g.DrawLine(dzialka, x1, y1, x2, y2);
                        g.DrawString(oznaczenieDzialki, czcionka, Brushes.Red, xx, yy);
                    }
                }
            }
            if (Rysuj.rysujWezly)
            {
                for (int i = 1; i < Policz.liczbaWezlow + 1; i++)
                {
                    int x = (int)(Policz.X[i]);
                    int y = (int)(Policz.Y[i]);
                    g.FillEllipse(Brushes.Black, x - 5, y - 5, 10, 10);
                    string oznaczenieWezla = Convert.ToString(Policz.wezel[i]);
                    g.DrawString(oznaczenieWezla, czcionka, Brushes.Black, x - 20, y + 10);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rysuj.rysujWezly = true;
            panel1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rysuj.rysujDzialki = true;
            panel1.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen liniaSiatki = new Pen(Color.Black, 1);
            Graphics g = e.Graphics;
            g.DrawLine(liniaSiatki, 0, 5, 575, 5);
            g.DrawLine(liniaSiatki, 570, 0, 575, 5);
            g.DrawLine(liniaSiatki, 570, 10, 575, 5);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen liniaSiatki = new Pen(Color.Black, 1);
            Graphics g = e.Graphics;
            g.DrawLine(liniaSiatki, 5, 0, 5, 575);
            g.DrawLine(liniaSiatki, 0, 570, 5, 575);
            g.DrawLine(liniaSiatki, 5, 575, 10, 570);
        }
    }
}
