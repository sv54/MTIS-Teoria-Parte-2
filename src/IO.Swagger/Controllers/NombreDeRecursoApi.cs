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
    public class NombreDeRecursoApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpDelete]
        [Route("/VHJ1_1/MTIS/1.0.0/NombreDeRecurso/{id}")]
        [ValidateModelState]
        [SwaggerOperation("NombreDeRecursoIdDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult NombreDeRecursoIdDelete([FromRoute][Required]string id, [FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Response));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"message\" : \"Se ha creado con exito, El campo no es valido, etc.\",\n  \"status\" : \"Success, Bad request, etc.\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Response>(exampleJson)
                        : default(Response);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal error</response>
        [HttpGet]
        [Route("/VHJ1_1/MTIS/1.0.0/NombreDeRecurso/{id}")]
        [ValidateModelState]
        [SwaggerOperation("NombreDeRecursoIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Recurso), description: "Success")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult NombreDeRecursoIdGet([FromRoute][Required]string id, [FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Recurso));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"codigoSala\" : \"1F\",\n  \"nombre\" : \"Salon de actas\",\n  \"nivel\" : 1\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Recurso>(exampleJson)
                        : default(Recurso);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">Estructura para hacer peticiones</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/NombreDeRecurso")]
        [ValidateModelState]
        [SwaggerOperation("NombreDeRecursoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult NombreDeRecursoPost([FromBody]Recurso body, [FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Response));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Response));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"message\" : \"Se ha creado con exito, El campo no es valido, etc.\",\n  \"status\" : \"Success, Bad request, etc.\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Response>(exampleJson)
                        : default(Response);            //TODO: Change the data returned
            return new ObjectResult(example);
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
        [Route("/VHJ1_1/MTIS/1.0.0/NombreDeRecurso")]
        [ValidateModelState]
        [SwaggerOperation("NombreDeRecursoPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(Response), description: "Not found")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult NombreDeRecursoPut([FromBody]Recurso body, [FromHeader]string restKey)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Response));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Response));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Response));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Response));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Response));
            string exampleJson = null;
            exampleJson = "{\n  \"message\" : \"Se ha creado con exito, El campo no es valido, etc.\",\n  \"status\" : \"Success, Bad request, etc.\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Response>(exampleJson)
                        : default(Response);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
