using System;
using System.Data.SqlClient;

namespace _06Publicaciones.config
{
    public static class Conexion
    {
        private static readonly string connectionString;

        static Conexion()
        {
            // Corregido el nombre de la instancia
            connectionString = @"Server=DESKTOP-BUUJ9LF\SQLEXPRESS01;Database=pubs;User Id=sa;Password=erick;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
    }
}