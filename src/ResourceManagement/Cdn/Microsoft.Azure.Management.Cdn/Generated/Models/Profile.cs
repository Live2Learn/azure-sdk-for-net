// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// CDN profile represents the top level resource and the entry point into
    /// the CDN API. This allows users to set up a logical grouping of
    /// endpoints in addition to creating shared configuration settings and
    /// selecting pricing tiers and providers.
    /// </summary>
    [JsonTransformation]
    public partial class Profile : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile() { }

        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile(string location, IDictionary<string, string> tags, string id = default(string), string name = default(string), string type = default(string), Sku sku = default(Sku), ProfileResourceState? resourceState = default(ProfileResourceState?), ProvisioningState? provisioningState = default(ProvisioningState?))
            : base(location, tags, id, name, type)
        {
            Sku = sku;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// The SKU (pricing tier) of the CDN profile.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Resource status of the profile. Possible values include:
        /// 'Creating', 'Active', 'Deleting', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public ProfileResourceState? ResourceState { get; private set; }

        /// <summary>
        /// Provisioning status of the profile. Possible values include:
        /// 'Creating', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
