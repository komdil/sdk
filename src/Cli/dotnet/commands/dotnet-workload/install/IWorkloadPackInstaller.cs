// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using static Microsoft.NET.Sdk.WorkloadManifestReader.WorkloadResolver;
using Microsoft.DotNet.Workloads.Workload.Install.InstallRecord;
using Microsoft.Extensions.EnvironmentAbstractions;

namespace Microsoft.DotNet.Workloads.Workload.Install
{
    internal interface IWorkloadPackInstaller : IInstaller
    {
        void InstallWorkloadPack(PackInfo packInfo, SdkFeatureBand sdkFeatureBand, DirectoryPath? offlineCache = null);

        void RollBackWorkloadPackInstall(PackInfo packInfo, SdkFeatureBand sdkFeatureBand);

        void DownloadToOfflineCache(PackInfo packInfo, DirectoryPath offlineCache, bool includePreviews);

        void GarbageCollectInstalledWorkloadPacks();
    }
}