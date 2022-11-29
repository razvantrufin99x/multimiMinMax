using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimiMinMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<float> lista = new List<float>();
        public void loadFloatInLista(float f)
        { 
            lista.Add(f);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadFloatInLista(float.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float min = new float();
            float max = new float();

            for (int i = 0; i < lista.Count; i++)
            {
                if (min > lista[i]) { min = lista[i]; }
                if (max < lista[i]) { max = lista[i]; }
            }
            textBox1.Text += "max= " + max.ToString() + " , min= " + min.ToString();
        }
    }
}
