﻿using System;

namespace BlueEyez.Scheduler.Loader
{
    internal static class ProxyDomainFactory
    {
        internal static ProxyDomain BuildProxy(AppDomain domain)
        {
            var type = typeof(ProxyDomain);

            return (ProxyDomain)domain.CreateInstanceAndUnwrap(type.Assembly.FullName, type.FullName ?? throw new InvalidOperationException());
        }
    }
}
