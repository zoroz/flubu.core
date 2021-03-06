﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Scripting;
using FlubuCore.Targeting;

namespace Flubu.Tests.TestData.BuildScripts.ForCreateTargetWithAttributes
{
    public class BuildScriptMethodHasNoParameters : DefaultBuildScript
    {
        protected override void ConfigureBuildProperties(IBuildPropertiesContext context)
        {
        }

        protected override void ConfigureTargets(ITaskContext session)
        {
        }

        [Target("Test")]
#pragma warning disable FlubuCore_TargetParameter_001 // Wrong first parameter
        public void TestTarget()
#pragma warning restore FlubuCore_TargetParameter_001 // Wrong first parameter
        {
        }
    }
}
