/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     TfaVerification
    /// </summary>
    [DataContract(Name = "TfaVerification")]
    public class TfaVerification : IEquatable<TfaVerification>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaVerification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TfaVerification()
        {
        }

        /// <summary>
        ///     Phone number (MSISDN) for which verification status is checked.
        /// </summary>
        /// <value>Phone number (MSISDN) for which verification status is checked.</value>
        [DataMember(Name = "msisdn", EmitDefaultValue = false)]
        public string Msisdn { get; private set; }

        /// <summary>
        ///     Sent UNIX timestamp (in millis), if the phone number (MSISDN) is verified.
        /// </summary>
        /// <value>Sent UNIX timestamp (in millis), if the phone number (MSISDN) is verified.</value>
        [DataMember(Name = "sentAt", EmitDefaultValue = false)]
        public long SentAt { get; private set; }

        /// <summary>
        ///     Indicates if the phone number (MSISDN) is already verified for 2FA application with given ID.
        /// </summary>
        /// <value>Indicates if the phone number (MSISDN) is already verified for 2FA application with given ID.</value>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; private set; }

        /// <summary>
        ///     Verification UNIX timestamp (in millis), if the phone number (MSISDN) is verified.
        /// </summary>
        /// <value>Verification UNIX timestamp (in millis), if the phone number (MSISDN) is verified.</value>
        [DataMember(Name = "verifiedAt", EmitDefaultValue = false)]
        public long VerifiedAt { get; private set; }

        /// <summary>
        ///     Returns false as Msisdn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMsisdn()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as SentAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSentAt()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as Verified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerified()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as VerifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerifiedAt()
        {
            return false;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaVerification {\n");
            sb.Append("  Msisdn: ").Append(Msisdn).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  VerifiedAt: ").Append(VerifiedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as TfaVerification);
        }

        /// <summary>
        ///     Returns true if TfaVerification instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaVerification input)
        {
            if (input == null)
                return false;

            return
                (
                    Msisdn == input.Msisdn ||
                    Msisdn != null &&
                    Msisdn.Equals(input.Msisdn)
                ) &&
                (
                    SentAt == input.SentAt ||
                    SentAt.Equals(input.SentAt)
                ) &&
                (
                    Verified == input.Verified ||
                    Verified.Equals(input.Verified)
                ) &&
                (
                    VerifiedAt == input.VerifiedAt ||
                    VerifiedAt.Equals(input.VerifiedAt)
                );
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Msisdn != null)
                    hashCode = hashCode * 59 + Msisdn.GetHashCode();
                hashCode = hashCode * 59 + SentAt.GetHashCode();
                hashCode = hashCode * 59 + Verified.GetHashCode();
                hashCode = hashCode * 59 + VerifiedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}