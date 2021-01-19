// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Bicep.Core.TypeSystem
{
    public class ResourceScopeType : TypeSymbol, IScopeReference
    {
        public ResourceScopeType(string name, ResourceScope scopeType)
            : base(name)
        {
            ResourceScopeType = scopeType;
        }

        public override TypeKind TypeKind => TypeKind.ResourceScopeReference;

        public ResourceScope ResourceScopeType { get; }
    }
}
