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

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class CalcularCosteApiController : ControllerBase
    { 
        /// <summary>
        /// Calcula el coste de transporte
        /// </summary>
        /// <param name="dirIn">Direccion origen</param>
        /// <param name="dirInCp">Codigo Postal de origen</param>
        /// <param name="dirFin">Direccion destino</param>
        /// <param name="dirFinCp">Codigo Postal de destino</param>
        /// <param name="dimensiones">Dimensiones del paquete</param>
        /// <param name="peso">Peso del paquete</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/CalcularCoste")]
        [ValidateModelState]
        [SwaggerOperation("CalcularCostePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult CalcularCostePost([FromQuery][Required()]string dirIn, [FromQuery][Required()]int? dirInCp, [FromQuery][Required()]string dirFin, [FromQuery][Required()]int? dirFinCp, [FromQuery][Required()]string dimensiones, [FromQuery][Required()]int? peso, [FromHeader]string restKey)
        {
            try
            {
                /*if (!ApiKeyAuth.Auth(restKey))
                {
                    Response response = new Response();

                    response.Status = "Unauthorized";
                    response.Message = "Falta el RestKey o es invalido";
                    return StatusCode(401, response);
                }*/

                List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
                result = DBUtils.DbGet("SELECT * FROM coste WHERE originCp='" + dirInCp.ToString() + "' and destCp='"+ dirFinCp.ToString() + "'");
                if (result.Count != 0)
                {
                    Response response = new Response();
                    string costeBD = "";

                    result[0].TryGetValue("coste", out costeBD);

                    response.Status = "Success";
                    response.Message = costeBD;

                    return StatusCode(200, response);
                }
                else
                {
                    Response response = new Response();
                    response.Status = "Bad request";
                    response.Message = "Las direcciones estan fuera de la area de cobertura";
                    return StatusCode(400, response);
                }
            }
            catch (Exception)
            {
                Response response = new Response();
                response.Status = "Internal error";
                response.Message = "Algo ha ido mal";
                return StatusCode(500, response);
            }
        }
    }
}
