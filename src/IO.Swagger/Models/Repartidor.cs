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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Repartidor : IEquatable<Repartidor>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]

        [DataMember(Name="id")]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Nombre
        /// </summary>

        [DataMember(Name="nombre")]
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or Sets Appellidos
        /// </summary>

        [DataMember(Name="appellidos")]
        public string Appellidos { get; set; }

        /// <summary>
        /// Puede ser libre, en envio o no disponible
        /// </summary>
        /// <value>Puede ser libre, en envio o no disponible</value>

        [DataMember(Name="estado")]
        public string Estado { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Repartidor {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Nombre: ").Append(Nombre).Append("\n");
            sb.Append("  Appellidos: ").Append(Appellidos).Append("\n");
            sb.Append("  Estado: ").Append(Estado).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Repartidor)obj);
        }

        /// <summary>
        /// Returns true if Repartidor instances are equal
        /// </summary>
        /// <param name="other">Instance of Repartidor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repartidor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Nombre == other.Nombre ||
                    Nombre != null &&
                    Nombre.Equals(other.Nombre)
                ) && 
                (
                    Appellidos == other.Appellidos ||
                    Appellidos != null &&
                    Appellidos.Equals(other.Appellidos)
                ) && 
                (
                    Estado == other.Estado ||
                    Estado != null &&
                    Estado.Equals(other.Estado)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Nombre != null)
                    hashCode = hashCode * 59 + Nombre.GetHashCode();
                    if (Appellidos != null)
                    hashCode = hashCode * 59 + Appellidos.GetHashCode();
                    if (Estado != null)
                    hashCode = hashCode * 59 + Estado.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Repartidor left, Repartidor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Repartidor left, Repartidor right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}