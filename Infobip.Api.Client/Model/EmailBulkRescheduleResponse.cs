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
    ///     EmailBulkRescheduleResponse
    /// </summary>
    [DataContract(Name = "EmailBulkRescheduleResponse")]
    public class EmailBulkRescheduleResponse : IEquatable<EmailBulkRescheduleResponse>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailBulkRescheduleResponse" /> class.
        /// </summary>
        /// <param name="bulkId">bulkId.</param>
        /// <param name="sendAt">sendAt.</param>
        public EmailBulkRescheduleResponse(string bulkId = default(string),
            DateTimeOffset sendAt = default(DateTimeOffset))
        {
            BulkId = bulkId;
            SendAt = sendAt;
        }

        /// <summary>
        ///     Gets or Sets BulkId
        /// </summary>
        [DataMember(Name = "bulkId", EmitDefaultValue = false)]
        public string BulkId { get; set; }

        /// <summary>
        ///     Gets or Sets SendAt
        /// </summary>
        [DataMember(Name = "sendAt", EmitDefaultValue = false)]
        public DateTimeOffset SendAt { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailBulkRescheduleResponse {\n");
            sb.Append("  BulkId: ").Append(BulkId).Append("\n");
            sb.Append("  SendAt: ").Append(SendAt).Append("\n");
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
            return Equals(input as EmailBulkRescheduleResponse);
        }

        /// <summary>
        ///     Returns true if EmailBulkRescheduleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailBulkRescheduleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailBulkRescheduleResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    BulkId == input.BulkId ||
                    BulkId != null &&
                    BulkId.Equals(input.BulkId)
                ) &&
                (
                    SendAt == input.SendAt ||
                    SendAt != null &&
                    SendAt.Equals(input.SendAt)
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
                if (BulkId != null)
                    hashCode = hashCode * 59 + BulkId.GetHashCode();
                if (SendAt != null)
                    hashCode = hashCode * 59 + SendAt.GetHashCode();
                return hashCode;
            }
        }
    }
}