using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MathNet.Numerics;
using System.Threading;

namespace Fractals
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double[] coefficients;
        public bool colorRoots = true;
        public int iterations = -1;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            float tolerance = 0.001f;
            iterations = Convert.ToInt32(txtIteration.Text);
            pBox.Image = new Bitmap(pBox.Width, pBox.Height);

            string[] viewport = txtViewport.Text.Split(',');
            double viewportX = Convert.ToDouble(viewport[0]);
            double viewportY = Convert.ToDouble(viewport[1]);

            string[] split = txtEquation.Text.Split(',');

            coefficients = new double[split.Length];
            for(int i = 0; i < split.Length; i++)
            {
                coefficients[coefficients.Length - 1 - i] = Convert.ToDouble(split[i]);
            }

            Complex[] roots = GetRoots(coefficients);

            for (float y = 0; y < pBox.Height; y = y + 1f)
            {
                for (float x = 0; x < pBox.Width; x = x + 1f)
                {
                    Complex z = new Complex((x - 500f)/500f * viewportX, (y - 500f)/500f * viewportY);
                    Color color = NewtonRaphson(z, iterations, tolerance, roots);
                    ((Bitmap)pBox.Image).SetPixel(Convert.ToInt32(x), Convert.ToInt32(y), color);
                }
            }
        }

        public Color NewtonRaphson(Complex x, int i, float tolerance, Complex[] roots)
        {

            Color[] colors = {
                    Color.Red,
                    Color.Green,
                    Color.Blue,
                    Color.Yellow,
                    Color.Purple,
                    Color.Orange,
                    Color.GreenYellow,
                    Color.OrangeRed,
                    Color.BlueViolet
            };

            if (i != 0)
            {
                Complex temp = Complex.Divide(F(x), FDerivative(x));
                x = Complex.Subtract(x, temp);

                for(int j = 0; j < roots.Length; j++)
                {
                    Complex difference = Complex.Subtract(x, roots[j]);
                    if (Math.Abs(difference.Real) < tolerance && Math.Abs(difference.Imaginary) < tolerance)
                    {
                        if(colorRoots)
                        {
                            int value = Convert.ToInt32(Convert.ToDouble(i) / Convert.ToDouble(iterations) * 255);
                            Color color = Color.FromArgb(value, colors[j].R, colors[j].B, colors[j].G);
                            return color;
                        }
                        else
                        {
                            int value = Convert.ToInt32(Convert.ToDouble(i) / Convert.ToDouble(iterations) * 255);
                            Color color = Color.FromArgb(value, value, value);
                            return color;
                        }
                        
                    }
                }
                return NewtonRaphson(x, i - 1, tolerance, roots);
            }
            else
            {
                return Color.Black;
            }

        }

        public Complex F(Complex x)
        {
            Complex result = new Complex(0, 0);
            for(int i = 0; i < coefficients.Length; i++)
            {
                Complex tempCoefficient = new Complex(coefficients[coefficients.Length - 1 - i], 0);
                Complex tempVariable = Complex.Pow(x, coefficients.Length - 1 - i);
                Complex tempResult = Complex.Multiply(tempCoefficient, tempVariable);
                result = Complex.Add(result, tempResult);
            }
            return result;
        }

        public Complex FDerivative(Complex x)
        {
            Complex result = new Complex(0, 0);
            for(int i = 1; i < coefficients.Length; i++)
            {
                if(coefficients[i] != 0)
                {
                    result = result + coefficients[i] * i * Complex.Pow(x, i - 1);
                }
            }

            return result;
            //return Complex.Multiply(8, Complex.Pow(x, 7)) + Complex.Multiply(60, Complex.Pow(x, 3));
        }

        public Complex[] GetRoots(Double[] coefficients)
        {
            return FindRoots.Polynomial(coefficients);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            colorRoots = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            colorRoots = true;
        }
    }
}

/*
 *             string[] polynomials = txtEquation.Text.Split('+');
            for(int i = 0; i < polynomials.Length; i++)
            {
                if(polynomials[i].Contains('-'))
                {
                    Array.Resize(ref polynomials, polynomials.Length + 1);
                    for(int j = i + 1; j < polynomials.Length - 1; j++)
                    {
                        polynomials[j + 1] = polynomials[j];
                    }
                    string[] tempArray = polynomials[i].Split('-');
                    polynomials[i] = tempArray[0];
                    polynomials[i + 1] = tempArray[1];
                }
            }

            string[] tempSplit = polynomials[0].Split('^');
            int tempLength = Convert.ToInt32(tempSplit[1]);
            double[] coefficients = new double[tempLength];

            for(int i = 0; i < polynomials.Length; i++)
            {
                string[] temp = polynomials[i].Split('^');
                if(temp.Length > 1)
                {
                    if(temp[0] == "x")
                    {
                        coefficients[Convert.ToInt32(temp[1]) - 1] = Convert.ToDouble(temp[0]);
                    }
                    coefficients[Convert.ToInt32(temp[1]) - 1] = Convert.ToDouble(temp[0]);
                }
                else
                {
                    coefficients[0] = Convert.ToDouble(temp[0]);
                }
            }

            Complex[] roots = GetRoots(coefficients);*/

/*            /*int iteration = 0;
        while(iteration < i)
        {
            Complex temp = Complex.Divide(F(x), FDerivative(x));
            x = Complex.Subtract(x, temp);

            for(int j = 0; j < roots.Length; j++)
            {
                Complex difference = Complex.Subtract(x, roots[j]);
                if (Math.Abs(difference.Real) < tolerance && Math.Abs(difference.Imaginary) < tolerance)
                {
                    if(colorRoots)
                    {
                        return colors[j];
                    }
                    else
                    {
                        int value = Convert.ToInt32(Convert.ToDouble(iteration) / Convert.ToDouble(i) * 255);
                        Color color = Color.FromArgb(value, value, value);
                        return color;
                    }

                }
            }
            iteration++;
        }
        return Color.Black;*/
