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
    ///     SmsIndiaDltOptions
    /// </summary>
    [DataContract(Name = "SmsIndiaDltOptions")]
    public class SmsIndiaDltOptions : IEquatable<SmsIndiaDltOptions>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsIndiaDltOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsIndiaDltOptions()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsIndiaDltOptions" /> class.
        /// </summary>
        /// <param name="contentTemplateId">Id of your registered DTL content template that matches this message&#39;s text..</param>
        /// <param name="principalEntityId">Your assigned DTL principal entity id. (required).</param>
        public SmsIndiaDltOptions(string contentTemplateId = default(string),
            string principalEntityId = default(string))
        {
            // to ensure "principalEntityId" is required (not null)
            PrincipalEntityId = principalEntityId ?? throw new ArgumentNullException("principalEntityId");
            ContentTemplateId = contentTemplateId;
        }

        /// <summary>
        ///     Id of your registered DTL content template that matches this message&#39;s text.
        /// </summary>
        /// <value>Id of your registered DTL content template that matches this message&#39;s text.</value>
        [DataMember(Name = "contentTemplateId", EmitDefaultValue = false)]
        public string ContentTemplateId { get; set; }

        /// <summary>
        ///     Your assigned DTL principal entity id.
        /// </summary>
        /// <value>Your assigned DTL principal entity id.</value>
        [DataMember(Name = "principalEntityId", IsRequired = true, EmitDefaultValue = false)]
        public string PrincipalEntityId { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsIndiaDltOptions {\n");
            sb.Append("  ContentTemplateId: ").Append(ContentTemplateId).Append("\n");
            sb.Append("  PrincipalEntityId: ").Append(PrincipalEntityId).Append("\n");
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
            return Equals(input as SmsIndiaDltOptions);
        }

        /// <summary>
        ///     Returns true if SmsIndiaDltOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsIndiaDltOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsIndiaDltOptions input)
        {
            if (input == null)
                return false;

            return
                (
                    ContentTemplateId == input.ContentTemplateId ||
                    ContentTemplateId != null &&
                    ContentTemplateId.Equals(input.ContentTemplateId)
                ) &&
                (
                    PrincipalEntityId == input.PrincipalEntityId ||
                    PrincipalEntityId != null &&
                    PrincipalEntityId.Equals(input.PrincipalEntityId)
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
                if (ContentTemplateId != null)
                    hashCode = hashCode * 59 + ContentTemplateId.GetHashCode();
                if (PrincipalEntityId != null)
                    hashCode = hashCode * 59 + PrincipalEntityId.GetHashCode();
                return hashCode;
            }
        }
    }
}