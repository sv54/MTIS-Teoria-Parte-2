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
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Envio));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            //exampleJson = "{\n  \"descripcion\" : \"Envio con material delicado\",\n  \"importancia\" : \"Normal\",\n  \"estado\" : \"En_espera\",\n  \"peso\" : 300,\n  \"altura\" : 10,\n  \"anchura\" : 20,\n  \"longuitud\" : 20,\n  \"id\" : 5632,\n  \"origen\" : \"Alicante\",\n  \"destino\" : \"Calle Vicente Blasco Ibañez, 8, 03181, Torrevieja Alicante, Alicante\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Envio>(exampleJson)
                        : default(Envio);            //TODO: Change the data returned
            return new ObjectResult(example);
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
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Envio>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "[ {\n  \"descripcion\" : \"Envio con material delicado\",\n  \"importancia\" : \"Normal\",\n  \"estado\" : \"En_espera\",\n  \"peso\" : 300,\n  \"altura\" : 10,\n  \"anchura\" : 20,\n  \"longuitud\" : 20,\n  \"id\" : 5632,\n  \"origen\" : \"Alicante\",\n  \"destino\" : \"Calle Vicente Blasco Ibañez, 8, 03181, Torrevieja Alicante, Alicante\"\n}, {\n  \"descripcion\" : \"Envio con material delicado\",\n  \"importancia\" : \"Normal\",\n  \"estado\" : \"En_espera\",\n  \"peso\" : 300,\n  \"altura\" : 10,\n  \"anchura\" : 20,\n  \"longuitud\" : 20,\n  \"id\" : 5632,\n  \"origen\" : \"Alicante\",\n  \"destino\" : \"Calle Vicente Blasco Ibañez, 8, 03181, Torrevieja Alicante, Alicante\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Envio>>(exampleJson)
                        : default(List<Envio>);            //TODO: Change the data returned
            return new ObjectResult(example);
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
            

            string insertRowSQL = "INSERT INTO mtisteoria.envio (estado, descripcion, origen, destino, peso, altura, anchura, longitud, importancia)" +
                    "VALUES('"+body.Estado+"', '"+ body.Descripcion + "', '"+body.Origen+"', '"+body.Destino+"', '"+body.Peso+"', '" + body.Altura + "', '" + body.Anchura + "', '" + body.Longuitud + "', '" + body.Importancia + "')";
            if (DBUtils.DbModif(insertRowSQL))
            {

                return StatusCode(200, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"Se ha creado el envio\"\n}"));
            }
            else
            {
                return StatusCode(400, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"No se han modificado filas\"\n}"));

            }

        //exampleJson = "[ {\n  \"descripcion\" : \"Envio con material delicado\",\n  \"importancia\" : \"Normal\",\n  \"estado\" : \"En_espera\",\n  \"peso\" : 300,\n  \"altura\" : 10,\n  \"anchura\" : 20,\n  \"longuitud\" : 20,\n  \"id\" : 5632,\n  \"origen\" : \"Alicante\",\n  \"destino\" : \"Calle Vicente Blasco Ibañez, 8, 03181, Torrevieja Alicante, Alicante\"\n}, {\n  \"descripcion\" : \"Envio con material delicado\",\n  \"importancia\" : \"Normal\",\n  \"estado\" : \"En_espera\",\n  \"peso\" : 300,\n  \"altura\" : 10,\n  \"anchura\" : 20,\n  \"longuitud\" : 20,\n  \"id\" : 5632,\n  \"origen\" : \"Alicante\",\n  \"destino\" : \"Calle Vicente Blasco Ibañez, 8, 03181, Torrevieja Alicante, Alicante\"\n} ]";
        

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
                    " peso = '" + body.Peso + "', altura = '" + body.Altura + "', anchura = '" + body.Anchura + "', longitud = '" + body.Longuitud + "', importancia = '" + body.Importancia + "' " +
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
