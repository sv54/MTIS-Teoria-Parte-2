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
    public class IdSeguimientoApiController : ControllerBase
    { 
        /// <summary>
        /// Generar identificador de seguimiento
        /// </summary>
        /// <param name="body">Petición para generar un identificador de seguimiento</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="201">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/idSeguimiento")]
        [ValidateModelState]
        [SwaggerOperation("GenerarIdentificador")]
        [SwaggerResponse(statusCode: 201, type: typeof(InlineResponse201), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult GenerarIdentificador([FromBody]IdSeguimientoBody body, [FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(InlineResponse201));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Response));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"id\" : \"LN11543234\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse201>(exampleJson)
                        : default(InlineResponse201);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Validar identificador de seguimiento
        /// </summary>
        /// <param name="id">Identificadora validar</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="201">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/idSeguimiento/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ValidarIdentificador")]
        [SwaggerResponse(statusCode: 201, type: typeof(InlineResponse2011), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult ValidarIdentificador([FromRoute][Required]string id, [FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(InlineResponse2011));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Response));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"id\" : true,\n  \"message\" : \"identificador correcto\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse2011>(exampleJson)
                        : default(InlineResponse2011);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}