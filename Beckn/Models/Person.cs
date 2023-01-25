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
    /// Describes a person as any individual
    /// </summary>
    [DataContract]
    public partial class Person : IEquatable<Person>
    { 
        /// <summary>
        /// Describes the identity of the person
        /// </summary>
        /// <value>Describes the identity of the person</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Profile url of the person
        /// </summary>
        /// <value>Profile url of the person</value>

        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// the name of the person
        /// </summary>
        /// <value>the name of the person</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>

        [DataMember(Name="image")]
        public Image Image { get; set; }

        /// <summary>
        /// Age of the person
        /// </summary>
        /// <value>Age of the person</value>

        [DataMember(Name="age")]
        public Object Age { get; set; }

        /// <summary>
        /// Date of birth of the person
        /// </summary>
        /// <value>Date of birth of the person</value>

        [DataMember(Name="dob")]
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Gender of something, typically a Person, but possibly also fictional characters, animals, etc. While Male and Female may be used, text strings are also acceptable for people who do not identify as a binary gender.Allowed values for this field can be published in the network policy
        /// </summary>
        /// <value>Gender of something, typically a Person, but possibly also fictional characters, animals, etc. While Male and Female may be used, text strings are also acceptable for people who do not identify as a binary gender.Allowed values for this field can be published in the network policy</value>

        [DataMember(Name="gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets Creds
        /// </summary>

        [DataMember(Name="creds")]
        public List<Credential> Creds { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>

        [DataMember(Name="languages")]
        public List<PersonLanguages> Languages { get; set; }

        /// <summary>
        /// Gets or Sets Skills
        /// </summary>

        [DataMember(Name="skills")]
        public List<PersonSkills> Skills { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>

        [DataMember(Name="tags")]
        public List<TagGroup> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Person {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Creds: ").Append(Creds).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Person)obj);
        }

        /// <summary>
        /// Returns true if Person instances are equal
        /// </summary>
        /// <param name="other">Instance of Person to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Person other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Image == other.Image ||
                    Image != null &&
                    Image.Equals(other.Image)
                ) && 
                (
                    Age == other.Age ||
                    Age != null &&
                    Age.Equals(other.Age)
                ) && 
                (
                    Dob == other.Dob ||
                    Dob != null &&
                    Dob.Equals(other.Dob)
                ) && 
                (
                    Gender == other.Gender ||
                    Gender != null &&
                    Gender.Equals(other.Gender)
                ) && 
                (
                    Creds == other.Creds ||
                    Creds != null &&
                    Creds.SequenceEqual(other.Creds)
                ) && 
                (
                    Languages == other.Languages ||
                    Languages != null &&
                    Languages.SequenceEqual(other.Languages)
                ) && 
                (
                    Skills == other.Skills ||
                    Skills != null &&
                    Skills.SequenceEqual(other.Skills)
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
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                    if (Age != null)
                    hashCode = hashCode * 59 + Age.GetHashCode();
                    if (Dob != null)
                    hashCode = hashCode * 59 + Dob.GetHashCode();
                    if (Gender != null)
                    hashCode = hashCode * 59 + Gender.GetHashCode();
                    if (Creds != null)
                    hashCode = hashCode * 59 + Creds.GetHashCode();
                    if (Languages != null)
                    hashCode = hashCode * 59 + Languages.GetHashCode();
                    if (Skills != null)
                    hashCode = hashCode * 59 + Skills.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Person left, Person right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
