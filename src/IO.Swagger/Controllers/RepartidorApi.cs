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

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class RepartidorApiController : ControllerBase
    { 
        /// <summary>
        /// Devuelve informacion de un envio
        /// </summary>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpGet]
        [Route("/VHJ1_1/MTIS/1.0.0/Repartidor/Disponibles")]
        [ValidateModelState]
        [SwaggerOperation("RepartidorDisponiblesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Repartidor), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult RepartidorDisponiblesGet([FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Repartidor));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"estado\" : \"Libre\",\n  \"appellidos\" : \"Torregrosa Peinado\",\n  \"id\" : 5632,\n  \"nombre\" : \"Pedro\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Repartidor>(exampleJson)
                        : default(Repartidor);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
