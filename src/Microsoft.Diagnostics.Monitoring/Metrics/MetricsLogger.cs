﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Diagnostics.Tracing.Parsers.IIS_Trace;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft.Diagnostics.Monitoring
{
    public sealed class MetricsLogger : IMetricsLogger
    {
        private readonly IMetricsStore _store;

        public MetricsLogger(IMetricsStore metricsStore)
        {
            _store = metricsStore;
        }

        public void LogMetrics(Metric metric)
        {
            _store.AddMetric(metric);
        }

        public void Dispose()
        {
        }

    }
}
