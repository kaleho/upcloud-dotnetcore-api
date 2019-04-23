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
    /// RestartServer
    /// </summary>
    [DataContract]
    public partial class RestartServer :  IEquatable<RestartServer>
    {
        /// <summary>
        /// Restart type
        /// </summary>
        /// <value>Restart type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StopTypeEnum
        {
            
            /// <summary>
            /// Enum Soft for value: soft
            /// </summary>
            [EnumMember(Value = "soft")]
            Soft = 1,
            
            /// <summary>
            /// Enum Hard for value: hard
            /// </summary>
            [EnumMember(Value = "hard")]
            Hard = 2
        }

        /// <summary>
        /// Restart type
        /// </summary>
        /// <value>Restart type</value>
        [DataMember(Name="stop_type", EmitDefaultValue=true)]
        public StopTypeEnum? StopType { get; set; }
        /// <summary>
        /// Action to take if timeout limit is exceeded.
        /// </summary>
        /// <value>Action to take if timeout limit is exceeded.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeoutActionEnum
        {
            
            /// <summary>
            /// Enum Destroy for value: destroy
            /// </summary>
            [EnumMember(Value = "destroy")]
            Destroy = 1,
            
            /// <summary>
            /// Enum Ignore for value: ignore
            /// </summary>
            [EnumMember(Value = "ignore")]
            Ignore = 2
        }

        /// <summary>
        /// Action to take if timeout limit is exceeded.
        /// </summary>
        /// <value>Action to take if timeout limit is exceeded.</value>
        [DataMember(Name="timeout_action", EmitDefaultValue=true)]
        public TimeoutActionEnum? TimeoutAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestartServer" /> class.
        /// </summary>
        /// <param name="stopType">Restart type (default to StopTypeEnum.Soft).</param>
        /// <param name="timeout">Stop timeout in seconds.</param>
        /// <param name="timeoutAction">Action to take if timeout limit is exceeded. (default to TimeoutActionEnum.Ignore).</param>
        public RestartServer(StopTypeEnum? stopType = StopTypeEnum.Soft, decimal? timeout = default(decimal?), TimeoutActionEnum? timeoutAction = TimeoutActionEnum.Ignore)
        {
            // use default value if no "stopType" provided
            if (stopType == null)
            {
                this.StopType = StopTypeEnum.Soft;
            }
            else
            {
                this.StopType = stopType;
            }
            this.Timeout = timeout;
            // use default value if no "timeoutAction" provided
            if (timeoutAction == null)
            {
                this.TimeoutAction = TimeoutActionEnum.Ignore;
            }
            else
            {
                this.TimeoutAction = timeoutAction;
            }
        }
        

        /// <summary>
        /// Stop timeout in seconds
        /// </summary>
        /// <value>Stop timeout in seconds</value>
        [DataMember(Name="timeout", EmitDefaultValue=true)]
        public decimal? Timeout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartServer {\n");
            sb.Append("  StopType: ").Append(StopType).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  TimeoutAction: ").Append(TimeoutAction).Append("\n");
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
            return this.Equals(input as RestartServer);
        }

        /// <summary>
        /// Returns true if RestartServer instances are equal
        /// </summary>
        /// <param name="input">Instance of RestartServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestartServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StopType == input.StopType ||
                    (this.StopType != null &&
                    this.StopType.Equals(input.StopType))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.TimeoutAction == input.TimeoutAction ||
                    (this.TimeoutAction != null &&
                    this.TimeoutAction.Equals(input.TimeoutAction))
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
                if (this.StopType != null)
                    hashCode = hashCode * 59 + this.StopType.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.TimeoutAction != null)
                    hashCode = hashCode * 59 + this.TimeoutAction.GetHashCode();
                return hashCode;
            }
        }
    }

}
