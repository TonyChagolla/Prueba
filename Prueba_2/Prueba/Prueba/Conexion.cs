using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Prueba
{
    public class Conexion
    {
        private SqlConnectionStringBuilder builder;
        private SqlConnection conn = null;

        public Conexion(string server, string user, string pass, string database)
        {
            builder = new SqlConnectionStringBuilder();
            builder.DataSource = server;
            builder.UserID = user;
            builder.Password = pass;
            builder.InitialCatalog = database;
        }

        public DataTable ExecQuery(string query)
        {
            conn = new SqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    conn.Close();
                    return dataTable;

                }
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                return null;
            }
        }

        public bool AgregarUsuario(string query, string login, string nombre, string paterno, string materno, float sueldo)
        {
            conn = new SqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@login", SqlDbType.VarChar);
                command.Parameters.Add("@Nombre", SqlDbType.VarChar);
                command.Parameters.Add("@Materno", SqlDbType.VarChar);
                command.Parameters.Add("@Paterno", SqlDbType.VarChar);
                command.Parameters.Add("@Sueldo", SqlDbType.Float);
                command.Parameters["@login"].Value = login;
                command.Parameters["@Nombre"].Value = nombre;
                command.Parameters["@Materno"].Value = materno;
                command.Parameters["@Paterno"].Value = paterno;
                command.Parameters["@Sueldo"].Value = sueldo;

                command.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }

        public bool ModificarSueldo(string query, string login, float sueldo)
        {
            conn = new SqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@login", SqlDbType.VarChar);
                command.Parameters.Add("@Sueldo", SqlDbType.Float);
                command.Parameters["@login"].Value = login;
                command.Parameters["@Sueldo"].Value = sueldo;

                command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    conn.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        if (bool.Parse(row["resultado"].ToString()) == true)
                            return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
        }
    }
}