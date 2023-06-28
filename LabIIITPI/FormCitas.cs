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
    public partial class FormCitas : Form
    {
        public FormCitas()
        {
            InitializeComponent();
        }

        private void citasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.citasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Citas' Puede moverla o quitarla según sea necesario.
            this.citasTableAdapter.Fill(this.dataSet1.Citas);

        }
    }
}
