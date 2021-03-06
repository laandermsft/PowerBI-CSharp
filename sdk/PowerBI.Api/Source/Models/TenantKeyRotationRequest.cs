// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Rotate encryption key request
    /// </summary>
    public partial class TenantKeyRotationRequest
    {
        /// <summary>
        /// Initializes a new instance of the TenantKeyRotationRequest class.
        /// </summary>
        public TenantKeyRotationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantKeyRotationRequest class.
        /// </summary>
        /// <param name="keyVaultKeyIdentifier">Uri to the version of the Azure
        /// Key Vault key to be used</param>
        public TenantKeyRotationRequest(string keyVaultKeyIdentifier = default(string))
        {
            KeyVaultKeyIdentifier = keyVaultKeyIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets uri to the version of the Azure Key Vault key to be
        /// used
        /// </summary>
        [JsonProperty(PropertyName = "keyVaultKeyIdentifier")]
        public string KeyVaultKeyIdentifier { get; set; }

    }
}
