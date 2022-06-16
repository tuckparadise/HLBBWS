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
    ///     SmsDeliveryTime
    /// </summary>
    [DataContract(Name = "SmsDeliveryTime")]
    public class SmsDeliveryTime : IEquatable<SmsDeliveryTime>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsDeliveryTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsDeliveryTime()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsDeliveryTime" /> class.
        /// </summary>
        /// <param name="hour">
        ///     Hour when the time window opens when used in from property or closes when used into the property.
        ///     (required).
        /// </param>
        /// <param name="minute">
        ///     Minute when the time window opens when used in from property or closes when used into the
        ///     property. (required).
        /// </param>
        public SmsDeliveryTime(int hour = default(int), int minute = default(int))
        {
            Hour = hour;
            Minute = minute;
        }

        /// <summary>
        ///     Hour when the time window opens when used in from property or closes when used into the property.
        /// </summary>
        /// <value>Hour when the time window opens when used in from property or closes when used into the property.</value>
        [DataMember(Name = "hour", IsRequired = true, EmitDefaultValue = false)]
        public int Hour { get; set; }

        /// <summary>
        ///     Minute when the time window opens when used in from property or closes when used into the property.
        /// </summary>
        /// <value>Minute when the time window opens when used in from property or closes when used into the property.</value>
        [DataMember(Name = "minute", IsRequired = true, EmitDefaultValue = false)]
        public int Minute { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsDeliveryTime {\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Minute: ").Append(Minute).Append("\n");
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
            return Equals(input as SmsDeliveryTime);
        }

        /// <summary>
        ///     Returns true if SmsDeliveryTime instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsDeliveryTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsDeliveryTime input)
        {
            if (input == null)
                return false;

            return
                (
                    Hour == input.Hour ||
                    Hour.Equals(input.Hour)
                ) &&
                (
                    Minute == input.Minute ||
                    Minute.Equals(input.Minute)
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
                hashCode = hashCode * 59 + Hour.GetHashCode();
                hashCode = hashCode * 59 + Minute.GetHashCode();
                return hashCode;
            }
        }
    }
}