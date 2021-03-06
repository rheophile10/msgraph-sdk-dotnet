// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PolicyRootTokenLifetimePoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class PolicyRootTokenLifetimePoliciesCollectionRequestBuilder : BaseRequestBuilder, IPolicyRootTokenLifetimePoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PolicyRootTokenLifetimePoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PolicyRootTokenLifetimePoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPolicyRootTokenLifetimePoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPolicyRootTokenLifetimePoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PolicyRootTokenLifetimePoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITokenLifetimePolicyRequestBuilder"/> for the specified PolicyRootTokenLifetimePolicy.
        /// </summary>
        /// <param name="id">The ID for the PolicyRootTokenLifetimePolicy.</param>
        /// <returns>The <see cref="ITokenLifetimePolicyRequestBuilder"/>.</returns>
        public ITokenLifetimePolicyRequestBuilder this[string id]
        {
            get
            {
                return new TokenLifetimePolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
