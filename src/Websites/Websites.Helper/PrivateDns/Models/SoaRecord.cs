// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Helper.PrivateDns.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An SOA record.
    /// </summary>
    public partial class SoaRecord
    {
        /// <summary>
        /// Initializes a new instance of the SoaRecord class.
        /// </summary>
        public SoaRecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SoaRecord class.
        /// </summary>
        /// <param name="host">The domain name of the authoritative name server
        /// for this SOA record.</param>
        /// <param name="email">The email contact for this SOA record.</param>
        /// <param name="serialNumber">The serial number for this SOA
        /// record.</param>
        /// <param name="refreshTime">The refresh value for this SOA
        /// record.</param>
        /// <param name="retryTime">The retry time for this SOA record.</param>
        /// <param name="expireTime">The expire time for this SOA
        /// record.</param>
        /// <param name="minimumTtl">The minimum value for this SOA record. By
        /// convention this is used to determine the negative caching
        /// duration.</param>
        public SoaRecord(string host = default(string), string email = default(string), long? serialNumber = default(long?), long? refreshTime = default(long?), long? retryTime = default(long?), long? expireTime = default(long?), long? minimumTtl = default(long?))
        {
            Host = host;
            Email = email;
            SerialNumber = serialNumber;
            RefreshTime = refreshTime;
            RetryTime = retryTime;
            ExpireTime = expireTime;
            MinimumTtl = minimumTtl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the domain name of the authoritative name server for
        /// this SOA record.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the email contact for this SOA record.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the serial number for this SOA record.
        /// </summary>
        [JsonProperty(PropertyName = "serialNumber")]
        public long? SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the refresh value for this SOA record.
        /// </summary>
        [JsonProperty(PropertyName = "refreshTime")]
        public long? RefreshTime { get; set; }

        /// <summary>
        /// Gets or sets the retry time for this SOA record.
        /// </summary>
        [JsonProperty(PropertyName = "retryTime")]
        public long? RetryTime { get; set; }

        /// <summary>
        /// Gets or sets the expire time for this SOA record.
        /// </summary>
        [JsonProperty(PropertyName = "expireTime")]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// Gets or sets the minimum value for this SOA record. By convention
        /// this is used to determine the negative caching duration.
        /// </summary>
        [JsonProperty(PropertyName = "minimumTtl")]
        public long? MinimumTtl { get; set; }

    }
}
