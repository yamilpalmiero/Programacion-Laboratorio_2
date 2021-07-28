using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public static class PacienteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PacienteDAO()
        {
            conexion = new SqlConnection(@"Data Source=.; Initial Catalog = Vacunatorio; Integrated Security = true;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }




        public static void Insertar(Paciente p)
        {
            try
            {
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO Pacientes(Nombre, Apellido, Turno) VALUES(@Nombre, @Apellido, @Turno)";
                comando.Parameters.AddWithValue("@Nombre", p.Nombre);
                comando.Parameters.AddWithValue("@Apellido", p.Apellido);
                comando.Parameters.AddWithValue("@Turno", p.Turno);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Error de SQL", ex);
            }
            finally
            {
                conexion.Close();
            }
        }




        public static Paciente Seleccionar()
        {
            try
            {
                Paciente paciente = null;
                comando.Connection = conexion;
                comando.CommandText = $"SELECT * FROM Pacientes WHERE turno = {paciente.Turno}";

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                if(oDr.Read() != false)
                {
                    paciente = new Paciente(Convert.ToInt32(oDr["Turno"]), oDr["Nombre"].ToString(), oDr["Apellido"].ToString());
                }

                return paciente;
            }

            catch (Exception ex)
            {
                throw new Exception("Error de SQL", ex);
            }
            finally
            {
                conexion.Close();
            }
        }




        public static List<Paciente> SeleccionarPacientes()
        {
            comando.CommandText = "SELECT Turno, Nombre, Apellido FROM Pacientes";

            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                List<Paciente> lista = new List<Paciente>();

                while (oDr.Read())
                {
                    int turno;
                    int.TryParse(oDr["Turno"].ToString(), out turno);
                    string nombre = oDr["Nombre"].ToString();
                    string apellido = oDr["Apellido"].ToString();

                    Paciente p = new Paciente(turno, nombre, apellido);
                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State != System.Data.ConnectionState.Closed)
                    conexion.Close();
            }
        }



    }
}
