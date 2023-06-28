using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabIIITPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPacientes fp=new FormPacientes();
            fp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCitas fc=new FormCitas();
            fc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHistoriasClinicas fh=new FormHistoriasClinicas();
            fh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormInforme fi=new FormInforme();
            fi.Show();
        }
    }
}
