// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using System.Collections.Generic;
using Bicep.Core.Resources;

namespace Bicep.Core.TypeSystem
{
    public interface IResourceTypeProvider
    {
        ResourceType GetType(ResourceScope targetScope, ResourceTypeReference reference);

        ResourceType GetExistingType(ResourceScope targetScope, ResourceTypeReference reference);

        bool HasType(ResourceScope targetScope, ResourceTypeReference typeReference);

        IEnumerable<ResourceTypeReference> GetAvailableTypes(ResourceScope targetScope);
    }
}