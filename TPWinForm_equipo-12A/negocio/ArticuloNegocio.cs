using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion," +
                    "  A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, Precio" +
                    " FROM ARTICULOS A, MARCAS M, CATEGORIAS C" +
                    " WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void agregar(Articulo ArticuloNuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                     "VALUES ('" + ArticuloNuevo.Codigo + "', '" + ArticuloNuevo.Nombre + "', '" + ArticuloNuevo.Descripcion + "', " +
                     ArticuloNuevo.Marca.Id + ", " + ArticuloNuevo.Categoria.Id + ", " + ArticuloNuevo.Precio + ")");

                datos.setearParametro("@Codigo", ArticuloNuevo.Codigo);
                datos.setearParametro("@Nombre", ArticuloNuevo.Nombre);
                datos.setearParametro("@Descripcion", ArticuloNuevo.Descripcion);
                datos.setearParametro("@IdMarca", ArticuloNuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", ArticuloNuevo.Categoria.Id);
                datos.setearParametro("@Precio", ArticuloNuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }




        public void modificar(Articulo Articulomodificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET " + "Codigo = @codigo, " + "Nombre = @nombre, " + "Descripcion = @descripcion, " + "IdMarca = @idMarca, " + "IdCategoria = @idCategoria, " + "Precio = @precio " + "WHERE Id = @id");

                datos.setearParametro("@Codigo", Articulomodificado.Codigo);
                datos.setearParametro("@Nombre", Articulomodificado.Nombre);
                datos.setearParametro("@Descripcion", Articulomodificado.Descripcion);
                datos.setearParametro("@IdMarca", Articulomodificado.Marca.Id);
                datos.setearParametro("@IdCategoria", Articulomodificado.Categoria.Id);
                datos.setearParametro("@Precio", Articulomodificado.Precio);
                datos.setearParametro("@id", Articulomodificado.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
