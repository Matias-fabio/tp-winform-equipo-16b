using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormApp
{
    internal class ComercioArticulo
    {
        public List<Articulo> articuloListar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security= true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT a.Codigo, a.Nombre, a.Descripcion, a.Precio, i.ImagenUrl AS imagen FROM ARTICULOS a LEFT JOIN IMAGENES i ON a.Id = i.IdArticulo;";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.ImagenUrl =lector["imagen"].ToString();
                    //Falta Agregar Marca y Categoria
                    listaArticulos.Add(aux);
                }
                conexion.Close();
                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            
            }
    
        }
    }
}
