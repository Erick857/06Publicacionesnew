using _06Publicaciones.config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Publicaciones.Models
{
    internal class Venta
    {
        public string IdTienda { get; set; }
        public string NumeroOrden { get; set; }
        public DateTime FechaOrden { get; set; }
        public int Cantidad { get; set; }
        public string MetodoPago { get; set; }
        public string IdPublicacion { get; set; }

        public string NombreListar { get; set; }

        // Constructor vacío
        public Venta() { }

        // Método para insertar un nuevo autor y retornar el registro insertado
        public static Venta InsertarVenta(Venta venta)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "INSERT INTO sales (stor_id, ord_num, ord_date, qty, payterms, title_id) VALUES (@IdTienda, @NumeroOrden, @FechaOrden, @Cantidad, @MetodoPago, @IdPublicacion)";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdTienda", venta.IdTienda);
                        comando.Parameters.AddWithValue("@NumeroOrden", venta.NumeroOrden);
                        comando.Parameters.AddWithValue("@FechaOrden", venta.FechaOrden);
                        comando.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                        comando.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                        comando.Parameters.AddWithValue("@IdPublicacion", venta.IdPublicacion);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Venta
                                {
                                    IdTienda = lector["stor_id"].ToString(),
                                    NumeroOrden = lector["ord_num"].ToString(),
                                    FechaOrden = Convert.ToDateTime(lector["ord_date"]),
                                    Cantidad = Convert.ToInt32(lector["qty"]),
                                    MetodoPago = lector["payterms"].ToString(),
                                    IdPublicacion = lector["title_id"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al insertar la venta.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar la venta.");
            }
            return null;
        }

        // Método para actualizar un autor existente y retornar "OK"
        public static string ActualizarVenta(Venta venta)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "UPDATE sales SET stor_id = @IdTienda, ord_num = @NumeroOrden, ord_date = @FechaOrden, qty = @Cantidad, payterms = @MetodoPago, title_id = @IdPublicacion  WHERE ord_num = @NumeroOrden";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        //sql inyection
                        comando.Parameters.AddWithValue("@IdTienda", venta.IdTienda);
                        comando.Parameters.AddWithValue("@NumeroOrden", venta.NumeroOrden);
                        comando.Parameters.AddWithValue("@FechaOrden", venta.FechaOrden);
                        comando.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                        comando.Parameters.AddWithValue("@MetodoPago", venta.MetodoPago);
                        comando.Parameters.AddWithValue("@IdPublicacion", venta.IdPublicacion);

                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al actualizar la venta.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al actualizar la venta.");
                return "Error";
            }
        }

        // Método para eliminar un autor y retornar "OK"
        public static string EliminarVenta(string numeroOrden)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "DELETE FROM sales WHERE ord_num = @NumeroOrden";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NumeroOrden", numeroOrden);
                        comando.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al eliminar la venta.");
                return "Error SQL";
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al eliminar la venta.");
                return "Error";
            }
        }

        // Método para obtener un trabajo por ID
        public static Venta ObtenerVentaPorId(string numeroOrden)
        {
            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = "SELECT * FROM sales WHERE ord_num = @NumeroOrden";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@NumeroOrden", numeroOrden);

                        using (var lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                return new Venta
                                {
                                    IdTienda = lector["stor_id"].ToString(),
                                    NumeroOrden = lector["ord_num"].ToString(),
                                    FechaOrden = Convert.ToDateTime(lector["ord_date"]),
                                    Cantidad = Convert.ToInt32(lector["qty"]),
                                    MetodoPago = lector["payterms"].ToString(),
                                    IdPublicacion = lector["title_id"].ToString(),
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la venta");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la venta");
            }
            return null;
        }
        public static List<Venta> ListVentas()
        {
            var ventas = new List<Venta>();

            try
            {
                using (var conexion = Conexion.GetConnection())
                {
                    var consulta = @"
                    SELECT s.stor_id, s.ord_num, s.ord_date, s.qty, s.payterms, s.title_id, t.title
                    FROM sales s
                    JOIN titles t ON s.title_id = t.title_id";

                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        using (var lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                ventas.Add(new Venta
                                {
                                    IdTienda = lector["stor_id"].ToString(),
                                    NumeroOrden = lector["ord_num"].ToString(),
                                    FechaOrden = Convert.ToDateTime(lector["ord_date"]),
                                    Cantidad = Convert.ToInt32(lector["qty"]),
                                    MetodoPago = lector["payterms"].ToString(),
                                    IdPublicacion = lector["title_id"].ToString(),
                                    NombreListar = $"{lector["ord_num"]} - {lector["title"]}",
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ErrorHandler.ManejarErrorSql(ex, "Error al obtener la lista de ventas.");
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "Error al obtener la lista de ventas.");
            }
            return ventas;
        }
    }
}
