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
    /// AvailablePlanListResponsePlans
    /// </summary>
    [DataContract]
    public partial class AvailablePlanListResponsePlans :  IEquatable<AvailablePlanListResponsePlans>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePlanListResponsePlans" /> class.
        /// </summary>
        /// <param name="plan">plan.</param>
        public AvailablePlanListResponsePlans(List<Plan> plan = default(List<Plan>))
        {
            this.Plan = plan;
        }
        
        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public List<Plan> Plan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailablePlanListResponsePlans {\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
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
            return this.Equals(input as AvailablePlanListResponsePlans);
        }

        /// <summary>
        /// Returns true if AvailablePlanListResponsePlans instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailablePlanListResponsePlans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailablePlanListResponsePlans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Plan == input.Plan ||
                    this.Plan != null &&
                    this.Plan.SequenceEqual(input.Plan)
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
                if (this.Plan != null)
                    hashCode = hashCode * 59 + this.Plan.GetHashCode();
                return hashCode;
            }
        }
    }

}
