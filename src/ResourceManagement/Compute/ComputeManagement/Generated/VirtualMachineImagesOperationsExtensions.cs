namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Azure;
    using Models;

    public static partial class VirtualMachineImagesOperationsExtensions
    {
            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='skus'>
            /// </param>
            /// <param name='version'>
            /// </param>
            public static VirtualMachineImage Get(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string version)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).GetAsync(location, publisherName, offer, skus, version), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='skus'>
            /// </param>
            /// <param name='version'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineImage> GetAsync( this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string version, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineImage> result = await operations.GetWithHttpMessagesAsync(location, publisherName, offer, skus, version, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of virtual machine image offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            public static IList<VirtualMachineImageResource> ListOffers(this IVirtualMachineImagesOperations operations, string location, string publisherName)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListOffersAsync(location, publisherName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListOffersAsync( this IVirtualMachineImagesOperations operations, string location, string publisherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IList<VirtualMachineImageResource>> result = await operations.ListOffersWithHttpMessagesAsync(location, publisherName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            public static IList<VirtualMachineImageResource> ListPublishers(this IVirtualMachineImagesOperations operations, string location)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListPublishersAsync(location), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListPublishersAsync( this IVirtualMachineImagesOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IList<VirtualMachineImageResource>> result = await operations.ListPublishersWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of virtual machine image skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            public static IList<VirtualMachineImageResource> ListSkus(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListSkusAsync(location, publisherName, offer), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListSkusAsync( this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IList<VirtualMachineImageResource>> result = await operations.ListSkusWithHttpMessagesAsync(location, publisherName, offer, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a list of virtual machine images.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='skus'>
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            public static IList<VirtualMachineImageResource> List(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, Expression<Func<VirtualMachineImageResource, bool>> filter = default(Expression<Func<VirtualMachineImageResource, bool>>), int? top = default(int?), string orderby = default(string))
            {
                return Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListAsync(location, publisherName, offer, skus, filter, top, orderby), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine images.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='skus'>
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='orderby'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<IList<VirtualMachineImageResource>> ListAsync( this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, Expression<Func<VirtualMachineImageResource, bool>> filter = default(Expression<Func<VirtualMachineImageResource, bool>>), int? top = default(int?), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<IList<VirtualMachineImageResource>> result = await operations.ListWithHttpMessagesAsync(location, publisherName, offer, skus, filter, top, orderby, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}