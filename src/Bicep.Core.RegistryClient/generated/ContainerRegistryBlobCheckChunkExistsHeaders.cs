// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Bicep.Core.RegistryClient
{
    internal partial class ContainerRegistryBlobCheckChunkExistsHeaders
    {
        private readonly Response _response;
        public ContainerRegistryBlobCheckChunkExistsHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> The length of the requested blob content. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> Content range of blob chunk. </summary>
        public string ContentRange => _response.Headers.TryGetValue("Content-Range", out string value) ? value : null;
    }
}
