// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reference to an Azure Virtual Machines Marketplace image. To retrieve a list of images supported by the Batch service, 
    /// see <see cref="PoolOperations.ListNodeAgentSkus"/> and <see cref="NodeAgentSku.VerifiedImageReferences"/>.
    /// </summary>
    public partial class ImageReference : ITransportObjectProvider<Models.ImageReference>, IPropertyMetadata
    {
        private readonly string offer;
        private readonly string publisher;
        private readonly string sku;
        private readonly string version;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageReference"/> class.
        /// </summary>
        /// <param name='offer'>The offer type of the Azure Virtual Machines Marketplace image.</param>
        /// <param name='publisher'>The publisher of the Azure Virtual Machines Marketplace image.</param>
        /// <param name='sku'>The SKU of the Azure Virtual Machines Marketplace image.</param>
        /// <param name='version'>The version of the Azure Virtual Machines Marketplace image.</param>
        public ImageReference(
            string offer,
            string publisher,
            string sku,
            string version = default(string))
        {
            this.offer = offer;
            this.publisher = publisher;
            this.sku = sku;
            this.version = version;
        }

        internal ImageReference(Models.ImageReference protocolObject)
        {
            this.offer = protocolObject.Offer;
            this.publisher = protocolObject.Publisher;
            this.sku = protocolObject.Sku;
            this.version = protocolObject.Version;
        }

        #endregion Constructors

        #region ImageReference

        /// <summary>
        /// Gets the offer type of the Azure Virtual Machines Marketplace image.
        /// </summary>
        /// <remarks>
        /// For example, UbuntuServer or WindowsServer.
        /// </remarks>
        public string Offer
        {
            get { return this.offer; }
        }

        /// <summary>
        /// Gets the publisher of the Azure Virtual Machines Marketplace image.
        /// </summary>
        /// <remarks>
        /// For example, Canonical or MicrosoftWindowsServer.
        /// </remarks>
        public string Publisher
        {
            get { return this.publisher; }
        }

        /// <summary>
        /// Gets the SKU of the Azure Virtual Machines Marketplace image.
        /// </summary>
        /// <remarks>
        /// For example, 14.04.0-LTS or 2012-R2-Datacenter.
        /// </remarks>
        public string Sku
        {
            get { return this.sku; }
        }

        /// <summary>
        /// Gets the version of the Azure Virtual Machines Marketplace image.
        /// </summary>
        /// <remarks>
        /// If this property is not specified, it defaults to 'latest', which is the latest version of the image.
        /// </remarks>
        public string Version
        {
            get { return this.version; }
        }

        #endregion // ImageReference

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.ImageReference ITransportObjectProvider<Models.ImageReference>.GetTransportObject()
        {
            Models.ImageReference result = new Models.ImageReference()
            {
                Offer = this.Offer,
                Publisher = this.Publisher,
                Sku = this.Sku,
                Version = this.Version,
            };

            return result;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects.
        /// </summary>
        internal static IList<ImageReference> ConvertFromProtocolCollection(IEnumerable<Models.ImageReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ImageReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ImageReference(o));

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, in a frozen state.
        /// </summary>
        internal static IList<ImageReference> ConvertFromProtocolCollectionAndFreeze(IEnumerable<Models.ImageReference> protoCollection)
        {
            ConcurrentChangeTrackedModifiableList<ImageReference> converted = UtilitiesInternal.CollectionToThreadSafeCollectionIModifiable(
                items: protoCollection,
                objectCreationFunc: o => new ImageReference(o).Freeze());

            converted = UtilitiesInternal.CreateObjectWithNullCheck(converted, o => o.Freeze());

            return converted;
        }

        /// <summary>
        /// Converts a collection of protocol layer objects to object layer collection objects, with each object marked readonly
        /// and returned as a readonly collection.
        /// </summary>
        internal static IReadOnlyList<ImageReference> ConvertFromProtocolCollectionReadOnly(IEnumerable<Models.ImageReference> protoCollection)
        {
            IReadOnlyList<ImageReference> converted =
                UtilitiesInternal.CreateObjectWithNullCheck(
                    UtilitiesInternal.CollectionToNonThreadSafeCollection(
                        items: protoCollection,
                        objectCreationFunc: o => new ImageReference(o).Freeze()), o => o.AsReadOnly());

            return converted;
        }

        #endregion // Internal/private methods
    }
}