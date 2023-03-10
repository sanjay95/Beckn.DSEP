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
using System.Text;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Beckn.Models
{
    /// <summary>
    /// Every API call in beckn protocol has a context. It provides a high-level overview to the receiver about the nature of the intended transaction. Typically, it is the BAP that sets the transaction context based on the consumer&#x27;s location and action on their UI. But sometimes, during unsolicited callbacks, the BPP also sets the transaction context but it is usually the same as the context of a previous full-cycle, request-callback interaction between the BAP and the BPP. The context object contains four types of fields. &lt;ol&gt;&lt;li&gt;Demographic information about the transaction using fields like &#x60;domain&#x60;, &#x60;country&#x60;, and &#x60;region&#x60;.&lt;/li&gt;&lt;li&gt;Addressing details like the sending and receiving platform&#x27;s ID and API URL.&lt;/li&gt;&lt;li&gt;Interoperability information like the protocol version that implemented by the sender and,&lt;/li&gt;&lt;li&gt;Transaction details like the method being called at the receiver&#x27;s endpoint, the transaction_id that represents an end-to-end user session at the BAP, a message ID to pair requests with callbacks, a timestamp to capture sending times, a ttl to specifiy the validity of the request, and a key to encrypt information if necessary.&lt;/li&gt;&lt;/ol&gt; This object must be passed in every interaction between a BAP and a BPP. In HTTP/S implementations, it is not necessary to send the context during the synchronous response. However, in asynchronous protocols, the context must be sent during all interactions,
    /// </summary>
    [DataContract]
    public partial class Context : IEquatable<Context>
    {
        /// <summary>
        /// Domain code that is relevant to this transaction context
        /// </summary>
        /// <value>Domain code that is relevant to this transaction context</value>

        [DataMember(Name = "domain")]
        public Domain Domain { get; set; }

        /// <summary>
        /// The location where the transaction is intended to be fulfilled.
        /// </summary>
        /// <value>The location where the transaction is intended to be fulfilled.</value>

        [DataMember(Name = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// The Beckn protocol method being called by the sender and executed at the receiver.
        /// </summary>
        /// <value>The Beckn protocol method being called by the sender and executed at the receiver.</value>

        [DataMember(Name = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Version of transaction protocol being used by the sender.
        /// </summary>
        /// <value>Version of transaction protocol being used by the sender.</value>

        [DataMember(Name = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Subscriber ID of the BAP
        /// </summary>
        /// <value>Subscriber ID of the BAP</value>

        [DataMember(Name = "bap_id")]
        public string BapId { get; set; }

        /// <summary>
        /// Subscriber URL of the BAP for accepting callbacks from BPPs.
        /// </summary>
        /// <value>Subscriber URL of the BAP for accepting callbacks from BPPs.</value>

        [DataMember(Name = "bap_uri")]
        public string BapUri { get; set; }

        /// <summary>
        /// Subscriber ID of the BPP
        /// </summary>
        /// <value>Subscriber ID of the BPP</value>

        [DataMember(Name = "bpp_id")]
        public string BppId { get; set; }

        /// <summary>
        /// Subscriber URL of the BPP for accepting calls from BAPs.
        /// </summary>
        /// <value>Subscriber URL of the BPP for accepting calls from BAPs.</value>

        [DataMember(Name = "bpp_uri")]
        public string BppUri { get; set; }

        /// <summary>
        /// This is a unique value which persists across all API calls from &#x60;search&#x60; through &#x60;confirm&#x60;. This is done to indicate an active user session across multiple requests. The BPPs can use this value to push personalized recommendations, and dynamic offerings related to an ongoing transaction despite being unaware of the user active on the BAP.
        /// </summary>
        /// <value>This is a unique value which persists across all API calls from &#x60;search&#x60; through &#x60;confirm&#x60;. This is done to indicate an active user session across multiple requests. The BPPs can use this value to push personalized recommendations, and dynamic offerings related to an ongoing transaction despite being unaware of the user active on the BAP.</value>

        [DataMember(Name = "transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// This is a unique value which persists during a request / callback cycle. Since beckn protocol APIs are asynchronous, BAPs need a common value to match an incoming callback from a BPP to an earlier call. This value can also be used to ignore duplicate messages coming from the BPP. It is recommended to generate a fresh message_id for every new interaction. When sending unsolicited callbacks, BPPs must generate a new message_id.
        /// </summary>
        /// <value>This is a unique value which persists during a request / callback cycle. Since beckn protocol APIs are asynchronous, BAPs need a common value to match an incoming callback from a BPP to an earlier call. This value can also be used to ignore duplicate messages coming from the BPP. It is recommended to generate a fresh message_id for every new interaction. When sending unsolicited callbacks, BPPs must generate a new message_id.</value>

        [DataMember(Name = "message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// Time of request generation in RFC3339 format
        /// </summary>
        /// <value>Time of request generation in RFC3339 format</value>

        [DataMember(Name = "timestamp")]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The encryption public key of the sender
        /// </summary>
        /// <value>The encryption public key of the sender</value>

        [DataMember(Name = "key")]
        public string Key { get; set; }

        /// <summary>
        /// The duration in ISO8601 format after timestamp for which this message holds valid
        /// </summary>
        /// <value>The duration in ISO8601 format after timestamp for which this message holds valid</value>

        [DataMember(Name = "ttl")]
        public string Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Context {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BapId: ").Append(BapId).Append("\n");
            sb.Append("  BapUri: ").Append(BapUri).Append("\n");
            sb.Append("  BppId: ").Append(BppId).Append("\n");
            sb.Append("  BppUri: ").Append(BppUri).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Context)obj);
        }

        /// <summary>
        /// Returns true if Context instances are equal
        /// </summary>
        /// <param name="other">Instance of Context to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Context other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Domain == other.Domain ||
                    (Domain != null &&
                    Domain.Equals(other.Domain))
                ) &&
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) &&
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.Equals(other.Action)
                ) &&
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                ) &&
                (
                    BapId == other.BapId ||
                    BapId != null &&
                    BapId.Equals(other.BapId)
                ) &&
                (
                    BapUri == other.BapUri ||
                    BapUri != null &&
                    BapUri.Equals(other.BapUri)
                ) &&
                (
                    BppId == other.BppId ||
                    BppId != null &&
                    BppId.Equals(other.BppId)
                ) &&
                (
                    BppUri == other.BppUri ||
                    BppUri != null &&
                    BppUri.Equals(other.BppUri)
                ) &&
                (
                    TransactionId == other.TransactionId ||
                    TransactionId != null &&
                    TransactionId.Equals(other.TransactionId)
                ) &&
                (
                    MessageId == other.MessageId ||
                    MessageId != null &&
                    MessageId.Equals(other.MessageId)
                ) &&
                (
                    Timestamp == other.Timestamp ||
                    Timestamp != null &&
                    Timestamp.Equals(other.Timestamp)
                ) &&
                (
                    Key == other.Key ||
                    Key != null &&
                    Key.Equals(other.Key)
                ) &&
                (
                    Ttl == other.Ttl ||
                    Ttl != null &&
                    Ttl.Equals(other.Ttl)
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
                if (Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();
                if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                if (BapId != null)
                    hashCode = hashCode * 59 + BapId.GetHashCode();
                if (BapUri != null)
                    hashCode = hashCode * 59 + BapUri.GetHashCode();
                if (BppId != null)
                    hashCode = hashCode * 59 + BppId.GetHashCode();
                if (BppUri != null)
                    hashCode = hashCode * 59 + BppUri.GetHashCode();
                if (TransactionId != null)
                    hashCode = hashCode * 59 + TransactionId.GetHashCode();
                if (MessageId != null)
                    hashCode = hashCode * 59 + MessageId.GetHashCode();
                if (Timestamp != null)
                    hashCode = hashCode * 59 + Timestamp.GetHashCode();
                if (Key != null)
                    hashCode = hashCode * 59 + Key.GetHashCode();
                if (Ttl != null)
                    hashCode = hashCode * 59 + Ttl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Context left, Context right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Context left, Context right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
