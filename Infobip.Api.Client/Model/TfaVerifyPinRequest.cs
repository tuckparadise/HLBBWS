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
    ///     TfaVerifyPinRequest
    /// </summary>
    [DataContract(Name = "TfaVerifyPinRequest")]
    public class TfaVerifyPinRequest : IEquatable<TfaVerifyPinRequest>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaVerifyPinRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TfaVerifyPinRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaVerifyPinRequest" /> class.
        /// </summary>
        /// <param name="pin">PIN code to verify (required).</param>
        public TfaVerifyPinRequest(string pin = default(string))
        {
            // to ensure "pin" is required (not null)
            Pin = pin ?? throw new ArgumentNullException("pin");
        }

        /// <summary>
        ///     PIN code to verify
        /// </summary>
        /// <value>PIN code to verify</value>
        [DataMember(Name = "pin", IsRequired = true, EmitDefaultValue = false)]
        public string Pin { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaVerifyPinRequest {\n");
            sb.Append("  Pin: ").Append(Pin).Append("\n");
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
            return Equals(input as TfaVerifyPinRequest);
        }

        /// <summary>
        ///     Returns true if TfaVerifyPinRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaVerifyPinRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaVerifyPinRequest input)
        {
            if (input == null)
                return false;

            return
                Pin == input.Pin ||
                Pin != null &&
                Pin.Equals(input.Pin);
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
                if (Pin != null)
                    hashCode = hashCode * 59 + Pin.GetHashCode();
                return hashCode;
            }
        }
    }
}