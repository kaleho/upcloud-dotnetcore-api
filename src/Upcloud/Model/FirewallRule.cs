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
    /// FirewallRule
    /// </summary>
    [DataContract]
    public partial class FirewallRule :  IEquatable<FirewallRule>
    {
        /// <summary>
        /// The direction of network traffic this rule will be applied to.
        /// </summary>
        /// <value>The direction of network traffic this rule will be applied to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            
            /// <summary>
            /// Enum In for value: in
            /// </summary>
            [EnumMember(Value = "in")]
            In = 1,
            
            /// <summary>
            /// Enum Out for value: out
            /// </summary>
            [EnumMember(Value = "out")]
            Out = 2
        }

        /// <summary>
        /// The direction of network traffic this rule will be applied to.
        /// </summary>
        /// <value>The direction of network traffic this rule will be applied to.</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Action to take if the rule conditions are met.
        /// </summary>
        /// <value>Action to take if the rule conditions are met.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Accept for value: accept
            /// </summary>
            [EnumMember(Value = "accept")]
            Accept = 1,
            
            /// <summary>
            /// Enum Reject for value: reject
            /// </summary>
            [EnumMember(Value = "reject")]
            Reject = 2,
            
            /// <summary>
            /// Enum Drop for value: drop
            /// </summary>
            [EnumMember(Value = "drop")]
            Drop = 3
        }

        /// <summary>
        /// Action to take if the rule conditions are met.
        /// </summary>
        /// <value>Action to take if the rule conditions are met.</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public AddressFamily? Family { get; set; }
        /// <summary>
        /// The protocol this rule will be applied to.
        /// </summary>
        /// <value>The protocol this rule will be applied to.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProtocolEnum
        {
            
            /// <summary>
            /// Enum Tcp for value: tcp
            /// </summary>
            [EnumMember(Value = "tcp")]
            Tcp = 1,
            
            /// <summary>
            /// Enum Udp for value: udp
            /// </summary>
            [EnumMember(Value = "udp")]
            Udp = 2,
            
            /// <summary>
            /// Enum Icmp for value: icmp
            /// </summary>
            [EnumMember(Value = "icmp")]
            Icmp = 3
        }

        /// <summary>
        /// The protocol this rule will be applied to.
        /// </summary>
        /// <value>The protocol this rule will be applied to.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public ProtocolEnum? Protocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FirewallRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallRule" /> class.
        /// </summary>
        /// <param name="direction">The direction of network traffic this rule will be applied to. (required).</param>
        /// <param name="action">Action to take if the rule conditions are met. (required).</param>
        /// <param name="position">Add the firewall rule to this position in the server&#39;s firewall list..</param>
        /// <param name="family">family (required).</param>
        /// <param name="protocol">The protocol this rule will be applied to..</param>
        /// <param name="icmpType">The ICMP type..</param>
        /// <param name="destinationAddressStart">The destination address range starts from this address..</param>
        /// <param name="destinationAddressEnd">The destination address range ends to this address..</param>
        /// <param name="destinationPortStart">The destination port range starts from this port number..</param>
        /// <param name="destinationPortEnd">The destination port range ends to this port number..</param>
        /// <param name="sourceAddressStart">The source address range starts from this address..</param>
        /// <param name="sourceAddressEnd">The source address range ends to this address..</param>
        /// <param name="sourcePortStart">The source port range starts from this port number..</param>
        /// <param name="sourcePortEnd">The source port range ends to this port number..</param>
        /// <param name="comment">Freeform comment string for the rule..</param>
        public FirewallRule(DirectionEnum? direction = default(DirectionEnum), ActionEnum? action = default(ActionEnum), decimal? position = default(decimal?), AddressFamily? family = default(AddressFamily), ProtocolEnum? protocol = default(ProtocolEnum?), string icmpType = default(string), string destinationAddressStart = default(string), string destinationAddressEnd = default(string), decimal? destinationPortStart = default(decimal?), decimal? destinationPortEnd = default(decimal?), string sourceAddressStart = default(string), string sourceAddressEnd = default(string), decimal? sourcePortStart = default(decimal?), decimal? sourcePortEnd = default(decimal?), string comment = default(string))
        {
            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new InvalidDataException("action is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.Action = action;
            }
            // to ensure "family" is required (not null)
            if (family == null)
            {
                throw new InvalidDataException("family is a required property for FirewallRule and cannot be null");
            }
            else
            {
                this.Family = family;
            }
            this.Position = position;
            this.Protocol = protocol;
            this.IcmpType = icmpType;
            this.DestinationAddressStart = destinationAddressStart;
            this.DestinationAddressEnd = destinationAddressEnd;
            this.DestinationPortStart = destinationPortStart;
            this.DestinationPortEnd = destinationPortEnd;
            this.SourceAddressStart = sourceAddressStart;
            this.SourceAddressEnd = sourceAddressEnd;
            this.SourcePortStart = sourcePortStart;
            this.SourcePortEnd = sourcePortEnd;
            this.Comment = comment;
        }
        


        /// <summary>
        /// Add the firewall rule to this position in the server&#39;s firewall list.
        /// </summary>
        /// <value>Add the firewall rule to this position in the server&#39;s firewall list.</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public decimal? Position { get; set; }



        /// <summary>
        /// The ICMP type.
        /// </summary>
        /// <value>The ICMP type.</value>
        [DataMember(Name="icmp_type", EmitDefaultValue=false)]
        public string IcmpType { get; set; }

        /// <summary>
        /// The destination address range starts from this address.
        /// </summary>
        /// <value>The destination address range starts from this address.</value>
        [DataMember(Name="destination_address_start", EmitDefaultValue=false)]
        public string DestinationAddressStart { get; set; }

        /// <summary>
        /// The destination address range ends to this address.
        /// </summary>
        /// <value>The destination address range ends to this address.</value>
        [DataMember(Name="destination_address_end", EmitDefaultValue=false)]
        public string DestinationAddressEnd { get; set; }

        /// <summary>
        /// The destination port range starts from this port number.
        /// </summary>
        /// <value>The destination port range starts from this port number.</value>
        [DataMember(Name="destination_port_start", EmitDefaultValue=false)]
        public decimal? DestinationPortStart { get; set; }

        /// <summary>
        /// The destination port range ends to this port number.
        /// </summary>
        /// <value>The destination port range ends to this port number.</value>
        [DataMember(Name="destination_port_end", EmitDefaultValue=false)]
        public decimal? DestinationPortEnd { get; set; }

        /// <summary>
        /// The source address range starts from this address.
        /// </summary>
        /// <value>The source address range starts from this address.</value>
        [DataMember(Name="source_address_start", EmitDefaultValue=false)]
        public string SourceAddressStart { get; set; }

        /// <summary>
        /// The source address range ends to this address.
        /// </summary>
        /// <value>The source address range ends to this address.</value>
        [DataMember(Name="source_address_end", EmitDefaultValue=false)]
        public string SourceAddressEnd { get; set; }

        /// <summary>
        /// The source port range starts from this port number.
        /// </summary>
        /// <value>The source port range starts from this port number.</value>
        [DataMember(Name="source_port_start", EmitDefaultValue=false)]
        public decimal? SourcePortStart { get; set; }

        /// <summary>
        /// The source port range ends to this port number.
        /// </summary>
        /// <value>The source port range ends to this port number.</value>
        [DataMember(Name="source_port_end", EmitDefaultValue=false)]
        public decimal? SourcePortEnd { get; set; }

        /// <summary>
        /// Freeform comment string for the rule.
        /// </summary>
        /// <value>Freeform comment string for the rule.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallRule {\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  IcmpType: ").Append(IcmpType).Append("\n");
            sb.Append("  DestinationAddressStart: ").Append(DestinationAddressStart).Append("\n");
            sb.Append("  DestinationAddressEnd: ").Append(DestinationAddressEnd).Append("\n");
            sb.Append("  DestinationPortStart: ").Append(DestinationPortStart).Append("\n");
            sb.Append("  DestinationPortEnd: ").Append(DestinationPortEnd).Append("\n");
            sb.Append("  SourceAddressStart: ").Append(SourceAddressStart).Append("\n");
            sb.Append("  SourceAddressEnd: ").Append(SourceAddressEnd).Append("\n");
            sb.Append("  SourcePortStart: ").Append(SourcePortStart).Append("\n");
            sb.Append("  SourcePortEnd: ").Append(SourcePortEnd).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as FirewallRule);
        }

        /// <summary>
        /// Returns true if FirewallRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FirewallRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirewallRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Family == input.Family ||
                    (this.Family != null &&
                    this.Family.Equals(input.Family))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.IcmpType == input.IcmpType ||
                    (this.IcmpType != null &&
                    this.IcmpType.Equals(input.IcmpType))
                ) && 
                (
                    this.DestinationAddressStart == input.DestinationAddressStart ||
                    (this.DestinationAddressStart != null &&
                    this.DestinationAddressStart.Equals(input.DestinationAddressStart))
                ) && 
                (
                    this.DestinationAddressEnd == input.DestinationAddressEnd ||
                    (this.DestinationAddressEnd != null &&
                    this.DestinationAddressEnd.Equals(input.DestinationAddressEnd))
                ) && 
                (
                    this.DestinationPortStart == input.DestinationPortStart ||
                    (this.DestinationPortStart != null &&
                    this.DestinationPortStart.Equals(input.DestinationPortStart))
                ) && 
                (
                    this.DestinationPortEnd == input.DestinationPortEnd ||
                    (this.DestinationPortEnd != null &&
                    this.DestinationPortEnd.Equals(input.DestinationPortEnd))
                ) && 
                (
                    this.SourceAddressStart == input.SourceAddressStart ||
                    (this.SourceAddressStart != null &&
                    this.SourceAddressStart.Equals(input.SourceAddressStart))
                ) && 
                (
                    this.SourceAddressEnd == input.SourceAddressEnd ||
                    (this.SourceAddressEnd != null &&
                    this.SourceAddressEnd.Equals(input.SourceAddressEnd))
                ) && 
                (
                    this.SourcePortStart == input.SourcePortStart ||
                    (this.SourcePortStart != null &&
                    this.SourcePortStart.Equals(input.SourcePortStart))
                ) && 
                (
                    this.SourcePortEnd == input.SourcePortEnd ||
                    (this.SourcePortEnd != null &&
                    this.SourcePortEnd.Equals(input.SourcePortEnd))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Family != null)
                    hashCode = hashCode * 59 + this.Family.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.IcmpType != null)
                    hashCode = hashCode * 59 + this.IcmpType.GetHashCode();
                if (this.DestinationAddressStart != null)
                    hashCode = hashCode * 59 + this.DestinationAddressStart.GetHashCode();
                if (this.DestinationAddressEnd != null)
                    hashCode = hashCode * 59 + this.DestinationAddressEnd.GetHashCode();
                if (this.DestinationPortStart != null)
                    hashCode = hashCode * 59 + this.DestinationPortStart.GetHashCode();
                if (this.DestinationPortEnd != null)
                    hashCode = hashCode * 59 + this.DestinationPortEnd.GetHashCode();
                if (this.SourceAddressStart != null)
                    hashCode = hashCode * 59 + this.SourceAddressStart.GetHashCode();
                if (this.SourceAddressEnd != null)
                    hashCode = hashCode * 59 + this.SourceAddressEnd.GetHashCode();
                if (this.SourcePortStart != null)
                    hashCode = hashCode * 59 + this.SourcePortStart.GetHashCode();
                if (this.SourcePortEnd != null)
                    hashCode = hashCode * 59 + this.SourcePortEnd.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }
    }

}
