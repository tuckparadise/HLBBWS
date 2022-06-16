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
    ///     TfaUpdateMessageRequest
    /// </summary>
    [DataContract(Name = "TfaUpdateMessageRequest")]
    public class TfaUpdateMessageRequest : IEquatable<TfaUpdateMessageRequest>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaUpdateMessageRequest" /> class.
        /// </summary>
        /// <param name="language">
        ///     Language code of language in which message text is written. It is used for reading the message
        ///     when it is sent via voice. If no language is set, message will be read in &#x60;English&#x60;..
        /// </param>
        /// <param name="messageText">Text of a message that will be sent. Message text must contain &#x60;pinPlaceholder&#x60;..</param>
        /// <param name="pinLength">PIN code length..</param>
        /// <param name="pinType">
        ///     Type of PIN code that will be generated and sent as part of 2FA message. You can set PIN type to
        ///     numeric, alpha, alphanumeric or hex..
        /// </param>
        /// <param name="regional">
        ///     Region specific parameters, often specified by local laws. Use this if country or region that
        ///     you are sending SMS to requires some extra parameters..
        /// </param>
        /// <param name="repeatDTMF">In case PIN message is sent by Voice, DTMF code will enable replaying the message..</param>
        /// <param name="senderId">The name that will appear as the sender of the 2FA message (Example: CompanyName)..</param>
        /// <param name="speechRate">
        ///     In case PIN message is sent by Voice, the speed of speech can be set for the message.
        ///     Supported range is from &#x60;0.5&#x60; to &#x60;2&#x60;..
        /// </param>
        public TfaUpdateMessageRequest(TfaLanguage? language = default(TfaLanguage?),
            string messageText = default(string), int pinLength = default(int),
            TfaPinType? pinType = default(TfaPinType?), TfaRegionalOptions regional = default,
            string repeatDTMF = default(string), string senderId = default(string), double speechRate = default(double))
        {
            Language = language;
            MessageText = messageText;
            PinLength = pinLength;
            PinType = pinType;
            Regional = regional;
            RepeatDTMF = repeatDTMF;
            SenderId = senderId;
            SpeechRate = speechRate;
        }

        /// <summary>
        ///     Language code of language in which message text is written. It is used for reading the message when it is sent via
        ///     voice. If no language is set, message will be read in &#x60;English&#x60;.
        /// </summary>
        /// <value>
        ///     Language code of language in which message text is written. It is used for reading the message when it is sent
        ///     via voice. If no language is set, message will be read in &#x60;English&#x60;.
        /// </value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public TfaLanguage? Language { get; set; }

        /// <summary>
        ///     Type of PIN code that will be generated and sent as part of 2FA message. You can set PIN type to numeric, alpha,
        ///     alphanumeric or hex.
        /// </summary>
        /// <value>
        ///     Type of PIN code that will be generated and sent as part of 2FA message. You can set PIN type to numeric, alpha,
        ///     alphanumeric or hex.
        /// </value>
        [DataMember(Name = "pinType", EmitDefaultValue = false)]
        public TfaPinType? PinType { get; set; }

        /// <summary>
        ///     Text of a message that will be sent. Message text must contain &#x60;pinPlaceholder&#x60;.
        /// </summary>
        /// <value>Text of a message that will be sent. Message text must contain &#x60;pinPlaceholder&#x60;.</value>
        [DataMember(Name = "messageText", EmitDefaultValue = false)]
        public string MessageText { get; set; }

        /// <summary>
        ///     PIN code length.
        /// </summary>
        /// <value>PIN code length.</value>
        [DataMember(Name = "pinLength", EmitDefaultValue = false)]
        public int PinLength { get; set; }

        /// <summary>
        ///     Region specific parameters, often specified by local laws. Use this if country or region that you are sending SMS
        ///     to requires some extra parameters.
        /// </summary>
        /// <value>
        ///     Region specific parameters, often specified by local laws. Use this if country or region that you are sending
        ///     SMS to requires some extra parameters.
        /// </value>
        [DataMember(Name = "regional", EmitDefaultValue = false)]
        public TfaRegionalOptions Regional { get; set; }

        /// <summary>
        ///     In case PIN message is sent by Voice, DTMF code will enable replaying the message.
        /// </summary>
        /// <value>In case PIN message is sent by Voice, DTMF code will enable replaying the message.</value>
        [DataMember(Name = "repeatDTMF", EmitDefaultValue = false)]
        public string RepeatDTMF { get; set; }

        /// <summary>
        ///     The name that will appear as the sender of the 2FA message (Example: CompanyName).
        /// </summary>
        /// <value>The name that will appear as the sender of the 2FA message (Example: CompanyName).</value>
        [DataMember(Name = "senderId", EmitDefaultValue = false)]
        public string SenderId { get; set; }

        /// <summary>
        ///     In case PIN message is sent by Voice, the speed of speech can be set for the message. Supported range is from
        ///     &#x60;0.5&#x60; to &#x60;2&#x60;.
        /// </summary>
        /// <value>
        ///     In case PIN message is sent by Voice, the speed of speech can be set for the message. Supported range is from
        ///     &#x60;0.5&#x60; to &#x60;2&#x60;.
        /// </value>
        [DataMember(Name = "speechRate", EmitDefaultValue = false)]
        public double SpeechRate { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaUpdateMessageRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MessageText: ").Append(MessageText).Append("\n");
            sb.Append("  PinLength: ").Append(PinLength).Append("\n");
            sb.Append("  PinType: ").Append(PinType).Append("\n");
            sb.Append("  Regional: ").Append(Regional).Append("\n");
            sb.Append("  RepeatDTMF: ").Append(RepeatDTMF).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  SpeechRate: ").Append(SpeechRate).Append("\n");
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
            return Equals(input as TfaUpdateMessageRequest);
        }

        /// <summary>
        ///     Returns true if TfaUpdateMessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaUpdateMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaUpdateMessageRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    Language == input.Language ||
                    Language.Equals(input.Language)
                ) &&
                (
                    MessageText == input.MessageText ||
                    MessageText != null &&
                    MessageText.Equals(input.MessageText)
                ) &&
                (
                    PinLength == input.PinLength ||
                    PinLength.Equals(input.PinLength)
                ) &&
                (
                    PinType == input.PinType ||
                    PinType.Equals(input.PinType)
                ) &&
                (
                    Regional == input.Regional ||
                    Regional != null &&
                    Regional.Equals(input.Regional)
                ) &&
                (
                    RepeatDTMF == input.RepeatDTMF ||
                    RepeatDTMF != null &&
                    RepeatDTMF.Equals(input.RepeatDTMF)
                ) &&
                (
                    SenderId == input.SenderId ||
                    SenderId != null &&
                    SenderId.Equals(input.SenderId)
                ) &&
                (
                    SpeechRate == input.SpeechRate ||
                    SpeechRate.Equals(input.SpeechRate)
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
                hashCode = hashCode * 59 + Language.GetHashCode();
                if (MessageText != null)
                    hashCode = hashCode * 59 + MessageText.GetHashCode();
                hashCode = hashCode * 59 + PinLength.GetHashCode();
                hashCode = hashCode * 59 + PinType.GetHashCode();
                if (Regional != null)
                    hashCode = hashCode * 59 + Regional.GetHashCode();
                if (RepeatDTMF != null)
                    hashCode = hashCode * 59 + RepeatDTMF.GetHashCode();
                if (SenderId != null)
                    hashCode = hashCode * 59 + SenderId.GetHashCode();
                hashCode = hashCode * 59 + SpeechRate.GetHashCode();
                return hashCode;
            }
        }
    }
}