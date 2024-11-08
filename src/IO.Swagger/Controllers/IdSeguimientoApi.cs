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
using System;
using System.Linq;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;
using IO.Swagger.Utils;

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
        /// <param name="restKey">Api Key</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpGet]
        [Route("/VHJ1_1/MTIS/1.0.0/idSeguimiento")]
        [ValidateModelState]
        [SwaggerOperation("GenerarIdentificador")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult GenerarIdentificador( [FromHeader]string restKey)
        {
            //if (!ApiKeyAuth.Auth(restKey))
            //{
            //    response.Status = "Unauthorized";
            //    response.Message = "Falta el RestKey o es invalido";
            //    return StatusCode(401, response);
            //}
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var aleatorio = new Random();
            var identificador = new string(
                Enumerable.Repeat(caracteres, 12)
                .Select(s => s[aleatorio.Next(s.Length)])
                .ToArray());
            //var json = JsonConvert.SerializeObject(new { codigo =  identificador});

            //Guardar en la base de datos
            Response response = new Response();
            response.Status = "Success";
            response.Message = identificador;
            return Ok(identificador);
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
        [HttpGet]
        [Route("/VHJ1_1/MTIS/1.0.0/idSeguimiento/validar/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ValidarIdentificador")]
        [SwaggerResponse(statusCode: 201, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult ValidarIdentificador([FromRoute][Required]string id, [FromHeader]string restKey)
        {
            Response response = new Response();
            if (id.Length != 12)
            {
                return Ok(false);

               // //return BadRequest("El ID debe tener 12 caracteres.");
               // response.Status = "BadRequest";
               // response.Message = "false";
               // return StatusCode(400, response);

            }
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            foreach (char c in id)
            {
                if (!caracteresPermitidos.Contains(c))
                {
                    return Ok(false);
                    
                    //response.Status = "BadRequest";
                    //response.Message = "false";
                    ////return StatusCode(400, response);
                }
            }
            response.Status = "Success";
            response.Message = "true";
            return Ok(true);
        }
    }
}
