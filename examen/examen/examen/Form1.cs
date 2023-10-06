using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i > 0; i--) {
                if (listBox1.Items[i].ToString().Length <= 5)
                {
                    listBox1.Items.RemoveAt(i);
                }
            
            }
            for (int i = listBox2.Items.Count - 1; i > 0; i--)
            {
                if (listBox2.Items[i].ToString().Length <= 5)
                {
                    listBox2.Items.RemoveAt(i);
                }

            }
        }

        private void listBox1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          string primeroizquieda = listBox1.Items[0].ToString();
            var ultimoizquierda = listBox1.Items[listBox1.Items.Count - 1].ToString();
            var primeroderecha = listBox2.Items[0].ToString();
           string ultimoderecha = listBox2.Items[listBox2.Items.Count - 1].ToString();
            listBox1.Items.Insert(0, primeroderecha);
            listBox1.Items.Insert(listBox1.Items.Count - 1, ultimoderecha);
            listBox1.Items.Remove(ultimoizquierda);
            listBox1.Items.Remove(primeroizquieda);
            listBox2.Items.Insert(0,primeroizquieda);
            listBox2.Items.Insert(listBox2.Items.Count - 1, ultimoizquierda);
            listBox2.Items.Remove(ultimoderecha);
            listBox2.Items.Remove(primeroderecha);
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string>izquierda=new List<string>();
            List<string> derecha = new List<string>();
            var cantidad = listBox2.Items.Count - 1;
            var cantidad1 = listBox1.Items.Count - 1;

            for (int i =cantidad1; i > 0; i--)
            {
                if (listBox1.Items[i].ToString().Length <= 5)
                {
                    izquierda.Add(listBox1.Items[i].ToString());
                    listBox1.Items.RemoveAt(i);
                }

            }
            for (int i =cantidad; i > 0; i--)
            {
                if (listBox2.Items[i].ToString().Length <= 5)
                {
                    derecha.Add(listBox2.Items[i].ToString());
                    listBox2.Items.RemoveAt(i);
                }

            }
            foreach (var item in izquierda)
            {
                listBox2.Items.Add(item);
            }
            foreach (var item in derecha)
            {
                listBox1.Items.Add(item);
            }


        }
    }
}
