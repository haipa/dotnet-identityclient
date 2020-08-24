// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.IdentityClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ClientWithSecrets
    {
        /// <summary>
        /// Initializes a new instance of the ClientWithSecrets class.
        /// </summary>
        public ClientWithSecrets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientWithSecrets class.
        /// </summary>
        /// <param name="key">private Key of client</param>
        /// <param name="keyType">Possible values include: 'RsaPrivateKey',
        /// 'SharedKey'</param>
        /// <param name="id">Unique identifier for a haipa client
        /// Only characters a-z, A-Z, numbers 0-9 and hyphens are
        /// allowed.</param>
        /// <param name="name">human readable name of client, for example email
        /// address of owner</param>
        /// <param name="description">optional description of client</param>
        /// <param name="allowedScopes">allowed scopes of client</param>
        public ClientWithSecrets(string key = default(string), string keyType = default(string), string id = default(string), string name = default(string), string description = default(string), IList<string> allowedScopes = default(IList<string>))
        {
            Key = key;
            KeyType = keyType;
            Id = id;
            Name = name;
            Description = description;
            AllowedScopes = allowedScopes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets private Key of client
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'RsaPrivateKey', 'SharedKey'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public string KeyType { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for a haipa client
        /// Only characters a-z, A-Z, numbers 0-9 and hyphens are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets human readable name of client, for example email
        /// address of owner
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional description of client
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets allowed scopes of client
        /// </summary>
        [JsonProperty(PropertyName = "allowedScopes")]
        public IList<string> AllowedScopes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id != null)
            {
                if (Id.Length > 40)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Id", 40);
                }
            }
            if (Name != null)
            {
                if (Name.Length > 254)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 254);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 200)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 200);
                }
            }
        }
    }
}