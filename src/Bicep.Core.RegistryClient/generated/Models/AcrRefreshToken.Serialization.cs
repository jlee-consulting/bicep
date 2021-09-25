// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Bicep.Core.RegistryClient.Models
{
    internal partial class AcrRefreshToken
    {
        internal static AcrRefreshToken DeserializeAcrRefreshToken(JsonElement element)
        {
            Optional<string> refreshToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("refresh_token"))
                {
                    refreshToken = property.Value.GetString();
                    continue;
                }
            }
            return new AcrRefreshToken(refreshToken.Value);
        }
    }
}
