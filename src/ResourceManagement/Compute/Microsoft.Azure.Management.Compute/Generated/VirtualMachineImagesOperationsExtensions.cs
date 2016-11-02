// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for VirtualMachineImagesOperations.
    /// </summary>
    public static partial class VirtualMachineImagesOperationsExtensions
    {
            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).GetAsync(location, publisherName, offer, skus, version), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a virtual machine image.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<VirtualMachineImage> GetAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, string version, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, publisherName, offer, skus, version, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine images.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='skus'>
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static System.Collections.Generic.IList<VirtualMachineImageResource> List(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, Microsoft.Rest.Azure.OData.ODataQuery<VirtualMachineImageResource> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<VirtualMachineImageResource>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListAsync(location, publisherName, offer, skus, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine images.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='skus'>
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<VirtualMachineImageResource>> ListAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, string skus, Microsoft.Rest.Azure.OData.ODataQuery<VirtualMachineImageResource> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<VirtualMachineImageResource>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(location, publisherName, offer, skus, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            public static System.Collections.Generic.IList<VirtualMachineImageResource> ListOffers(this IVirtualMachineImagesOperations operations, string location, string publisherName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListOffersAsync(location, publisherName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image offers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<VirtualMachineImageResource>> ListOffersAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListOffersWithHttpMessagesAsync(location, publisherName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            public static System.Collections.Generic.IList<VirtualMachineImageResource> ListPublishers(this IVirtualMachineImagesOperations operations, string location)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListPublishersAsync(location), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image publishers.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<VirtualMachineImageResource>> ListPublishersAsync(this IVirtualMachineImagesOperations operations, string location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListPublishersWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of virtual machine image skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            public static System.Collections.Generic.IList<VirtualMachineImageResource> ListSkus(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IVirtualMachineImagesOperations)s).ListSkusAsync(location, publisherName, offer), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of virtual machine image skus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// </param>
            /// <param name='publisherName'>
            /// </param>
            /// <param name='offer'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<VirtualMachineImageResource>> ListSkusAsync(this IVirtualMachineImagesOperations operations, string location, string publisherName, string offer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSkusWithHttpMessagesAsync(location, publisherName, offer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
