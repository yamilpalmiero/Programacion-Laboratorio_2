using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace ModeloFacultad
{
    public partial class frmVista : Form
    {
        Curso curso = null;

        public frmVista()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            curso = new Curso((short)nudAnioCurso.Value, (Divisiones)cmbDivisionCurso.SelectedItem, new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, dtpFechaIngreso.Value));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (curso is null)
            {
                MessageBox.Show("No existe ningun curso", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rtbDatos.Text = (string)curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            curso += new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, (Divisiones)cmbDivision.SelectedItem);
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division; 
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
        }
    }
}
