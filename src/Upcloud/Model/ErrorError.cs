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
    /// ErrorError
    /// </summary>
    [DataContract]
    public partial class ErrorError :  IEquatable<ErrorError>
    {
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="error_code", EmitDefaultValue=true)]
        public ErrorCode? ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets ErrorStatus
        /// </summary>
        [DataMember(Name="error_status", EmitDefaultValue=true)]
        public ErrorStatus? ErrorStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorError" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorStatus">errorStatus.</param>
        public ErrorError(ErrorCode? errorCode = default(ErrorCode?), ErrorStatus? errorStatus = default(ErrorStatus?))
        {
            this.ErrorCode = errorCode;
            this.ErrorStatus = errorStatus;
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorError {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorStatus: ").Append(ErrorStatus).Append("\n");
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
            return this.Equals(input as ErrorError);
        }

        /// <summary>
        /// Returns true if ErrorError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
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
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorStatus != null)
                    hashCode = hashCode * 59 + this.ErrorStatus.GetHashCode();
                return hashCode;
            }
        }
    }

}
