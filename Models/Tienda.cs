using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    internal class Tienda
    {
        public string IdTienda { get; set; }
        public string NombreTienda { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }

        // Constructor vacío
        public Tienda() { }

        // Método para insertar un nuevo autor y retornar el registro insertado
        public static Tienda InsertarTienda(Tienda tienda)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO stores (stor_id, stor_name, stor_address, city, state, zip) VALUES (@IdTienda, @NombreTienda, @Direccion, @Ciudad, @Estado, @CodigoPostal)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTienda", tienda.IdTienda);
                        comando.Parameters.AddWithValue("@NombreTienda", tienda.NombreTienda);
                        comando.Parameters.AddWithValue("@Direccion", tienda.Direccion);
                        comando.Parameters.AddWithValue("@Ciudad", tienda.Ciudad);
                        comando.Parameters.AddWithValue("@Estado", tienda.Estado);
                        comando.Parameters.AddWithValue("@CodigoPostal", tienda.CodigoPostal);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Tienda
                                {
                                    IdTienda = lector["stor_id"].ToString(),
                                    NombreTienda = lector["stor_name"].ToString(),
                                    Direccion = (lector["stor_address"]).ToString(),
                                    Ciudad = (lector["city"]).ToString(),
                                    Estado = (lector["state"]).ToString(),
                                    CodigoPostal = (lector["zip"]).ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la tienda.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la tienda.");
            }
            return null;
        }

        // Método para actualizar un autor existente y retornar "OK"
        public static string ActualizarTienda(Tienda tienda)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE stores SET stor_id = @IdTienda, stor_name = @NombreTienda, stor_address = @Direccion, city = @Ciudad, state = @Estado, zip = @CodigoPostal  WHERE stor_id = @IdTienda";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@IdTienda", tienda.IdTienda);
                        comando.Parameters.AddWithValue("@NombreTienda", tienda.NombreTienda);
                        comando.Parameters.AddWithValue("@Direccion", tienda.Direccion);
                        comando.Parameters.AddWithValue("@Ciudad", tienda.Ciudad);
                        comando.Parameters.AddWithValue("@Estado", tienda.Estado);
                        comando.Parameters.AddWithValue("@CodigoPostal", tienda.CodigoPostal);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la tienda.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la tienda.");
                return "Error";
            }
        }

        // Método para eliminar un autor y retornar "OK"
        public static string EliminarTienda(string idTienda)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM stores WHERE stor_id = @IdTienda";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTienda", idTienda);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la tienda.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la tienda.");
                return "Error";
            }
        }

        // Método para obtener un trabajo por ID
        public static Tienda ObtenerTiendaPorId(string idTienda)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM stores WHERE stor_id = @IdTienda";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idTienda", idTienda);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Tienda
                                {
                                    IdTienda = lector["stor_id"].ToString(),
                                    NombreTienda = lector["stor_name"].ToString(),
                                    Direccion = (lector["stor_address"]).ToString(),
                                    Ciudad = (lector["city"]).ToString(),
                                    Estado = (lector["state"]).ToString(),
                                    CodigoPostal = (lector["zip"]).ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la tienda.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la tienda.");
            }
            return null;
        }
        public static List<Tienda> ListTiendas()
        {
            var tiendas = new List<Tienda>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM stores";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                tiendas.Add(new Tienda
                                {
                                    IdTienda = lector["stor_id"].ToString(),
                                    NombreTienda = lector["stor_name"].ToString(),
                                    Direccion = (lector["stor_address"]).ToString(),
                                    Ciudad = (lector["city"]).ToString(),
                                    Estado = (lector["state"]).ToString(),
                                    CodigoPostal = (lector["zip"]).ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de tiendas.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de tiendas.");
            }

            return tiendas;
        }
    }
}
