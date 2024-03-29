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
    ///     TfaApplicationResponse
    /// </summary>
    [DataContract(Name = "TfaApplicationResponse")]
    public class TfaApplicationResponse : IEquatable<TfaApplicationResponse>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaApplicationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TfaApplicationResponse()
        {
        }

        /// <summary>
        ///     2FA application ID.
        /// </summary>
        /// <value>2FA application ID.</value>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public string ApplicationId { get; private set; }

        /// <summary>
        ///     Created 2FA application configuration.
        /// </summary>
        /// <value>Created 2FA application configuration.</value>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public TfaApplicationConfiguration Configuration { get; private set; }

        /// <summary>
        ///     Indicates if the created application is enabled.
        /// </summary>
        /// <value>Indicates if the created application is enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; private set; }

        /// <summary>
        ///     2FA application name.
        /// </summary>
        /// <value>2FA application name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        ///     Returns false as ApplicationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApplicationId()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as Configuration should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfiguration()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as Enabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEnabled()
        {
            return false;
        }

        /// <summary>
        ///     Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
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
            sb.Append("class TfaApplicationResponse {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return Equals(input as TfaApplicationResponse);
        }

        /// <summary>
        ///     Returns true if TfaApplicationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaApplicationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaApplicationResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    ApplicationId == input.ApplicationId ||
                    ApplicationId != null &&
                    ApplicationId.Equals(input.ApplicationId)
                ) &&
                (
                    Configuration == input.Configuration ||
                    Configuration != null &&
                    Configuration.Equals(input.Configuration)
                ) &&
                (
                    Enabled == input.Enabled ||
                    Enabled.Equals(input.Enabled)
                ) &&
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
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
                if (ApplicationId != null)
                    hashCode = hashCode * 59 + ApplicationId.GetHashCode();
                if (Configuration != null)
                    hashCode = hashCode * 59 + Configuration.GetHashCode();
                hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                return hashCode;
            }
        }
    }
}