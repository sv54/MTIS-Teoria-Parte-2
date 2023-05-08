using System;

namespace IO.Swagger.Utils
{
    /// <summary>
    /// Clase para validar el RestKey
    /// </summary>
    public abstract class ApiKeyAuth
    {
        /// <summary>
        /// Metodo para validar el RestKey
        /// </summary>
        /// <param name="api_key"></param>
        /// <returns></returns>
        static public Boolean Auth(string api_key)
        {
            return (api_key != null && DBUtils.dbConsult("SELECT * FROM restkey WHERE rest_key='" + api_key.ToString() + "'"));
        }
    }
}
