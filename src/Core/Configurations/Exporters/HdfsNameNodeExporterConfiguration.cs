﻿// <copyright file="HdfsNameNodeExporterConfiguration.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// </copyright>

namespace Core.Configurations.Exporters
{
    /// <summary>
    /// Configuring the HDFS NameNode exporter required endpoints, based on Ambari API's structure.
    /// </summary>
    public class HdfsNameNodeExporterConfiguration : BaseExporterConfiguration
    {
        /// <inheritdoc />
        public override string UriEndpoint => $"{BaseUri}/services/HDFS/components/NAMENODE";
    }
}
