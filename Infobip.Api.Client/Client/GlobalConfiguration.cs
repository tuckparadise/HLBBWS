/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System.Collections.Generic;

namespace Infobip.Api.Client
{
    /// <summary>
    ///     <see cref="GlobalConfiguration" /> provides a compile-time extension point for globally configuring
    ///     API Clients.
    /// </summary>
    /// <remarks>
    ///     A customized implementation via partial class may reside in another file and may
    ///     be excluded from automatic generation via a .openapi-generator-ignore file.
    /// </remarks>
    public class GlobalConfiguration : Configuration
    {
        /// <summary>
        ///     Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static IReadableConfiguration Instance
        {
            get => _globalConfiguration;
            set
            {
                lock (GlobalConfigSync)
                {
                    _globalConfiguration = value;
                }
            }
        }

        #region Private Members

        private static readonly object GlobalConfigSync = new { };
        private static IReadableConfiguration _globalConfiguration;

        #endregion Private Members

        #region Constructors

        /// <inheritdoc />
        private GlobalConfiguration()
        {
        }

        /// <inheritdoc />
        public GlobalConfiguration(IDictionary<string, string> defaultHeader, string apiKey, string apiKeyPrefix,
            string basePath = "http://localhost:3000/api") : base(defaultHeader, apiKey, apiKeyPrefix, basePath)
        {
        }

        static GlobalConfiguration()
        {
            Instance = new GlobalConfiguration();
        }

        #endregion Constructors
    }
}