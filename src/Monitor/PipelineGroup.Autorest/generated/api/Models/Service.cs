// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Extensions;

    /// <summary>Service Info.</summary>
    public partial class Service :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IService,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal
    {

        /// <summary>Internal Acessors for Persistence</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IServiceInternal.Persistence { get => (this._persistence = this._persistence ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.PersistenceConfigurations()); set { {_persistence = value;} } }

        /// <summary>Backing field for <see cref="Persistence" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations _persistence;

        /// <summary>Persistence options to all pipelines in the instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations Persistence { get => (this._persistence = this._persistence ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.PersistenceConfigurations()); set => this._persistence = value; }

        /// <summary>The name of the mounted persistent volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Inlined)]
        public string PersistencePersistentVolumeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurationsInternal)Persistence).PersistentVolumeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurationsInternal)Persistence).PersistentVolumeName = value ?? null; }

        /// <summary>Backing field for <see cref="Pipeline" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> _pipeline;

        /// <summary>Pipelines belonging to a given pipeline group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> Pipeline { get => this._pipeline; set => this._pipeline = value; }

        /// <summary>Creates an new <see cref="Service" /> instance.</summary>
        public Service()
        {

        }
    }
    /// Service Info.
    public partial interface IService :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.IJsonSerializable
    {
        /// <summary>The name of the mounted persistent volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the mounted persistent volume.",
        SerializedName = @"persistentVolumeName",
        PossibleTypes = new [] { typeof(string) })]
        string PersistencePersistentVolumeName { get; set; }
        /// <summary>Pipelines belonging to a given pipeline group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Pipelines belonging to a given pipeline group.",
        SerializedName = @"pipelines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> Pipeline { get; set; }

    }
    /// Service Info.
    internal partial interface IServiceInternal

    {
        /// <summary>Persistence options to all pipelines in the instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations Persistence { get; set; }
        /// <summary>The name of the mounted persistent volume.</summary>
        string PersistencePersistentVolumeName { get; set; }
        /// <summary>Pipelines belonging to a given pipeline group.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPipeline> Pipeline { get; set; }

    }
}