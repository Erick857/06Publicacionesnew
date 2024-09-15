using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    internal class Editorial
    {
        public string IdEditorial { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        // Constructor vacío
        public Editorial() { }

        // Método para insertar un nuevo autor y retornar el registro insertado
        public static Editorial InsertarEditorial(Editorial editorial)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO publishers (pub_id, pub_name, city, state, country) VALUES (@IdEditorial, @Nombre, @Ciudad, @Estado, @Pais)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEditorial", editorial.IdEditorial);
                        comando.Parameters.AddWithValue("@Nombre", editorial.Nombre);
                        comando.Parameters.AddWithValue("@Ciudad", editorial.Ciudad);
                        comando.Parameters.AddWithValue("@Estado", editorial.Estado);
                        comando.Parameters.AddWithValue("@Pais", editorial.Pais);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Editorial
                                {
                                    IdEditorial = lector["pub_id"].ToString(),
                                    Nombre = lector["pub_name"].ToString(),
                                    Ciudad = lector["city"].ToString(),
                                    Estado = lector["state"].ToString(),
                                    Pais = lector["country"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la editorial.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la editorial.");
            }
            return null;
        }

        // Método para actualizar un autor existente y retornar "OK"
        public static string ActualizarEditorial(Editorial editorial)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE publishers SET pub_id = @IdEditorial, pub_name = @Nombre, city = @Ciudad, state = @Estado, country = @Pais  WHERE pub_id = @IdEditorial";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.AddWithValue("@IdEditorial", editorial.IdEditorial);
                        comando.Parameters.AddWithValue("@Nombre", editorial.Nombre);
                        comando.Parameters.AddWithValue("@Ciudad", editorial.Ciudad);
                        comando.Parameters.AddWithValue("@Estado", editorial.Estado);
                        comando.Parameters.AddWithValue("@Pais", editorial.Pais);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la editorial.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la editorial.");
                return "Error";
            }
        }

        // Método para eliminar un autor y retornar "OK"
        public static string EliminarEditorial(string idEditorial)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM publishers WHERE pub_id = @IdEditorial";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEditorial", idEditorial);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la editorial.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la editorial.");
                return "Error";
            }
        }

        // Método para obtener un trabajo por ID
        public static Editorial ObtenerEditorialPorId(string idEditorial)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM publishers WHERE pub_id = @IdEditorial";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEditorial", idEditorial);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Editorial
                                {
                                    IdEditorial = lector["pub_id"].ToString(),
                                    Nombre = lector["pub_name"].ToString(),
                                    Ciudad = lector["city"].ToString(),
                                    Estado = lector["state"].ToString(),
                                    Pais = lector["country"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la editorial");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la editorial");
            }
            return null;
        }
        public static List<Editorial> ListEditoriales()
        {
            var editoriales = new List<Editorial>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM publishers";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                editoriales.Add(new Editorial
                                {
                                    IdEditorial = lector["pub_id"].ToString(),
                                    Nombre = lector["pub_name"].ToString(),
                                    Ciudad = lector["city"].ToString(),
                                    Estado = lector["state"].ToString(),
                                    Pais = lector["country"].ToString(),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de editoriales.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de editoriales.");
            }
            return editoriales;
        }
    }
}
