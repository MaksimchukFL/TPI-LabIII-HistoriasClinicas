using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LabIIITPI.DataSet1TableAdapters;

namespace LabIIITPI
{
    public partial class FormInforme : Form
    {
        private DataSet1 dataSet1;
        public FormInforme()
        {
            InitializeComponent();
            dataSet1 = new DataSet1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string path = textBox1.Text + "InformePaciente.pdf";
            PacientesTableAdapter pacientesTableAdapter= new PacientesTableAdapter();
            CitasTableAdapter citasTableAdapter= new CitasTableAdapter();
            HistoriasClinicasTableAdapter historiasClinicasTableAdapter=new HistoriasClinicasTableAdapter();

            DataSet1.PacientesDataTable pacientesDataTable = pacientesTableAdapter.GetDataByDNI(int.Parse(textBox1.Text));
            DataSet1.CitasDataTable citasDataTable = citasTableAdapter.GetDataByDNI(int.Parse(textBox1.Text));
            DataSet1.HistoriasClinicasDataTable historiasclinicasDataTable = historiasClinicasTableAdapter.GetDataByDNI(int.Parse(textBox1.Text));


            Document informePaciente = new Document();


            if (pacientesDataTable.Rows.Count > 0)
            {
                //Creando el PDF con el informe
                DataSet1.PacientesRow filaPaciente = pacientesDataTable.Rows[0] as DataSet1.PacientesRow;
                DataSet1.CitasRow filaCita = citasDataTable.Rows[0] as DataSet1.CitasRow;
                DataSet1.HistoriasClinicasRow filaHistoriasClinicas=historiasclinicasDataTable.Rows[0] as DataSet1.HistoriasClinicasRow;

                PdfWriter writer = PdfWriter.GetInstance(informePaciente, new FileStream(path, FileMode.Create));
                informePaciente.Open();
                //Agregando la info al PDF
                informePaciente.Add(new Paragraph("DNI del paciente: " + filaPaciente.DNI.ToString()));
                informePaciente.Add(new Paragraph("Nombre y apellido del paciente: " + filaPaciente.NombreyApellido));
                informePaciente.Add(new Paragraph("Fecha de nacimiento del paciente: " + filaPaciente.Nacimiento.ToString()));
                informePaciente.Add(new Paragraph("Genero: " + filaPaciente.Genero));
                informePaciente.Add(new Paragraph("Direccion: " + filaPaciente.Direccion));
                informePaciente.Add(new Paragraph("Telefono: " + filaPaciente.Telefono));
                informePaciente.Add(new Paragraph("//////////CITAS//////////"));
                foreach (DataSet1.CitasRow citaRow in citasDataTable.Rows)
                {
                    informePaciente.Add(new Paragraph("ID de la cita: " + citaRow.IDCita.ToString()));
                    informePaciente.Add(new Paragraph("Fecha y hora de la cita: " + citaRow.FechayHora.ToString()));
                    informePaciente.Add(new Paragraph("Motivo de la cita: " + citaRow.Motivo));
                }
                informePaciente.Add(new Paragraph("//////////HISTORIA CLINICA//////////"));
                foreach (DataSet1.HistoriasClinicasRow historiaclinicaRow in historiasclinicasDataTable.Rows)
                {
                    informePaciente.Add(new Paragraph("ID de la historia clinica: " + historiaclinicaRow.IDHistoriaClinica.ToString()));
                    informePaciente.Add(new Paragraph("Fecha y hora de la consulta: " + historiaclinicaRow.FechaConsulta.ToString()));
                    informePaciente.Add(new Paragraph("Motivo de la consulta: " + historiaclinicaRow.MotivoConsulta));
                    informePaciente.Add(new Paragraph("Detalles de la visita: " + historiaclinicaRow.DetallesVisita));
                    informePaciente.Add(new Paragraph("Estudios realizados: " + historiaclinicaRow.EstudiosRealizados));
                    informePaciente.Add(new Paragraph("Medicacion recetada: " + historiaclinicaRow.Medicacion));
                }


                informePaciente.Close();
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                MessageBox.Show("Paciente no encontrado!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
