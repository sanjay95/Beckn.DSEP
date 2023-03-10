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
    /// Describes time in its various forms. It can be a single point in time; duration; or a structured timetable of operations&lt;br&gt;This has properties like label, time stamp,duration,range, days, schedule
    /// </summary>
    [DataContract]
    public partial class Time : IEquatable<Time>
    { 
        /// <summary>
        /// Gets or Sets Label
        /// </summary>

        [DataMember(Name="label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>

        [DataMember(Name="duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>

        [DataMember(Name="range")]
        public TimeRange Range { get; set; }

        /// <summary>
        /// comma separated values representing days of the week
        /// </summary>
        /// <value>comma separated values representing days of the week</value>

        [DataMember(Name="days")]
        public string Days { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>

        [DataMember(Name="schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Time {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Days: ").Append(Days).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Time)obj);
        }

        /// <summary>
        /// Returns true if Time instances are equal
        /// </summary>
        /// <param name="other">Instance of Time to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Time other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    Duration == other.Duration ||
                    Duration != null &&
                    Duration.Equals(other.Duration)
                ) && 
                (
                    Range == other.Range ||
                    Range != null &&
                    Range.Equals(other.Range)
                ) && 
                (
                    Days == other.Days ||
                    Days != null &&
                    Days.Equals(other.Days)
                ) && 
                (
                    Schedule == other.Schedule ||
                    Schedule != null &&
                    Schedule.Equals(other.Schedule)
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
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                    if (Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();
                    if (Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();
                    if (Days != null)
                    hashCode = hashCode * 59 + Days.GetHashCode();
                    if (Schedule != null)
                    hashCode = hashCode * 59 + Schedule.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Time left, Time right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Time left, Time right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
