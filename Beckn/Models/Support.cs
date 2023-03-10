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

namespace Beckn.Models
{ 
    /// <summary>
    /// Details of customer support
    /// </summary>
    [DataContract]
    public partial class Support : IEquatable<Support>
    { 
        /// <summary>
        /// Gets or Sets RefId
        /// </summary>

        [DataMember(Name="ref_id")]
        public string RefId { get; set; }

        /// <summary>
        /// Gets or Sets CallbackPhone
        /// </summary>

        [DataMember(Name="callback_phone")]
        public string CallbackPhone { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>

        [DataMember(Name="phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>

        [DataMember(Name="email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>

        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Support {\n");
            sb.Append("  RefId: ").Append(RefId).Append("\n");
            sb.Append("  CallbackPhone: ").Append(CallbackPhone).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Support)obj);
        }

        /// <summary>
        /// Returns true if Support instances are equal
        /// </summary>
        /// <param name="other">Instance of Support to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Support other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RefId == other.RefId ||
                    RefId != null &&
                    RefId.Equals(other.RefId)
                ) && 
                (
                    CallbackPhone == other.CallbackPhone ||
                    CallbackPhone != null &&
                    CallbackPhone.Equals(other.CallbackPhone)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
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
                    if (RefId != null)
                    hashCode = hashCode * 59 + RefId.GetHashCode();
                    if (CallbackPhone != null)
                    hashCode = hashCode * 59 + CallbackPhone.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Support left, Support right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Support left, Support right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
