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
    public partial class Envio : IEquatable<Envio>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <value>Gets or Sets Id</value>

        [DataMember(Name = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// En_espera, En_curso o Entregado
        /// </summary>
        /// <value>En_espera, En_curso o Entregado</value>

        [DataMember(Name = "estado")]
        public string Estado { get; set; }

        /// <summary>
        /// Gets or Sets Descripcion
        /// </summary>
        /// <value>Gets or Sets Descripcion</value>

        [DataMember(Name = "descripcion")]
        public string Descripcion { get; set; }

        /// <summary>
        /// Gets or Sets Origen
        /// </summary>
        /// <value>Gets or Sets Origen</value>

        [DataMember(Name = "origen")]
        public string Origen { get; set; }

        /// <summary>
        /// Gets or Sets Origen
        /// </summary>
        /// <value>Gets or Sets Origen</value>

        [DataMember(Name = "origenCp")]
        public string OrigenCp { get; set; }

        /// <summary>
        /// Gets or Sets Destino
        /// </summary>
        /// <value>Gets or Sets Destino</value>

        [DataMember(Name = "destino")]
        public string Destino { get; set; }

        /// <summary>
        /// Gets or Sets Destino
        /// </summary>
        /// <value>Gets or Sets Destino</value>

        [DataMember(Name = "destinoCp")]
        public string DestinoCp { get; set; }

        /// <summary>
        /// En gramos
        /// </summary>
        /// <value>En gramos</value>

        [DataMember(Name = "peso")]
        public long? Peso { get; set; }

        /// <summary>
        /// En centimetros
        /// </summary>
        /// <value>En centimetros</value>

        [DataMember(Name = "altura")]
        public long? Altura { get; set; }

        /// <summary>
        /// En centimetros
        /// </summary>
        /// <value>En centimetros</value>

        [DataMember(Name = "anchura")]
        public long? Anchura { get; set; }

        /// <summary>
        /// En centimetros
        /// </summary>
        /// <value>En centimetros</value>

        [DataMember(Name = "longitud")]
        public long? Longitud { get; set; }

        /// <summary>
        /// Baja, Normal o Alta
        /// </summary>
        /// <value>Baja, Normal o Alta</value>

        [DataMember(Name = "importancia")]
        public string Importancia { get; set; }

        /// <summary>
        /// Coste
        /// </summary>
        /// <value>Coste</value>


        [DataMember(Name = "idrepartidor")]
        public long? idrepartidor { get; set; }

        [DataMember(Name = "coste")]
        public long? Coste { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IOSwaggerModelsEnvio {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Estado: ").Append(Estado).Append("\n");
            sb.Append("  Descripcion: ").Append(Descripcion).Append("\n");
            sb.Append("  Origen: ").Append(Origen).Append("\n");
            sb.Append("  OrigenCp: ").Append(OrigenCp).Append("\n");
            sb.Append("  Destino: ").Append(Destino).Append("\n");
            sb.Append("  DestinoCp: ").Append(DestinoCp).Append("\n");
            sb.Append("  Peso: ").Append(Peso).Append("\n");
            sb.Append("  Altura: ").Append(Altura).Append("\n");
            sb.Append("  Anchura: ").Append(Anchura).Append("\n");
            sb.Append("  Longitud: ").Append(Longitud).Append("\n");
            sb.Append("  Importancia: ").Append(Importancia).Append("\n");
            sb.Append("  idrepartidor: ").Append(Longitud).Append("\n");
            sb.Append("  Coste: ").Append(Coste).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Envio)obj);
        }

        /// <summary>
        /// Returns true if IOSwaggerModelsEnvio instances are equal
        /// </summary>
        /// <param name="other">Instance of IOSwaggerModelsEnvio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Envio other)
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
                    Estado == other.Estado ||
                    Estado != null &&
                    Estado.Equals(other.Estado)
                ) &&
                (
                    Descripcion == other.Descripcion ||
                    Descripcion != null &&
                    Descripcion.Equals(other.Descripcion)
                ) &&
                (
                    Origen == other.Origen ||
                    Origen != null &&
                    Origen.Equals(other.Origen)
                ) &&
                (
                    OrigenCp == other.OrigenCp ||
                    OrigenCp != null &&
                    OrigenCp.Equals(other.OrigenCp)
                ) &&
                (
                    Destino == other.Destino ||
                    Destino != null &&
                    Destino.Equals(other.Destino)
                ) &&
                (
                    DestinoCp == other.DestinoCp ||
                    DestinoCp != null &&
                    DestinoCp.Equals(other.DestinoCp)
                ) &&
                (
                    Peso == other.Peso ||
                    Peso != null &&
                    Peso.Equals(other.Peso)
                ) &&
                (
                    Altura == other.Altura ||
                    Altura != null &&
                    Altura.Equals(other.Altura)
                ) &&
                (
                    Anchura == other.Anchura ||
                    Anchura != null &&
                    Anchura.Equals(other.Anchura)
                ) &&
                (
                    Longitud == other.Longitud ||
                    Longitud != null &&
                    Longitud.Equals(other.Longitud)
                ) &&
                (
                    Importancia == other.Importancia ||
                    Importancia != null &&
                    Importancia.Equals(other.Importancia)
                ) &&
                (
                    idrepartidor == other.idrepartidor ||
                    idrepartidor != null &&
                    idrepartidor.Equals(other.idrepartidor)
                ) &&
                (
                    Coste == other.Coste ||
                    Coste != null &&
                    Coste.Equals(other.Coste)
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
                if (Estado != null)
                    hashCode = hashCode * 59 + Estado.GetHashCode();
                if (Descripcion != null)
                    hashCode = hashCode * 59 + Descripcion.GetHashCode();
                if (Origen != null)
                    hashCode = hashCode * 59 + Origen.GetHashCode();
                if (OrigenCp != null)
                    hashCode = hashCode * 59 + OrigenCp.GetHashCode();
                if (Destino != null)
                    hashCode = hashCode * 59 + Destino.GetHashCode();
                if (DestinoCp != null)
                    hashCode = hashCode * 59 + DestinoCp.GetHashCode();
                if (Peso != null)
                    hashCode = hashCode * 59 + Peso.GetHashCode();
                if (Altura != null)
                    hashCode = hashCode * 59 + Altura.GetHashCode();
                if (Anchura != null)
                    hashCode = hashCode * 59 + Anchura.GetHashCode();
                if (Longitud != null)
                    hashCode = hashCode * 59 + Longitud.GetHashCode();
                if (Importancia != null)
                    hashCode = hashCode * 59 + Importancia.GetHashCode();
                if (idrepartidor != null)
                    hashCode = hashCode * 59 + idrepartidor.GetHashCode();
                if (Coste != null)
                    hashCode = hashCode * 59 + Coste.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Envio left, Envio right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Envio left, Envio right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
