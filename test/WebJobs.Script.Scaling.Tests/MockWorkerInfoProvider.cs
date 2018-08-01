﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.Azure.WebJobs.Script.Scaling.Tests
{
    public class MockWorkerInfoProvider : IWorkerInfoProvider
    {
        public virtual Task<IWorkerInfo> GetWorkerInfo(string activityId)
        {
            return Task.FromResult<IWorkerInfo>(new MockWorkerInfo { LoadFactor = 50 });
        }
    }
}