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
    ///     TfaApplicationRequest
    /// </summary>
    [DataContract(Name = "TfaApplicationRequest")]
    public class TfaApplicationRequest : IEquatable<TfaApplicationRequest>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaApplicationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TfaApplicationRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TfaApplicationRequest" /> class.
        /// </summary>
        /// <param name="configuration">Created 2FA application configuration..</param>
        /// <param name="enabled">Indicates if the created application is enabled..</param>
        /// <param name="name">2FA application name. (required).</param>
        public TfaApplicationRequest(TfaApplicationConfiguration configuration = default, bool enabled = default(bool),
            string name = default(string))
        {
            // to ensure "name" is required (not null)
            Name = name ?? throw new ArgumentNullException("name");
            Configuration = configuration;
            Enabled = enabled;
        }

        /// <summary>
        ///     Created 2FA application configuration.
        /// </summary>
        /// <value>Created 2FA application configuration.</value>
        [DataMember(Name = "configuration", EmitDefaultValue = false)]
        public TfaApplicationConfiguration Configuration { get; set; }

        /// <summary>
        ///     Indicates if the created application is enabled.
        /// </summary>
        /// <value>Indicates if the created application is enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        ///     2FA application name.
        /// </summary>
        /// <value>2FA application name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaApplicationRequest {\n");
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
            return Equals(input as TfaApplicationRequest);
        }

        /// <summary>
        ///     Returns true if TfaApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TfaApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TfaApplicationRequest input)
        {
            if (input == null)
                return false;

            return
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