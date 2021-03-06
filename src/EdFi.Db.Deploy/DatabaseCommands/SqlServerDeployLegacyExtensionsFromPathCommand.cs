﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Reflection;
using EdFi.Db.Deploy.UpgradeEngineFactories;
using log4net;

namespace EdFi.Db.Deploy.DatabaseCommands
{
    public class SqlServerDeployLegacyExtensionsFromPathCommand : DeployLegacyExtensionsFromPathCommand
    {
        public SqlServerDeployLegacyExtensionsFromPathCommand(SqlServerUpgradeEngineFactory upgradeEngineFactory)
            : base(
                upgradeEngineFactory,
                LogManager.GetLogger(
                    MethodBase.GetCurrentMethod()
                        .DeclaringType)) { }
    }
}
