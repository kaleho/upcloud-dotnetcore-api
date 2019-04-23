/* 
 * Upcloud api
 *
 * The UpCloud API consists of operations used to control resources on UpCloud. The API is a web service interface. HTTPS is used to connect to the API. The API follows the principles of a RESTful web service wherever possible. The base URL for all API operations is  https://api.upcloud.com/. All API operations require authentication.
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Upcloud.Client.SwaggerDateConverter;

namespace Upcloud.Model
{
    /// <summary>
    /// IpAddressListResponse
    /// </summary>
    [DataContract]
    public partial class IpAddressListResponse :  IEquatable<IpAddressListResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpAddressListResponse" /> class.
        /// </summary>
        /// <param name="ipAddresses">ipAddresses.</param>
        public IpAddressListResponse(IpAddresses ipAddresses = default(IpAddresses))
        {
            this.IpAddresses = ipAddresses;
        }
        
        /// <summary>
        /// Gets or Sets IpAddresses
        /// </summary>
        [DataMember(Name="ip_addresses", EmitDefaultValue=true)]
        public IpAddresses IpAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpAddressListResponse {\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpAddressListResponse);
        }

        /// <summary>
        /// Returns true if IpAddressListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IpAddressListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpAddressListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpAddresses == input.IpAddresses ||
                    (this.IpAddresses != null &&
                    this.IpAddresses.Equals(input.IpAddresses))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IpAddresses != null)
                    hashCode = hashCode * 59 + this.IpAddresses.GetHashCode();
                return hashCode;
            }
        }
    }

}