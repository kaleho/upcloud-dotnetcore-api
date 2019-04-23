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
    /// The storage state indicates the storage&#39;s current status. * &#x60;online&#x60; - The storage resource is ready for use. The storage can be attached or detached. * &#x60;maintenance&#x60; - Maintenance work is currently performed on the storage. The storage may have been newly created or it is being updated by some API operation. * &#x60;cloning&#x60; - The storage resource is currently the clone source for another storage. * &#x60;backuping&#x60; - The storage resource is currently being backed up to another storage. * &#x60;error&#x60; - The storage has encountered an error and is currently inaccessible.
    /// </summary>
    /// <value>The storage state indicates the storage&#39;s current status. * &#x60;online&#x60; - The storage resource is ready for use. The storage can be attached or detached. * &#x60;maintenance&#x60; - Maintenance work is currently performed on the storage. The storage may have been newly created or it is being updated by some API operation. * &#x60;cloning&#x60; - The storage resource is currently the clone source for another storage. * &#x60;backuping&#x60; - The storage resource is currently being backed up to another storage. * &#x60;error&#x60; - The storage has encountered an error and is currently inaccessible.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StorageState
    {
        
        /// <summary>
        /// Enum Online for value: online
        /// </summary>
        [EnumMember(Value = "online")]
        Online = 1,
        
        /// <summary>
        /// Enum Maintenance for value: maintenance
        /// </summary>
        [EnumMember(Value = "maintenance")]
        Maintenance = 2,
        
        /// <summary>
        /// Enum Cloning for value: cloning
        /// </summary>
        [EnumMember(Value = "cloning")]
        Cloning = 3,
        
        /// <summary>
        /// Enum Backuping for value: backuping
        /// </summary>
        [EnumMember(Value = "backuping")]
        Backuping = 4,
        
        /// <summary>
        /// Enum Error for value: error
        /// </summary>
        [EnumMember(Value = "error")]
        Error = 5
    }

}
