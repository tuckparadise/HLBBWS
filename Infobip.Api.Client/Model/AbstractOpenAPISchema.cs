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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     Abstract base class for oneOf, anyOf schemas in the OpenAPI specification
    /// </summary>
    public abstract class AbstractOpenAPISchema
    {
        /// <summary>
        ///     Custom JSON serializer
        /// </summary>
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            MissingMemberHandling = MissingMemberHandling.Error,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        ///     Custom JSON serializer for objects with additional properties
        /// </summary>
        public static readonly JsonSerializerSettings AdditionalPropertiesSerializerSettings =
            new JsonSerializerSettings
            {
                // OpenAPI generated types generally hide default constructors.
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy
                    {
                        OverrideSpecifiedNames = false
                    }
                }
            };

        /// <summary>
        ///     Gets or Sets the actual instance
        /// </summary>
        public abstract object ActualInstance { get; set; }

        /// <summary>
        ///     Gets or Sets IsNullable to indicate whether the instance is nullable
        /// </summary>
        public bool IsNullable { get; protected set; }

        /// <summary>
        ///     Gets or Sets the schema type, which can be either `oneOf` or `anyOf`
        /// </summary>
        public string SchemaType { get; protected set; }

        /// <summary>
        ///     Converts the instance into JSON string.
        /// </summary>
        public abstract string ToJson();
    }
}