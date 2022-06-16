﻿/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     Defines Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmailBulkStatus
    {
        /// <summary>
        ///     Enum Pending for value: PENDING
        /// </summary>
        [EnumMember(Value = "PENDING")] Pending = 1,

        /// <summary>
        ///     Enum Paused for value: PAUSED
        /// </summary>
        [EnumMember(Value = "PAUSED")] Paused = 2,

        /// <summary>
        ///     Enum Processing for value: PROCESSING
        /// </summary>
        [EnumMember(Value = "PROCESSING")] Processing = 3,

        /// <summary>
        ///     Enum Canceled for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")] Canceled = 4,

        /// <summary>
        ///     Enum Finished for value: FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")] Finished = 5,

        /// <summary>
        ///     Enum Failed for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")] Failed = 6
    }
}