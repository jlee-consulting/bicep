// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Bicep.Core.RegistryClient.Models
{
    /// <summary> The Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema. </summary>
    internal partial class Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema
    {
        /// <summary> Initializes a new instance of Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="aadAccessToken"> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/> or <paramref name="aadAccessToken"/> is null. </exception>
        internal Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema(string service, string aadAccessToken)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }
            if (aadAccessToken == null)
            {
                throw new ArgumentNullException(nameof(aadAccessToken));
            }

            GrantType = "access_token";
            Service = service;
            AadAccessToken = aadAccessToken;
        }

        /// <summary> Can take a value of access_token. </summary>
        public string GrantType { get; }
        /// <summary> Indicates the name of your Azure container registry. </summary>
        public string Service { get; }
        /// <summary> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </summary>
        public string AadAccessToken { get; }
    }
}
