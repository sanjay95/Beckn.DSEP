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
    /// A label under which a collection of items can be grouped.
    /// </summary>
    [DataContract]
    public partial class Category : IEquatable<Category>
    {
        /// <summary>
        /// ID of the category
        /// </summary>
        /// <value>ID of the category</value>

        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ParentCategoryId
        /// </summary>

        [DataMember(Name = "parent_category_id")]
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets Descriptor
        /// </summary>

        [DataMember(Name = "descriptor")]
        public Descriptor Descriptor { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>

        [DataMember(Name = "time")]
        public Time Time { get; set; }

        /// <summary>
        /// Time to live for an instance of this schema
        /// </summary>
        /// <value>Time to live for an instance of this schema</value>

        [DataMember(Name = "ttl")]
        public Object Ttl { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>

        [DataMember(Name = "tags")]
        public List<TagGroup> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ParentCategoryId: ").Append(ParentCategoryId).Append("\n");
            sb.Append("  Descriptor: ").Append(Descriptor).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Category)obj);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="other">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category other)
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
                    ParentCategoryId == other.ParentCategoryId ||
                    ParentCategoryId != null &&
                    ParentCategoryId.Equals(other.ParentCategoryId)
                ) &&
                (
                    Descriptor == other.Descriptor ||
                    Descriptor != null &&
                    Descriptor.Equals(other.Descriptor)
                ) &&
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) &&
                (
                    Ttl == other.Ttl ||
                    Ttl != null &&
                    Ttl.Equals(other.Ttl)
                ) &&
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
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
                if (ParentCategoryId != null)
                    hashCode = hashCode * 59 + ParentCategoryId.GetHashCode();
                if (Descriptor != null)
                    hashCode = hashCode * 59 + Descriptor.GetHashCode();
                if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                if (Ttl != null)
                    hashCode = hashCode * 59 + Ttl.GetHashCode();
                if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Category left, Category right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Category left, Category right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
