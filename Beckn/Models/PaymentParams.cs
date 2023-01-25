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
    /// 
    /// </summary>
    [DataContract]
    public partial class PaymentParams : IEquatable<PaymentParams>
    { 
        /// <summary>
        /// The reference transaction ID associated with a payment activity
        /// </summary>
        /// <value>The reference transaction ID associated with a payment activity</value>

        [DataMember(Name="transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>

        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>

        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>

        [DataMember(Name="bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountNumber
        /// </summary>

        [DataMember(Name="bank_account_number")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets VirtualPaymentAddress
        /// </summary>

        [DataMember(Name="virtual_payment_address")]
        public string VirtualPaymentAddress { get; set; }

        /// <summary>
        /// Gets or Sets SourceBankCode
        /// </summary>

        [DataMember(Name="source_bank_code")]
        public string SourceBankCode { get; set; }

        /// <summary>
        /// Gets or Sets SourceBankAccountNumber
        /// </summary>

        [DataMember(Name="source_bank_account_number")]
        public string SourceBankAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets SourceVirtualPaymentAddress
        /// </summary>

        [DataMember(Name="source_virtual_payment_address")]
        public string SourceVirtualPaymentAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentParams {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  VirtualPaymentAddress: ").Append(VirtualPaymentAddress).Append("\n");
            sb.Append("  SourceBankCode: ").Append(SourceBankCode).Append("\n");
            sb.Append("  SourceBankAccountNumber: ").Append(SourceBankAccountNumber).Append("\n");
            sb.Append("  SourceVirtualPaymentAddress: ").Append(SourceVirtualPaymentAddress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PaymentParams)obj);
        }

        /// <summary>
        /// Returns true if PaymentParams instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentParams other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TransactionId == other.TransactionId ||
                    TransactionId != null &&
                    TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    BankCode == other.BankCode ||
                    BankCode != null &&
                    BankCode.Equals(other.BankCode)
                ) && 
                (
                    BankAccountNumber == other.BankAccountNumber ||
                    BankAccountNumber != null &&
                    BankAccountNumber.Equals(other.BankAccountNumber)
                ) && 
                (
                    VirtualPaymentAddress == other.VirtualPaymentAddress ||
                    VirtualPaymentAddress != null &&
                    VirtualPaymentAddress.Equals(other.VirtualPaymentAddress)
                ) && 
                (
                    SourceBankCode == other.SourceBankCode ||
                    SourceBankCode != null &&
                    SourceBankCode.Equals(other.SourceBankCode)
                ) && 
                (
                    SourceBankAccountNumber == other.SourceBankAccountNumber ||
                    SourceBankAccountNumber != null &&
                    SourceBankAccountNumber.Equals(other.SourceBankAccountNumber)
                ) && 
                (
                    SourceVirtualPaymentAddress == other.SourceVirtualPaymentAddress ||
                    SourceVirtualPaymentAddress != null &&
                    SourceVirtualPaymentAddress.Equals(other.SourceVirtualPaymentAddress)
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
                    if (TransactionId != null)
                    hashCode = hashCode * 59 + TransactionId.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (BankCode != null)
                    hashCode = hashCode * 59 + BankCode.GetHashCode();
                    if (BankAccountNumber != null)
                    hashCode = hashCode * 59 + BankAccountNumber.GetHashCode();
                    if (VirtualPaymentAddress != null)
                    hashCode = hashCode * 59 + VirtualPaymentAddress.GetHashCode();
                    if (SourceBankCode != null)
                    hashCode = hashCode * 59 + SourceBankCode.GetHashCode();
                    if (SourceBankAccountNumber != null)
                    hashCode = hashCode * 59 + SourceBankAccountNumber.GetHashCode();
                    if (SourceVirtualPaymentAddress != null)
                    hashCode = hashCode * 59 + SourceVirtualPaymentAddress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PaymentParams left, PaymentParams right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PaymentParams left, PaymentParams right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
