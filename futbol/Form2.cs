using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace futbol
{
    public partial class Form2 : Form
    {
        int elma;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            
            elma = frm.armut;
            label1.Text = elma.ToString();
        }
    }
}
