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
    public partial class FormHistoriasClinicas : Form
    {
        public FormHistoriasClinicas()
        {
            InitializeComponent();
        }

        private void historiasClinicasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historiasClinicasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormHistoriasClinicas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.HistoriasClinicas' Puede moverla o quitarla según sea necesario.
            this.historiasClinicasTableAdapter.Fill(this.dataSet1.HistoriasClinicas);

        }
    }
}
