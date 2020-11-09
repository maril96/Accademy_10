using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.TestDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyClass mc = new MyClass(this.button2);
            //creo un'istanza di MyClass passandogli un bottone della form.
            //così facendo ho due Delegate nella lista di Delegate che è l'evento "button2.Click",
            //uno è quello che si crea istanziando MyClass, e l'altro è stato creato nel Designer della Form
            //l'ordine è dato (in genere) da quello con cui i vari sottoscrittori si inseriscono nella lista.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text;
        }
    }
}
