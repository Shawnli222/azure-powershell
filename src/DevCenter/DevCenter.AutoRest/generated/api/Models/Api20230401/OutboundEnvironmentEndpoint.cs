// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>
    /// A collection of related endpoints from the same service for which the agent requires outbound access.
    /// </summary>
    public partial class OutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IOutboundEnvironmentEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IOutboundEnvironmentEndpointInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>The type of service that the agent connects to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public string Category { get => this._category; }

        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDependency[] _endpoint;

        /// <summary>The endpoints for this service for which the agent requires outbound access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDependency[] Endpoint { get => this._endpoint; }

        /// <summary>Internal Acessors for Category</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IOutboundEnvironmentEndpointInternal.Category { get => this._category; set { {_category = value;} } }

        /// <summary>Internal Acessors for Endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDependency[] Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IOutboundEnvironmentEndpointInternal.Endpoint { get => this._endpoint; set { {_endpoint = value;} } }

        /// <summary>Creates an new <see cref="OutboundEnvironmentEndpoint" /> instance.</summary>
        public OutboundEnvironmentEndpoint()
        {

        }
    }
    /// A collection of related endpoints from the same service for which the agent requires outbound access.
    public partial interface IOutboundEnvironmentEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable
    {
        /// <summary>The type of service that the agent connects to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of service that the agent connects to.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get;  }
        /// <summary>The endpoints for this service for which the agent requires outbound access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The endpoints for this service for which the agent requires outbound access.",
        SerializedName = @"endpoints",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDependency) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDependency[] Endpoint { get;  }

    }
    /// A collection of related endpoints from the same service for which the agent requires outbound access.
    internal partial interface IOutboundEnvironmentEndpointInternal

    {
        /// <summary>The type of service that the agent connects to.</summary>
        string Category { get; set; }
        /// <summary>The endpoints for this service for which the agent requires outbound access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20230401.IEndpointDependency[] Endpoint { get; set; }

    }
}