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
    ///     SmsInboundMessageResult
    /// </summary>
    [DataContract(Name = "SmsInboundMessageResult")]
    public class SmsInboundMessageResult : IEquatable<SmsInboundMessageResult>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsInboundMessageResult" /> class.
        /// </summary>
        /// <param name="messageCount">messageCount.</param>
        /// <param name="pendingMessageCount">pendingMessageCount.</param>
        /// <param name="results">results.</param>
        public SmsInboundMessageResult(int messageCount = default(int), int pendingMessageCount = default(int),
            List<SmsInboundMessage> results = default(List<SmsInboundMessage>))
        {
            MessageCount = messageCount;
            PendingMessageCount = pendingMessageCount;
            Results = results;
        }

        /// <summary>
        ///     Gets or Sets MessageCount
        /// </summary>
        [DataMember(Name = "messageCount", EmitDefaultValue = false)]
        public int MessageCount { get; set; }

        /// <summary>
        ///     Gets or Sets PendingMessageCount
        /// </summary>
        [DataMember(Name = "pendingMessageCount", EmitDefaultValue = false)]
        public int PendingMessageCount { get; set; }

        /// <summary>
        ///     Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<SmsInboundMessage> Results { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsInboundMessageResult {\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  PendingMessageCount: ").Append(PendingMessageCount).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return Equals(input as SmsInboundMessageResult);
        }

        /// <summary>
        ///     Returns true if SmsInboundMessageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsInboundMessageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsInboundMessageResult input)
        {
            if (input == null)
                return false;

            return
                (
                    MessageCount == input.MessageCount ||
                    MessageCount.Equals(input.MessageCount)
                ) &&
                (
                    PendingMessageCount == input.PendingMessageCount ||
                    PendingMessageCount.Equals(input.PendingMessageCount)
                ) &&
                (
                    Results == input.Results ||
                    Results != null &&
                    input.Results != null &&
                    Results.SequenceEqual(input.Results)
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
                hashCode = hashCode * 59 + MessageCount.GetHashCode();
                hashCode = hashCode * 59 + PendingMessageCount.GetHashCode();
                if (Results != null)
                    hashCode = hashCode * 59 + Results.GetHashCode();
                return hashCode;
            }
        }
    }
}