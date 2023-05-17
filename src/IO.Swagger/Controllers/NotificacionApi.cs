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
using System.Net.Mail;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class NotificacionApiController : ControllerBase
    {

        private void enviarCorreo(string destino, string subject, string mensaje)
        {
            // Configurar los parámetros del servidor SMTP
            SmtpClient smtpClient = new SmtpClient("localhost", 25);
            //smtpClient.Credentials = new NetworkCredential("username", "password");

            // Configurar el mensaje de correo electrónico
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("servidorAPI@example.com");
            mailMessage.To.Add(new MailAddress(destino));
            mailMessage.Subject = subject;
            mailMessage.Body = mensaje;

            // Enviar el mensaje de correo electrónico
            smtpClient.Send(mailMessage);
        }


        /// <summary>
        /// Notifica al cliente
        /// </summary>
        /// <remarks>Notifica al cliente mediante un correo de que hay una actualizacion respecto a su pedido</remarks>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/Notificacion/enviarCorreo/{correo}/{tema}")]
        [ValidateModelState]
        [SwaggerOperation("NotificacionEnviarCorreoPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult NotificacionEnviarCorreoPost([FromRoute][Required] string correo, [FromRoute][Required] string tema, [FromHeader]string restKey)
        {
            try { 
                enviarCorreo(correo, tema, "No ha estado presente para la recogida del paquete. Deberá pasarse por el centro de recogida más cercano para poder obtener su paquete.");
                return StatusCode(200, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"Se ha notificado al cliente\"\n}"));
            }catch(Exception)
            {
                return StatusCode(500, JsonConvert.DeserializeObject("{\n  \"mensaje\" : \"Error enviando el correo\"\n}"));
            }
        }

        /// <summary>
        /// Notifica al cliente para recoger el envio
        /// </summary>
        /// <remarks>Notifica al cliente mediante un correo de que no estaba presente para recoger el envio y tiene que pasarse por el centro de distribución local</remarks>
        /// <param name="id">Id del envio</param>
        /// <param name="body">Estructura para hacer peticiones</param>
        /// <param name="restKey">Api Key</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad request</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="500">Internal error</response>
        [HttpPost]
        [Route("/VHJ1_1/MTIS/1.0.0/Notificacion/EnvioSinRecoger/{id}")]
        [ValidateModelState]
        [SwaggerOperation("NotificacionEnvioSinRecogerIdPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Response), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(Response), description: "Bad request")]
        [SwaggerResponse(statusCode: 401, type: typeof(Response), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 500, type: typeof(Response), description: "Internal error")]
        public virtual IActionResult NotificacionEnvioSinRecogerIdPost([FromRoute][Required]string id, [FromBody]Recurso body, [FromHeader]string restKey)
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
    }
}
