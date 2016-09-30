using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hola_mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido";
            button1.Text = "Comenzar";
            label1.ForeColor = Color.Fuchsia;
            label1.Text = label1.Text.ToUpper();
            label1.Text = Form1.DefaultBackColor.ToArgb().ToString();
            // comentario.
        }

    }
}
