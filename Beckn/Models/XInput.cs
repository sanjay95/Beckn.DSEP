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
    /// Contains any additional or extended inputs required to confirm an order. This is typically a Form Input. Sometimes, selection of catalog elements is not enough for the BPP to confirm an order. For example, to confirm a flight ticket, the airline requires details of the passengers along with information on baggage, identity, in addition to the class of ticket. Similarly, a logistics company may require details on the nature of shipment in order to confirm the shipping. A recruiting firm may require additional details on the applicant in order to confirm a job application. For all such purposes, the BPP can choose to send this object attached to any object in the catalog that is required to be sent while placing the order. This object can typically be sent at an item level or at the order level. The item level XInput will override the Order level XInput as it indicates a special requirement of information for that particular item. Hence the BAP must render a separate form for the Item and another form at the Order level before confirmation.
    /// </summary>
    [DataContract]
    public partial class XInput : IEquatable<XInput>
    { 
        /// <summary>
        /// Gets or Sets Form
        /// </summary>

        [DataMember(Name="form")]
        public Form Form { get; set; }

        /// <summary>
        /// Indicates whether the form data is mandatorily required by the BPP to confirm the order.
        /// </summary>
        /// <value>Indicates whether the form data is mandatorily required by the BPP to confirm the order.</value>

        [DataMember(Name="required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Gets or Sets FormSubmission
        /// </summary>

        [DataMember(Name="form_submission")]
        public Object FormSubmission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XInput {\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  FormSubmission: ").Append(FormSubmission).Append("\n");
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
            return obj.GetType() == GetType() && Equals((XInput)obj);
        }

        /// <summary>
        /// Returns true if XInput instances are equal
        /// </summary>
        /// <param name="other">Instance of XInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XInput other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Form == other.Form ||
                    Form != null &&
                    Form.Equals(other.Form)
                ) && 
                (
                    Required == other.Required ||
                    Required != null &&
                    Required.Equals(other.Required)
                ) && 
                (
                    FormSubmission == other.FormSubmission ||
                    FormSubmission != null &&
                    FormSubmission.Equals(other.FormSubmission)
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
                    if (Form != null)
                    hashCode = hashCode * 59 + Form.GetHashCode();
                    if (Required != null)
                    hashCode = hashCode * 59 + Required.GetHashCode();
                    if (FormSubmission != null)
                    hashCode = hashCode * 59 + FormSubmission.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(XInput left, XInput right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(XInput left, XInput right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
