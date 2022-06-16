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
    ///     SmsApiRequestError
    /// </summary>
    [DataContract(Name = "SmsApiRequestError")]
    public class SmsApiRequestError : IEquatable<SmsApiRequestError>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsApiRequestError" /> class.
        /// </summary>
        /// <param name="serviceException">serviceException.</param>
        public SmsApiRequestError(SmsApiRequestErrorDetails serviceException = default)
        {
            ServiceException = serviceException;
        }

        /// <summary>
        ///     Gets or Sets ServiceException
        /// </summary>
        [DataMember(Name = "serviceException", EmitDefaultValue = false)]
        public SmsApiRequestErrorDetails ServiceException { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsApiRequestError {\n");
            sb.Append("  ServiceException: ").Append(ServiceException).Append("\n");
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
            return Equals(input as SmsApiRequestError);
        }

        /// <summary>
        ///     Returns true if SmsApiRequestError instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsApiRequestError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsApiRequestError input)
        {
            if (input == null)
                return false;

            return
                ServiceException == input.ServiceException ||
                ServiceException != null &&
                ServiceException.Equals(input.ServiceException);
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
                if (ServiceException != null)
                    hashCode = hashCode * 59 + ServiceException.GetHashCode();
                return hashCode;
            }
        }
    }
}