﻿using System;
using System.Web;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace TwitterBootstrapDemonstrator
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication.For<DemonstratorRegistry>().StructureMap(new Container()).Bootstrap();
        }
    }
}