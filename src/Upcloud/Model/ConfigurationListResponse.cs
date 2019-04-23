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
    /// ConfigurationListResponse
    /// </summary>
    [DataContract]
    public partial class ConfigurationListResponse :  IEquatable<ConfigurationListResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationListResponse" /> class.
        /// </summary>
        /// <param name="serverSizes">serverSizes.</param>
        public ConfigurationListResponse(ConfigurationListResponseServerSizes serverSizes = default(ConfigurationListResponseServerSizes))
        {
            this.ServerSizes = serverSizes;
        }
        
        /// <summary>
        /// Gets or Sets ServerSizes
        /// </summary>
        [DataMember(Name="server_sizes", EmitDefaultValue=true)]
        public ConfigurationListResponseServerSizes ServerSizes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationListResponse {\n");
            sb.Append("  ServerSizes: ").Append(ServerSizes).Append("\n");
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
            return this.Equals(input as ConfigurationListResponse);
        }

        /// <summary>
        /// Returns true if ConfigurationListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurationListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerSizes == input.ServerSizes ||
                    (this.ServerSizes != null &&
                    this.ServerSizes.Equals(input.ServerSizes))
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
                if (this.ServerSizes != null)
                    hashCode = hashCode * 59 + this.ServerSizes.GetHashCode();
                return hashCode;
            }
        }
    }

}