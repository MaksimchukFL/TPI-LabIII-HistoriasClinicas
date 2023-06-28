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
    public partial class FormPacientes : Form
    {
        
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dataSet1.Pacientes);

        }

        private void FormPacientes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dataSet1.Pacientes);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dataSet1.Pacientes);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dataSet1.Pacientes);

        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void pacientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pacientesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void pacientesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingreso de datos inválidos. \nPosibles motivos del error:\n1-Formato inválido de ingreso de datos\n2-El paciente listado no existe.");
        }
    }
}
