/*
 * Beckn Protocol Core
 *
 * Beckn Core Transaction API specification
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

using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Beckn.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ConfirmBody : IEquatable<ConfirmBody>
    {
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [Required]

        [DataMember(Name = "context")]
        public
            Context Context
        { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [Required]

        [DataMember(Name = "message")]
        public SelectMessage Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmBody {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ConfirmBody)obj);
        }

        /// <summary>
        /// Returns true if ConfirmBody instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfirmBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Context == other.Context ||
                    Context != null &&
                    Context.Equals(other.Context)
                ) &&
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
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
                if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(ConfirmBody left, ConfirmBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ConfirmBody left, ConfirmBody right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
