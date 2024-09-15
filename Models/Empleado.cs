using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    internal class Empleado
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Inicial { get; set; }
        public string Apellido { get; set; }
        public int JobId { get; set; }
        public int JobLevel { get; set; }
        public int EditorialId { get; set; }
        public DateTime FechaContratacion { get; set; }

        public string NombreCompleto { get; set; }

        // Constructor vacío
        public Empleado() { }

        // Método para insertar un nuevo autor y retornar el registro insertado
        public static Empleado InsertarEmpleado(Empleado empleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO employee (emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date) VALUES (@IdEmpleado, @Nombre, @Inicial, @Apellido, @JobId, @JobLevel, @EditorialId, @FechaContratacion)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                        comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        comando.Parameters.AddWithValue("@Inicial", empleado.Inicial);
                        comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                        comando.Parameters.AddWithValue("@JobId", empleado.JobId);
                        comando.Parameters.AddWithValue("@JobLevel", empleado.JobLevel);
                        comando.Parameters.AddWithValue("@EditorialId", empleado.EditorialId);
                        comando.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Empleado
                                {
                                    IdEmpleado = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Inicial = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    JobId = Convert.ToInt32(lector["job_id"]), 
                                    JobLevel = Convert.ToInt32(lector["job_lvl"]),
                                    EditorialId = Convert.ToInt32(lector["pub_id"]),
                                    FechaContratacion = Convert.ToDateTime(lector["hire_date"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el empleado.");
            }
            return null;
        }

        // Método para actualizar un autor existente y retornar "OK"
        public static string ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE employee SET emp_id = @IdEmpleado, fname = @Nombre, minit = @Inicial, lname = @Apellido, job_id = @JobId, job_lvl = @JobLevel, pub_id = @EditorialId, hire_date = @FechaContratacion  WHERE emp_id = @IdEmpleado";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                        comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        comando.Parameters.AddWithValue("@Inicial", empleado.Inicial);
                        comando.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                        comando.Parameters.AddWithValue("@JobId", empleado.JobId);
                        comando.Parameters.AddWithValue("@JobLevel", empleado.JobLevel);
                        comando.Parameters.AddWithValue("@EditorialId", empleado.EditorialId);
                        comando.Parameters.AddWithValue("@FechaContratacion", empleado.FechaContratacion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar el empleado.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar el empleado.");
                return "Error";
            }
        }

        // Método para eliminar un autor y retornar "OK"
        public static string EliminarEmpleado(string idEmpleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM employee WHERE emp_id = @IdEmpleado";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar el empleado.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar el empleado.");
                return "Error";
            }
        }

        // Método para obtener un trabajo por ID
        public static Empleado ObtenerEmpleadoPorId(string idEmpleado)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee WHERE emp_id = @IdEmpleado";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Empleado
                                {
                                    IdEmpleado = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Inicial = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    JobId = Convert.ToInt32(lector["job_id"]),
                                    JobLevel = Convert.ToInt32(lector["job_lvl"]),
                                    EditorialId = Convert.ToInt32(lector["pub_id"]),
                                    FechaContratacion = Convert.ToDateTime(lector["hire_date"]),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener el empleado.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener el empleado.");
            }
            return null;
        }
        public static List<Empleado> ListEmpleados()
        {
            var empleados = new List<Empleado>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM employee";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                empleados.Add(new Empleado
                                {
                                    IdEmpleado = lector["emp_id"].ToString(),
                                    Nombre = lector["fname"].ToString(),
                                    Inicial = lector["minit"].ToString(),
                                    Apellido = lector["lname"].ToString(),
                                    JobId = Convert.ToInt32(lector["job_id"]),
                                    JobLevel = Convert.ToInt32(lector["job_lvl"]),
                                    EditorialId = Convert.ToInt32(lector["pub_id"]),
                                    FechaContratacion = Convert.ToDateTime(lector["hire_date"]),
                                    NombreCompleto = lector["fname"].ToString() + " " + lector["lname"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de empleados.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de empleados.");
            }

            return empleados;
        }
    }
}
