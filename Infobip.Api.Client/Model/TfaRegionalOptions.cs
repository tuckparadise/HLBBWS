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
    ///     TfaRegionalOptions
    /// </summary>
    [DataContract(Name = "TfaRegionalOptions")]
    public class TfaRegionalOptions : IEquatable<TfaRegionalOptions>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaRegionalOptions" /> class.
        /// </summary>
        /// <param name="indiaDlt">
        ///     Distributed Ledger Technology (DLT) specific parameters required for sending SMS to phone
        ///     numbers registered in India..
        /// </param>
        public TfaRegionalOptions(TfaIndiaDltOptions indiaDlt = default)
        {
            IndiaDlt = indiaDlt;
        }

        /// <summary>
        ///     Distributed Ledger Technology (DLT) specific parameters required for sending SMS to phone numbers registered in
        ///     India.
        /// </summary>
        /// <value>
        ///     Distributed Ledger Technology (DLT) specific parameters required for sending SMS to phone numbers registered in
        ///     India.
        /// </value>
        [DataMember(Name = "indiaDlt", EmitDefaultValue = false)]
        public TfaIndiaDltOptions IndiaDlt { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaRegionalOptions {\n");
            sb.Append("  IndiaDlt: ").Append(IndiaDlt).Append("\n");
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
            return Equals(input as TfaRegionalOptions);
        }

        /// <summary>
        ///     Returns true if TfaRegionalOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaRegionalOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaRegionalOptions input)
        {
            if (input == null)
                return false;

            return
                IndiaDlt == input.IndiaDlt ||
                IndiaDlt != null &&
                IndiaDlt.Equals(input.IndiaDlt);
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
                if (IndiaDlt != null)
                    hashCode = hashCode * 59 + IndiaDlt.GetHashCode();
                return hashCode;
            }
        }
    }
}