using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL_Prueba_2
{
    internal class DiscoServer
    {
        public List<Disco> ListaDisco()
        {
            List<Disco> lista = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database= DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select D.Titulo, D.CantidadCanciones, D.UrlImagenTapa as Portada, E.Descripcion as Estilo, T.Descripcion as TipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION T\r\nwhere D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.Estilo = (string)lector["Estilo"];
                    aux.TipoEdicion = (string)lector["TipoEdicion"];
                    aux.UrlImagenTapa = (string)lector["Portada"];

                    lista.Add(aux);


                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
