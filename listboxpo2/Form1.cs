using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listboxpo2
{
    public partial class Form1 : Form
    {
        List<string> animais = new List<string>();
        public Form1()
        {
            InitializeComponent();
            animais.Add("zebra");
            animais.Add("camelo");
            animais.Add("arara");
            lb_Animais.DataSource = animais;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            animais.Clear();
            lb_Animais.DataSource = null;
            lb_Animais.DataSource = animais;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite um animal!");
            }

            else
            {
                animais.Add(textBox1.Text);
                textBox1.Clear();
                lb_Animais.DataSource = null;
                lb_Animais.DataSource = animais;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exitem dois métodos, são eles:

            /*1º método
             remove o item da posição selecionada
            */
            animais.RemoveAt(lb_Animais.SelectedIndex);
            lb_Animais.DataSource = null;
           lb_Animais.DataSource = animais;
            

            /* 2° método 
            remove a partir do texto escrito
            
            animais.Remove(textBox1.Text);
            textBox1.Clear();
            lb_Animais.DataSource = null;
            lb_Animais.DataSource = animais;
            */ 
            
        }
    }
}
