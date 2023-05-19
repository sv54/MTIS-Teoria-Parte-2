using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace IO.Swagger.Utils
{
    /// <summary>
    /// Clase para interactuar con la Base de Datos
    /// </summary>
    public abstract class DBUtils
    {
        static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        static string bd = "mtisteoria";            //Nombre de la base de datos
        static string usuario = "root";       //Usuario de acceso a MySQL
        static string password = "root";   //Contraseña de usuario de acceso a MySQL

        //Crearemos la cadena de conexión concatenando las variables
        static string connectionString = "Server=" + servidor + ";Database=" + bd + ";Uid=" + usuario + ";Pwd=" + password + ";";
        //Instancia para conexión a MySQL, recibe la cadena de conexión
        static MySqlConnection conexion = new MySqlConnection(connectionString);

        /// <summary>
        /// Recibe una comando UPDATE para modificar un valor en la Base de Datos y devuelve un buleano con el estado de la ejecucion
        /// </summary>
        /// <param name="command">Comando SQL para UPDATE</param>
        /// <returns>True si se ha modificado correctamente, False en caso contrario</returns>
        public static bool DbModif(string command)
        {
            MySqlCommand cmd = null;
            bool result = false;
            try
            {
                cmd = new MySqlCommand(command, conexion);
                conexion.Open();
                // Modificar
                int filasModificadas = cmd.ExecuteNonQuery();
                result = filasModificadas > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: ");
                Console.WriteLine(e.ToString());
                Debug.WriteLine("ERROR: \n\n");
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conexion != null) conexion.Close();
            }
            return result;
        }

        /// <summary>
        /// Recibe una comando UPDATE para modificar un valor en la Base de Datos y devuelve un buleano con el estado de la ejecucion
        /// </summary>
        /// <param name="command">Comando SQL para UPDATE</param>
        /// <returns>True si se ha modificado correctamente, False en caso contrario</returns>
        public static int DbCreateReturnId(string command)
        {
            MySqlCommand cmd = null;
            int result = 0;
            try
            {
                cmd = new MySqlCommand(command + "; SELECT LAST_INSERT_ID()", conexion);
                conexion.Open();
                // Modificar
                cmd.ExecuteNonQuery();
                result = (int)cmd.LastInsertedId;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: ");
                Console.WriteLine(e.ToString());
                Debug.WriteLine("ERROR: \n\n");
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conexion != null) conexion.Close();
            }
            return result;
        }

        /// <summary>
        /// Recibe una comando SELECT y devuelve una lista <COLUMNA, VALOR>
        /// </summary>
        /// <param name="command">Comando SQL para SELECT</param>
        /// <returns>Devuelve una lista <COLUMNA, VALOR></returns>
        public static List<Dictionary<string, string>> DbGet(string command)
        {
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            try
            {
                cmd = new MySqlCommand(command, conexion);
                conexion.Open();
                // Consultar
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i).ToString());
                    }
                    result.Add(row);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (conexion != null) conexion.Close();
            }
            return result;
        }

        /// <summary>
        /// Recibe una comando SELECT y consulta la Base de Datos si existe el elemento
        /// </summary>
        /// <param name="command">Comando SQL para SELECT</param>
        /// <returns>True si el elemento existe en la table, False en caso contrario</returns>
        public static Boolean dbConsult(string command)
        {
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            bool result = false;

            try
            {
                cmd = new MySqlCommand(command, conexion);
                conexion.Open();
                // Consultar
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = true;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Dispose();
                if (conexion != null) conexion.Close();
            }
            return result;
        }
    }
}
