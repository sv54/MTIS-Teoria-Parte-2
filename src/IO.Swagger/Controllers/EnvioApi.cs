/*
 * API MTIS - OpenAPI 3.0
 *
 * Practica grupal  de MTIS de la Universidad de Alicante 2022-2023.  _Esta documentacion esta escrita en el Swagger Editor y con OpenAPI 3.0_  `Autor: Nikita Polyanskiy, Serhii Vidernikov, Robert Kazaryan, Víctor Hernández Justamante y Ángel Tamame Pérez`
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using IO.Swagger.Utils;
using System.Diagnostics;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class EnvioApiController : ControllerBase
    { 
        /// <summary>
        /// Devuelve informacion de un envio
        /// </summary>
        /// <param name="id">id de envio</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpGet]
        [Route("/VHJ1_1/MTIS/1.0.0/Envio/{id}")]
        [ValidateModelState]
        [SwaggerOperation("EnvioIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Envio), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult EnvioIdGet([FromRoute][Required]string id, [FromHeader]string restKey)
        {
            List<Envio> envios = new List<Envio>();
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            result = DBUtils.DbGet("SELECT * FROM envio WHERE id='"+id+"'");
            if(result.Count != 0)
            {
                Envio envio = new Envio();
                string estado = "";
                string descripcion = "";
                string origen = "";
                string destino = "";
                string peso = "";
                string altura = "";
                string anchura = "";
                string longitud = "";
                string importancia = "";
                string idrepartidor = "";

                result[0].TryGetValue("estado", out estado);
                result[0].TryGetValue("descripcion", out descripcion);
                result[0].TryGetValue("origen", out origen);
                result[0].TryGetValue("destino", out destino);
                result[0].TryGetValue("peso", out peso);
                result[0].TryGetValue("altura", out altura);
                result[0].TryGetValue("anchura", out anchura);
                result[0].TryGetValue("longitud", out longitud);
                result[0].TryGetValue("importancia", out importancia);

                envio.Id = int.Parse(id);
                envio.Estado = estado;
                envio.Descripcion = descripcion;
                envio.Origen = origen;
                envio.Destino = destino;
                envio.Peso = int.Parse(peso);
                envio.Altura = int.Parse(altura);
                envio.Anchura = int.Parse(anchura);
                envio.Longitud = int.Parse(longitud);
                envio.Importancia = importancia;

            return StatusCode(200, envio);
            }
            return StatusCode(400, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"No se ha encontrado envio con id "+id+"\"\n}"));
        }

        /// <summary>
        /// Devuelve todos los envios pendientes
        /// </summary>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpGet]
        [Route("/VHJ1_1/MTIS/1.0.0/Envio/Pendientes")]
        [ValidateModelState]
        [SwaggerOperation("EnvioPendientesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Envio>), description: "Success")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult EnvioPendientesGet([FromHeader]string restKey)
        {
            List<Envio> envios = new List<Envio>();
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            result = DBUtils.DbGet("SELECT * FROM envio WHERE estado='pendiente'");
            for (int i = 0; i< result.Count; i++)
            {
                Envio response = new Envio();
                string id = "";
                string estado = "";
                string descripcion = "";
                string origen = "";
                string destino = "";
                string peso = "";
                string altura = "";
                string anchura = "";
                string longitud = "";
                string importancia = "";

                Debug.WriteLine("result?");
                result[i].TryGetValue("id", out id);
                result[i].TryGetValue("estado", out estado);
                result[i].TryGetValue("descripcion", out descripcion);
                result[i].TryGetValue("origen", out origen);
                result[i].TryGetValue("destino", out destino);
                result[i].TryGetValue("peso", out peso);
                result[i].TryGetValue("altura", out altura);
                result[i].TryGetValue("anchura", out anchura);
                result[i].TryGetValue("longitud", out longitud);
                result[i].TryGetValue("importancia", out importancia);

                Debug.WriteLine("response?");
                response.Id = int.Parse(id);
                response.Estado = estado;
                response.Descripcion = descripcion;
                response.Origen = origen;
                response.Destino = destino;
                response.Peso = int.Parse(peso);
                response.Altura = int.Parse(altura);
                response.Anchura = int.Parse(anchura);
                response.Longitud = int.Parse(longitud);
                response.Importancia = importancia;

                Debug.WriteLine("200?");
                envios.Add(response);
            }
                return StatusCode(200, envios);
        }

        /// <summary>
        /// Registrar nuevo envio
        /// </summary>
        /// <remarks>Registrarmos nuevo envio</remarks>
        /// <param name="body">Estructura para hacer peticiones</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/Envio")]
        [ValidateModelState]
        [SwaggerOperation("EnvioPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Envio>), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult EnvioPost([FromBody]Envio body, [FromHeader]string restKey)
        {

            /* Comprobar rest key
            if (!conexion.esCorrectaRestKey(body.RestKey))
            {
                return StatusCode(403, JsonConvert.DeserializeObject("{\"mensaje\" : \"RestKey incorrecta\"}"));
            }
            */


            string insertRowSQL = "INSERT INTO mtisteoria.envio (estado, descripcion, origen, destino, peso, altura, anchura, longitud, importancia, coste)" +
                    "VALUES('" + body.Estado + "', '" + body.Descripcion + "', '" + body.Origen + "', '" + body.Destino + "', '" + body.Peso + "', '" + body.Altura + "', '" + body.Anchura + "', '" + body.Longitud
                    + "', '" + body.Importancia + "','" + body.Coste + "')";
            int respDB = DBUtils.DbCreateReturnId(insertRowSQL);
            if (respDB != 0)
            {
                Response response = new Response();
                response.Status = "";
                response.Message = respDB.ToString();
                return StatusCode(200, response);
            }
            else
            {
                return StatusCode(400, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"No se han modificado filas\"\n}"));

            }
        

        }

        /// <summary>
        /// Registrar nuevo envio
        /// </summary>
        /// <remarks>Registrarmos nuevo envio</remarks>
        /// <param name="body">Estructura para hacer peticiones</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpPut]
        [Route("/VHJ1_1/MTIS/1.0.0/Envio/Repartidor")]
        [ValidateModelState]
        [SwaggerOperation("EnvioAsignarRepartidor")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Envio>), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult EnvioRepartidor([FromBody] Envio body, [FromHeader] string restKey)
        {
          

            string updateRowSQL = "UPDATE mtisteoria.envio  SET idRepartidor = '" + body.idrepartidor + "'" +
                                 " WHERE id = '" + body.Id + "'";
            if (DBUtils.DbModif(updateRowSQL))
            {

                return StatusCode(200, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"Se ha asignado repartidor al envio\"\n}"));
            }
            else
            {
                return StatusCode(400, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"No se han modificado filas\"\n}"));

            }
        }


    



        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">Estructura para hacer peticiones</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpPut]
        [Route("/VHJ1_1/MTIS/1.0.0/Envio")]
        [ValidateModelState]
        [SwaggerOperation("EnvioPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Seguimiento>), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult EnvioPut([FromBody]Envio body, [FromHeader]string restKey)
        {
            //UPDATE `mtisteoria`.`envio` SET `estado` = 'stringg', `descripcion` = 'g', `origen` = 'g', `destino` = 'g', `peso` = '1', `altura` = '2', `anchura` = '1', `longitud` = '1', `importancia` = 'g' WHERE (`id` = '3');

            string updateRowSQL = "UPDATE mtisteoria.envio  SET estado = '" + body.Estado + "', descripcion = '" + body.Descripcion + "', origen = '" + body.Origen + "', destino = '" + body.Destino + "', " +
                    " peso = '" + body.Peso + "', altura = '" + body.Altura + "', anchura = '" + body.Anchura + "', longitud = '" + body.Longitud + "', importancia = '" + body.Importancia + "' " +
                    " WHERE id = '"+body.Id +"'";
            if (DBUtils.DbModif(updateRowSQL))
            {

                return StatusCode(200, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"Se ha modificado el envio\"\n}"));
            }
            else
            {
                return StatusCode(400, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"No se han modificado filas\"\n}"));

            }
        }
    }
}
