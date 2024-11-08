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
            List<Repartidor> envios = new List<Repartidor>();
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            result = DBUtils.DbGet("SELECT * FROM repartidor WHERE estado='disponible'");
            for (int i = 0; i < result.Count; i++)
            {
                Repartidor response = new Repartidor();
                
                string id = "";
                string nombre = "";
                string appellidos = "";
                string estado = "";
                

                Debug.WriteLine("result?");
                result[i].TryGetValue("id", out id);
                result[i].TryGetValue("nombre", out nombre);
                result[i].TryGetValue("apellidos", out appellidos);
                result[i].TryGetValue("estado", out estado);
                

                Debug.WriteLine("response?");
                response.Id = int.Parse(id);
                response.Nombre = nombre;
                response.Appellidos = appellidos;
                response.Estado = estado;
               

                Debug.WriteLine("200?");
                envios.Add(response);
            }
            return StatusCode(200, envios);
        }
    }
}
