using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    internal class Publicacion
    {
        public string IdPublicacion { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int? IdEditorial { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Avance { get; set; }
        public int? Regalias { get; set; }
        public int? VentasAnuales { get; set; }
        public string Notas { get; set; }
        public DateTime FechaPublicacion { get; set; }

        // Constructor vacío
        public Publicacion() { }

        // Método para insertar un nuevo autor y retornar el registro insertado
        public static Publicacion InsertarPublicacion(Publicacion publicacion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO titles (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate)" +
                        "VALUES (@IdPublicacion, @Titulo, @Genero, @IdEditorial, @Precio, @Avance, @Regalias, @VentasAnuales, @Notas, @FechaPublicacion)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdPublicacion", publicacion.IdPublicacion);
                        comando.Parameters.AddWithValue("@Titulo", publicacion.Titulo);
                        comando.Parameters.AddWithValue("@Genero", publicacion.Genero);
                        comando.Parameters.AddWithValue("@IdEditorial", publicacion.IdEditorial);
                        comando.Parameters.AddWithValue("@Precio", publicacion.Precio);
                        comando.Parameters.AddWithValue("@Avance", publicacion.Avance);
                        comando.Parameters.AddWithValue("@Regalias", publicacion.Regalias);
                        comando.Parameters.AddWithValue("@VentasAnuales", publicacion.VentasAnuales);
                        comando.Parameters.AddWithValue("@Notas", publicacion.Notas);
                        comando.Parameters.AddWithValue("@FechaPublicacion", publicacion.FechaPublicacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Publicacion
                                {
                                    IdPublicacion = lector["title_id"].ToString(),
                                    Titulo = lector["title"].ToString(),
                                    Genero = lector["type"].ToString(),
                                    IdEditorial = lector["pub_id"] != DBNull.Value ? Convert.ToInt32(lector["pub_id"]) : (int?)null,
                                    Precio = lector["price"] != DBNull.Value ? Convert.ToDecimal(lector["price"]) : (decimal?)null,
                                    Avance = lector["advance"] != DBNull.Value ? Convert.ToDecimal(lector["advance"]) : (decimal?)null,
                                    Regalias = lector["royalty"] != DBNull.Value ? Convert.ToInt32(lector["royalty"]) : (int?)null,
                                    VentasAnuales = lector["ytd_sales"] != DBNull.Value ? Convert.ToInt32(lector["ytd_sales"]) : (int?)null,
                                    Notas = lector["notes"] != DBNull.Value ? lector["notes"].ToString() : null,
                                    FechaPublicacion = Convert.ToDateTime(lector["pubdate"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la publicacion.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la publicacion.");
            }
            return null;
        }

        // Método para actualizar un autor existente y retornar "OK"
        public static string ActualizarPublicacion(Publicacion publicacion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE titles SET title_id = @IdPublicacion, title = @Titulo, type = @Genero, pub_id = @EditorialId, price = @Precio, advance = @Avance, royalty = @Regalias, ytd_sales = @VentasAnuales, notes = @Notas, pubdate = @FechaPublicacion WHERE title_id = @IdPublicacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.AddWithValue("@IdPublicacion", publicacion.IdPublicacion);
                        comando.Parameters.AddWithValue("@Titulo", publicacion.Titulo);
                        comando.Parameters.AddWithValue("@Genero", publicacion.Genero);
                        comando.Parameters.AddWithValue("@IdEditorial", publicacion.IdEditorial);
                        comando.Parameters.AddWithValue("@Precio", publicacion.Precio);
                        comando.Parameters.AddWithValue("@Avance", publicacion.Avance);
                        comando.Parameters.AddWithValue("@Regalias", publicacion.Regalias);
                        comando.Parameters.AddWithValue("@VentasAnuales", publicacion.VentasAnuales);
                        comando.Parameters.AddWithValue("@Notas", publicacion.Notas);
                        comando.Parameters.AddWithValue("@FechaPublicacion", publicacion.FechaPublicacion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la publicacion.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la publicacion.");
                return "Error";
            }
        }

        // Método para eliminar un autor y retornar "OK"
        public static string EliminarPublicacion(string idPublicacion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM titles WHERE title_id = @IdPublicacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdPublicacion", idPublicacion);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la publicacion.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la publicacion.");
                return "Error";
            }
        }

        // Método para obtener un trabajo por ID
        public static Publicacion ObtenerPublicacionPorId(string idPublicacion)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM titles WHERE title_id = @IdPublicacion";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdPublicacion", idPublicacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Publicacion
                                {
                                    IdPublicacion = lector["title_id"].ToString(),
                                    Titulo = lector["title"].ToString(),
                                    Genero = lector["type"].ToString(),
                                    IdEditorial = lector["pub_id"] != DBNull.Value ? Convert.ToInt32(lector["pub_id"]) : (int?)null,
                                    Precio = lector["price"] != DBNull.Value ? Convert.ToDecimal(lector["price"]) : (decimal?)null,
                                    Avance = lector["advance"] != DBNull.Value ? Convert.ToDecimal(lector["advance"]) : (decimal?)null,
                                    Regalias = lector["royalty"] != DBNull.Value ? Convert.ToInt32(lector["royalty"]) : (int?)null,
                                    VentasAnuales = lector["ytd_sales"] != DBNull.Value ? Convert.ToInt32(lector["ytd_sales"]) : (int?)null,
                                    Notas = lector["notes"] != DBNull.Value ? lector["notes"].ToString() : null,
                                    FechaPublicacion = Convert.ToDateTime(lector["pubdate"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la publicacion");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la publicacion");
            }
            return null;
        }
        public static List<Publicacion> ListPublicaciones()
        {
            var publicaciones = new List<Publicacion>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM titles";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                publicaciones.Add(new Publicacion
                                {
                                    IdPublicacion = lector["title_id"].ToString(),
                                    Titulo = lector["title"].ToString(),
                                    Genero = lector["type"].ToString(),
                                    IdEditorial = lector["pub_id"] != DBNull.Value ? Convert.ToInt32(lector["pub_id"]) : (int?)null,
                                    Precio = lector["price"] != DBNull.Value ? Convert.ToDecimal(lector["price"]) : (decimal?)null,
                                    Avance = lector["advance"] != DBNull.Value ? Convert.ToDecimal(lector["advance"]) : (decimal?)null,
                                    Regalias = lector["royalty"] != DBNull.Value ? Convert.ToInt32(lector["royalty"]) : (int?)null,
                                    VentasAnuales = lector["ytd_sales"] != DBNull.Value ? Convert.ToInt32(lector["ytd_sales"]) : (int?)null,
                                    Notas = lector["notes"] != DBNull.Value ? lector["notes"].ToString() : null,
                                    FechaPublicacion = Convert.ToDateTime(lector["pubdate"]),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de publicaciones.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de publicaciones.");
            }
            return publicaciones;
        }
    }
}
