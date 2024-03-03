/*
 * Auth Service
 *
 * This API provides token-based authentication for user registration, login, and client credential management. It ensures secure communication by utilizing tokens for authentication. Users can register with unique usernames and passwords, authenticate using client credentials, retrieve client IDs and secrets, and regenerate client credentials as needed. The API supports various user roles, including 'user', 'admin', 'moderator', 'guest', and 'superadmin'.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = authservice.Client.FileParameter;
using OpenAPIDateConverter = authservice.Client.OpenAPIDateConverter;

namespace authservice.Model
{
    /// <summary>
    /// ClientGet200Response
    /// </summary>
    [DataContract(Name = "_client_get_200_response")]
    public partial class ClientGet200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGet200Response" /> class.
        /// </summary>
        /// <param name="clientId">User&#39;s client ID.</param>
        /// <param name="clientSecret">User&#39;s client secret.</param>
        public ClientGet200Response(string clientId = default(string), string clientSecret = default(string))
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// User&#39;s client ID
        /// </summary>
        /// <value>User&#39;s client ID</value>
        /// <example>abc123-xyz456</example>
        [DataMember(Name = "clientId", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// User&#39;s client secret
        /// </summary>
        /// <value>User&#39;s client secret</value>
        /// <example>def789-ghi012</example>
        [DataMember(Name = "clientSecret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientGet200Response {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
