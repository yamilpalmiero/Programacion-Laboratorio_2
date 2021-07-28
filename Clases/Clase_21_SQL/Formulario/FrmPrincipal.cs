using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Formulario
{
    public partial class FrmPrincipal : Form
    {
        SqlConnection conexion;
        SqlCommand comando = new SqlCommand();

        public FrmPrincipal()
        {
            conexion = new SqlConnection("Data Source = localhost; Database = Medicamentos; Trusted_Connection = True;");
            InitializeComponent();
        }
    }
}
