// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Bicep.Core.TypeSystem.Az;

namespace Bicep.Core.TypeSystem
{
    public interface IScopeReference
    {
        ResourceScope ResourceScopeType { get; }
    }
}
