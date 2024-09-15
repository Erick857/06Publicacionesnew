using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace _06Publicaciones.Models
{
    internal class Trabajo
    {
        public string IdTrabajo { get; set; }
        public string Descripcion { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }

        // Constructor vacío
        public Trabajo() { }

        // Método para insertar un nuevo autor y retornar el registro insertado
        public static Trabajo InsertarTrabajo(Trabajo trabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO jobs (job_desc, min_lvl, max_lvl) VALUES (@Descripcion, @MinLevel, @MaxLevel)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Descripcion", trabajo.Descripcion);
                        comando.Parameters.AddWithValue("@MinLevel", trabajo.MinLevel);
                        comando.Parameters.AddWithValue("@MaxLevel", trabajo.MaxLevel);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Trabajo
                                {
                                    Descripcion = lector["job_desc"].ToString(),
                                    MinLevel = Convert.ToInt32(lector["min_lvl"]),
                                    MaxLevel = Convert.ToInt32(lector["max_lvl"]),                              
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el trabajo.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el trabajo.");
            }
            return null;
        }

        // Método para actualizar un autor existente y retornar "OK"
        public static string ActualizarTrabajo(Trabajo trabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE jobs SET job_desc = @Descripcion, min_lvl = @MinLevel, max_lvl = @MaxLevel WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.Clear();                     
                        comando.Parameters.AddWithValue("@Descripcion", trabajo.Descripcion);
                        comando.Parameters.AddWithValue("@MinLevel", trabajo.MinLevel);
                        comando.Parameters.AddWithValue("@MaxLevel", trabajo.MaxLevel);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el trabajo.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el trabajo.");
                return "Error";
            }
        }

        // Método para eliminar un autor y retornar "OK"
        public static string EliminarTrabajo(string idTrabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", idTrabajo);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el trabajo.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el trabajo.");
                return "Error";
            }
        }

        // Método para obtener un trabajo por ID
        public static Trabajo ObtenerTrabajoPorId(string idTrabajo)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs WHERE job_id = @IdTrabajo";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTrabajo", idTrabajo);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Trabajo
                                {
                                    IdTrabajo = lector["job_id"].ToString(),
                                    Descripcion = lector["job_desc"].ToString(),
                                    MinLevel = Convert.ToInt32(lector["min_lvl"]),
                                    MaxLevel = Convert.ToInt32(lector["max_lvl"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el trabajo.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el trabajo.");
            }
            return null;
        }
        public static List<Trabajo> ListTrabajos()
        {
            var trabajos = new List<Trabajo>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM jobs";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                trabajos.Add(new Trabajo
                                {
                                    IdTrabajo = lector["job_id"].ToString(),
                                    Descripcion = lector["job_desc"].ToString(),
                                    MinLevel = Convert.ToInt32(lector["min_lvl"]),
                                    MaxLevel = Convert.ToInt32(lector["max_lvl"]),
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de trabajos.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de trabajos.");
            }

            return trabajos;
        }
    }
}
