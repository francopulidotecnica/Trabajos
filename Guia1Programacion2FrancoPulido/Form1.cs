using Guia1Programacion2FrancoPulido.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1Programacion2FrancoPulido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = textBox1.Text;
            int modelo = Convert.ToInt32(numericUpDown1.Value);
            int añoACalcular = Convert.ToInt32(numericUpDown2.Value);
            double valorFabrica = Convert.ToDouble(textBox4.Text);
            int vidaUtil = Convert.ToInt32(textBox5.Text);
            double tasaDepreciacion = Convert.ToDouble(textBox4.Text);

            Moto moto = new Moto(marca, modelo, valorFabrica);


            FormVer fVer = new FormVer();

            fVer.listBox1.Items.Add(moto.VerDescripcion());

            double valorLineal = moto.CalcularDepreciacionLineal(añoACalcular, vidaUtil);
            fVer.listBox1.Items.Add($"Depreciación lineal: ${valorLineal,10:f2}");

            double valorAnual = moto.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion);
            fVer.listBox1.Items.Add($"Depreciación anual: ${valorAnual,10:f2}");

            fVer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
} 
