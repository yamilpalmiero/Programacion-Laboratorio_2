using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Entidades
{
    //DELEGADO
    public delegate void FinDeSalida(int bomberoIndex);

    [Serializable]
    public class Bombero : IArchivos<string>, IArchivos<Bombero>
    {
        private string nombre;
        private List<Salidas> salidas;
        //EVENTO
        public event FinDeSalida MarcarFin;



        public Bombero(string nombre)
        {
            this.nombre = nombre;
            this.salidas = new List<Salidas>();
        }





        //IMPLICITOS para BINARIO
        public void Guardar(Bombero info)//Implementacion IMPLICITA de Guardar para serializar a binario
        {
            try
            {
                string ruta = Environment.CurrentDirectory + "\\Bombero.bin";
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream stream = new FileStream(ruta, FileMode.Create))//Puede ser FileMode.Append
                {
                    formatter.Serialize(stream, info);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar a binario.", ex);
            }
        }

        public Bombero Leer()//Implementacion IMPLICITA de Leer para deserializar a binario
        {
            try
            {
                string ruta = Environment.CurrentDirectory + "\\Bombero.bin";
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream stream = new FileStream(ruta, FileMode.Open))
                {
                    return (Bombero)formatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar.", ex);
            }
        }


        //EXPLICITOS para la BD
        void IArchivos<string>.Guardar(string info)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(@"Data Source=.; Initial Catalog=20201119-sp; Integrated Security=true;");

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                if (!(String.IsNullOrWhiteSpace(info)))
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "INSERT INTO log(entrada, alumno) VALUES(@Entrada, @Alumno)";
                    comando.Parameters.AddWithValue("@Entrada", info);
                    comando.Parameters.AddWithValue("@Alumno", "Yamil Palmiero");
                }

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            catch (Exception ex)
            {
                throw new Exception("Error de SQL al guardar los datos.", ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        string IArchivos<string>.Leer()
        {
            string retorno = string.Empty;

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(@"Data Source=.; Initial Catalog=20201119-sp; Integrated Security=true;");

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = $"SELECT * FROM log";

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            SqlDataReader oDr = comando.ExecuteReader();

            if (oDr.Read() != false)
            {
                retorno = oDr["Entrada"].ToString() + "-" + oDr["Alumno"].ToString();
            }

            return retorno;
        }






        public void AtenderSalida(object bomberoIndex)
        {
            Salidas salida = new Salidas();

            salidas.Add(salida);//Agregara una nueva salida a la lista del Bombero

            Thread.Sleep(3000);//Agregar un sleep de entre 2 y 4 segundos (en este aso agrego 3 seg)

            salidas[salidas.Count - 1].FinalizarSalida();//Finalizo una salida de la lista

            string mensaje = $"{this.nombre} - {this.salidas[salidas.Count - 1].ToString()}";
            //this.Guardar(mensaje);
            MarcarFin((int)bomberoIndex);//Avisar mediante el evento MarcarFin que se termino la salida. Usar el index para saber que bombero fue
        }
    }
}
