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
    /// Contains tracking information that can be used by the BAP to track the fulfillment of an order in real-time. which is useful for knowing the location of time sensitive deliveries.
    /// </summary>
    [DataContract]
    public partial class Tracking : IEquatable<Tracking>
    {
        /// <summary>
        /// A unique tracking reference number
        /// </summary>
        /// <value>A unique tracking reference number</value>

        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// A URL to the tracking endpoint. This can be a link to a tracking webpage, a webhook URL created by the BAP where BPP can push the tracking data, or a GET url creaed by the BPP which the BAP can poll to get the tracking data. It can also be a websocket URL where the BPP can push real-time tracking data.
        /// </summary>
        /// <value>A URL to the tracking endpoint. This can be a link to a tracking webpage, a webhook URL created by the BAP where BPP can push the tracking data, or a GET url creaed by the BPP which the BAP can poll to get the tracking data. It can also be a websocket URL where the BPP can push real-time tracking data.</value>

        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// In case there is no real-time tracking endpoint available, this field will contain the latest location of the entity being tracked. The BPP will update this value everytime the BAP calls the track API.
        /// </summary>
        /// <value>In case there is no real-time tracking endpoint available, this field will contain the latest location of the entity being tracked. The BPP will update this value everytime the BAP calls the track API.</value>

        [DataMember(Name = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// This value indicates if the tracking is currently active or not. If this value is `active`, then the BAP can begin tracking the order. If this value is `inactive`, the tracking URL is considered to be expired and the BAP should stop tracking the order.
        /// </summary>
        /// <value>This value indicates if the tracking is currently active or not. If this value is `active`, then the BAP can begin tracking the order. If this value is `inactive`, the tracking URL is considered to be expired and the BAP should stop tracking the order.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ActiveEnum for active
            /// </summary>
            [EnumMember(Value = "active")]
            ActiveEnum = 0,
            /// <summary>
            /// Enum InactiveEnum for inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            InactiveEnum = 1
        }

        /// <summary>
        /// This value indicates if the tracking is currently active or not. If this value is &#x60;active&#x60;, then the BAP can begin tracking the order. If this value is &#x60;inactive&#x60;, the tracking URL is considered to be expired and the BAP should stop tracking the order.
        /// </summary>
        /// <value>This value indicates if the tracking is currently active or not. If this value is &#x60;active&#x60;, then the BAP can begin tracking the order. If this value is &#x60;inactive&#x60;, the tracking URL is considered to be expired and the BAP should stop tracking the order.</value>

        [DataMember(Name = "status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tracking {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Tracking)obj);
        }

        /// <summary>
        /// Returns true if Tracking instances are equal
        /// </summary>
        /// <param name="other">Instance of Tracking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tracking other)
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
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) &&
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
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
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Tracking left, Tracking right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Tracking left, Tracking right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
